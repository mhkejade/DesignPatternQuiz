using System;
using System.Collections;
using System.Reflection.Emit;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeriaA = new PizzeriaA();
            Pizzeria pizzeriaB = new PizzeriaB();

            Pizza pizza;

            pizza = pizzeriaA.OrderPizza("Cheese");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaA.OrderPizza("Clam");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaA.OrderPizza("Veggie");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaB.OrderPizza("Cheese");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaB.OrderPizza("Clam");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");

            pizza = pizzeriaB.OrderPizza("Veggie");
            Console.WriteLine($"I ordered {pizza.Name}");
            Console.WriteLine("");
        }
    }
}
