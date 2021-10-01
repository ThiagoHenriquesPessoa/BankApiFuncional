using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApiFuncional.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Password { get; set; }
        public Client Client { get; set; }
    }
}
