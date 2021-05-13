using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    //[Table("tblTypeClass")]
    public class TypeClass
    {
        public int CllassId { get; set; }
        public int TypeId { get; set; }
    }
}
