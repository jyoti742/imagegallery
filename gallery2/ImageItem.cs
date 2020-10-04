using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallery2
{
    class ImageItem
    {
        string id;
        string name;
        string format;
        byte[] baseb4;
        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] Base64 { get; set; }
        public string Format { get; set; }
    }
}
