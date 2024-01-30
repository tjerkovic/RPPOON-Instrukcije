using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * APSTRAKTNA TVORNICA - OBRAZAC STVARANJA
 */

namespace PrviZadatakCetvrtaZadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory fordFactory = new FordFactory();
            CarFactory toyotaFactory = new ToyotaFactory();

            Car ford = fordFactory.CreateCar();
            Car toyota = toyotaFactory.CreateCar();

            ford.Drive();
            toyota.Drive();
        }
    }
    public abstract class Car
    {
        public abstract void Drive();
    }
    public abstract class CarFactory
    {
        public abstract Car CreateCar();
    }
    public class FordFactory: CarFactory
    {
        public override Car CreateCar()
        {
            return new Ford();
        }
    }
    public class ToyotaFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new Toyota();
        }
    }
    public class Ford: Car
    {
        public override void Drive() 
        {
            Console.WriteLine("Vrum Ford.");
        }
    }
    public class Toyota: Car
    {
        public override void Drive()
        {
            Console.WriteLine("Vrum Toyota.");
        }
    }
}
