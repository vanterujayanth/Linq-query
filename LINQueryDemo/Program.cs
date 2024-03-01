using LINQueryDemo;
using System.Security.Cryptography.X509Certificates;

public  class Program
{
    static void Main(string[] args)
    {
        LiqueryDemo1 l1 = new LiqueryDemo1();
        List<Employee>emp = new List<Employee>() {
           

            new Employee() {Emp_id = 209, Name = "Anjita", Emp_gender = "Female",
                                       Hire_data = "12/3/2017", Emp_salary = 20000},

            new Employee() {    Emp_id = 210, Name = "Soniya",  Emp_gender = "Female",
                                    Hire_data = "22/4/2018", Emp_salary = 30000},

            new Employee() {    Emp_id = 211, Name = "Rohit", Emp_gender = "Male",
                                  Hire_data = "3/5/2016", Emp_salary = 40000},

            new Employee() {Emp_id = 212, Name = "Supriya", Emp_gender = "Female",
                                      Hire_data = "4/8/2017", Emp_salary = 40000},

            new Employee() {Emp_id = 213, Name = "Anil", Emp_gender = "Male",
                                Hire_data = "12/1/2016", Emp_salary = 40000},

            new Employee() {Emp_id = 214, Name = "Anju", Emp_gender = "Female",
                                 Hire_data = "17/6/2015", Emp_salary = 50000},
        };
       // for order 
         var res = from e in emp 
                  orderby e.Emp_id descending
                  select e; 
        foreach(var item in res)
        {
            Console.WriteLine("Employee_Id : {0}",item.Emp_id);
        }
        // for names 
        var name = from n in emp
                   orderby n.Name descending
                   select n;
        foreach (var item in name)
        {
            Console.WriteLine("Employee_Id : {0}", item.Name);
        }
    }
   
}