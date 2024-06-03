namespace MilitaryUnit
{
    public static class Helpers
    {
        public static string Truncate(this string value, int chars, bool alignRight = false)
        {
            if (alignRight)
                return value.Length <= chars ? new string(' ', chars - value.Length) + value : value.Substring(0, chars-3) + "...";

            return value.Length <= chars ? value + new string(' ', chars - value.Length) : value.Substring(0, chars-3) + "...";
        }
    }

    public class MilitaryUnit
    {
        public List<Weapon> weapons;

        public MilitaryUnit()
        {
            weapons = new List<Weapon>();
        }

        public void AddWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (Weapon weapon in weapons)
            {
                double cost = weapon.CalculateCost();
                Console.WriteLine($"{weapon.Name} cost: ${cost}");
                totalCost += cost;
            }
            return totalCost;
        }
    }

    public abstract class Weapon
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Weapon(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract double CalculateCost();
    }

    public class Gun : Weapon
    {
        public int Capacity { get; set; }
        public double Calibre { get; set; }

        public Gun(string name, int weight, int capacity, double calibre) : base(name, weight)
        {
            Capacity = capacity;
            Calibre = calibre;
        }

        public override double CalculateCost()
        {
            return Capacity * Calibre * 10;
        }
    }

    public class Blade : Weapon
    {
        public int Length { get; set; }
        public int HandCount { get; set; }

        public Blade(string name, int weight, int length, int handCount) : base(name, weight)
        {
            Length = length;
            HandCount = handCount;
        }

        public override double CalculateCost()
        {
            return Length * HandCount * 5;
        }
    }

    public class Machinegun : Gun
    {
        public int Rapidity { get; set; }

        public Machinegun(string name, int weight, int capacity, double calibre, int rapidity) : base(name, weight, capacity, calibre)
        {
            Rapidity = rapidity;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() * Rapidity * 0.5;
        }
    }

    
}


/*
 * 
 * class Program
    {
        static void Main(string[] args)
        {
            // Create a military unit
            MilitaryUnit unit = new MilitaryUnit();

            // Create different weapons
            Gun pistol = new Gun("Pistol", 2, 15, 9.0);
            Blade sword = new Blade("Sword", 3, 100, 1);
            Machinegun machinegun = new Machinegun("Machinegun", 10, 30, 7.62, 600);

            // Add weapons to the military unit
            unit.AddWeapon(pistol);
            unit.AddWeapon(sword);
            unit.AddWeapon(machinegun);

            // Calculate and display the total cost of the weapons
            double totalCost = unit.CalculateTotalCost();
            Console.WriteLine($"Total cost of all weapons in the military unit: ${totalCost}");
        }
    }
*/