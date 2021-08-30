using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericMethod
    {
        public void GenMethod()
        {
            List<String> lstStr = new List<string>();
            lstStr.Add("A");
            lstStr.Add("B");
            lstStr.Add("C");
            lstStr.Add("D");
            ProcessedItems<string>(lstStr);
        }
        public void ProcessedItems<T>(List<T>lst)    //example of generic method T-Generic type
        {
            Console.WriteLine("***********************************");
            foreach(T item in lst)
            {

                Console.WriteLine(item);
            }
        }
    }
}
