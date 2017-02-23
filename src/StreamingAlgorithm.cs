using System;
using System.Collections.Generic;

namespace src
{
    public class StreamingAlgorithm
    {
        public List<Video> Videos { get; }
        public List<Endpoint> Endpoints { get; }
        public List<Request> Requests { get; }
        public List<Cache> Caches { get; }

        public StreamingAlgorithm(int nVideos, int nEndpoints, int nRequests, int nCaches)
        {
            Videos = new List<Video>(nVideos);
            for (int i = 0; i < nVideos; i++)
            {
                Videos.Add(new Video() { Id = i });
            }

            Endpoints = new List<Endpoint>(nEndpoints);
            for (int i = 0; i < nEndpoints; i++)
            {
                Endpoints.Add(new Endpoint() { Id = i });
            }

            Requests = new List<Request>(nRequests);
            for (int i = 0; i < nRequests; i++)
            {
                Requests.Add(new Request());
            }

            Caches = new List<Cache>(nCaches);
            for (int i = 0; i < nCaches; i++)
            {
                Caches.Add(new Cache());
            }
        }

        //public int Score(int endpointId, int cacheId, int videoId)
        //{
        //    var endpoint = Endpoints[endpointId];
        //    if (!endpoint.CacheLatency.ContainsKey(cacheId))
        //    {
        //        return 0;
        //    }

        //    int maxLatency = endpoint.DataCenterLatency;


        //}

        public void Calculate()
        {
            ulong comb = 0;
            foreach (var r in Requests)
            {
                foreach (var connectedCache in r.EndPoint.CacheScore)
                {
                    var cache = connectedCache.Key;
                    comb++;
                    //var score = new Score()
                    //{
                    //    Video = r.Video,
                    //    Endpoint = r.EndPoint,
                    //    Value = r.Number * connectedCache.Value
                    //};

                    //cache.scores.Add(score);
                }
            }
            Console.WriteLine("comb = " + comb);
            // PrintCacheScores();
        }

        private void PrintCacheScores()
        {
            for (int i = 0; i < Caches.Count; i++)
            {
                Console.WriteLine("CACHE " + i);
                foreach (var score in Caches[i].scores)
                {
                    Console.WriteLine($"Video {score.Video.Id} Endpoint {score.Endpoint.Id} Value {score.Value}");
                }
            }
        }
    }
}

