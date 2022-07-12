using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.BLL.Models
{
    internal class CoffeeModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Temperature { get; set; }
        public int MakeTime { get; set; }
    }
}
