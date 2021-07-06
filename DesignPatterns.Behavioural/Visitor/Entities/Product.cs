namespace DesignPatterns.Behavioural.Visitor.Entities
{
    public abstract class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}