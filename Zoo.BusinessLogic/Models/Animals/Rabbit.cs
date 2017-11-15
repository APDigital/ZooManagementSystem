using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : Animal
  {
    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth, true)
    {
    }
    public override void Feed()
    {
      Console.WriteLine("<Munch, munch>");
      base.Feed();
    }
  }
}