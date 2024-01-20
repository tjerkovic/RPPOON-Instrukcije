using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * U ovome zadatku slijedimo:
 * SRP - klasa App sada samo koristi listu tvornica umjesto da instancira više klasa proizvoda
 * OCP - sučeljem proizvoda i apstraktnom tvornicom omogućujemo proširenje tj. možemo dodati još 
 *       tipova proizvoda bez da mijenjamo kod u App klasi
 * LSP - Konkretne klase Factory su međusobno zamjenjive
 * ISP - ITV i IDisplay su odvojeni, umjesto da su spojeni u npr. IComponents
 * DIP - konkretne klase ovise o apstrakcijama tj. DellTV, DellDisplay, SamsungTV, SamsungDisplay, 
 *       DellFactory, SamsungFactory sad ovise o ITV i IDisplay sučeljima
 */

namespace ApstraktnaTvornica
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IAbstractFactory
    {
        ITV CreateTV();
        IDisplay CreateDisplay();
    }
    public interface ITV
    {
        void SellTVInterface();
    }
    public interface IDisplay
    {
        void SellDisplayInterface();
    }
    public class DellTV: ITV
    {
        public void SellTVInterface() 
        {
            Console.WriteLine("Sell Dell TV.");
        }
    }

    public class SamsungTV: ITV
    {
        public void SellTVInterface() 
        {
            Console.WriteLine("Sell Samsung TV.");
        }
    }

    public class DellDisplay: IDisplay
    {
        public void SellDisplayInterface() 
        {
            Console.WriteLine("Sell Dell Display.");
        }
    }

    public class SamsungDisplay: IDisplay
    {
        public void SellDisplayInterface() 
        {
            Console.WriteLine("Sell Samsung Display.");
        }
    }
    public class DellFactory : IAbstractFactory
    {
        public ITV CreateTV()
        {
            return new DellTV();
        }

        public IDisplay CreateDisplay()
        {
            return new DellDisplay();
        }
    }

    public class SamsungFactory : IAbstractFactory
    {
        public ITV CreateTV()
        {
            return new SamsungTV();
        }

        public IDisplay CreateDisplay()
        {
            return new SamsungDisplay();
        }
    }

    public class App
    {
        IAbstractFactory abstractFactory;
        ITV tv;
        IDisplay display;

        public App(IAbstractFactory abstractFactory)
        {
            this.abstractFactory = abstractFactory;
            this.tv = abstractFactory.CreateTV();
            this.display = abstractFactory.CreateDisplay();
        }
        public void SellTV()
        {
            tv.SellTVInterface();
        }
        public void SellDisplay()
        {
            display.SellDisplayInterface();
        }
    }
}
