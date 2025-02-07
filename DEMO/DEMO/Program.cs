using System.Diagnostics.CodeAnalysis;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            class StringGenericComparer : IEqualityComparer<string>
            //        {
            //            public bool Equals(string? strX, string? strY)
            //            {
            //                return strX?.ToLower().Equals(strY?.ToLower()) ?? strY is null;
            //            }

            //            public int GetHashCode([DisallowNull] string obj)
            //            {
            //                return obj?.ToLower().GetHashCode() ?? 0;
            //            }
            //        }

            //        KeyValuePair<string, int>[] keyValuePairs = new KeyValuePair<string, int>[]
            //        {
            //                new KeyValuePair<string, int>("Nada", 30),
            //                new KeyValuePair<string, int>("Rana", 20),
            //                new KeyValuePair<string, int>("Mariem", 50)
            //        };

            //        Dictionary<string, int> Note = new Dictionary<string, int>(keyValuePairs, new StringGenericComparer()); 

            //        Note.Add("Mona", 10);
            //            Note.Add("mariam", 10); 
            //            Note.Remove("mariam");

            //            foreach (var person in Note)
            //            {
            //                Console.WriteLine($"Person.Key = {person.Key}, Person.Value = {person.Value}");
            //            }

            //    Console.WriteLine("----------------------------------");

            //            foreach (var item in Note.Keys)
            //            {
            //                Console.WriteLine(item);
            //            }

            //Console.WriteLine("----------------------------------");

            //foreach (var item in Note.Values)
            //{
            //    Console.WriteLine(item);
            //}



            //HashSet [] even numbers {2,4,6,8} 

            HashSet<int> Numbers = new HashSet<int>();
            Numbers.Add(1); // 1
            Numbers.Add(2); // 2
            Numbers.Add(3); // 3
            Numbers.Add(3); // 3 

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            HashSet<Movie> Movies = new HashSet<Movie>(new MovieEqualityComparer())
{
    new Movie(1, "MovieX", 100),
    new Movie(2, "MovieY", 200),
    new Movie(3, "MovieZ", 300),
};

            Movies.Add(new Movie(3, "MovieZ", 300));

            foreach (var item in Movies)
            {
                Console.WriteLine(item);
            }

        }
    }
}