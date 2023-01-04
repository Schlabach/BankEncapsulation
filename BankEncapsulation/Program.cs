namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine($"How much money would you like to deposit into your account?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            List<string> response = new List<string> { "yes", "Yes", "yea", "Yea", "yep", "Yep" };

            Console.WriteLine($"Would you like to see your account balance?");
            string answer = Console.ReadLine();
            if(!response.Contains(answer))
            {
                Console.WriteLine($"Have a nice day!");
            }
            else
            {
                account.GetBalance();
            }


        }


    }
}
