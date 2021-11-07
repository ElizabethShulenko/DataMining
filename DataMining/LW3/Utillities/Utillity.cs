using LW3.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace LW3.Utillities
{
    public static class Utillity
    {
        public static List<Vector> GetVectorsFromFile(string filePath)
        {
            var vectors = new List<Vector>();

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine().Trim(' ');

                    var splitedLineArray = line.Split(new char[] { ' ' }, 2);

                    var xString = splitedLineArray[0];
                    var yString = splitedLineArray[1];

                    if (!String.IsNullOrEmpty(xString) && Int32.TryParse(xString, out int x)
                        && !String.IsNullOrEmpty(yString) && Int32.TryParse(yString, out int y))
                    {
                        vectors.Add(new Vector { X = x, Y = y });
                    }
                }
            }

            return vectors;
        }
    }
}
