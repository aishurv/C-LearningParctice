using PracticeProject.EmpMgmt;
using System;

namespace PracticeProject.EmpMgmt
{
    class EmpMgmtProject
    {
        public EmpMgmtProject()
        {
            
            Employee veena = new StoreManager("Veena", "Kore", "veena@emp.com", new DateTime(2024, 1, 16), 25);
            Manager sneha = new Manager("sneha", "mali", "sneha@emp.com", new DateTime(2024, 1, 16), 30);
            JuniorResearcher geeta = new JuniorResearcher("geeta", "kore", "geeta@emp.com", new DateTime(2024, 1, 23), 17);
            Employee reva = new StoreManager("reva", "mali", "reva@emp.com", new DateTime(2024, 12, 12), 10);
            Employee megha = new StoreManager("megha", "khane", "megha@emp.com", new DateTime(2024, 8, 8), 10);

            veena.DisplayEmployeeDetails();
            veena.PerformWork();
            veena.PerformWork();
            veena.PerformWork();
            veena.ReceiveWage();

            sneha.DisplayEmployeeDetails();
            sneha.PerformWork();
            sneha.PerformWork();
            sneha.PerformWork();
            sneha.AttendManagementMeeting();
            sneha.ReceiveWage();

            geeta.ResearchNewPieTastes(5);
            geeta.ReceiveWage();

            Employee[] employees = new Employee[5];
            employees[0] = veena;
            employees[1] = sneha;
            employees[2] = geeta;
            employees[3] = reva;
            employees[4] = megha;

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
