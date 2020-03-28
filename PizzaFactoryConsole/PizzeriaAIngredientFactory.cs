using System.Collections.Generic;

namespace PizzaFactory
{
    public class PizzeriaAIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public Clam CreateClam()
        {
            return new Frozen();
        }

        public Dough CreateDough()
        {
            return new ThinCrust();
        }

        public Sauce CreateSauce()
        {
            return new CherryTomato();
        }

        public IList<Veggies> CreateVeggies()
        {
            return new List<Veggies>{new Olives(), new Onions(), new BellPeppers()};
        }
    }
}