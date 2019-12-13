using System;
using System.Collections.Generic;
using System.Linq;

namespace Concept.Linq.Lesson0 {
    class Main
    {
        public void Run()
        {
            IEnumerable<int> dataSource;
            try
            {
                dataSource = GetData();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid operation");
                goto Exit;
            }
            var query = from i in dataSource
                        select i * i;
            foreach (var i in query) { Console.WriteLine(i.ToString()); }

            Exit:
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        private IEnumerable<int> GetData() {throw new InvalidOperationException();}
    }
}
