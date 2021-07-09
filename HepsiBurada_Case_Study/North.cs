using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada_Case_Study
{
    public class North : Direction
    {
        public override int getX()
        {
            return 0;
        }

        public override int getY()
        {
            return 1;
        }
        public override string ToString()
        {
            return "N";
        }
    }
}
