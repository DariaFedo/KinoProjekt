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

namespace Nowy_system.ListsControls
{
    /// <summary>
    /// Interaction logic for WorkerControl.xaml
    /// </summary>
    public partial class UserPanel : UserControl
    {
        CTS.System Program;

        public UserPanel(CTS.System program)
        {
            InitializeComponent();
            this.Program = program;
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if (sender.Equals(this.workerBtn))
            {
                WorkerControl workerPanel = new WorkerControl(Program);
                MainPanel.Children.Clear();
                MainPanel.Children.Add(workerPanel);
            }
            if (sender.Equals(this.clientBtn))
            {
                ClientControl clientPanel = new ClientControl(Program);
                MainPanel.Children.Clear();
                MainPanel.Children.Add(clientPanel);
            }
            if (sender.Equals(this.filmBtn))
            {
                FilmControl filmPanel = new FilmControl(Program);
                MainPanel.Children.Clear();
                MainPanel.Children.Add(filmPanel);

            }
            if (sender.Equals(this.roomBtn))
            {
                RoomControl roomPanel = new RoomControl(Program);
                MainPanel.Children.Clear();
                MainPanel.Children.Add(roomPanel);

            }
            if (sender.Equals(this.showBtn))
            {
                ShowControl showPanel = new ShowControl(Program);
                MainPanel.Children.Clear();
                MainPanel.Children.Add(showPanel);

            }
            if (sender.Equals(this.bookingBtn))
            {
                BookingControl bookingPanel = new BookingControl(Program);
                MainPanel.Children.Clear();
                MainPanel.Children.Add(bookingPanel);
            }
            if (sender.Equals(this.ticketBtn))
            {
                TicketControl ticketPanel = new TicketControl(Program);
                MainPanel.Children.Clear();
                MainPanel.Children.Add(ticketPanel);

            }

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
