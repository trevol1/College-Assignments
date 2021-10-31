using Newtonsoft.Json;
using Registracio.Model;
using Registracio.UWP.DataAccess;
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
using Registracio.UWP;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Registracio.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ItemMain : Page
    {
        private Items items = new Items();
        private EmpDataAccess itemsDataAccess = new EmpDataAccess();

        private ItemModel ViewModel { get; } = new ItemModel();

        public ItemMain()
        {
            InitializeComponent();

            Loaded += DataShow;
        }
        private async void DataShow(object sender, RoutedEventArgs e)
        {

           await ViewModel.LoadItemsAsync();

        }
        private void BtnAddNew_Click_Item(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddNewItem));
        }

        private async void BtnDelete_Click_Item(object sender, RoutedEventArgs e)
        {

            Items item = ((Items)itemsList.SelectedItem);

            await itemsDataAccess.DeleteItems(item);
            var message = new MessageDialog("Item Deleted!");
            await message.ShowAsync();
        }

        private void BtnEmployeesList_Click_Employee(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void BtnUpdate_Click_Item(object sender, RoutedEventArgs e)
        {
            Items items = ((Items)itemsList.SelectedItem);
            if (items != null)
            {
                itemUpdateTb.Text = items.ItemName;
            }
        }

        

        private async void BtnUpdateItemSave(object sender, RoutedEventArgs e)
        {
            Items items = ((Items)itemsList.SelectedItem);
            items.ItemName = itemUpdateTb.Text;
            await itemsDataAccess.UpdateItemAsync(items);
        }
    }
}
