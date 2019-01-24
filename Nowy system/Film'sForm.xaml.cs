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
    /// Interaction logic for Film_sForm.xaml
    /// </summary>
    public partial class Film_sForm : Window
    {
        public CTS.Film film = new CTS.Film();
        public bool check=false;
        Acceptchange acc = new Acceptchange();
        public Film_sForm()
        {         
            InitializeComponent();
            FilmForm.DataContext = film;

        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            acc.ShowDialog();
            if(acc.check)
            {
                check = true;
                this.Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
