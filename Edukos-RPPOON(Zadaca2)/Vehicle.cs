using System;
/*
 * KRŠENJE OCP-a
 * OCP - Softverski entitete (klase, module, funkcije) trebalo bi biti moguće 
 * proširivati, ali ne i modificirati. Postiže se kroz sučelja, nasljeđivanjem, 
 * i modifikatorima pristupačnosti.
 * 
 * Klasa Vehicle treba biti abstract, te treba sadržavati apstraktnu metodu PlanTrip,
 * koju će onda svaka klasa koja ju nasljeđuje zasebno implementirati.
 * Klasa TravelAgency treba sadržavati samo metodu PlanTrip koja će u listi argumenata
 * primati argument Vehicle vehicle, te ćemo umjesto provjeravanja o kojem se vozilu
 * radi, samo pozivati metodu PlanTrip na određenom objektu (car ili bicycle).
 * 
 * Na ovaj način zaštitili smo naš kod od izmjena, a omogućili smo njegovo proširavanje.
*/
namespace SOLID_Nacela
{
    public class Vehicle
    {
        public string Type { get; set; }

        public void Start()
        {
            Console.WriteLine("Starting the vehicle");
        }
    }
    public class Carr : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating the car");
        }
    }
    public class Bicycle : Vehicle
    {
        public void Pedal()
        {
            Console.WriteLine("Pedaling the bicycle");
        }
    }
    public class TravelAgency
    {
        public void PlanTrip(Vehicle vehicle)
        {
            if (vehicle is Carr)
            {
                Console.WriteLine("Planning a trip by car");
            }
            else if (vehicle is Bicycle)
            {
                Console.WriteLine("Planning a trip by bicycle");
            }
            else
            {
                Console.WriteLine("Planning a trip by unknown vehicle");
            }

            vehicle.Start();
        }
    }
}

