﻿using Newtonsoft.Json;
using System;
using System.Windows;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Registracio.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddEmployee : Page
    {
        public AddEmployee()
        {
            this.InitializeComponent();
        }
        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
        private async void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            var employee = new AddEmployee() 
            {
                Name = employeeNameTb.Text
            };

            // This was a part of just a startup project, but i will work on the database part in the coming weeks.

            /*var employeeJson = JsonConvert.SerializeObject(employee);

            var client = new HttpClient();
            var HttpContent = new StringContent(employeeJson);
            HttpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            await client.PostAsync("http://localhost:56388/api/Employees", HttpContent);*/

 
            var message= new MessageDialog("Employee " + employeeNameTb.Text + " Added, with DOB: " + birthDatePicker.SelectedDate);
            await message.ShowAsync();

            Frame.GoBack();
        }
    }
}