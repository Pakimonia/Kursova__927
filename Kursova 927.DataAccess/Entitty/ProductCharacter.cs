using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    [Table("tblProductCharacter")]
    public class ProductCharacter
    {
        public int CharacterId { get; set; }
        public int ProductId { get; set; }
    }
}
