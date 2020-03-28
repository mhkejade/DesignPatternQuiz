using System;

namespace PizzaFactory
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        private readonly IBoxFactory _boxFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory, IBoxFactory boxFactory)
        {
            _ingredientFactory = ingredientFactory;
            _boxFactory = boxFactory;
        }

        public override void Prepare()
        {
            Dough = _ingredientFactory.CreateDough();
            Clam = _ingredientFactory.CreateClam();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();

            Console.WriteLine($"Preparing {Name} Pizza Using...");
            Console.WriteLine($"Dough: {Dough}, Cheese: {Cheese}, Sauce: {Sauce}, Clam : {Clam}");
        }

        public override void Box()
        {
            Console.WriteLine($"Putting pizza in {_boxFactory.CreateBox().GetColor()} coloured box");
        }
    }
}