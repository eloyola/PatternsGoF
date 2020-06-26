using System;

namespace FactoryMethod
{
    
    public class CitiSavingAcct : ISavingAccount
    {
        public CitiSavingAcct()
        {
            Balance = 5000;
        }
    }

    public class NationalSavingAcct : ISavingAccount
    {
        public NationalSavingAcct()
        {
            Balance = 2000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingAcctFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingAccount("CITI-321");
            var nationalAcct = factory.GetSavingAccount("NATIONAL-987");

            Console.WriteLine($"My city account balance  is {citiAcct.Balance} \nand national balance is {nationalAcct.Balance}");
        }
    }
}
