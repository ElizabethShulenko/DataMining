using LW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LW3
{
    public static class KMeansAlgorythm
    {
        private static Random _random = new Random();

        public static List<Cluster> InitClusterCentroides(long maxX, long maxY, int clusterCount)
        {
            var clusters = new List<Cluster>(clusterCount);

            for (int i = 0; i < clusterCount; i++)
            {
                var x = _random.Next(0, (int)maxX);
                var y = _random.Next(0, (int)maxY);

                var cluster = new Cluster()
                {
                    Centroid = new Vector(x, y)
                };

                clusters.Add(cluster);
            }

            return clusters;
        }

        public static void CountClusters(List<Cluster> clusters, List<Vector> vectors)
        {
            foreach (var vector in vectors)
            {
                var minDistance = Double.PositiveInfinity;

                var closestCluster = clusters.First();

                foreach (var cluster in clusters)
                {
                    var distance = vector.Distance(cluster.Centroid);

                    if (distance < minDistance)
                    {
                        minDistance = distance;

                        closestCluster = cluster;
                    }
                }

                closestCluster.Add(vector);
            }
        }

        public static double RunIteration(List<Vector> vectors, List<Cluster> clusters)
        {
            Task.Run(() => KMeansAlgorythm.CountClusters(clusters, vectors)).GetAwaiter().GetResult();

            var clustersAverageDistance = Task.Run(() => GetClastersAverageDistance(clusters)).GetAwaiter().GetResult();

            return clustersAverageDistance;
        }

        private static double GetClastersAverageDistance(List<Cluster> clusters)
        {
            var clustersAverageDistance = 0.0;

            foreach (var cluster in clusters)
            {
                var distance = 0.0;

                foreach (var vector in cluster.Vectors)
                {
                    distance += vector.Distance(cluster.Centroid) / cluster.Vectors.Count;
                }

                clustersAverageDistance += distance;
            }

            return clustersAverageDistance / clusters.Count;
        }
    }
}
