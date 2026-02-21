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
    #region Q3 
    //public class StudentRegister
    //{
    //    private string[] names = new string[5];

    //    // Q3 - a
    //    public string this[int index]
    //    {
    //        get
    //        {
    //            if (index >= 0 && index < names.Length)
    //                return names[index];
    //            return null;
    //        }
    //        set
    //        {
    //            if (index >= 0 && index < names.Length)
    //                names[index] = value;
    //        }
    //    }

    //    // Q3 - c
    //    public string this[string name]
    //    {
    //        get
    //        {
    //            foreach (var n in names)
    //            {
    //                if (n == name)
    //                    return n;
    //            }
    //            return null;
    //        }
    //    }
    //}

    #endregion Q3
    #region Q4 
    //public class Order
    //{
    //    // Q4 - a
    //    public static int TotalOrders = 0;

    //    public string Item;

    //    public Order(string item)
    //    {
    //        Item = item;
    //        TotalOrders++;
    //    }

    //    // Q4 - b
    //    public static int GetTotalOrders()
    //    {
    //        return TotalOrders;
    //    }
    //}
    #endregion Q4 
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
            #region Q3 
            //StudentRegister register = new StudentRegister();
            //register[0] = "Ali";
            //register[1] = "Sara";
            //Console.WriteLine(register[0]);
            //// Q3 - b
            //register[10] = "Test";
            //Console.WriteLine(register["Ali"]);
            #endregion Q3
            #region Q4 
            //Order o1 = new Order("Laptop");
            //Order o2 = new Order("Phone");

            //Console.WriteLine("Item 1: " + o1.Item);
            //Console.WriteLine("Item 2: " + o2.Item);

            //Console.WriteLine("Total Orders: " + Order.GetTotalOrders());
            #endregion Q4
            #endregion part 1

        }
    }
}
