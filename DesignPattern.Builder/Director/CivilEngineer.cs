using DesignPattern.Builder.Builder;
using DesignPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Director
{
    public class CivilEngineer
    {

        private HouseBuilder houseBuilder;

        public CivilEngineer(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House getHouse()
        {
            return this.houseBuilder.getHouse();
        }

        public void constructHouse()
        {
            this.houseBuilder.buildBasement();
            this.houseBuilder.buildStructure();
            this.houseBuilder.bulidRoof();
            this.houseBuilder.buildInterior();
        }
    }
}
