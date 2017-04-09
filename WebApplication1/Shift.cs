using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Shift
    {
        string date;
        string shiftManager;
        string joiner;
        string type;

        public Shift(string d, string sm, string j, string t)
        {
            this.date = d;
            this.shiftManager = sm;
            this.joiner = j;
            this.type = t;
        }
        
    }
}