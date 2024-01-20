using System;
/* 
 * KRŠENJE ISP-a
 * ISP - klijenti ne bi trebali biti prisiljeni implementirati sučelja koja 
 * ne koriste. Više specifičnih sučelja bolje je od jednog općeg.
 * 
 * Kršenje ISP-a ogleda se u klasama BasketballPlayer i FootballPlayer, jer
 * nepotrebno sadržavaju metode akcija koje ne postoje u tim sportovima. 
 * Interface IAction trebalo bi razdvojiti na IFootballAction i IBasketballAction,
 * te bi određena klasa implementirala odgovarajuće sučelje.
 * 
 * Na ovaj način izbjegavamo implementaciju nepotrebnih metoda i smanjujemo i
 * pojednostavljujemo kod.
 */
namespace SOLID_Nacela
{
    public interface IAction
    {
        void Shoot();
        void Tackle();
        void Dunk();
    }
    public class BasketballPlayer : IAction
    {
        public void Shoot()
        {

        }
        public void Tackle()
        {
            throw new NotImplementedException();
        }
        public void Dunk()
        {

        }
    }
    public class FootballPlayer: IAction
    {
        public void Shoot()
        {

        }
        public void Tackle()
        {

        }
        public void Dunk()
        {
            throw new NotImplementedException();
        }
    }
}