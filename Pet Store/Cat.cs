using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Store
{
    internal class Cat : IBreedSpeak
    {
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Speak { get; set; }

    }
}
