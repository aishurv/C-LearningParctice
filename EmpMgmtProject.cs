using PracticeProject.EmpMgmt;
using System;

namespace PracticeProject.EmpMgmt
{
    class EmpMgmtProject
    {
        public EmpMgmtProject()
        {
            
            Employee bethany = new StoreManager("Veena", "Kore", "veena@emp.com", new DateTime(2024, 1, 16), 25);
            Manager mary = new Manager("sneha", "mali", "sneha@emp.com", new DateTime(2024, 1, 16), 30);
            JuniorResearcher bobJunior = new JuniorResearcher("geeta", "kore", "geeta@emp.com", new DateTime(2024, 1, 23), 17);
            Employee kevin = new StoreManager("reva", "mali", "reva@emp.com", new DateTime(2024, 12, 12), 10);
            Employee kate = new StoreManager("megha", "khane", "megha@emp.com", new DateTime(2024, 8, 8), 10);

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

            mary.DisplayEmployeeDetails();
            mary.PerformWork();
            mary.PerformWork();
            mary.PerformWork();
            mary.AttendManagementMeeting();
            mary.ReceiveWage();

            bobJunior.ResearchNewPieTastes(5);
            bobJunior.ReceiveWage();

            Employee[] employees = new Employee[5];
            employees[0] = bethany;
            employees[1] = mary;
            employees[2] = bobJunior;
            employees[3] = kevin;
            employees[4] = kate;

            foreach (var employee in employees)
            {
                employee.PerformWork();
                employee.ReceiveWage();
                employee.DisplayEmployeeDetails();
                employee.GiveBonus();
                //employee.AttendManagementMeeting();
            }

            Console.ReadLine();
        }
    }
}
