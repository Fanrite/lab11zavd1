using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace lab11zavd1
{
    class Program
    {
        static bool Inputdata(ref double p, string buk)
        {
            string inp;

         vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            try
            {
                p = Convert.ToDouble(inp);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            double min = 10, max = 40;
        start:
            string outp = "";
            int i = 0, n = 10;
            double sum = 0;
            double[] arr;

            //input min & max 
            if (!Inputdata(ref min, "vvedit minimalne 4slo:"))
                return;
            if (!Inputdata(ref max, "vvedit maxsimalne 4slo:"))
                return;

            arr = new double[n];

            Random random = new Random();

            for (; i < n; i++)
            {
                arr[i] = min + random.NextDouble() * (max - min);
                sum += arr[i];
            }

            for (i = 0; i < n; i++)
                outp += $" array[{i}]={arr[i]}";

            if (MessageBox.Show(outp + $"\nSumma:{sum}" + "\n\nPovtor?", "Rezultat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                goto start;
        }
    }
}
