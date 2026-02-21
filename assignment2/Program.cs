namespace assignment2
{
    
    #region Q1
    // Q1 - a
    // Problems in the original design:
    // 1- Owner and Balance are public (break encapsulation)
    // 2- Withdraw has no validation (can allow negative balance)

    // Q1 - b
    // Fixed version using proper encapsulation
    //public class BankAccount
    //{
    //    private string owner;
    //    private double balance;

    //    public string Owner
    //    {
    //        get { return owner; }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //                owner = value;
    //        }
    //    }

    //    public double Balance
    //    {
    //        get { return balance; }
    //        private set
    //        {
    //            if (value >= 0)
    //                balance = value;
    //        }
    //    }

    //    public void Withdraw(double amount)
    //    {
    //        if (amount > 0 && amount <= balance)
    //            balance -= amount;
    //    }
    //}
    // Q1 - c
    // Why public fields are bad:
    // - Break encapsulation
    // - Allow invalid values
    // - Hard to control or modify behavior later

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1 
            // Q1 :
            //BankAccount account = new BankAccount();

            //account.Owner = "Soha";
            //account.Withdraw(50);

            //Console.WriteLine("Owner: " + account.Owner);
        }
    }
}
