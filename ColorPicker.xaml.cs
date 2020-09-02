using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControl2020
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();
        }


        public Color ColorSet
        {
            get { return (Color)GetValue(ColorSetProperty); }
            set { SetValue(ColorSetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ColorSet.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorSetProperty =
            DependencyProperty.Register("ColorSet", typeof(Color), 
                typeof(ColorPicker), 
                new FrameworkPropertyMetadata(Colors.Red, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        private void btnRed(object sender, RoutedEventArgs e)
        {
            ColorSet = Colors.Red;
        }
        private void btnGreen(object sender, RoutedEventArgs e)
        {
            ColorSet = Colors.Green;
        }
        private void btnBlue(object sender, RoutedEventArgs e)
        {
            ColorSet = Colors.Blue;
        }
        private void btnYellow(object sender, RoutedEventArgs e)
        {
            ColorSet = Colors.Yellow;
        }
    }


    public class ColorToBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color clr)
                return new SolidColorBrush(clr);

            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
