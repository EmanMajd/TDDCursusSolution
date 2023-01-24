using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldo;

        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }

        public void Storten(decimal bedrag)
        {
            // throw new NotImplementedException();
            saldo += bedrag;

        }



    }
}
