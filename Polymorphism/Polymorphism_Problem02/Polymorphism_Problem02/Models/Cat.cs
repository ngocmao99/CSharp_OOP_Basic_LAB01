using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Problem02.Models
{
    public class Cat: Animals
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }
        public override string ExplainMyself()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExplainMyself())
                .Append("MEEOW");
            return sb.ToString();
        }

    }
}
