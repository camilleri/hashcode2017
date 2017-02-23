using System.Collections.Generic;

namespace src
{
    public class Endpoint
    {
        public int Id { get; set; }

        public int DataCenterLatency { get; set; }
        public Dictionary<int, int> CacheLatency { get; set; } // [cacheId, Latency]

        public Endpoint()
        {
            CacheLatency = new Dictionary<int, int>();
        }
    }
}
