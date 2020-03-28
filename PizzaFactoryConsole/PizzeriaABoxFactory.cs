namespace PizzaFactory
{
    public class PizzeriaABoxFactory : IBoxFactory
    {
        public Box CreateBox()
        {
            return new Red();
        }
    }
}