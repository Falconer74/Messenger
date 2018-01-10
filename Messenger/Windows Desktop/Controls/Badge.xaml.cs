using System;
using System.Collections.Generic;
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

namespace Windows_Desktop.Controls
{
    /// <summary>
    /// Interaction logic for Badge.xaml
    /// </summary>
    public partial class Badge : UserControl
    {

        int amount = 0;

        public int Amount
        {
            set
            {
                amount = value;
                Label_Main.Text = amount.ToString();
            }
            get
            {
                return amount;
            }
        }



        public Badge()
        {
            InitializeComponent();
        }
    }
}
