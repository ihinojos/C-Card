using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Card
{
    public class Transaction
    {
        [Key, Display(AutoGenerateField = false)]
        public string ID { get; set; }
        [Required]
        [Display(Name = "Card Holder")]
        public string CardHolder { get; set; }
        [Display(Name = "Card Number")]
        public int CardNumber { get; set; }
        public string Location { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public bool Credit { get; set; }
        [Display(Name = "Parent Card")]
        public string MainCard { get; set; }
        public string Entity { get; set; }
        public string Class { get; set; }
        public string JobNumber { get; set; }
        public string JobName { get; set; }
        public string Notes { get; set; }
        public string[] TicketPath { get; set; }
    }
}
