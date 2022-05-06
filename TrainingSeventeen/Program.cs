using System;
using System.Globalization;
using TrainingSeventeen.Entities;
using System.Collections.Generic;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord{ UserName = name, Instant = instant });
                    }
                    Console.WriteLine("Total Users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

/* HashSet<string> set = new HashSet<string>();
 * set.Add("Notebook");
 * set.Add("TV");
 * set.Add("Tablet");
 * foreach( p in set)
 * {
 * Console.WritLine("p");
 * }
 */

/*            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
*/

/*SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 7, 8, 9, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 9, 11, 13, 17 };

            SortedSet<int> c = new SortedSet<int>(a);

            //UNION
            c.UnionWith(b);
            PrintCollection(c);

            //INTERCECTION
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //DIFFERENCE
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

            static void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach (T obj in collection)
                {
                    Console.Write(obj + " ");
                }
                Console.WriteLine();
            }*/