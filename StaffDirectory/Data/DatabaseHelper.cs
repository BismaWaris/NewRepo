using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using StaffDirectory.Models;

namespace StaffDirectory.Data
{
    public class DatabaseHelper
    {
        readonly SQLiteAsyncConnection _database;

        public DatabaseHelper(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Employee>().Wait();
        }

        internal Task<List<Employee>> GetEmployeesAsync()
        {
            return _database.Table<Employee>().ToListAsync();
        }

        internal Task<int> SaveEmployeeAsync(Employee employee)
        {
            if (employee.EmployeeID != 0)
            {
                return _database.UpdateAsync(employee);
            }
            else
            {
                return _database.InsertAsync(employee);
            }
        }


        internal Task<int> UpdateEmployeeAsync(Employee employee)
        {
            // This checks if the employee has an ID that's not the default value. If the employee exists (i.e., the EmployeeID is not 0), it updates the record.

            if (employee.EmployeeID != 0)
            {
                return _database.UpdateAsync(employee);
            }
            else
            {

                // This returns a completed task with a result of 0.
                return Task.FromResult(0);
            }
        }

    }
}