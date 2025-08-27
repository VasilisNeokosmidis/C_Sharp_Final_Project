using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Peripatos.Core
{
    public abstract class Place
    {
        public abstract string Title { get; set; }
        public abstract string Description { get; set; }

        public List<byte[]> Images { get; set; } = new List<byte[]>();

    }
}
