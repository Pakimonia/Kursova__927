using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DTO
{
    class ProductDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsAviable { get; set; }
        public float Price { get; set; }
        public List<ProductOptionDTO> VarOptions { get; set; }
        public List<ProductClassDTO> Classes { get; set; }
        public List<ProductCharacterDTO> Characters { get; set; }

    }
}
