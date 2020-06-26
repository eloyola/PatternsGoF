namespace FactoryMethod
{
    public interface ICreditUnionFactory
    {
        ISavingAccount GetSavingAccount(string acctNo);
    }
}