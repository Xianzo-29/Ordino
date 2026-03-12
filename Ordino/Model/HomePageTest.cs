using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ordino.ViewModel;

namespace Ordino.Model
{
    public class HomePageTest : ObservableObject
    {
        private string _course = string.Empty;
        private string _title = string.Empty;

        public string Course 
        {
            get { return _course; }
            set
            {
                if (_course != value)
                {
                    _course = value;
                    OnPropertyChanged(nameof(Course));
                }
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }
    }
}
