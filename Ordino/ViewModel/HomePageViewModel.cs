using Ordino.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordino.ViewModel
{
    internal class HomePageViewModel : ObservableObject
    {
        public UserModel CurrentUser { get; }

        public HomePageViewModel(UserModel currentUser)
        {
            CurrentUser = currentUser;

            homePageTests = new ObservableCollection<HomePageTest> 
            {
            new HomePageTest { Course = "Math", Title = "BS1001"}

            };

        }

        public ObservableCollection<HomePageTest> homePageTests { get; set; }


    }
}
