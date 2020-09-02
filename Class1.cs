using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CustomControl2020
{
    public class VM : PropChanged
    {
        public Color BoundColor
        {
            get => _clr;
            set { _clr = value; OnPropChanged(); }
        }
        private Color _clr = Colors.Black;
    }

    public class PropChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropChanged([CallerMemberName] string s = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }
    }
}
