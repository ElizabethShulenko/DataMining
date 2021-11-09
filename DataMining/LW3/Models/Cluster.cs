using System.Collections.Generic;

namespace LW3.Models
{
    public class Cluster
    {
        public Vector Centroid { get; set; }

        public List<Vector> Vectors { get; set; }

        public Cluster()
        {
            Centroid = new Vector();

            Vectors = new List<Vector>();
        }

        public void Add(Vector vector)
        {
            Vectors.Add(vector);

            ChangeCentroid(vector);
        }

        private void ChangeCentroid(Vector vector)
        {
            var newCentroid = new Vector();

            newCentroid.X = vector.X;
            newCentroid.Y = vector.Y;

            if (Vectors.Count > 1)
            {
                newCentroid.X += Centroid.X * (Vectors.Count - 1);
                newCentroid.Y += Centroid.Y * (Vectors.Count - 1);
            }

            newCentroid.X /= Vectors.Count;
            newCentroid.Y /= Vectors.Count;

            Centroid = newCentroid;
        }

        //public void CountNewCentroid()
        //{
        //    var newCentroid = new Vector();

        //    foreach (var vector in Vectors)
        //    {
        //        newCentroid.Add(vector);
        //    }

        //    newCentroid.X /= Vectors.Count;
        //    newCentroid.Y /= Vectors.Count;

        //    Centroid = newCentroid;
        //}
    }
}
