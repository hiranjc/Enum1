using Enum1.Entities;
using Enum1.Entities.Enums;

namespace Enum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}