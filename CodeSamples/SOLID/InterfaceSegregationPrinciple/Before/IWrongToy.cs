using System;

namespace CodeSamples.SOLID.InterfaceSegregationPrinciple.Before
{
    public interface IWrongToy
    {
        void setPrice(int price);
        void setColor(String color);
        void move();
        void fly();
    }
}