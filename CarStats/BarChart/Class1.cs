using System;

namespace BarChart
{
    public class BarChart()
    {
        string car = new[] {"Ferrari", "Dacia", "Smart", "Lamborghini", "Renault"};
        int orderid = 0;
        int orders = new Faker<Order>()
        .RuleFor(o => o.Item, f => f.PickRandom(car));
        return f;
        
    }
}
