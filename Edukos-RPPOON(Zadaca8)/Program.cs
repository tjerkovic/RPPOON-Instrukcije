using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukos_RPPOON_Zadaca8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager configManager = new ConfigurationManager();
            CarConfigurator carConfigurator = new CarConfigurator();

            carConfigurator.AddExtra(new Equipment("LED", 1500));
            carConfigurator.AddExtra(new Equipment("Carbon", 5000));
            carConfigurator.AddExtra(new Equipment("Sensors", 15000));
            carConfigurator.Model = "Sedan";

            configManager.AddConfiguration(carConfigurator.Store());

            Console.WriteLine("Current Model: " + carConfigurator.Model);
            Console.WriteLine("Current Equipment count: " + carConfigurator.Store().GetPackages().Count);

            while (carConfigurator.additionalEquipment.Count > 0)
            {
                carConfigurator.Remove(carConfigurator.additionalEquipment[0]);
            }

            Console.WriteLine("Current Model: " + carConfigurator.Model);
            Console.WriteLine("Current Equipment count: " + carConfigurator.Store().GetPackages().Count);
        }
    }
    public class Equipment
    {
        public string Addition { get; set; }
        public int Price { get; set; }
        public Equipment(string addition, int price)
        {
            Addition = addition;
            Price = price;
        }
    }
    public class CarConfigurator
    {
        public string Model;
        public List<Equipment> additionalEquipment = new List<Equipment>();
        public void AddExtra(Equipment package) { additionalEquipment.Add(package); }
        public void Remove(Equipment package) { additionalEquipment.Remove(package); }
        public void Rollback(CarConfiguration configuration)
        {
            Model = configuration.GetModel();
            additionalEquipment.Clear();
            additionalEquipment.AddRange(configuration.GetPackages());
        }
        public CarConfiguration Store() 
        { 
            return new CarConfiguration(Model, additionalEquipment); 
        }
    }

    public class CarConfiguration
    {
        private string model;
        public List<Equipment> additionalEquipment;
        public CarConfiguration(string model, List<Equipment> additionalEquipment)
        {
            this.model = model;
            this.additionalEquipment = new List<Equipment>(additionalEquipment);
        }
        public string GetModel()
        {
            return model;
        }
        public List<Equipment> GetPackages()
        {
            return new List<Equipment>(additionalEquipment);
        }
    }

    public class ConfigurationManager
    {
        public List<CarConfiguration> configurations = new List<CarConfiguration>();
        public void AddConfiguration(CarConfiguration configuration) { configurations.Add(configuration); }
        public void DeleteConfiguration(CarConfiguration configuration) { configurations.Remove(configuration); }
        public CarConfiguration GetConfiguration(int index) { return configurations[index]; }
    }
}
