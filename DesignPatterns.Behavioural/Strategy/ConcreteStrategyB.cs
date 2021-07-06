using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Strategy
{
   public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string> ?? throw new Exception("input is not a list") ;
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}