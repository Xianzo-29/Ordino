using Ordino.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ordino.ViewModel
{
    internal class ReferenceVM
    {
        public ObservableCollection<HomePageTest> Folder { get; set;}

        public HomePageTest addData { get; set; }

        public ICommand SaveCommand { get; set; }
        public ICommand ClearCommand { get; set; }

        public ReferenceVM()
        {
            Folder = new ObservableCollection<HomePageTest>()
            {
                new HomePageTest { Activity = "Act#1", Course = "History", FileType = "mp4" },
                new HomePageTest { Activity = "HW#1", Course = "El Filibusterismo", FileType = "jpg" }
            };
            addData = new HomePageTest();
            SaveCommand = new RelayCommand(ExecuteSaveCommand);
            ClearCommand = new RelayCommand(ExecuteClearCommand);
        }

        public void ExecuteSaveCommand(object? par)
        {

            Folder.Add(new HomePageTest { Activity = addData.Activity, Course = addData.Course, FileType = addData.FileType });

            addData.Activity = string.Empty;
            addData.Course = string.Empty;
            addData.FileType = string.Empty;
        }

        public void ExecuteClearCommand(object? par)
        {
            addData.Activity = string.Empty;
            addData.Course = string.Empty;
            addData.FileType = string.Empty;
        }
    }
}
