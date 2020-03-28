namespace PizzaFactory
{
    public class PizzeriaBBoxFactory : IBoxFactory
    {
        public Box CreateBox()
        {
            return new Green();
        }
    }
}