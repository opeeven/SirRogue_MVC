using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue_MVC
{
    public class DataManager
    {
        public Stats Stats { get; set; }

        public DataManager()
        {
            Stats = new Stats(0, 0, 0, 0);
        }
    }
}
