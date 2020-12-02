using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();
            Console.WriteLine(o4.getNetSalary());
           
            Console.WriteLine(o4.empNo);
            Console.WriteLine(o1.empNo);
            Console.WriteLine(o2.empNo);
            Console.WriteLine(o3.empNo);

            Console.WriteLine(o3.empNo);
            Console.WriteLine(o2.empNo);
            Console.WriteLine(o1.empNo);
            Console.WriteLine(o4.empNo);




            Console.ReadLine();
        }
    }
    public class Employee
    {
        private string EmpName;
        private int EmpNo;
        private decimal Basic;
        private short DeptNo;
        public static int auto;

        static Employee()
        {
            int auto = 0;
        }

        public Employee()
        {
            Console.WriteLine("0 parameter constructor");
            auto++;
            this.EmpNo = auto;
        }
            
        public Employee(String EmpName)
        {
            auto++;
            this.EmpNo = auto;
            this.EmpName = EmpName;
        }

        public Employee(String EmpName,decimal Basic)
        {
            auto++;
            this.EmpNo = auto;
            this.EmpName = EmpName;
            this.Basic = Basic;
        }

        public Employee(String EmpName, decimal Basic,short DeptNo)
        {
            auto++;
            this.EmpNo = auto;
            this.EmpName = EmpName;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public string Name
        {
            set
            {

                if (value.Length != 0)
                {
                    this.EmpName = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return EmpName;
            }
        }
        public int empNo
        {
            get
            {
                return EmpNo;
            }
        }
        public decimal basic
        {
            set
            {
                if (value >= 20000 && value <= 100000)
                {
                    this.Basic = value;

                }
                else
                {
                    Console.WriteLine("enter basic between 20000 to 35000");
                }
            }
            get
            {
                return Basic;
            }
        }
        public short deptNo
        {
            set
            {
                if (value > 0)
                {
                    this.DeptNo = value;
                }
                else
                {
                    Console.WriteLine("deptno must be above 0");
                }
            }
            get
            {
                return DeptNo;
            }
        }
        public decimal getNetSalary()
        {
            decimal ta = 3000;
            decimal da = 2000;
            decimal hra = 3000;
            return this.basic + ta + da + hra;
        }


    }
  

    
}
