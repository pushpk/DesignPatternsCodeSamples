using DesignPattern.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Builder
{
   public  interface HouseBuilder
    {

        void buildBasement();

        void buildStructure();

        void bulidRoof();

        void buildInterior();

        House getHouse();
    }
}
