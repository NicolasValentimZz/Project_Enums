using Exercicio_Enum.Entities.Enums;
using Exercicio_Enum.Entities;
using System.Globalization;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Client Data:");
        Console.Write("Name: ");
        string clientName = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        string dateFormat = "dd/MM/yyyy";
        Console.Write("Birth Date: ");
        DateTime birtDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture);
        
        Console.WriteLine("Enter Order Data:");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        Console.WriteLine("Status: " + status);

        Client client = new Client(clientName, email, birtDate);
        Order order = new Order(DateTime.Now, status, client);
        
        Console.Write("How many items to this order: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Product Name: ");
            string productNAme = Console.ReadLine();
            Console.Write("Product Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(productNAme, price);
            OrderItem orderItem = new OrderItem(quantity, price, product);
        }
        
        Console.WriteLine("Order Sumary:");
        Console.WriteLine(order);
    }
}