using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CacheController
    {
        private int _addressSize;
        private int _blockSize;
        private int _numRows;
        private int _numWays;
        private List<MemoryAddress> _addresses;
        private Dictionary<int, int> _cache;

        public CacheController(string addressString, int entryByteSize, int numberRows, int numberWays)
        {
            _blockSize = entryByteSize;
            _numRows = numberRows;
            _numWays = numberWays;
            _addresses = new List<MemoryAddress>();
            foreach (string a in addressString.Split(','))
            {
                _addresses.Add(new MemoryAddress(int.Parse(a), numberRows, entryByteSize));
            }

        }
        public void SimulateDirectMappedCache()
        {
            foreach (MemoryAddress address in _addresses)
            {
                if(_cache.ContainsKey() )
            }
        }
    }
}
