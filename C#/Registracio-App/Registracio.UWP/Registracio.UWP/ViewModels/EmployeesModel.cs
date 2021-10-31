using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registracio.UWP.DataAcess;
using System.Collections.ObjectModel;

namespace Registracio.UWP.ViewModels
{
    public class EmployeesModel
    {
        public ObservableCollection<Model.Employee> Employees { get; set; } = new ObservableCollection<Model.Employee>();
        private DataAcess.Employees employeesDataAccess = new DataAcess.Employees();



        internal async Task LoadCoursesAsync()
        {
            var employees = await employeesDataAccess.GetEmployeesAsync();


        }
    }
}
