using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Business_Access_Layer;
using Business_Entity_Layer;

namespace WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Informations info = new Informations();
        public Operations oper = new Operations();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            info.username = usernameTxb.Text;
            info.password = passwordTxb.Text;
            info.fullname = fullnameTxb.Text;
            info.email = emailTxb.Text;
            
            int rows =oper.insertUser(info);
            if (rows > 0)
            {
                MessageBox.Show("Data saved successfully");
            }
        }
    }
}