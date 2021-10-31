using Newtonsoft.Json;
using Registracio.UWP.ViewModels;
using System;
using System.Collections.Generic;
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
        public EmployeesModel ViewModel { get; } = new EmployeesModel();

        public MainPage()
        {
            InitializeComponent();

            Loaded += DataShow;
            // Loaded += MainPage_LoadedAsync;
        }

        private async void DataShow(object sender, RoutedEventArgs e)
        {

            HttpClient client = new HttpClient();
            var JsonResponse = await client.GetStringAsync("http://localhost:37089/api/courses");
            var employeesResult = JsonConvert.DeserializeObject<List<EmployeesModel>>(JsonResponse);
            employeesList.ItemsSource = employeesResult;

        }
        /* public MainPage()
         {
             InitializeComponent();


            // Loaded += DataShow;
             // Loaded += MainPage_LoadedAsync;
         }

         //private async void DataShow(object sender, RoutedEventArgs e)
         /*{

             HttpClient client = new HttpClient();
             var JsonResponse = await client.GetStringAsync("http://localhost:37089/api/courses");
             var employeesResult = JsonConvert.DeserializeObject<List<Course>>(JsonResponse);
             Courses.ItemsSource = employeesResult;

         }
         // This was a part of just a startup project, but i will work on the database part in the coming weeks.

         /*protected override async void OnNavigatedTo(NavigationEventArgs e)
         {
             HttpClient client = new HttpClient();
             var JsonResponse = await client.GetStringAsync("https://localhost:44320/api/values");
             var employeesResult = JsonConvert.DeserializeObject<List<AddEmployee>>(JsonResponse);//<List<Employee>>
             employeesList.ItemsSource = employeesResult;
         }
         /*private void AppBarButton_Click(object sender, RoutedEventArgs e)
         {
             Frame.Navigate(typeof(AddEmployee));
         }*/

        private void BtnItemsList_Click_Item(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPageItem));
        }

        private void BtnAddNew_Click_Employee(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddEmployee));
        }

        private async void BtnDelete_Click_Employee(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("Employee Deleted!");
            await message.ShowAsync();
        }
    }
}
