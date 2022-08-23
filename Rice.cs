using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInventoryManagment
{
    public class Rice
    {
        public TypesOfRice typesOfRice;
        public TypesOfPulse typesOfPulse;
        public TypesOfWheat typesOfWheat;
    }
    public class TypesOfRice
    {
        public int name;
        public int weight;
        public int price;
    }
    public class TypesOfPulse
    {
        public int name;
        public int weight;
        public int price;
    }
    public class TypesOfWheat
    {
        public int name;
        public int weight;
        public int price;
    }
}
