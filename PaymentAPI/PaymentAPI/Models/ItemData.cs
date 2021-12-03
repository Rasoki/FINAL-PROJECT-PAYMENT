using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace PaymentAPI.Models
{
    public class ItemData
    {
        [Key]
        public int Id { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
    }
}