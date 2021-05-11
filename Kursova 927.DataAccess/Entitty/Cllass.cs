using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    [Table("tblCllass")]
    public class Cllass
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Class name is required field")]
        public string Name { get; set; }


    }
}
