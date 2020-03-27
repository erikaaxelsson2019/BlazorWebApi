using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entites
{
    public class CaseStatus
    {
        public CaseStatus()
        {
            Case = new HashSet<Case>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual ICollection<Case> Case { get; set; }
    }
}
