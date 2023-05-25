namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount nick = new BankAccount("12345", "Nicholas Chamboko", 10000);
            /*nick.DisplayAccountInfo();
            nick.Deposit(2000);
            nick.Withdraw(5000);
            nick.DisplayAccountInfo();
            */

            SavingsAccount kupa = new SavingsAccount("2589", "Nick", 5000,5);
            kupa.Deposit(1000);
            kupa.DisplayAccountInfo();

        }
    }
}