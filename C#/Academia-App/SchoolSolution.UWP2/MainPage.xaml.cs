using Newtonsoft.Json;
using Registracio.Model;
using Registracio.UWP.DataAccess;
using Registracio.UWP.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Registracio.UWP
{
    public sealed partial class MainPage : Page
    {
        private Employees employees = new Employees();
        private EmpDataAccess employeesDataAccess = new EmpDataAccess();

        private EmpModel ViewModel { get; } = new EmpModel();

        public MainPage()
        {
            InitializeComponent();

            Loaded += DataShow;
        }

        private async void DataShow(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadEmployeesAsync();
        }


        private void BtnItemsList_Click_Item(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ItemMain));
        }

        private void BtnAddNew_Click_Employee(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddEmployee));
        }

        private async void BtnDelete_Click_Employee(object sender, RoutedEventArgs e)
        {
            Employees employee = ((Employees)employeeNameList.SelectedItem);

            await employeesDataAccess.DeleteEmployee(employee);

            var message = new MessageDialog("Employee Deleted!");
            await message.ShowAsync();
        }


        private async void BtnUpdateSave(object sender, RoutedEventArgs e)
        {
            Employees employee = ((Employees)employeeNameList.SelectedItem);

                employee.EmpName = employeeUpdateTb.Text;

            await employeesDataAccess.UpdateEmployee(employee);

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Employees employee = ((Employees)employeeNameList.SelectedItem);
            if (employee != null)
            {
                employeeUpdateTb.Text = employee.EmpName;
            }
        }
    }
}
