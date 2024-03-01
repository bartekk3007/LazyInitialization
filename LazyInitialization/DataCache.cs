using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitialization
{
    internal class DataCache
    {
        public Person p1
        {
            get
            {
                Random random = new Random();
                return pBasic ?? (pBasic = new Person(random.Next(0, 100)));
            }
        }  
        private Person? pBasic 
        {
            get;
            set;
        } = null;
    }
}
