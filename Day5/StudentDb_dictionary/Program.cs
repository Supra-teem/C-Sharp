using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDb_dictionary
{
    class students
    {
        public string name { get; set; }
        public int engM { get; set; }
        public int hindiM { get; set; }
        public int mathM { get; set; }
        public int chemM { get; set; }
        public int physicsM { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            students st1 = new students()
            {
                name = "Bisal",
                engM = 89,
                hindiM = 90,
                mathM=99,
                chemM=85,
                physicsM=92
            };
            students st2 = new students()
            {
                name = "Sumit",
                engM = 85,
                hindiM = 91,
                mathM=88,
                chemM=85,
                physicsM=93
            };
            students st3 = new students()
            {
                name = "Shyamal",
                engM = 89,
                hindiM = 94,
                mathM=75,
                chemM=72,
                physicsM=80
            };
            students st4 = new students()
            {
                name = "Nidhi",
                engM = 84,
                hindiM = 90,
                mathM=100,
                chemM=75,
                physicsM=93
            };
            students st5 = new students()
            {
                name = "Partho",
                engM = 89,
                hindiM = 72,
                mathM=74,
                chemM=85,
                physicsM=92
            };
            Dictionary<string, students> dt = new Dictionary<string, students>();
            dt.Add(st1.name, st1);
            dt.Add(st2.name, st2);
            dt.Add(st3.name, st3);
            dt.Add(st4.name, st4);
            dt.Add(st5.name, st5);
            foreach (KeyValuePair<string, students> vp in dt)
            {
                Console.WriteLine("Key = " + vp.Key);
                students st = vp.Value;
                Console.WriteLine("Name = {0}, Marks in English = {1}, Hindi = {2}, Math = {3}, Chemistry = {4}, Physics = {5}",
                               st.name,st.engM,st.hindiM,st.mathM,st.chemM,st.physicsM);
            }

            Console.WriteLine("\n\nAfter converting From Dictionary to Array");
            students[] dtarr = new students[dt.Count];
            dtarr = dt.Values.ToArray();
            foreach (var item in dtarr)
            {
                Console.WriteLine($"Name {item.name} ");
                Console.WriteLine($"English Mark {item.engM} ");
                Console.WriteLine($"Hindi Mark {item.hindiM} ");
                Console.WriteLine($"Math Mark { item.mathM} ");
                Console.WriteLine($"Chemistry Mark { item.chemM} ");
                Console.WriteLine($"Physics Mark {item.physicsM} ");
                Console.WriteLine();
            }

            Console.WriteLine("\n\nAfter converting From Array to Dictionary");
            var dictionary = dtarr.ToDictionary(x => Array.IndexOf(dtarr, x));
            foreach (var s in dictionary)
            {
                Console.WriteLine($"Student Name: {s.Value.name}");
                Console.WriteLine($"Marks of English is: {s.Value.engM}");
                Console.WriteLine($"Marks of Hindi is: {s.Value.hindiM}");
                Console.WriteLine($"Marks of Math is: {s.Value.mathM}");
                Console.WriteLine($"Marks of Chemistry is: {s.Value.chemM}");
                Console.WriteLine($"Marks of Physics is: {s.Value.physicsM}");
                Console.WriteLine();
            }


        }
    }
}
