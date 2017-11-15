using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Elephant : AnimalThatCanBeGroomed
    {
        public Elephant(DateTime dateOfBirth) : base(dateOfBirth)
        {

        }
        public override void Feed()
        {
            Console.WriteLine("Yum");
            base.Feed();
        }
    }
}
