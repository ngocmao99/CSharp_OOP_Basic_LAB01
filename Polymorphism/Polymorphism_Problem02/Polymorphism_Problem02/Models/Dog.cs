using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Problem02.Models
{
    public class Dog:Animals
    {
        public Dog(string name, string favouriteFood)
        : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExplainMyself())
                .Append("DJAAF");
            return sb.ToString();
        }
    }
}
