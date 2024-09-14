using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   public  class Example2
    {
        private string dotnet, management, mis, cg, cn;
        private string ;
        private string mis;
        private string cg;
        private string cn;
       
        public Object this[int index]
        {
            set
            {
                if (index == 0)
                    dotnet = (string)value;
                else if (index == 1)
                    management = (string)value;
                else if (index == 2)
                    mis = (string)value;
                else if (index == 3)
                    cg = (string)value;
                else if (index == 4)
                    cn = (string)value;

            }
        
            get {
                if(index == 0)
                    return dotnet;
                else if(index == 1)
                    return management;
                else if(index == 2) 
                    return mis;
                else

        }

    }
}
