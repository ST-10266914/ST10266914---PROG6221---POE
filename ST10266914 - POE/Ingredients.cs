using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10266914___POE
{
    public class Ingredients
    {
        //A line of code which allows for data to be stored and retrieved in a variable when called//
        public string Name { get; set; }
        //A line of code which allows for data to be stored and retrieved in a variable when called//
        public int Quantity {  get; set; }
        //A line of code which allows for data to be stored and retrieved in a variable when called//
        public string Measurement {  get; set; }

        //A constructor for the above variables//
        public Ingredients(string name, int quantity, string measurement)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Measurement = measurement;
        }
    }
}
