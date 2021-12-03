using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Car
    {
        public int CarNumber { get; set; }
        private Engine _engine;
        public Car(int pedalsize)
        {
            _engine = new Engine() { PedalSize = pedalsize };
        }
        public Engine engine { get { return _engine; } }

    }
}
