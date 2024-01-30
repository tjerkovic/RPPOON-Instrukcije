using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukos_RPPOON_Zadaca5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientCode.Run();
        }
    }
    public interface IIngredient
    {
        void AddIngredient();
    }

    public class BaseIngredientDecorator : IIngredient
    {
        protected IIngredient ingredient;
        public BaseIngredientDecorator(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }
        public virtual void AddIngredient()
        {
            ingredient.AddIngredient();
        }
    }

    public class Noodles: IIngredient
    {
        public void AddIngredient()
        {
            Console.WriteLine("Noodles Added");
        }
    }
    public class MushroomDecorator : BaseIngredientDecorator
    {
        public MushroomDecorator(IIngredient ingredient) : base(ingredient) { }
        public override void AddIngredient()
        {
            base.AddIngredient();
            Console.WriteLine("Added Mushrooms");
        }
    }
    public class BeefDecorator : BaseIngredientDecorator
    {
        public BeefDecorator(IIngredient ingredient) : base(ingredient) { }
        public override void AddIngredient()
        {
            base.AddIngredient();
            Console.WriteLine("Added Beef");
        }
    }
    public class WaterDecorator : BaseIngredientDecorator
    {
        public WaterDecorator(IIngredient ingredient) : base(ingredient) { }
        public override void AddIngredient()
        {
            base.AddIngredient();
            Console.WriteLine("Added Water");
        }
    }

    public class Meal
    {
        IIngredient ingredient;
        public void MakeMushroomNoodleSoup()
        {
            ingredient = new BaseIngredientDecorator(new MushroomDecorator(new BeefDecorator(new WaterDecorator(new Noodles()))));
            ingredient.AddIngredient();
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new Meal().MakeMushroomNoodleSoup();
        }
    }
}

