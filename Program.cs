using System;

namespace Generic
{
    abstract class Engine { }
    abstract class CarPart { }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { }
    class Battery : CarPart { }
    class Differential : CarPart { }
    class Wheel : CarPart { }
    
    abstract class  Car<TEngine> where TEngine : Engine
    {
        public TEngine engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : Engine;
        
    }
    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }   

    internal class Program
    {
        static void Main(string[] args)
        {
                   
        }
    }
}
