using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class VOK<O, K, V> : DataBase<O, K, V>
        where O : IComparable<O>, IEquatable<O>
        where K : IComparable<K>, IEquatable<K>
        where V : IComparable<V>, IEquatable<V>
    {
        public VOK(int maxDataBlockItemCount) : base(maxDataBlockItemCount) { }
        protected override IndexItem<O, K, V> GetIndexItem(DataItem<O, K, V> dataItem)
        {
            if (IndexItemList != null && IndexItemList.Count > 0)
            {
                //定位到块
                IndexItem<O, K, V> indexItem = null;
                foreach (var index in this.IndexItemList)
                {
                    if (index.DataItem.Value.CompareTo(dataItem.Value) > 0)
                    {
                        //小于当前
                        indexItem = index;
                        break;
                    }
                    else if (dataItem.Value.Equals(index.DataItem.Value))
                    {
                        //等于当前
                        if (dataItem.ID.CompareTo(index.DataItem.ID) > 0)
                        {
                            indexItem = index;
                            break;
                        }
                        else if (dataItem.ID.Equals(index.DataItem.ID))
                        {
                            if (dataItem.Key.CompareTo(index.DataItem.Key) > 0)
                            {
                                indexItem = index;
                                break;
                            }
                            else if (dataItem.Key.Equals(index.DataItem.Key))
                            {
                                indexItem = index;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        //大于当前,继续，如果都找不到，确保保留最后一个
                        indexItem = index;
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
            return list.OrderBy(d => d.DataItem.Value).ThenBy(d => d.DataItem.ID).ThenBy(d => d.DataItem.Key).ToList();
        }

        protected override List<DataItem<O, K, V>> Order(List<DataItem<O, K, V>> list)
        {
            return list.OrderBy(d => d.Value).ThenBy(d => d.ID).ThenBy(d => d.Key).ToList();
        }
    }
}
