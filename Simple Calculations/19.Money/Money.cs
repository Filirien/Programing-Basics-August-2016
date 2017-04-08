using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MOney
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double ioani = double.Parse(Console.ReadLine());
            double komisionna = double.Parse(Console.ReadLine());
           
            double leva = bitcoin * 1168;
           double  dolars = ioani * 0.15;
            double leva1 = dolars * 1.76;
            double euro = (leva + leva1) / 1.95;
            double result = (komisionna / 100) * euro;
            Console.WriteLine(euro - result);



        }
    }
}
