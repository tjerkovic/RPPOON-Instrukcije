using System;
/*
 * KRŠENJE LSP-a
 * LSP - Objekte treba moći zamijeniti instancama njihovih podklasa bez da 
 * se narušava ispravnost programa. Dijete klasa treba moci zamijeniti 
 * roditelj klasu.
 * 
 * U našem slučaju nije moguće zamijeniti roditelj klasu - Car i dijete klasu - Tesla
 * jer Tesla klasa ima drukčiju funkcionalnost od roditelj klase. Ispravno bi bilo da 
 * imamo apstrakciju u kojoj bi imali metodu Charge i onda bi svaka klasa implementirala
 * tu metodu na svoj način.
 */
namespace SOLID_Nacela
{
    public class Car
    {
        public virtual void Charge()
        {
            Console.WriteLine("Tanking the car.");
        }
    }
    public class Audi : Car
    {
        public override void Charge()
        {
            Console.WriteLine("Tanking the car.");
        }
    }
    public class Tesla : Car
    {
        public override void Charge()
        {
            Console.WriteLine("Charging the car.");
        }
    }
}