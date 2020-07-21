using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManager.Models
{
    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }
        public string Issue { get; set; }
        [Display(Name = "Completed")]
        public bool IsComplete { get; set; }
        [ForeignKey("Tenant")]
        [Display(Name = "Tenant Id")]
        public int TenantId {get; set;}
        public Tenant Tenant { get; set; }
        [ForeignKey("Contractor")]
        [Display(Name = "Contractor Id")]
        public int? ContractorId { get; set; }
        public Contractor Contractor { get; set; }

    }
}
