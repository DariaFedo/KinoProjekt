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
using System.Windows.Shapes;

namespace Nowy_system
{
    /// <summary>
    /// Interaction logic for Show_sForm.xaml
    /// </summary>
    public partial class Show_sForm : Window
    {
        //public CTS.Show worker = new CTS.Worker();
        //CTS.System Program;
        public Show_sForm(/*CTS.System program*/)
        {
            //Program = program;
            InitializeComponent();
            //ShowForm.DataContext = show;
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            //Acceptchange acc = new Acceptchange();
            //acc.Show();
            //if (acc.check)
            //{
            //    Program.ShowCollection.Remove(show);
            //    Program.ShowCollection.Add(show);
            //    acc.Close();
            //}
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //Program.ShowCollection.Remove(show);
            //Program.ShowCollection.Add(show);
        }
    }
}
