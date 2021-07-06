using DesignPatterns.Behavioural.Visitor.Interfaces;

namespace DesignPatterns.Behavioural.Visitor.Entities
{
    /// <summary>
    /// Electronic product
    /// </summary>
    public class ElectronicProduct :Product, IVisitableItem
    {
        public void ApplyDiscount(IItemDiscountVisitor visitor)
        {
            visitor.ElectronicDiscount(this);
        }
    }
}