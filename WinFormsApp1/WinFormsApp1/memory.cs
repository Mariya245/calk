using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class memory
    {
        int mem = 0;
        public void MC() { mem = 0; }

        public void MP(int n) { mem += n; }//m+
        public void MM(int n) { mem -= n; }//m-
        public int MR() { return mem; }
    }
}
