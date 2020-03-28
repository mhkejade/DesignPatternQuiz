namespace PizzaFactory
{
    public class PizzeriaB : Pizzeria
    {
        protected override Pizza MakePizza(string pizzaType)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new PizzeriaBIngredientFactory();
            IBoxFactory boxFactory = new PizzeriaBBoxFactory();

            if (pizzaType.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria B {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria B {pizzaType}"
                };
            }
            else if (pizzaType.Equals("Veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory, boxFactory)
                {
                    Name = $"Pizzeria B {pizzaType}"
                };
            }


            return pizza;
        }
    }
}