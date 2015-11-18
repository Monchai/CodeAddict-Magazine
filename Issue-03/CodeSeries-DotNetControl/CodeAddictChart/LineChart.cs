using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeAddict.Control.Chart
{
    public partial class LineChart : UserControl
    {
        private LineChartItem item;
        public LineChart()
        {
            InitializeComponent();
            this.item = new LineChartItem();
            this.item.addValue(10);
            this.item.addValue(20);
            this.item.addValue(18);
            this.item.addValue(32);

        }
        public void Draw()
        {
            Graphics g = this.CreateGraphics();
            int stepOfChart = 50;            
            int ChartWidth = 300;
            int ChartHeight = 100;

            SolidBrush brushOfBackground = new SolidBrush(Color.White);
            g.FillRectangle(brushOfBackground, 0, 0, ChartWidth, ChartHeight);
            
            List<int> chartValues = this.item.getValues;
            List<Point> pointOfLine = new List<Point>();
            int currentPointX = 0;
            Pen pLine = new Pen(this.item.color);

            for(int i=0;i<chartValues.Count;i++){
                int currentValueY = chartValues[i];
                currentPointX += stepOfChart;
                pointOfLine.Add(new Point(currentPointX, currentValueY));
            }

            g.DrawLines(pLine, pointOfLine.ToArray());
            
        }
        private void LineChart_Resize(object sender, EventArgs e)
        {
            this.Draw();
        }

        private void LineChart_Paint(object sender, PaintEventArgs e)
        {
            this.Draw();
        }
    }
}
