using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace WebApi.Entites
{
    public class Case
    {
  
        [Required]
        public int Id { get; set; }

        [Required]
        public int CaseworkerId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int CaseStatusId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }


        public Caseworker Caseworker { get; set; }

        public Customer Customer { get; set; }

        public CaseStatus CaseStatus { get; set; }
    }
}
