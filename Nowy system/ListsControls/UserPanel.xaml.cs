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
using System.Collections.ObjectModel;

namespace Nowy_system.ListsControls
{
    /// <summary>
    /// Interaction logic for WorkerControl.xaml
    /// </summary>
    public partial class UserPanel : UserControl
    {
        CTS.System Program;
        FilmControl filmPanel;
        //WorkerControl workerPanel;
        //ShowControl showPanel;
        //TicketControl ticketPanel;

        public UserPanel(CTS.System program)
        {
            InitializeComponent();
            this.Program = program;
            filmPanel = new FilmControl(Program);
            //workerPanel = new WorkerControl(Program);
            //showPanel = new ShowControl(Program);
            //ticketPanel = new TicketControl(Program);
           
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
            if (filmPanel.films.IsVisible)
            {
                if (filmPanel.films.SelectedIndex > -1 && !(filmPanel.films.SelectedItems.Count > 1))
                {
                    Film_sForm film_SForm = new Film_sForm();
                   CTS.Film film = (CTS.Film)filmPanel.films.SelectedItem;
                    CTS.Film backup = new CTS.Film(film);
                    film_SForm.film = film;
                    film_SForm.FilmForm.DataContext = film_SForm.film;
                    film_SForm.ShowDialog();
                    if (film_SForm.check == true)
                    {
                        ((ObservableCollection<CTS.Film>)filmPanel.films.ItemsSource).Remove(film);
                        this.Program.FilmCollection.Add(film_SForm.film);
                    }
                    else
                    {
                        ((ObservableCollection<CTS.Film>)filmPanel.films.ItemsSource).Remove(film);
                        this.Program.FilmCollection.Add(backup);
                    }
                }
                else
                {
                    MessageBox.Show("Item not selected, or selected more than one");
                }
            }

            //if (workerPanel.workers.IsVisible)
            //{
            //    if (workerPanel.workers.SelectedIndex > -1 && !(workerPanel.workers.SelectedItems.Count > 1))
            //    {
            //        Worker_sForm worker_SForm = new Worker_sForm(Program);
            //        CTS.Worker worker1 = (CTS.Worker)workerPanel.workers.SelectedItem;
            //        CTS.Worker backup = new CTS.Worker((CTS.Worker)workerPanel.workers.SelectedItem);
            //        worker_SForm.worker = new CTS.Worker((CTS.Worker)workerPanel.workers.SelectedItem);
            //        worker_SForm.WorkerForm.DataContext = worker_SForm.worker;
            //        worker_SForm.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Item not selected, or selected more than one");
            //    }
            //}

            //if (showPanel.shows.IsVisible)
            //{
            //    if (showPanel.shows.SelectedIndex > -1 && !(showPanel.shows.SelectedItems.Count > 1))
            //    {
            //        Show_sForm show_SForm = new Show_sForm(Program);
            //        CTS.Show show1 = (CTS.Show)showPanel.shows.SelectedItem;
            //        CTS.Show backup = new CTS.Show((CTS.Show)showPanel.shows.SelectedItem);
            //        show_SForm.show = new CTS.Show((CTS.Show)showPanel.shows.SelectedItem);
            //        show_SForm.ShowForm.DataContext =show_SForm.show;
            //        show_SForm.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Item not selected, or selected more than one");
            //    }
            //}

            //if (ticketPanel.tickets.IsVisible)
            //{
            //    if (ticketPanel.tickets.SelectedIndex > -1 && !(ticketPanel.tickets.SelectedItems.Count > 1))
            //    {
            //        Ticket_sForm ticket_SForm = new Ticket_sForm(Program);
            //        CTS.Ticket ticket1 = (CTS.Ticket)ticketPanel.tickets.SelectedItem;
            //        CTS.Ticket backup = new CTS.Ticket((CTS.Ticket)ticketPanel.tickets.SelectedItem);
            //        ticket_SForm.worker = new CTS.Ticket((CTS.Ticket)ticketPanel.tickets.SelectedItem);
            //        ticket_SForm.TicketForm.DataContext = ticket_SForm.ticket;
            //        ticket_SForm.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Item not selected, or selected more than one");
            //    }
            //}

            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (filmPanel.films.IsVisible)
            {
                Film_sForm film_form = new Film_sForm();
                film_form.ShowDialog();

                if (film_form.check == true)
                {
                    this.Program.FilmCollection.Add(film_form.film);
                }
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (filmPanel.films.IsVisible)
            {
                if (filmPanel.films.SelectedIndex > -1)
                {
                    ObservableCollection<CTS.Film> itemsToRemove = new ObservableCollection<CTS.Film>();

                    foreach (CTS.Film item in filmPanel.films.SelectedItems)
                    {
                        itemsToRemove.Add(item);
                    }
                    foreach (CTS.Film item in itemsToRemove)
                    {
                        ((ObservableCollection<CTS.Film>)filmPanel.films.ItemsSource).Remove(item);
                    }

                }
                else
                {
                    MessageBox.Show("Item not selected, or selected more than one");
                }
            }
        }
    }
}
