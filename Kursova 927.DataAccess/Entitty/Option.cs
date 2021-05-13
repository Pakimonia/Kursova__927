using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    //[Table("tblOption")]
    public class Option
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
