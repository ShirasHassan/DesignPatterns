namespace DesignPatterns.Behavioural.Visitor.Interfaces
{
    public interface IVisitableItem
    {
        void ApplyDiscount(IItemDiscountVisitor visitor);
    }
}