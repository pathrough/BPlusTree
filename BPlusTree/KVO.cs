using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class KVO<O, K, V> : DataBase<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        public KVO(int maxDataBlockItemCount, int maxIndexBlockItemCount, Host<O, K, V> host) : base(maxDataBlockItemCount, maxIndexBlockItemCount, host) { }
        protected override IndexItem<O, K, V> GetIndexItem(DataItem<O, K, V> dataItem)
        {
            if (IndexItemList != null && IndexItemList.Count > 0)
            {
                //定位到块
                IndexItem<O, K, V> indexItem = null;
                foreach (var index in this.IndexItemList)
                {
                    if (index.DataItem.Key.CompareTo(dataItem.Key) > 0)
                    {
                        //小于当前
                        indexItem = index;
                        break;
                    }
                    else if (dataItem.Key.Equals(index.DataItem.Key))
                    {
                        //等于当前
                        if (dataItem.Value.CompareTo(index.DataItem.Value) > 0)
                        {
                            indexItem = index;
                            break;
                        }
                        else if (dataItem.Value.Equals(index.DataItem.Value))
                        {
                            if (dataItem.ID.CompareTo(index.DataItem.ID) > 0)
                            {
                                indexItem = index;
                                break;
                            }
                            else if (dataItem.ID.Equals(index.DataItem.ID))
                            {
                                indexItem = index;
                                break;
                            }
                            else
                            {
                                indexItem = index;
                                continue;
                            }
                        }
                        else
                        {
                            indexItem = index;
                            continue;
                        }
                    }
                    else
                    {
                        //大于当前,继续，如果都找不到，确保保留最后一个
                        indexItem = index;
                        continue;
                    }
                }
                return indexItem;
            }
            else
            {
                return null;//找不到
            }
        }

        protected override List<IndexItem<O, K, V>> Order(List<IndexItem<O, K, V>> list)
        {
            return list.OrderBy(d => d.DataItem.Key).ThenBy(d => d.DataItem.Value).ThenBy(d => d.DataItem.ID).ToList();
        }

        protected override List<DataItem<O, K, V>> Order(List<DataItem<O, K, V>> list)
        {
            return list.OrderBy(d => d.Key).ThenBy(d => d.Value).ThenBy(d => d.ID).ToList();
        }

      
    }
}
