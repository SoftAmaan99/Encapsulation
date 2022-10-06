namespace Encapsulation;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Bank bank = new Bank();
            bank.AccountNumber = 0000147854254;
            bank.Name = "Joy Root";
            // bank.SetBalance(-5000);
            // double Balance = bank.GetBalance();
            bank.amount = -5000;
            Console.WriteLine($"Balance : {bank.amount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}