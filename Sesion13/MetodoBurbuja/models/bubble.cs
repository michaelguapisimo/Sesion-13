using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoBurbuja.models
{
    internal class bubble
    {
        public void BubbleSort(int[] array) 
        {
            try
            {
                for (int i = 0; i < array.Length; i++) { 
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                        }
                    }                             
                }    
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }   
    }
}
