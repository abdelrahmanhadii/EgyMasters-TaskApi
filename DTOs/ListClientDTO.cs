using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class ListClientDTO: IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Residence { get; set; }
        public string Description { get; set; }
        public string SalesMan { get; set; }
        public string ClientSource { get; set; }
        public string ClientClassfication { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Mobile { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
    }
}
