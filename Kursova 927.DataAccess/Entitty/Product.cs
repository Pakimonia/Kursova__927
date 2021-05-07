using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    class Product
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required field")]
        public string Name { get; set; }
        public bool IsAviable { get; set; }
        [Required(ErrorMessage = "Price is required field")]
        public float Price { get; set; }
        public int Count { get; set; }

        public List<string> ImagesURL { get; set;}
        //public List<ProductOptionDTO> VarOptions { get; set; }
        //public List<ProductClassDTO> Classes { get; set; }
        //public List<ProductCharacterDTO> Characters { get; set; }
    }
}
