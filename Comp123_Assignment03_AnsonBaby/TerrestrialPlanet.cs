using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Assignment03_AnsonBaby
{
    class TerrestrialPlanet : Planet
    {
         //PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        //CONSTRUCTOR METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       public bool HasMoons()
       {
           if (MoonCount > 0)
           {
               return true;
           }
           else
           {
               return  false;
           }
       }

       public bool Habitable()
       {
           if (_oxygen == true)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
    }
}
