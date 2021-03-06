using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralManager g = new GeneralManager("value", "cleark", "onkar", 30000, 1);
            Console.WriteLine(g.CalcNetSalary());
            Employee e = new CEO("vedant", 32000.5m,2);
            Console.WriteLine(e.CalcNetSalary());
        }
    }
    public abstract class Employee
    {
        private string name;
        private int empno;
        private short deptno;
        public decimal basic;
        private static int auto;

        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name Can not be NULL");
                }
            }
            get
            {
                return name;
            }
        }
        public int EmpNo
        {
            get
            {
                return empno;
            }
        }
        public short DeptNo
        {
            set
            {
                if (value > 0 )
                {
                    deptno = value;
                }
                else
                    Console.WriteLine("Dept No must be greater than 0");
            }
            get
            {
                return deptno;
            }
        }
        public abstract decimal Basic { set; get; }
        public abstract decimal CalcNetSalary();
        public Employee(string name, decimal basic, short deptno)
        {
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptno;
            auto++;
            this.empno = auto;
        }

    }
    public class Manager : Employee
    {
        private string designation;
        public override decimal Basic
        {
            set
            {
                basic = value;
            }
            get
            {
                return basic;
            }
        }
        public string Designation
        {
            set
            {
                if (value != null)
                {
                    designation = value;
                }
                else
                    Console.WriteLine("Designation Cant Be null");
            }
            get
            {
                return designation;
            }
        }

        public override decimal CalcNetSalary()
        {
            return basic + 2000 + 2000;

        }
        public Manager(string designation, string name, decimal basic, short deptno) : base(name, basic, deptno)
        {
            this.Designation = designation;
        }


    }
    public class GeneralManager : Manager
    {
        public string Perks { set; get; }
        public GeneralManager(string perks, string designation, string name, decimal basic, short deptno) : base(designation, name, basic, deptno)
        {
            this.Perks = perks;
        }
    }
    public class CEO : Employee
    {
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic + 5000 + 10000 + 9000;
            
        }
        public CEO(string name, decimal basic, short deptno) : base(name, basic, deptno)
        {

        }
    }
}
