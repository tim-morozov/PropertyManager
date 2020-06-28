using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManager.Models
{
    public class Reccomendation
    {
        [Key]
        public int Id { get; set; }
        public string Rec { get; set; }
        [ForeignKey("Property")]
        public int? PropertyId { get; set; }
        public Property Property { get; set; }

    }
}
