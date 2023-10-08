using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SabarovDA.Sprint2.Task1.V27.Lib
//int a = 654;  false, false, true, false, true, false
//int b = 325;
//int c = 154;(|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
//int d = 333; (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) 
{
    public class DataService : ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a - 400 > b) | (c + 200 < d);
            res[1] = (a - 400 > b) & (c +200 < d);
            res[2] = (a > b) || (c - 200 < d); 
            res[3] = (a > b) && (c + 200 < d);
            res[4] = !res[0];
            res[5] = (a > b) ^ (c < d);
            return res;
        }
    }
}
