using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTest.Model
{
    // Dummy class
    public class Dummy
    {
        private string sometext;
        

        public string Sometext
        {
            get { return sometext; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("sometext must be null ore empty");
                }
                sometext = value;
            }
        }

        private int somenumber;

        public int SomeNumber
        {
            get { return somenumber; }
            set
            {
                if (value < 1 || 4 < value)
                {
                    throw new ArgumentException("Somenumber must be in range 1-4");
                }
                somenumber = value;
            }
        }
    }
}
