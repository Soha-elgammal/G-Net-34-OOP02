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
    #region Q2
    //public class Product
    //{
    //    private double price;

    //    public double Price
    //    {
    //        get { return price; }
    //        set
    //        {
    //            if (value > 0)
    //                price = value;
    //        }
    //    }

    //    public double PriceAfterTax
    //    {
    //        get
    //        {
    //            return price * 1.14;
    //        }
    //    }
    //}
    #endregion Q2
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            #region Q1
            //BankAccount account = new BankAccount();

            //account.Owner = "Soha";
            //account.Withdraw(50);

            //Console.WriteLine("Owner: " + account.Owner);
            #endregion Q1
            #region Q2
            //Product p = new Product();

            //p.Price = 100;

            //Console.WriteLine("Price: " + p.Price);
            //Console.WriteLine("Price After Tax: " + p.PriceAfterTax);
            #endregion Q2 
            #endregion part 1

        }
    }
}
