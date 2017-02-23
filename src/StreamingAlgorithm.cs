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
                Videos.Add(new Video() { Id  = i });
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


    }
}
