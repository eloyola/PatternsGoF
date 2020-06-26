using System;

namespace FactoryMethod
{
    public class SavingAcctFactory : ICreditUnionFactory
    {
        public ISavingAccount GetSavingAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
            {
                return new CitiSavingAcct();
            }
            else if (acctNo.Contains("NATIONAL"))
            {
                return new NationalSavingAcct();
            }
            else
                throw new ArgumentException("Invalid account number");
        }
    }
}