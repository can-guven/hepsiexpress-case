using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada_Case_Study
{
    public class East : Direction
    {
        public override int getX()
        {
            return 1;
        }

        public override int getY()
        {
            return 0;
        }
        public override string ToString()
        {
            return "E";
        }
    }
}
