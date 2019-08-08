/*
 *Attributes and Properties:
 year_model (for the car’s year_model)
 make (for the make of the car)
 speed (for the cars current speed)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMainDriver
{
    public class Car
    {
        public int year { get; set; }
        public string make { get; set; }
        public int speed { get; set; }
        public Car()
        {
        }
        /// <summary>
        /// The car class must have a method that accepts the car’s year_model and make as arguments. 
        /// These values should be assigned to the car’s year_model and make data attributes.
        /// It should also assign zero to the speed data attribute.
        /// </summary>
        /// <param name="cyear"></param>
        /// <param name="cmake"></param>
        public void carMethod(int cyear, string cmake)
        {
            this.year = cyear;
            this.make = cmake;
            this.speed = 0;
        }

        /// <summary>
        /// The accelerate method should and five to the speed data attribute each time it is called.
        /// </summary>
        public void accelerate()
        {
            this.speed += 5;
        }
        
        /// <summary>
        /// The break method should subtract five from the speed data attribute each time it called.
        /// </summary>
        public void breakk()
        {
            this.speed -= 5;
        }

        /// <summary>
        /// The current_speed method should return the current speed.
        /// </summary>
        /// <returns></returns>
        public int speedMethod()
        {
            return this.speed;
        }
    }
}
