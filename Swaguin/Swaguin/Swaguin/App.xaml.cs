using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Swaguin.Models;
using System.Collections.ObjectModel;

namespace Swaguin
{
    public partial class App : Application
    {
        public static SwaguinDatabase SwaguinData { get; private set; }
        public App(string dbPath)
        {
            InitializeComponent();

            //set database path first, then retrieve main page
            SwaguinData = new SwaguinDatabase(dbPath);

            GetAll();

            MainPage = new Swaguin.MainPage();
        }

        // A transférer 
        private async void Insert()
        {
            await SwaguinData.AddNewContactAsync("Fafin");
        }

        // A transférer 
        private async void GetAll()
        {
            ObservableCollection<Contact> people = new ObservableCollection<Contact>(await SwaguinData.GetAllContactAsync());
            people.Last();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
