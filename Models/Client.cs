using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Client : BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        [MinLength(10)]
        public string Residence { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Description { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string SalesMan { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        public string ClientSource { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        public string ClientClassfication { get; set; }
        [MaxLength(15)]
        [MinLength(7)]
        public string Telephone1{ get; set; }
        [MaxLength(15)]
        [MinLength(7)]
        public string Telephone2 { get; set; }
        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        public string Mobile { get; set; }
        [MaxLength(11)]
        [MinLength(11)]
        public string Whatsapp { get; set; }
        [Required]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }
        public List<Call> Calls { get; set; }
    }
}
