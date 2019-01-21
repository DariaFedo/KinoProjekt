﻿using System;
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
        FilmControl filmPanel;
        WorkerControl workerPanel;
        ShowControl showPanel;
        TicketControl ticketPanel;

        public UserPanel(CTS.System program)
        {
            InitializeComponent();
            this.Program = program;
            filmPanel = new FilmControl(Program);
            workerPanel = new WorkerControl(Program);
            showPanel = new ShowControl(Program);
            ticketPanel = new TicketControl(Program);
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
                    Film_sForm film_SForm = new Film_sForm(Program);
                    CTS.Film film1 = (CTS.Film)filmPanel.films.SelectedItem;
                    CTS.Film backup = new CTS.Film((CTS.Film)filmPanel.films.SelectedItem);
                    film_SForm.film = new CTS.Film((CTS.Film)filmPanel.films.SelectedItem);
                    film_SForm.FilmForm.DataContext = film_SForm.film;
                    film_SForm.ShowDialog();
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
            //        CTS.Worker film1 = (CTS.Worker)workerPanel.workers.SelectedItem;
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
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (filmPanel.films.IsVisible)
            {

            }
        }
    }
}
