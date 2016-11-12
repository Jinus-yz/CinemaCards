using System.Windows.Forms;

namespace CinemaCards
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var choice = new Resources.Controls.Choice();
            this.Controls.Add(choice);
        }
    }
}
