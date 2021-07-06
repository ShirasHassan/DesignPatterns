using DesignPatterns.Behavioural.Visitor.Interfaces;

namespace DesignPatterns.Behavioural.Visitor.Entities
{
    public class StationaryProduct : Product,IVisitableItem
    {
        public void ApplyDiscount(IItemDiscountVisitor visitor)
        {
            visitor.ApplyStationaryDiscount(this);
        }
    }
}