using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Peripatos.Core
{
    public class Beach: Place
    {
        public override string Title { get; set; }
        public override string Description { get; set; }

        public Beach(string title, string description, List<byte[]> images)
        {
            Title = title;
            Description = description;
            Images = images;
        }
    }
}
