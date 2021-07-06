using DesignPatterns.Behavioural.Visitor.Entities;

namespace DesignPatterns.Behavioural.Visitor.Interfaces
{
    public interface IItemDiscountVisitor
    {
        float Discount { get; }
        void ApplyStationaryDiscount(StationaryProduct product);
        void GroceryDiscount(GroceryProduct product);
        void ElectronicDiscount(ElectronicProduct product);
    }
}