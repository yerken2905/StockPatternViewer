using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockPatternViewer
{
    class CreateChart
    {
        public Chart ChartForCandle;
        public CreateChart()
        {
            ChartForCandle = new Chart();
            ChartForCandle.Series.Clear();
            ChartForCandle.ChartAreas.Clear();
            ChartArea candleArea = new ChartArea("ChartAreaCandle")
            {
                CursorX={IsUserSelectionEnabled=true, IsUserEnabled=true},
                CursorY={AxisType=AxisType.Secondary},
            }
        }

    }
}
