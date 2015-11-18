using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CodeAddict.Control.Chart
{
    public class LineChartItem
    {
        public Color color { get; set; }
        private int minValue;
        private int maxValue;
        private List<int> values { get; set; }
        public LineChartItem()
        {
            this.color = Color.Lime;
            this.values = new List<int>();
        }
        public void addValue(int value){

            if (value < this.minValue) this.minValue = value;
            if (value > this.maxValue) this.maxValue = value;

            this.values.Add(value);
        }
        public void clearValue()
        {
            this.values.Clear();
            this.minValue = 0;
            this.maxValue = 0;

        }
        public int getMax{
            get{
                return this.maxValue;
            }
        }
        public int getMin{
            get{
                return this.minValue;
            }
        }
        public List<int> getValues
        {
            get
            {
                return this.values;
            }
        }
    }
}
