using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{

    public class Host<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        List<DataBase<O, K, V>> _DataBases = new List<DataBase<O, K, V>>();

        public List<DataBase<O, K, V>> DataBases
        {
            get { return _DataBases; }
        }
        public Host(int maxDataBlockItemCount)
        {
            RollBackWhenStart();//回滚意外关机的导致事务未完成的工作，也许也可以根据日志自动完成事务
            //DataBases.Add(new OKV(maxDataBlockItemCount));
            DataBases.Add(new KVO<O, K, V>(maxDataBlockItemCount));
            //DataBases.Add(new VOK(maxDataBlockItemCount));
        }

        List<DataItemLog<O, K, V>> _LogList = new List<DataItemLog<O, K, V>>();
        /// <summary>
        /// 事务日志，插入成功后会删掉
        /// </summary>
        public List<DataItemLog<O, K, V>> LogList
        {
            get
            {
                return _LogList;
            }
        }

        public void RollBackWhenStart()
        {
            foreach (var item in LogList)
            {
                foreach (var db in _DataBases)
                {
                    if (item.Operation == OperationType.Insert)
                    {
                        db.Delete(item.DataItem);
                    }
                    else if (item.Operation == OperationType.Delete)
                    {
                        db.Insert(item.DataItem);
                    }
                }
            }
            LogList.RemoveAll(d => true);//回滚完毕，删除事务日志
        }

        public void RollBack(DataItemLog<O, K, V> log)
        {
            foreach (var db in _DataBases)
            {
                if (log.Operation == OperationType.Insert)
                {
                    db.Delete(log.DataItem);
                }
                else if (log.Operation == OperationType.Delete)
                {
                    db.Insert(log.DataItem);
                }
            }
            LogList.Remove(log);//回滚完毕，删除事务日志
        }

        public void Insert(DataItem<O, K, V> dataItem)
        {
            DataItemLog<O, K, V> log = null;
            try
            {
                log = new DataItemLog<O, K, V>(dataItem, OperationType.Insert);
                try
                {
                    LogList.Add(log);//写入事务日志
                }
                catch (Exception)
                {
                    //todo:清除写了一半的日志文件
                    throw;
                }
                foreach (var db in _DataBases)
                {
                    db.Insert(dataItem);
                }
                LogList.Remove(log);//移除事务日志
            }
            catch (Exception)
            {
                if (log != null)
                {
                    RollBack(log);//事务回滚
                }
            }
        }

        public void Delete(DataItem<O, K, V> dataItem)
        {
            DataItemLog<O, K, V> log = null;
            try
            {
                log = new DataItemLog<O, K, V>(dataItem, OperationType.Delete);
                try
                {
                    LogList.Add(log);//写入事务日志
                }
                catch (Exception)
                {
                    //todo:清除写了一半的日志文件
                    throw;
                }
                foreach (var db in _DataBases)
                {
                    db.Delete(dataItem);
                }
                LogList.Remove(log);//移除事务日志
            }
            catch (Exception)
            {
                if (log != null)
                {
                    RollBack(log);//事务回滚
                }
            }
        }
    }
}
