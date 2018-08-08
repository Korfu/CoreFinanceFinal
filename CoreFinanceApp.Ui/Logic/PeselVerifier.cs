using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreFinanceApp.Ui.Logic
{
    public class PeselVerifier
    {
        public bool VerifyPesel(string pesel)
        {
            if (pesel.Length != 11)
            {
                return false;
            }
            else
            {
                foreach (char c in pesel)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }
        }

    }
}