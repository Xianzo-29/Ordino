using Ordino.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordino.ViewModel
{
    internal class ReferenceVM
    {
        public ObservableCollection<HomePageTest> Folder { get; set;}

        public ReferenceVM()
        {
            Folder = new ObservableCollection<HomePageTest>()
            {
                new HomePageTest { Course = "History", Title = "BS1001" },
                new HomePageTest { Course = "El Filibusterismo", Title = "BS1002" }
            };
        }
    }
}
