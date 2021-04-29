using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DTO
{
    class TypeDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ProductClassDTO> Classes { get; set; }
    }
}


