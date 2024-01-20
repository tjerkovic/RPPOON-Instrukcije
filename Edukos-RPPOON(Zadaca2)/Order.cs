using System.Collections.Generic;
/*
 * KRŠENJE SRP-a
 * SRP - Klasa bi trebala imati samo jednu odgovornost, dok u ovome primjeru klasa
 * Order ima 2 odgovornosti, tj. 2 funkcionalnosti sustava.
 *       
 * Svaka metoda može se razdvojiti u zasebnu klasu, recimo metoda CalculateTotalPrice,
 * može pripadati klasi Calculator, dok metoda PrintInvoice može pripadati klasi
 * Printer. 
 * 
 * Ovakav način refaktoriranja omogućuje lakše održavanje jer bi na ovaj način svaka 
 * klasa imala jedan razlog za promjenu.
 */
namespace SOLID_Nacela
{
    public class Order
    {
        public string OrderId { get; set; }
        public List<Product> Products { get; set; }

        public void CalculateTotalPrice()
        {
            // Code to calculate the total price of the order
        }

        public void PrintInvoice()
        {
            // Code to print the invoice for the order
        }
    }
}


