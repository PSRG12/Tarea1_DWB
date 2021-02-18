using System;
using Tarea1_DWB.DataAccess;
using System.Linq;

namespace Tarea1_DWB
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext dbcontext = new NorthwindContext();

            var employeeSelect = dbcontext.Employees.Select(s => new
            {
                //Proyección Lambda
                EmployeeId = s.EmployeeId,
                EmployeeFirstName = s.FirstName,
                EmployeeAdress = s.Address,
                EmployeeHomePhone = s.HomePhone,
                EmployeeNotes = s.Notes

            }).ToList();

            Console.WriteLine("Proceso Exitoso:)");
        }
    }
}
