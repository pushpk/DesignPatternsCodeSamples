using DesignPattern.Builder.Builder;
using DesignPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.ConcreteBuilders
{
   public class TipiHouseBuilder : HouseBuilder
    {

        private House house;

        public TipiHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            this.house.setBasement("Wooden Poles");
        }

        public void buildStructure()
        {
            this.house.setStructure("Wood and Ice");
        }

        public void buildInterior()
        {
            this.house.setInterior("Fire Wood");
        }

        public void bulidRoof()
        {
            this.house.setRoof("Wood, caribou and seal skins");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
