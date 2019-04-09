using System;

namespace cars {

    public class Car {
        private string _basicSound = "Boink";
        public string Make {get; set; }
        public string Model {get; set; }
        public int Year {get; set; }
        public double Price {get; set; }
        //Methods Overloading

        public void Drive (string sound) {
            Console.WriteLine($"{Make} {Model} car goes {sound}");
        }
        public void Drive() {
            Console.WriteLine($"{Make} {Model} car goes {_basicSound}");
        }
    }
}
