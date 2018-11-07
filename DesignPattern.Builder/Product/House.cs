using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Product
{
    public class House : HousePlan
    {

        private String _basement;

        private String structure;

        private String roof;

        private String interior;

        public string basement { get { return this._basement;  } }

        public void setBasement(String basement)
        {
            this._basement = basement;
        }

        public void setStructure(String structure)
        {
            this.structure = structure;
        }

        public void setRoof(String roof)
        {
            this.roof = roof;
        }

        public void setInterior(String interior)
        {
            this.interior = interior;
        }
    }
}
