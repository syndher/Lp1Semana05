using System;
using Bogus;
using Bogus.Extensions;

namespace BarChart
{
    public class BarChart
    {

        public static int BarChartCars(int args[0])
        {
        string car = new[] {"Ferrari", "Dacia", "Smart", "Lamborghini", "Renault"};
        string orders = new Faker<Order>()
            .StrictMode(true)
            .RuleFor(o => o.Item, f => f.PickRandom(car))
            .RuleFor(o => o.Quantity, f => f.Random.Number(args[0]));
        AnsiConsole.Write(orders);
        return orders;
        }
        }
        
    }
}
