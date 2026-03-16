using Ordino.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;

namespace Ordino.ViewModel
{
    internal class HomePageViewModel : ObservableObject
    {
        public UserModel CurrentUser { get; set; }



        public HomePageViewModel(UserModel currentUser)
        {
            CurrentUser = currentUser;

            homePageTests = new ObservableCollection<HomePageTest> 
            {
                new HomePageTest { Activity = "Act#1", Course = "History", FileType = "mp4" },
                new HomePageTest { Activity = "HW#1", Course = "El Filibusterismo", FileType = "jpg" }

            };
            
        }

        public ObservableCollection<HomePageTest> homePageTests { get; set; }
        

    }
}
