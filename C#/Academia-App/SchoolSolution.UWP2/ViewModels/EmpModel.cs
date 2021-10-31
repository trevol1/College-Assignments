using Registracio.Model;
using Registracio.UWP.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registracio.DataContext;
using System.Diagnostics;

namespace Registracio.UWP.ViewModels
{
    public class EmpModel
    {
        public ObservableCollection<Employees> Employees { get; set; } = new ObservableCollection<Employees>();
        private DataAccess.EmpDataAccess employeesDataAccess = new DataAccess.EmpDataAccess();

        internal async Task LoadEmployeesAsync()
        {
            var employees = await employeesDataAccess.GetEmployeesAsync();

            foreach (Employees employee in employees)
            {
                Employees.Add(employee);
                Debug.WriteLine(employee);
            }
        }
    }
}

