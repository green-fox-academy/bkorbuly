using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKing.Models
{
    public class BankAccountList
    {
        public BankAccount bankAccountOne = new BankAccount()
        {
            Name = "Simba",
            Balance = 2000,
            Animaltype = "Lion",
            Currency = "Zebra"
        };
        public BankAccount bankAccountTwo = new BankAccount()
        {
            Name = "Zordon",
            Balance = -2000,
            Animaltype = "Lion",
            Currency = "Zebra",
            GoodGuy = false
        };
        public BankAccount bankAccountThree = new BankAccount()
        {
            Name = "Mufasa",
            Balance = 2000000,
            Animaltype = "Lion",
            Currency = "Zebra",
            IsKingOrNot = true
        };
        public BankAccount bankAccountFour = new BankAccount()
        {
            Name = "Timon & Pumba",
            Balance = 200000000000,
            Animaltype = "Meerkat and Wart-hog",
            Currency = "Zebra"
        };

        public List<BankAccount> bankAccountList = new List<BankAccount>();

        public List<BankAccount> FillList()
        {
            bankAccountList.Add(bankAccountOne);
            bankAccountList.Add(bankAccountTwo);
            bankAccountList.Add(bankAccountThree);
            bankAccountList.Add(bankAccountFour);
            return bankAccountList;
        }     
       
    }
}
