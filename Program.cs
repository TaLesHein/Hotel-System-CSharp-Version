using entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Account account = new Account (1234, "ABC", 100.00);
        Menu.homePage(account);
        
    }
}