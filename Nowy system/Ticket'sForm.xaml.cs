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
    /// Interaction logic for Ticket_sForm.xaml
    /// </summary>
    public partial class Ticket_sForm : Window
    {
        //public CTS.Ticket ticket = new CTS.Ticket();
        //CTS.System Program;
        public Ticket_sForm(/*CTS.System program*/)
        {
            //Program = program;
            InitializeComponent();
            //Ticket.DataContext = ticket;
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            //Acceptchange acc = new Acceptchange();
            //acc.Show();
            //if (acc.check)
            //{
            //    Program.TicketCollection.Remove(ticket);
            //    Program.TicketCollection.Add(ticket);
            //    acc.Close();
            //}
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //Program.TicketCollection.Remove(ticket);
            //Program.TicketCollection.Add(ticket);
        }
    }
}
