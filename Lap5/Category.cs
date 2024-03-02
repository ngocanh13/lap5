using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap.Lap5
{
    internal class Category
    {
        public string Name { get; set; }
        public List<Medicine> Medicines { get; set; }

        public Category(string name)
        {
            Name = name;
            Medicines = new List<Medicine>();
        }
    }
}
