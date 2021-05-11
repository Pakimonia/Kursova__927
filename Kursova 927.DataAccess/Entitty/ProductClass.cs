using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    [Table("tblProductClass")]
    public class ProductClass
    {
        public int CllassId { get; set; }
        public int ProductId { get; set; }
    }
}
