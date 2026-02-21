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
    #region part 2
    //Q1 
    //public enum TicketType
    //{
    //    Standard,
    //    VIP,
    //    IMAX
    //}

    //public struct SeatLocation
    //{
    //    public char Row;
    //    public int Number;

    //    public SeatLocation(char row, int number)
    //    {
    //        Row = row;
    //        Number = number;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Row}-{Number}";
    //    }
    //}

    //public class Ticket
    //{
    //    private string movieName;
    //    private double price;

    //    // Q2 - a
    //    private static int ticketCounter = 0;

    //    // Q2 - b
    //    public int TicketId { get; private set; }

    //    public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
    //    {
    //        MovieName = movieName;
    //        Type = type;
    //        Seat = seat;
    //        Price = price;

    //        ticketCounter++;
    //        TicketId = ticketCounter;
    //    }

    //    // Q1 - a
    //    public string MovieName
    //    {
    //        get { return movieName; }
    //        set
    //        {
    //            if (!string.IsNullOrEmpty(value))
    //                movieName = value;
    //        }
    //    }

    //    public TicketType Type { get; set; }

    //    public SeatLocation Seat { get; set; }

    //    public double Price
    //    {
    //        get { return price; }
    //        set
    //        {
    //            if (value > 0)
    //                price = value;
    //        }
    //    }

    //    // Q1 - b
    //    public double PriceAfterTax
    //    {
    //        get { return price * 1.14; }
    //    }

    //    // Q2 - c
    //    public static int GetTotalTicketsSold()
    //    {
    //        return ticketCounter;
    //    }
    //}
    //// Q3
    //public class Cinema
    //{
    //    private Ticket[] tickets = new Ticket[20];

    //    public Ticket this[int index]
    //    {
    //        get
    //        {
    //            if (index >= 0 && index < tickets.Length)
    //                return tickets[index];
    //            return null;
    //        }
    //        set
    //        {
    //            if (index >= 0 && index < tickets.Length)
    //                tickets[index] = value;
    //        }
    //    }

    //    public Ticket GetByMovieName(string movieName)
    //    {
    //        foreach (var t in tickets)
    //        {
    //            if (t != null && t.MovieName == movieName)
    //                return t;
    //        }
    //        return null;
    //    }

    //    public bool AddTicket(Ticket t)
    //    {
    //        for (int i = 0; i < tickets.Length; i++)
    //        {
    //            if (tickets[i] == null)
    //            {
    //                tickets[i] = t;
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //}

    //// Q4
   
    //public static class BookingHelper
    //{
    //    private static int counter = 0;

    //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    //    {
    //        double total = numberOfTickets * pricePerTicket;

    //        if (numberOfTickets >= 5)
    //            return total * 0.9;

    //        return total;
    //    }

    //    public static string GenerateBookingReference()
    //    {
    //        counter++;
    //        return "BK-" + counter;
    //    }
    //}

    #endregion part 2
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
            #region part 2
            //Cinema cinema = new Cinema();

            //// Q5 - a
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data for Ticket {i + 1}:");

            //    Console.Write("Movie Name: ");
            //    string movie = Console.ReadLine();

            //    Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
            //    TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //    Console.Write("Seat Row: ");
            //    char row = char.Parse(Console.ReadLine());

            //    Console.Write("Seat Number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    Ticket t = new Ticket(movie, type, new SeatLocation(row, number), price);
            //    cinema.AddTicket(t);
            //}

            //// Q5 - b
            //Console.WriteLine("========== All Tickets ==========");
            //for (int i = 0; i < 3; i++)
            //{
            //    var t = cinema[i];
            //    if (t != null)
            //    {
            //        Console.WriteLine($"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax} EGP");
            //    }
            //}

            //// Q5 - c
            //Console.Write("Enter movie name to search: ");
            //string search = Console.ReadLine();
            //var found = cinema.GetByMovieName(search);

            //if (found != null)
            //    Console.WriteLine($"Found: Ticket #{found.TicketId} | {found.MovieName} | {found.Type} | Seat: {found.Seat} | Price: {found.Price} EGP");
            //else
            //    Console.WriteLine("Not Found");

            //// Q5 - d
            //Console.WriteLine("Total Tickets Sold: " + Ticket.GetTotalTicketsSold());

            //// Q5 - e
            //Console.WriteLine("Booking Reference 1: " + BookingHelper.GenerateBookingReference());
            //Console.WriteLine("Booking Reference 2: " + BookingHelper.GenerateBookingReference());

            //// Q5 - f
            //double discount = BookingHelper.CalcGroupDiscount(5, 80);
            //Console.WriteLine("Group Discount (5 x 80): " + discount + " EGP");

            #endregion part 2 
        }
    }
}
