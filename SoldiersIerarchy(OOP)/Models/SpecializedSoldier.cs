using ClassesIerarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIerarchy { 

     public enum CorpType
     {
       Airforces,
       Marines
     }


  public  class SpecializedSoldier:Private
    {
      

        public SpecializedSoldier(int id, string firstName, string lastName, decimal salary, CorpType corp):base( id,  firstName,  lastName,  salary)
        {
            this.Corp = corp;
        }

        public CorpType Corp { get; set; }
    }
}
