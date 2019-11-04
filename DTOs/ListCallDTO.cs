using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTOs
{
    public class ListCallDTO: IDTO
    {
        public string ClientName { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
        public DateTime Date { get; set; }
        public string Project { get; set; }
        public string Situation { get; set; }
        public string Type { get; set; }
        public bool Done { get; set; }
    }
}
