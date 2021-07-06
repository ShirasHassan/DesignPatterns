using DesignPatterns.Behavioural.Visitor.Interfaces;

namespace DesignPatterns.Behavioural.Visitor.Entities
{
    public class GroceryProduct : Product, IVisitableItem
    {
        public void ApplyDiscount(IItemDiscountVisitor visitor)
        {
            visitor.GroceryDiscount(this);
        }
    }
}