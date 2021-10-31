using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public sealed partial class MainPageItem : Page
    {
        public MainPageItem()
        {
            this.InitializeComponent();
        }

        private void BtnAddNew_Click_Item(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddNewItem));
        }

        private async void BtnDelete_Click_Item(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("Item Deleted!");
            await message.ShowAsync();
        }

        private void BtnEmployeesList_Click_Employee(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
