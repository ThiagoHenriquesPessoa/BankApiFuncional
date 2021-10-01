using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApiFuncional.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string PublicPlace { get; set; }
        public int Number { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
