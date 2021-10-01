using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApiFuncional.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Address Address { get; set; }
    }
}
