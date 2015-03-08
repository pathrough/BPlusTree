﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPlusTree
{
    public class KVO:DataBase
    {
        public KVO(int maxDataBlockItemCount) : base(maxDataBlockItemCount) { }
        protected override IndexItem GetIndexItem(DataItem dataItem)
        {
            if (IndexItemList != null && IndexItemList.Count > 0)
            {
                //定位到块
                IndexItem indexItem = null;
                foreach (var index in this.IndexItemList)
                {
                    if (index.DataItem.Key.CompareTo(dataItem.Key) > 0)
                    {
                        //小于当前
                        indexItem = index;
                        break;
                    }
                    else if (dataItem.Key == index.DataItem.Key)
                    {
                        //等于当前
                        if (dataItem.Value.CompareTo(index.DataItem.Value) > 0)
                        {
                            indexItem = index;
                            break;
                        }
                        else if (dataItem.Value == index.DataItem.Value)
                        {
                            if (dataItem.ID.CompareTo(index.DataItem.ID) > 0)
                            {
                                indexItem = index;
                                break;
                            }
                            else if (dataItem.ID == index.DataItem.ID)
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

        protected override List<IndexItem> Order(List<IndexItem> list)
        {
            return list.OrderBy(d => d.DataItem.Key).ThenBy(d => d.DataItem.Value).ThenBy(d => d.DataItem.ID).ToList();
        }

        protected override List<DataItem> Order(List<DataItem> list)
        {
            return list.OrderBy(d => d.Key).ThenBy(d => d.Value).ThenBy(d => d.ID).ToList();
        }
    }
}