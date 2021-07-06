using System.Collections.Generic;
using DesignPatterns.Behavioural.Visitor.Entities;
using DesignPatterns.Behavioural.Visitor.Interfaces;

namespace DesignPatterns.Behavioural.Visitor
{
    public class ObjectStructure
    {
        private List<IVisitableItem> OrderItems { get; }
        public ObjectStructure(List<IVisitableItem> items) => OrderItems = items;
        public float TotalDiscount { get; private set; }

       public  void ApplyDiscount(IItemDiscountVisitor visitor)
        {
            foreach (var item in OrderItems)
            {
                item.ApplyDiscount(visitor);
            }
            TotalDiscount = visitor.Discount;
        }
        
    }
}