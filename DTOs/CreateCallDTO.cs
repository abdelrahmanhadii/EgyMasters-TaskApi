using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTOs
{
    public class CreateCallDTO: IDTO
    {
        [Required]
        public int ClientId { get; set; }
        [MaxLength(200)]
        [MinLength(10)]
        public string Description { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Label { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Project { get; set; }
        [MaxLength(200)]
        [MinLength(10)]
        public string Situation { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string Type { get; set; }
        [Required]
        public bool Done { get; set; }
    }
}
