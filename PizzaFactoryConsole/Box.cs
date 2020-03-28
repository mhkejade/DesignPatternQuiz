namespace PizzaFactory
{
    public abstract class Box
    {
        public abstract string GetColor();
    }

    public class Red : Box
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    public class Green : Box
    {
        public  override string GetColor()
        {
            return "Green";
        }
    }
}