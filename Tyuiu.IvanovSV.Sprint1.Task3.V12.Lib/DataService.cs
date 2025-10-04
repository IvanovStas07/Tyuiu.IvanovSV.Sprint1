using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvanovSV.Sprint1.Task3.V12.Lib
{
    public class DataService
    {
        public object TriangleArea(double x, double y)
        {
            return Math.Round(x * y * 0.5, 3);
        }
    }
}
