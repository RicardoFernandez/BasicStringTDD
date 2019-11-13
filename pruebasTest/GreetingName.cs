using System;

namespace pruebasTest
{
    public class GreetingName
    {
        public string Greet(string name)
        {

            var mensaje = "Hello, " + name;
            var nameIsNull = String.IsNullOrWhiteSpace(name);
            if (nameIsNull)
            {
               mensaje += "My Friend";
                return mensaje;
            }
            var nameSplit = name.Split(",".ToCharArray());
            if (nameSplit.Length == 2)
            {
                mensaje = "Hello, "+ nameSplit[0] + " and " + nameSplit[1];
            }
            if (name.Equals(name.ToUpper()))
            {
                mensaje = "HELLO ";
                mensaje += name + "!";
            }
            return mensaje;
        }

    }
}
