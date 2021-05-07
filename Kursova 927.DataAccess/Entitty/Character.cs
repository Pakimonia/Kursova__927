using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DataAccess.Entitty
{
    class Character
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Title is required field")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Character is required field")]
        public string Charracter { get; set; }
    }
}
