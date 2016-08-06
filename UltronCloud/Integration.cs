using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltronCloud
{
    class Integration
    {
        public string Name { get; protected set; }

        public Integration(string name)
        {
            Name = name;
        }
    }
}
