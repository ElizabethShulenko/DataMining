using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LW1
{
    public partial class Form1 : Form
    {
        private readonly string _filePath = @"F:\univer\sms-spam-corpus.csv";
        private readonly string[] _stopWords = { "in", "to", "the", "a", "n", "and", "at" };

        private readonly Regex _specialSymbolsRegex = new Regex(@"[^\w\s']|[\d_]|('\w+)", RegexOptions.Compiled);

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void Run()
        {
            var hamList = new List<string>();
            var spamList = new List<string>();

            LoadEditedString(_filePath, ref hamList, ref spamList);

            var hamDictionary = CountWords(String.Join(" ", hamList)).OrderByDescending(x => x.Value).ToList();
            var spamDictionary = CountWords(String.Join(" ", spamList)).OrderByDescending(x => x.Value).ToList();

            WriteDictionaryToFile(hamDictionary, "../../Output", "hamDictionary.txt");
            WriteDictionaryToFile(spamDictionary, "../../Output", "spamDictionary.txt");

            var hamWordCountDictionary = Utillities.CountWordsLength(hamDictionary.Select(m => m.Key)).OrderBy(m=>m.Key);
            var spamWordCountDictionary = Utillities.CountWordsLength(spamDictionary.Select(m => m.Key)).OrderBy(m => m.Key);

            Utillities.DrawNewChart(hamWordCountDictionary, chartHamWordLength);
            Utillities.DrawNewChart(spamWordCountDictionary, chartSpamWordLength);

            labelHamAverageLength.Text = String.Format("Ham words average length: {0:F2}", Utillities.CountAverageLength(hamDictionary));
            labelSpamAverageLength.Text = String.Format("Spam words average length: {0:F2}", Utillities.CountAverageLength(spamDictionary));

            var hamNotificationCountDictionary = Utillities.CountWordsLength(hamList).OrderBy(m => m.Key);
            var spamNotificationCountDictionary = Utillities.CountWordsLength(spamList).OrderBy(m => m.Key);

            Utillities.DrawNewChart(hamNotificationCountDictionary, chartHamNotificationLength);
            Utillities.DrawNewChart(spamNotificationCountDictionary, chartSpamNotificationLength);

            labelHamNoticeAvgLength.Text = String.Format("Ham notices average length: {0:F2}", Utillities.CountAverageLength(hamList));
            labelSpamNoticeAvgLength.Text = String.Format("Spam notices average length: {0:F2}", Utillities.CountAverageLength(spamList));

            Utillities.CountFrequentWordsLength(hamDictionary, chartHamFrequentWords);
            Utillities.CountFrequentWordsLength(spamDictionary, chartSpamFrequentWords);
        }

        private Dictionary<string, int> CountWords(string text)
        {
            var dictionary = new Dictionary<string, int>();

            var words = text.Split(' ');

            foreach (var word in words)
            {
                if (String.IsNullOrEmpty(word))
                {
                    break;
                }

                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            return dictionary;
        }

        private void LoadEditedString(string filePath, ref List<string> hamListResult, ref List<string> spamListResult)
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine().TrimEnd(',');

                    var splitedLineArray = line.Split(new char[] { ',', '"' }, 2);

                    var key = splitedLineArray[0].Trim();

                    var editedSentenseSB = new StringBuilder();

                    foreach (var valueRaw in splitedLineArray[1].Split(' '))
                    {
                        var value = GetClearedString(valueRaw);

                        if (String.IsNullOrEmpty(value))
                        {
                            continue;
                        }

                        editedSentenseSB.Append($"{value} ");
                    }

                    if (key == "spam")
                    {
                        spamListResult.Add(editedSentenseSB.ToString().Trim());
                    }
                    else if (key == "ham")
                    {
                        hamListResult.Add(editedSentenseSB.ToString().Trim());
                    }
                }
            }
        }

        private string GetClearedString(string rawString)
        {
            if (String.IsNullOrEmpty(rawString))
            {
                return null;
            }

            var result = _specialSymbolsRegex.Replace(rawString.Trim().ToLower(), "");

            if (_stopWords.Any(stopWord => stopWord == result))
            {
                return null;
            }

            return result.Trim();
        }

        private void WriteDictionaryToFile(IEnumerable<KeyValuePair<string, int>> dictionary, string filePath, string fileName)
        {
            using (var streamWriter = new StreamWriter($"{filePath}/{fileName}"))
            {
                foreach (var keyValuePair in dictionary)
                {
                    streamWriter.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                }
            }
        }

    }
}


