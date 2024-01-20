using System;
using System.Collections.Generic;
/*
 * KRŠENJE DIP-a
 * DIP - Visokorazinski moduli ne bi trebali ovisiti o niskorazinskim modulima.
 * Oboje bi trebali ovisiti o apstrakcijama.
 * 
 * U ovaj kod treba se uvesti ISwitchable interface, tj. apstrakcija, te ćemo na 
 * taj način maknuti čvrstu spregu između klasa LightBulb i Switch.
 * Također, klasa Switch neće morati stvarati objekt bulb već će ovisiti o apstrakciji.
 * 
 * Na ovaj način mičemo čvrstu spregu koju ne želimo imati u našem kodu i ovisiti 
 * ćemo o apstrakciji kojoj većinom težimo.
*/
namespace SOLID_Nacela
{
    public class LightBulb
    {
        public void TurnOn()
        {
            Console.WriteLine("Light Bulb is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light Bulb is OFF");
        }
    }

    public class Switch
    {
        public LightBulb bulb;

        public Switch(LightBulb bulb)
        {
            this.bulb = bulb;
        }

        public void Operate()
        {
            bulb.TurnOn();
        }
    }
}