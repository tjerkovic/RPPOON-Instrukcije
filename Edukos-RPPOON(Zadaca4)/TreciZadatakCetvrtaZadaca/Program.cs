using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * METODA TVORNICA - OBRAZAC STVARANJA
 */

namespace TreciZadatakCetvrtaZadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new AssassinCreator());
            game.SpawnChampion("Leap of faith");
        }
    }
    public class Game
    {
        ChampionCreator creator;
        public Game(ChampionCreator creator)
        {
            this.creator = creator;
        }
        public Champion SpawnChampion(string superpower)
        {
            return creator.SummonChampion(superpower);
        }
    }
    public interface Champion
    {
        void Attack();
    }
    public abstract class ChampionCreator
    {
        public abstract Champion SummonChampion(string superpower);
    }
    public class AssassinCreator: ChampionCreator
    {
        public override Champion SummonChampion(string ability)
        {
            return new Assassin(ability);
        }
    }
    public class MechCreator: ChampionCreator
    {
        public override Champion SummonChampion(string specialEffect)
        {
            return new Mech(specialEffect);
        }
    }
    public class Assassin: Champion
    {
        string ability;
        public Assassin(string ability)
        {
            this.ability = ability;
        }
        public void Attack()
        {
            Console.WriteLine($"Attack - {ability}");
        }
    }
    public class Mech: Champion
    {
        string specialEffect;
        public Mech(string specialEffect)
        {
            this.specialEffect = specialEffect;
        }
        public void Attack()
        {
            Console.WriteLine($"Attack - {specialEffect}");
        }
    }
}
