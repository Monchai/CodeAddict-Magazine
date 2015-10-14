using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyControl_01.ControlUI
{
    public class SimpleChartDataSource
    {

        public List<SimpleChartItem> items;
        public SimpleChartDataSource()
        {
            this.items = new List<SimpleChartItem>();
        }
        public int ItemsCount
        {
            get
            {
                return this.items.Count;
            }
        }
    }

    public class SimpleChartItem
    {

        public delegate void ItemClick(SimpleChartItem item);

        public int ID;
        public string Label { get; set; }
        public int Value { get; set; }
        public System.Drawing.Color Color { get; set; }

        public event ItemClick onItemClick;

        public SimpleChartItem()
        {
            this.ID = 0;
            this.Value = 0;
            this.Label = "";
            this.Color = System.Drawing.Color.Gray;
        }
    }
}
