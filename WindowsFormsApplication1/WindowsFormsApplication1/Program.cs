using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Test
    {
        public static void Main()
        {
            int i = 0;

            System.Console.WriteLine("ループ開始");
            while (i < 20)
            {
                System.Console.WriteLine("iの値は" + i);
                i++;
            }
            System.Console.WriteLine("ループ終了");
        }
    }
}
