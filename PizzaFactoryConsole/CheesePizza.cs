using System;
using System.Linq;

namespace PizzaFactory
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        private readonly IBoxFactory _boxFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory, IBoxFactory boxFactory)
        {
            _ingredientFactory = ingredientFactory;
            _boxFactory = boxFactory;
        }

        public override void Prepare()
        {
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();

            Console.WriteLine($"Preparing {Name} Pizza Using...");
            Console.WriteLine($"Dough: {Dough}, Cheese: {Cheese}, Sauce: {Sauce}, Veggies : {string.Join(",", Veggies.Select(f => f.ToString()))}");
        }

        public override void Box()
        {
            Console.WriteLine($"Putting pizza in {_boxFactory.CreateBox().GetColor()} coloured box");
        }
    }
}