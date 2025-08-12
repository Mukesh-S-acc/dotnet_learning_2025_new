using System;
using System.Collections.Generic;



class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string City { get; set; }
    public int Salary { get; set; }
    public int DeptNo { get; set; }
}

class Program
{

    public static void Main()
    {

        List<Employee> employees = new List<Employee>()
        {
            new Employee { EmpId = 1, EmpName = "John", City = "Pune", Salary = 20000, DeptNo = 10 },
            new Employee { EmpId = 2, EmpName = "Sara", City = "Mumbai", Salary = 30000, DeptNo = 20 },
            new Employee { EmpId = 3, EmpName = "Kia", City = "Pune", Salary = 25000, DeptNo = 10 },
            new Employee { EmpId = 4, EmpName = "Raj", City = "Delhi", Salary = 40000, DeptNo = 30 },
            new Employee { EmpId = 5, EmpName = "Simran", City = "Pune", Salary = 35000, DeptNo = 20 },
            new Employee { EmpId = 6, EmpName = "Amit", City = "Mumbai", Salary = 15000, DeptNo = 20 }
       };


        var ids = employees.Select(e => e.EmpId).ToList();
        //Console.WriteLine(ids);
        //foreach(var i in ids)
        //{
        //    Console.WriteLine(i+ " ");
        //}
        var dept10 = employees.Where(e => e.DeptNo == 10);
        //foreach (var i in dept10)
        //{
        //    Console.WriteLine(i.EmpName + " ");
        //}
        var firstEmp = employees.First();
        //Console.WriteLine(firstEmp.EmpName);
        bool anyDelhi = employees.Any(e => e.City == "Delhi");
        bool allAbove = employees.All(e => e.Salary > 10000);
        int totalCount = employees.Count();
        var startWithS = employees.Where(e => e.EmpName.StartsWith("S"));
        //foreach (var i in startWithS)
        //{
        //    Console.WriteLine(i.EmpName + " ");
        //}


        var orderedBySalary = employees.OrderByDescending(e => e.Salary);
        //foreach (var i in orderedBySalary)
        //{
        //    Console.WriteLine(i.EmpName + " ");
        //}

        var top2 = employees.OrderByDescending(e => e.Salary).Take(2);
        var skip = employees.Skip(2);
        //foreach (var i in skip)
        //{
        //    Console.WriteLine(i.EmpName + " ");
        //}
        var avgSalary = employees.Average(e => e.Salary);
        var deptSalary = employees.Where(e => e.DeptNo == 20).Sum(e => e.Salary);
        var minSalary = employees.OrderBy(e => e.Salary).First();
        var Uppername = employees.Select(e => e.EmpName.ToUpper());
        //foreach (var i in Uppername)
        //{
        //    Console.WriteLine(i + " ");
        //}


        var highinpune = employees.Where(e => e.City == "Pune" && e.Salary > 25000);
        var groupByCity = employees.GroupBy(e => e.City)
            .Select(g => new { City = g.Key, Count = g.Count() });

        var mumbaiNames = employees.Where(e => e.City == "Mumbai")
            .OrderBy(e => e.EmpName)
            .Select(e => e.EmpName);

        //foreach (var i in mumbaiNames)
        //{
        //    Console.WriteLine(i + " ");
        //}
        var namestore = employees.Select(e=>e.EmpName);
        var joinString = string.Join(",", namestore);
        Console.WriteLine(joinString);

        var rangeSalary = employees
            .Where(e => e.Salary >= 20000 && e.Salary <= 35000)
            .Select(e => e.EmpName);

        bool EmpExists = employees.Any(e => e.EmpId == 4);
        var first3Alpha = employees.OrderBy(e => e.EmpName).Take(3).Select(e => e.EmpName);

    }
}