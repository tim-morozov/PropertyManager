using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManager.Models
{
    public class Complaint
    {
        [Key]
        public int Id { get; set; }
        public string Issue { get; set; }
        [ForeignKey("Tenant")]
        public int TenantId { get; set; }
        public int Tenant { get; set; }
    }
}
