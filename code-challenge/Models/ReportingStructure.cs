using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Models
{
    public class ReportingStructure
    {
        public Employee Employee { get; set; }
        public int NumberOfReports
        {
            get
            {
                int subordinateCount = 0;
                if (Employee.DirectReports != null && Employee.DirectReports.Any())
                {
                  subordinateCount = 
                        Employee
                           .DirectReports
                           .Where(directReport => directReport.DirectReports!= null)
                           .SelectMany(directReport =>
                                         directReport
                                            .DirectReports                                            
                                            .Select(indirectReport => indirectReport.EmployeeId))
                          .Union(Employee.DirectReports.Select(directReport => directReport.EmployeeId))
                          .Distinct()
                          .Count();
                }
                return subordinateCount; 
            }
        }
    }
}
