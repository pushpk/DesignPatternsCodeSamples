using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Product
{
    public interface HousePlan
    {

     void setBasement(String basement);

    void setStructure(String structure);

     void setRoof(String roof);

     void setInterior(String interior);
} 

}
