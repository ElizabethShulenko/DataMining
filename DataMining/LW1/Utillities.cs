using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace LW1
{
    public static class Utillities
    {
        public static void DrawNewChart(IEnumerable<KeyValuePair<string, int>> dictionary, Chart chart)
        {
            var count = 0;

            foreach (var keyValuePair in dictionary)
            {
                chart.Series[0].Points.AddXY(count, keyValuePair.Key.Length);
                count++;
            }
        }
        public static void DrawNewChart(IEnumerable<string> notificationList, Chart chart)
        {
            var count = 0;

            foreach (var notise in notificationList)
            {
                chart.Series[0].Points.AddXY(count, notise.Length);
                count++;
            }
        }
        public static double CountAverageLength(IEnumerable<KeyValuePair<string, int>> dictionary)
        {
            double wordLengthSum = dictionary.Select(w => w.Key.Length).Sum();

            double wordCount = dictionary.Count();

            return wordLengthSum / wordCount;
        }
        public static double CountAverageLength(IEnumerable<string> notificationList)
        {
            double noticeLengthSum = notificationList.Select(n => n.Length).Sum();

            double noticeCount = notificationList.Count();

            return noticeLengthSum / noticeCount;
        }
        public static void CountWordsLength(IEnumerable<KeyValuePair<string, int>> dictionary, Chart chart)
        {
            chart.Series[0].Points.Clear();

            var amount = 20;

            foreach(var keyValuePair in dictionary)
            {
                if (amount == 0) break;
                chart.Series[0].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                amount--;
            }
        }
    }
}
