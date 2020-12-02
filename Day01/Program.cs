using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();

            
            Console.WriteLine(o1.EMNO+" "+o1.NAME + " " +o1.BASIC + " " +o1.DEPTNO);
            Console.WriteLine(o2.EMNO);
            Console.WriteLine(o3.EMNO);
            Console.WriteLine("reverse order");
            Console.WriteLine(o3.EMNO);
            Console.WriteLine(o2.EMNO);
            Console.WriteLine(o1.EMNO);


        }
    }

    public class Employee
    {
        
        private static int EMPNO=0;
       
       
       

        public Employee()
        {
            empNo = ++EMPNO;
            this.NAME = " ";
            this.BASIC= 10000;
            this.DEPTNO = 1;
        }


        private string name;
        public string NAME
        {
            set
            {
                if (value == " ")
                    Console.WriteLine("Blank names are not allowed.");
                else
                    name = value;
            }

            get
            {
                return name;
            }
        }

        private int empNo;
        public int EMNO
        {
            private set 
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }

        private decimal basic;
        public decimal BASIC
        {
            set
            {
                if (value > 10000 && value < 50000)
                    basic = value;
                else
                    Console.WriteLine("must be between 10k to 50k range");
            }
            get
            {
                return basic;
            }
        }

        private short deptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine(" DEPT NO must be greater than 0");
            }
            get
            {
                return deptNo;
            }

        }
    }
}
