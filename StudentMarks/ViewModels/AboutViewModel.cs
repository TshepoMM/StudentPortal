using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Input;
using System.Xml.Serialization;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StudentMarks.ViewModels
{
    public class AboutViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SubjectPicker { get; }


        public AboutViewModel()
        {

        }
    }
}
