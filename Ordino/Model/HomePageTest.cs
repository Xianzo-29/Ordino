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
        private string _activity = string.Empty;
        private string _course = string.Empty;
        private string _filetype = string.Empty;

        public string Activity
        {
            get { return _activity; }
            set
            {
                if (_activity != value)
                {
                    _activity = value;
                    OnPropertyChanged(nameof(Activity));
                }
            }
        }

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

        public string FileType
        {
            get { return _filetype; }
            set
            {
                if (_filetype != value)
                {
                    _filetype = value;
                    OnPropertyChanged(nameof(FileType));
                }
            }
        }
    }
}
