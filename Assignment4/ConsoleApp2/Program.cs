namespace Assignment3
{
    public interface Iprintable
    {
        void Print();
    }


    public class EmployeeManagementSystem : Iprintable
    {


        public int Salary;

        public void Print()
        {



            Console.WriteLine("enter the first name of the employee:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("enter last name of the employee:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter employee Salary :");
            Salary = Convert.ToInt32(Console.ReadLine());
            if (Salary <= 0 || Salary > 20000)
            {
                Console.WriteLine("please enter a valid value again from starting....THANK YOU");

                Print();
            }
            else if (Salary < 5000)
            {
                Console.WriteLine("Employee Name : {0}", FirstName + LastName);
                Console.WriteLine("Net Salary : {0}", Salary);

                int PF = 8 * (Salary / 100);
                Console.WriteLine("Gross Salary : {0}", Salary + PF);
            }
            else if (Salary > 5000 && Salary < 10000)
            {
                Console.WriteLine("Employee Name : {0}", FirstName + LastName);
                Console.WriteLine("Net Salary : {0}", Salary);

                int PF = 9 * (Salary / 100);
                Console.WriteLine("Gross Salary : {0}", Salary + PF);
            }
            else if (Salary > 10000 && Salary < 20000)
            {
                Console.WriteLine("Employee Name : {0}", FirstName + LastName);
                Console.WriteLine("Net Salary : {0}", Salary);

                int PF = 10 * (Salary / 100);
                Console.WriteLine("Gross Salary : {0}", Salary + PF);
            }




        }
        public class Manager : EmployeeManagementSystem
        {
            private double PetrolAllowance;
            private double FoodAllowance;
            private double OtherAllowance;




            public void Calculate()
            {
                Console.WriteLine("Enter Salary of Manager:");
                Salary = Convert.ToInt32(Console.ReadLine());
                PetrolAllowance = 8 * (Salary / 100);
                FoodAllowance = 13 * (Salary / 100);
                OtherAllowance = 3 * (Salary / 100);

                Console.WriteLine("GROSS SALARY OF MANAGER = {0}", Salary + PetrolAllowance + FoodAllowance + OtherAllowance);
            }
            public void CalculateSalary()
            {
                Console.WriteLine("NET SALARY OF MANAGER = {0}", Salary);
            }


        }
        public class MarketingExecutive : EmployeeManagementSystem
        {
            private int KiloMeterTravel;
            private int TourAllowances;
            private int TelephoneAllowances;




            public void Calculate()
            {
                Console.WriteLine("Enter Marketing Executive Salary:");
                Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter kilomter travel by Marketing EXecutive:");
                KiloMeterTravel = Convert.ToInt32(Console.ReadLine());
                TourAllowances = KiloMeterTravel * 5;
                TelephoneAllowances = 1000;

                Console.WriteLine("Gross Salary of marketing executive: {0}", Salary + KiloMeterTravel + TourAllowances + TelephoneAllowances);
            }
            public void CalculateSalary()
            {
                Console.WriteLine("Net salary of marketing exective:{0}", +Salary);
            }
        }




        public class Q1
        {
            public static void Main()
            {



                Iprintable IP = new EmployeeManagementSystem();
                IP.Print();


                Manager manager = new Manager();
                manager.Calculate();
                manager.CalculateSalary();


                MarketingExecutive ME = new MarketingExecutive();

                ME.Calculate();
                ME.CalculateSalary();

                Console.ReadKey();
            }
        }
    }
}