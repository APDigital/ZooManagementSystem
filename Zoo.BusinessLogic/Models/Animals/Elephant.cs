using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Elephant : Animal
    {
        public Elephant(DateTime dateOfBirth) : base(dateOfBirth, true)
        {

        }
        public override void Feed()
        {
            Console.WriteLine("Yum");
            base.Feed();
        }
    }
}
