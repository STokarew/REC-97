using System;

namespace REC_97
{
    sealed class Seed
    {
        private int weight;
        public Seed(int weight)
        {
            Weight = weight;
        }
        public int Weight { get; set; }

        public override string ToString()
                    => $"{Weight} тонн";
        public static Seed operator +(Seed seed1, Seed seed2)
        {
            return new Seed(seed1.Weight + seed2.Weight);
        }
        public static Seed operator -(Seed seed1, Seed seed2)
        {
            return new Seed(seed1.Weight - seed2.Weight);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var part1 = new Seed(10);
            var part2 = new Seed(90);
            Seed sum = part1 + part2;
            Console.WriteLine($"{part1} {part2} Сумма: {sum}");

            var part3 = new Seed(50);
            var part4 = new Seed(90);
            Seed diff = part4 - part3;
            Console.WriteLine($"{part4} {part3} Разница: {diff}");
        }
    }
}
