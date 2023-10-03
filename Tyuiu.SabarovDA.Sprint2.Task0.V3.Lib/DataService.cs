using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SabarovDA.Sprint2.Task0.V3.Lib
{ //45 127 false, true, false, true, false, true
    public class DataService : ISprint2Task0V3
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;
            res[1] = x != y;
            res[2] = x + 100 < y;
            res[3] = x + 100 > y;
            res[4] = x + 100 <= y;
            res[5] = x + 100 >= y;
            return res;
        }
    }
}
