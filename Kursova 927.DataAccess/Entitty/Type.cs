using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    [Table("tblType")]
    class Type
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Type name is required field")]
        public string Name { get; set; }
        public List<ProductClass> Classes { get; set; }
    }
}
