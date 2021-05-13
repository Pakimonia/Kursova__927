using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    //[Table("tblOptionProduct")]
    public class OptionProduct
    {
        public int OptionId { get; set; }
        public int ProductId { get; set; }
    }
}
