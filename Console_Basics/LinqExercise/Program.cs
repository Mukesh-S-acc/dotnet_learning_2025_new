using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int Empid { get; set; }
    public string EmpName { get; set; }
    public string City { get; set; }
    public double Salary { get; set; }
    public int Deptno { get; set; }
}


class Program
{

    public static void Main()
    {

        List<Employee> employees = new List<Employee>
        
            {
                new Employee { Empid=1, EmpName="Sara", City="Pune", Salary=20000, Deptno=10 },

                new Employee { Empid=2, EmpName="Piya", City="Chennai", Salary=30000, Deptno=20 },
                new Employee { Empid=3, EmpName="Kia", City="Bangalore", Salary=5000, Deptno=30 },
                new Employee { Empid=4, EmpName="John", City="Pune", Salary=10, Deptno=10 },
                new Employee { Empid=5, EmpName="Anna", City="Coimbatore", Salary=10, Deptno=10 },
                new Employee { Empid=6, EmpName="Mike", City="Pune", Salary=10, Deptno=10 },
                new Employee { Empid=7, EmpName="Ravi", City="Pune", Salary=10000, Deptno=10 },
         };

        var cityGroup = employees.GroupBy(e => e.City).Select(g => new { City = g.Key, EmployeeCount = g.Count() });

        foreach (var cg in cityGroup)
        {
            Console.WriteLine($"City: {cg.City}, Total Employees: {cg.EmployeeCount}");
        }




        //    var highestInDept = employees.GroupBy(e => e.Deptno).Select(g => new{
        //    DeptNo = g.Key,
        //    MaxSalary = g.Max(e => e.Salary),
        //    TopEarners = g.Where(e => e.Salary == g.Max(emp => emp.Salary))});

        //    foreach (var dept in highestInDept)
        //    {
        //        Console.WriteLine($"Dept: {dept.DeptNo}, Highest Salary: {dept.MaxSalary}");
        //        foreach (var emp in dept.TopEarners)
        //        { Console.WriteLine($" {emp.EmpName}"); }
        //    }


        var highSalary = employees.Where(e => e.Salary > 20000).Select(e => new { e.EmpName, e.City });

        foreach (var i in highSalary)
        {
            Console.WriteLine($"Name: {i.EmpName}, City : {i.City}");
        }


        //    var anObj = employees.Select(e => new { e.EmpName,e.City});

        //    foreach (var o in anObj)
        //    {
        //        Console.WriteLine($"Name: {o.EmpName}, city: {o.City}");
        //    }


        //    var groupByDept = employees.GroupBy(e => e.Deptno).Select(g => new{
        //    DeptNo = g.Key,
        //    Count = g.Count(),
        //    AvgSalary = g.Average(e => e.Salary)
        //    });

        //    foreach (var dept in groupByDept)
        //    { Console.WriteLine($"Dept: {dept.DeptNo}, Count: {dept.Count}, Avg Salary: {dept.AvgSalary}"); }

        //    var empByCity = employees.GroupBy(e => e.City).Select(a => new
        //    {
        //        City = a.Key,
        //        TotEmp = a.Count(),
        //        Salaries = a.Select(e=>e.Salary).ToList()
        //    });

        //    Console.WriteLine();

        //    foreach (var city in empByCity)
        //    {
        //        Console.Write($"City: {city.City}, Total Employees: {city.TotEmp}");
        //        Console.Write("Salaries: ");

        //        foreach (var salary in city.Salaries)
        //        {
        //            Console.Write(salary);
        //        }
        //        Console.ReadLine();
        //    }

        //    var avgSalaryPerDept = employees.Where(e => e.Salary > 0).GroupBy(e => e.Deptno).Select(g => new
        //{
        //    DeptNo = g.Key,
        //    AvgSalary = g.Average(e => e.Salary)
        //});

        //    foreach (var dept in avgSalaryPerDept)
        //    { Console.WriteLine($"Dept: {dept.DeptNo},Avg Salary: {dept.AvgSalary}"); }


        var nonZeroSalaryGroups = employees.Where(e => e.Salary > 0).GroupBy(e => e.Deptno).Select(g => new
        {
            DeptNo = g.Key,
            EmployeeNames = g.Select(e => e.EmpName).ToList()
        });

        foreach (var dept in nonZeroSalaryGroups)
        {
            Console.Write($"Dept: {dept.DeptNo}");

            Console.Write(" Employees:");
            foreach(var i in dept.EmployeeNames)
            {
                Console.Write(i + ", "); 
            }
            Console.WriteLine();
        }



    }


}