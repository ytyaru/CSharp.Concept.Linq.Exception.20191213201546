using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson1 {
    class Main
    {
        public void Run()
        {
            string[] files = { "fileA.txt", "fileB.txt", "fileC.txt" };
            var exceptionDemoQuery =
                from file in files
                let n = SomeMethodThatMightThrow(file)
                select n;
            try
            {
                foreach (var item in exceptionDemoQuery)
                {
                    Console.WriteLine($"Processing {item}");
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        string SomeMethodThatMightThrow(string s)
        {
            if (s[4] == 'C') { throw new InvalidOperationException(); }
            return @"C:\newFolder\" + s;
        }
    }
}
