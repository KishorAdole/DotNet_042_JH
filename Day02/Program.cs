using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager("Mahesh", 2, "Manager");
            e1.BASIC = 20000;
            e1.Display();
            Console.WriteLine();
           
            Employee e2 = new GeneralManager("Vishal", 3, "GeneralManager", "Authority");
            e2.BASIC = 40000;
            e2.Display();
            Console.WriteLine();
           

            Employee e3 = new CEO("Kishor", 4);
            e3.BASIC = 100000;
            e3.Display();
            Console.WriteLine();

           
            Employee e4 = new Manager();
            e4.Display();
            Console.WriteLine();
          
            Console.ReadLine();
        }
    }
    abstract class Employee
    {
        private static int StaticEmpNo = 0;

        public Employee()
        {
            
        }

        private string name;
        public string NAME
        {
            get 
            { 
                return name; 
            }
            set
            {
                if (value == " ")
                {
                    //Console.WriteLine("Name should not be empty...");
                    name = "Kumar";
                }
                else
                {
                    name = value;
                }
            }
        }

        private int empNo;
        public int EMPNO
        {
            get 
            { 
                return empNo; 
            }
            private set 
            { 
                empNo = ++StaticEmpNo; 
            }
        }

        private short deptNo;
        public short DEPTNO
        {
            get
            {
                return deptNo;
            }
            set
            {
                if (value <= 0 )
                {
                    deptNo = 1;
                }

                deptNo = value;
            }
        }

        protected decimal basic;

        public Employee(string name = " ", short deptNo = 0)
        {
            EMPNO = 10;
            this.NAME = name;
            this.DEPTNO = deptNo;
        }
        public abstract decimal BASIC { set; get; }

        public abstract decimal CalcNetSalary();

        public virtual void Display()
        {
            Console.Write(EMPNO + " " + NAME + " " + DEPTNO + " " + basic + " " + CalcNetSalary() + " ");
        }
    }


    interface IDBFunction
    {
        void create();
        void insert();
        void delete();
        void update();


    }
    class Manager : Employee, IDBFunction
    {
        private string designation;


        public string DESIGNAION
        {
            get 
            { 
                return designation; 
            }
            set
            {
                if (value == " ")
                {
                    designation = "Employee";
                }
                designation = value;
            }
        }

        public Manager(string name = " ", short deptNo = 0, string designation = " ") : base(name, deptNo)
        {
            this.designation = designation;
        }
        public override decimal BASIC
        {
            get => basic;

            set
            {
                if (value <= 5000)
                {
                    basic = 15000;
                }

                basic = value;
            }
        }

        public override decimal CalcNetSalary()
        {
            return BASIC * 1000;
        }

        public void create()
        {
            Console.WriteLine("Create Manager");
        }

        public void delete()
        {
            Console.WriteLine("delete Manager");
        }

        public void insert()
        {
            Console.WriteLine("insert Manager");
        }

        public void update()
        {
            Console.WriteLine("update Manager");
        }

        public override void Display()
        {
            base.Display();
            Console.Write(designation);
        }
    }

    class GeneralManager : Manager
    {
        private string perks;
        public string PERKS
        {
            get 
            { 
                return perks; 
            }
            set 
            { 
                perks = value; 
            }
        }
        public GeneralManager(string name = " ", short deptNo = 0, string designation = " ", string perks = " ") : base(name, deptNo, designation)
        {
            this.PERKS = perks;
        }

        public override void Display()
        {
            base.Display();
            Console.Write(" " + PERKS);
        }

    }

    class CEO : Employee
    {
        public override decimal BASIC
        {
            get => basic;
            set
            {
                if (value <= 10000)
                {
                    basic = 15000;
                }
                basic = value;
            }
        }

        public CEO(string name = " ", short deptNo = 0) : base(name, deptNo)
        {

        }
        public sealed override decimal CalcNetSalary()
        {
            return BASIC * 1000 * 20;
        }
    }

}
