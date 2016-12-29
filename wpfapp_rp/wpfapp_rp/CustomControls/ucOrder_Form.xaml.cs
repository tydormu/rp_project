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

namespace wpfapp_rp.CustomControls
{
    /// <summary>
    /// Interaction logic for ucOrder_Form.xaml
    /// </summary>
    public partial class ucOrder_Form : UserControl
    {
        public ucOrder_Form()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submited");
            PrintDialog printDlg = new PrintDialog();
            ucOrder_Form uc = new ucOrder_Form();
            printDlg.PrintVisual(uc, "User Control Printing.");
        }
    }
}
