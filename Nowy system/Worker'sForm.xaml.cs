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
using CTS = Cinema.Ticket.System;

namespace Nowy_system
{
    /// <summary>
    /// Interaction logic for Worker_sForm.xaml
    /// </summary>
    public partial class Worker_sForm : Window
    {
        //public CTS.Worker worker = new CTS.Worker();
        //CTS.System Program;
        public Worker_sForm(/*CTS.System program*/)
        {
            //Program = program;
            InitializeComponent();
            //WorkerForm.DataContext = worker;
        }

        //private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        //{
        //    Acceptchange acc = new Acceptchange();
        //    acc.Show();
        //    if (acc.check)
        //    {
        //        Program.WorkerCollection.Remove(worker);
        //        Program.WorkerCollection.Add(worker);
        //        acc.Close();
        //    }
        //}

        //private void Cancel_Click(object sender, RoutedEventArgs e)
        //{
        //    Program.WorkerCollection.Remove(worker);
        //    Program.WorkerCollection.Add(worker);
        //}
    }
}
