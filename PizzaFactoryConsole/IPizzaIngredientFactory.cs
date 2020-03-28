using System.Collections.Generic;

namespace PizzaFactory
{
    public interface IPizzaIngredientFactory
    {
        Cheese CreateCheese();
        Clam CreateClam();
        Dough CreateDough();
        Sauce CreateSauce();
        IList<Veggies> CreateVeggies();
    }
}