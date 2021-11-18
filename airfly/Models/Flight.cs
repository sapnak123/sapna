using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace airfly.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="From")]
        public string source { get; set; }
        public string destination { get; set; }
        public string Airplane { get; set; }

        public DateTime departure { get; set; }
        public string date { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public string Araival { get; set; }
        public string Duration { get; set; }
    }
}
