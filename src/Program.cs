using System;
using System.Linq;

namespace src
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Parse input
            var header = Console.ReadLine().Split().ToList().Select(int.Parse).ToList();

            var algorithm = new StreamingAlgorithm(header[0], header[1], header[2], header[3]);

            var videoSizes = Console.ReadLine().Split().ToList().Select(int.Parse).ToList();
            for (int i = 0; i < algorithm.Videos.Count; i++)
            {
                algorithm.Videos[i].Size = videoSizes[i];
            }

            // endpoints
            foreach (var endpoint in algorithm.Endpoints)
            {
                var endPointHeader = Console.ReadLine().Split().ToList().Select(int.Parse).ToList();
                endpoint.DataCenterLatency = endPointHeader[0];
                for (int c = 0; c < endPointHeader[1]; c++)
                {
                    var connectedCache = Console.ReadLine().Split().ToList().Select(int.Parse).ToList();
                    endpoint.CacheLatency.Add(connectedCache[0], connectedCache[1]);
                }
            }

            // requests
            foreach (var request in algorithm.Requests)
            {
                var requestLine = Console.ReadLine().Split().ToList().Select(int.Parse).ToList();
                request.VideoId = requestLine[0];
                request.EndPointId = requestLine[1];
                request.Number = requestLine[2];
            }
        }
    }
}
