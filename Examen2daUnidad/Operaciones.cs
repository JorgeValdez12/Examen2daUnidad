using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daUnidad
{
    class Operaciones
    {
        public int suma(int[] nums)
        {
            int sumanums = 0;
            for(int x=0;x<nums.Length;x++)
            {
                sumanums = sumanums + nums[x];
            }
            return sumanums;
        }

        public double promedio(int[] nums)
        {
            double sumanums = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                sumanums += nums[x];
            }
            return sumanums / 10;
        }

        public int moda(int[] nums)
        {
            int frecTemp, frecModa = 0, moda1 = -1;
            for (int x = 0; x < nums.Length; x++)
            {
                frecTemp = 1;
                for (int y = x + 1; y < nums.Length; y++)
                {
                    if (nums[x] == nums[y])
                        frecTemp++;
                }
                if (frecTemp > frecModa)
                {
                    frecModa = frecTemp;
                    moda1 = nums[x];
                }
            }
            return moda1;
        }

        public int mediana(int[] nums)
        {
            int aux = 0;
            int pos = 0;
            int z = 0;
            int x = 0;
            for (z = 0; z < nums.Length; z++)
            {
                pos = z;
                for (x = z + 1; x < nums.Length; x++)
                {
                    if (nums[x] < nums[pos])
                    {
                        pos = x;

                    }
                }
                aux = nums[z];
                nums[z] = nums[pos];
                nums[pos] = aux;

            }
            return ((nums[4] + nums[5]) / 2);
        }
    }
}
