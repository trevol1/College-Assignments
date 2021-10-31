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
    public sealed partial class AddNewItem : Page
    {
        public AddNewItem()
        {
            this.InitializeComponent();
        }

        private async void BtnAddNew_Click_Employee(object sender, RoutedEventArgs e)
        {
            var item = new AddNewItem() 
            {
                Name = itemNameTb.Text
            };
            var message = new MessageDialog("Item " + itemNameTb.Text + " Added, with quantity: " + itemQ.SelectedValue);
            await message.ShowAsync();

            Frame.GoBack();
        }

        private void BtnCancel_Click_Employee_1(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
