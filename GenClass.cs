using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenClass<T>
    {
        public void Display(T genericParameter)
        {
            string a = "asc";
            Console.WriteLine("Parameter type:{0},value:{1}", typeof(T).ToString(), genericParameter);
        }
        public void Displays(T genericParameter)
        {
            string a = "asc";
            Console.WriteLine("Parameter type:{0},value:{1}", typeof(T).ToString(), genericParameter);
        }

    }
    class emp
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
    }
    class GenericClassEx
    {
        static void Main(string[] args)
        {

            GenClass<int> lstInt = new GenClass<int>();
            List<emp> e1 = new List<emp>();
            e1.Add(new emp { employeeID = 101, employeeName = "john" });

        }
    }

}

