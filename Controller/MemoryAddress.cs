using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MemoryAddress
    {
        public int Address { get; set; }
        public int Row { get; set; }
        public int Tag { get; set; }
        /// <summary>
        /// Constructor for a memory address
        /// </summary>
        /// <param name="address">Address stored in decimal value</param>
        /// <param name="rowSize">Amount of rows in the cache</param>
        /// <param name="entryByteSize">Amount of bytes of memory</param>
        public MemoryAddress(int address, int rowSize = 32, int entryByteSize = 5)
        {
            string stringHexAddress = address.ToString("X");  // Gives you hexadecimal
            Address = Convert.ToInt32(stringHexAddress, 16);  // Back to int again.

            Row = (address / entryByteSize) % rowSize;
            Tag = address / (entryByteSize * rowSize);
        }
    }
}
