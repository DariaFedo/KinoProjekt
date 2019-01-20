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
    /// Interaction logic for WorkerControl.xaml
    /// </summary>
    public partial class BookingControl : UserControl
    {
        CTS.System Program;
        public BookingControl(CTS.System program)
        {
            InitializeComponent();
            this.Program = program;
            bookings.ItemsSource = program.BookingCollection;
        }
    }
}
