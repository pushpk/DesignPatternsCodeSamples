using DesignPattern.Builder.Builder;
using DesignPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.ConcreteBuilders
{
    public class IglooHouseBuilder : HouseBuilder
    {

        private House house;

        public IglooHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            this.house.setBasement("Ice Bars");
        }

        public void buildStructure()
        {
            this.house.setStructure("Ice Blocks");
        }

        public void buildInterior()
        {
            this.house.setInterior("Ice Carvings");
        }

        public void bulidRoof()
        {
            this.house.setRoof("Ice Dome");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
