namespace PizzaFactory
{
    public abstract class Pizzeria
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = MakePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }

        protected abstract Pizza MakePizza(string pizzaType);
    }
}