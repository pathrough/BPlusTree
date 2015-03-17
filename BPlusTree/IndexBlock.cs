using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public abstract class IndexBlock<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        //字节组成【块字节数】【索引项】..【下一个块位置】
        /*目前只有一级索引
         读取第一块（每一块固定大小）
         * 每一块最后包含下一块的位置（块与块之间可能不是按顺序的）
         * 每一个索引项大小是不确定的，因为数据项大小不确定
         * 索引项大小，数据项，数据块位置
         */
        public IndexBlock(DataBase<O, K, V> dataBase, List<IndexItem<O, K, V>> indexItemList)
        {
            this._DataBase = dataBase;
            _IndexItemList = indexItemList;
            //_Position = position;//新创建的位置是由于文件指针觉得的
        }

        /// <summary>
        /// 从磁盘初始化索引块
        /// </summary>
        /// <param name="position"></param>
        /// <param name="dataBase"></param>
        public IndexBlock(long position, DataBase<O, K, V> dataBase)
        {
            this._DataBase = dataBase;
            this._Position = position;
            byte[] bs = new byte[this.DataBase.IndexBlockSize];
            using (FileStream fs = new FileStream(this.DataBase.IndexPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(position, SeekOrigin.Begin);
                fs.Read(bs, 0, bs.Length);              
            }

            //有多少个indexItem
            byte[] bsIndexItemCount = bs.GetSubArray(0, 4);
            this._Count = bsIndexItemCount.ToInt32();

            //读出所有IndexItem
            this._IndexItemList = new List<IndexItem<O, K, V>>();
            int index = 0;
            for (int i = 0; i < this._Count; i++)
            {
                //indexItem有多长，固定长度的IndexItem可以没有这个，这个应该在具体的类型中实现
                byte[] bsLen = bs.GetSubArray(index, 4);
                index = index + 4;
                int len = bsLen.ToInt32();

                //读出一个indexItem
                byte[] bsIndexItem = bs.GetSubArray(index, len);
                IndexItem<O, K, V> indexItem = CreateIndexItem(bsIndexItem);
                this._IndexItemList.Add(indexItem);
            }
        }

        protected abstract IndexItem<O, K, V> CreateIndexItem(byte[] bs);

        IndexBlock<O, K, V> _Next;

        //下一个数据块，是否必要，如果是树状
        public IndexBlock<O, K, V> Next
        {
            get
            {
                //todo:Next IndexBlock
                return _Next;
            }
        }

        readonly long _NextBlockPosition;

        public long NextBlockPosition
        {
            get { return _NextBlockPosition; }
        }


        private List<IndexItem<O, K, V>> _IndexItemList = new List<IndexItem<O, K, V>>();
        public List<IndexItem<O, K, V>> IndexItemList
        {
            get { return _IndexItemList; }
            set { _IndexItemList = value; }
        }

        public int MaxItemCount
        {
            get
            {
                return this.DataBase.MaxIndexBlockItemCount;
            }
        }

        readonly DataBase<O, K, V> _DataBase;
        public DataBase<O, K, V> DataBase
        {
            get
            {
                return _DataBase;
            }
        }

        int? _Count;
        /// <summary>
        /// 可以从磁盘初始化
        /// </summary>
        public int Count
        {
            get
            {
                if (_Count == null)
                {
                    _Count = this.IndexItemList.Count;
                }
                return _Count.Value;
            }
        }

        long _Position;
        public long Position
        {
            get
            {
                return _Position;
            }
        }

        public byte[] ToBytes()
        {
            List<byte> bsList = new List<byte>();

            foreach (var index in this.IndexItemList)
            {
                bsList.AddRange(index.ToBytes());
            }
            return bsList.ToArray();
        }
    }
}
