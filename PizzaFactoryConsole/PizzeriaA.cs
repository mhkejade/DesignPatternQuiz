namespace PizzaFactory
{
    public class PizzeriaA : Pizzeria
    {
        protected override Pizza MakePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new PizzeriaAIngredientFactory();
            IBoxFactory boxFactory = new PizzeriaABoxFactory();

            if (pizzaType.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria A {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria A {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria A {pizzaType}"
                };
            }
            

            return pizza;
        }
    }
}