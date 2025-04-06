using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Projektsammlung.Exercises.Ex_11_InterfacesKlassen;

namespace Projektsammlung.Exercises.Ex_11_InterfacesKlassen
{
    internal class Person2
    {
        private ILogger logger = new ConsoleLogger();

        private string name;
        
        public string Name
        {
            get 
            {
                logger.Log($"Der Getter von {name} wurde aufgerufen!");
                return name;
            }

            set
            {
                name = value;
                logger.Log($"Der Setter von {name} wurde aufgerufen!");
            }
        }
    }
}
