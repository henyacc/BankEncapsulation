using BankEncapsulation;

public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount();
        
        Console.Write("Enter amount to deposit: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        account.Deposit(amount);
        Console.WriteLine($"New balance: {account.GetBalance()}");
    }
}


