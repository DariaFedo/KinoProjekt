using System.Windows;
using System;
using CTS = Cinema.Ticket.System;


namespace Nowy_system
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CTS.System program;
        ListsControls.UserPanel UP;
        Logowanie logowanie;
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Ladujlisty(CTS.System program)
        {
            CTS.Worker worker = new CTS.Worker("k.mroziewicz@gmail.com", "Krzysztof", "698523641", "Mroziewicz", "Manager", "admin", "admin");
            program.WorkerCollection.Add(worker);

            worker = new CTS.Worker("d.fedo@gmail.com", "Daria", "625523641", "Fedorowicz", "Bileter", "admin1", "admin1");
            program.WorkerCollection.Add(worker);

            CTS.Room pokoj1 = new CTS.Room('a', 2, 7);
            program.RoomCollection.Add(pokoj1);

            CTS.Client client = new CTS.Client("sz.chlond@gmail.com", "Szymon", "698563641", "Chlond");
            program.ClientCollection.Add(client);

            CTS.Client client1 = new CTS.Client("u.gumola@gmail.com", "Urszula", "698563641", "Gumola");
            program.ClientCollection.Add(client1);

            DateTime datepremiere = new DateTime(2015, 10, 6);
            CTS.Film film = new CTS.Film(18, "Clarke, Harington, Glen", "Benioff", "Fantasy", "English, Polish", 160, datepremiere, "2D", "Game of Thrones");
            program.FilmCollection.Add(film);

            datepremiere = new DateTime(2010, 11, 8);

            CTS.Film film1 = new CTS.Film(10, "Schwarzenegger, Depp", "Jolie", "Thriller", "English, Polish", 180, datepremiere, "2D", "Nie ma takiego filmu");
            program.FilmCollection.Add(film1);

            DateTime dateshow = new DateTime(2008, 3, 1, 7, 0, 0);

            CTS.Show show = new CTS.Show(dateshow, film, pokoj1);
            program.ShowsCollection.Add(show);

            CTS.Ticket ticket = new CTS.Ticket(25.50, "normalny");
            program.TicketCollection.Add(ticket);

            ticket = new CTS.Ticket(15.50, "ulgowy");
            program.TicketCollection.Add(ticket);

        }

        void Logowanie_Closed(object sender, EventArgs e)
        {
            if (logowanie.lpoint)
            {
                button.Visibility = Visibility.Collapsed;
                Stackpanel.Children.Add(UP = new ListsControls.UserPanel(program));
            }
        }
        public void button_Click(object sender, RoutedEventArgs e)
        {
            program = new CTS.System();
            logowanie = new Logowanie(program);
            Ladujlisty(program);            
            logowanie.Show();

           logowanie.Closed += new EventHandler(Logowanie_Closed);
        }



    }
}
