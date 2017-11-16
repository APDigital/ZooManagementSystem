using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    interface IAnimal
    {
        void Feed();
        void Groom();
        bool IsHungry();
    }
}
