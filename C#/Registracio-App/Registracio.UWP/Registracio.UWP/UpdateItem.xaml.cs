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
    public sealed partial class UpdateItem : Page
    {
        public UpdateItem()
        {
            this.InitializeComponent();
        }

        private async void BtnConfirm_Click_Item(object sender, RoutedEventArgs e)
        {
            var message = new MessageDialog("Employee " + itemNameUpdateTb.Text + " Updated, with quantity: " + itemQUpdateTb.SelectedValue);
            await message.ShowAsync();

            Frame.GoBack();
        }

        private void BtnCancel_Click_Item_1(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
