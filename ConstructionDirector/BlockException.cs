using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionDirector
{
    public class BlockException : Exception
    {
        public string Capture { get; }
        public BlockException(string message, string capture) : base(message)
        {
            Capture = capture;
        }
    }
}
