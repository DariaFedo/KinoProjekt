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
using CTS = Cinema.Ticket.System;

namespace Nowy_system.ListsControls
{
    /// <summary>
    /// Interaction logic for MainUserControl.xaml
    /// </summary>
    public partial class MainUserControl : UserControl
    {
        CTS.System Program;
        public MainUserControl(CTS.System program)
        {
            InitializeComponent();
            this.Program = program;
        }

        string buttonName = "";



        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            buttonName = b.Content.ToString();

            switch (buttonName)
            {
                case "workerBtn":
                    //wyświetlanie kontrolki 1 z całym ItemCollection i analogicznie dalej - jeszcze nie rozkminiłam jak to się robi.
                case "clientBtn":
                    
                case "filmBtn":

                case "roomBtn":

                case "showBtn":

                case "bookingBtn":

                case "ticketBtn":

                default:
                   break;
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            //KOLEKCJA_.Remove((OBIEKT_Z_KOLEKCJI_)CZEGOŚCollection.SelectedItem);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //UserControl Formularz = new UserControl(); --> tu będzie wywołanie formularza do uzupełniania danych ;_; jajebie ile roboty
            //Formularz.ShowDialog();
            //KOLEKCJA.Add(Formularz.newPerson);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //MUserControl Edit = new UserControl();
            //Edit.NAZWA_FORMULARZA_DO_WSTAWIANIA_DANYCH.DataContext = CZEGOŚCollection.SelectedItem;
            //Edit.ShowDialog();
        }
    }
}



