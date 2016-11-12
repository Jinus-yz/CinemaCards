using CinemaCards.Resources.Controls;
using System.Windows.Forms;

namespace CinemaCards
{
    public partial class MainForm : Form
    {
        string state;

        public MainForm()
        {
            InitializeComponent();
            setState("");
        }

        void setState(string newState)
        {
            state = newState;
            Controls.Clear();
            switch (newState)
            {
                case "add":
                    break;
                case "roll":
                    break;
                default:
                    var choice = new Choice();
                    choice.Dock = DockStyle.Fill;
                    Controls.Add(choice);
                    choice.Controls["btnAdd"].Click += choiceAdd_click;
                    choice.Controls["btnRoll"].Click += choiceRoll_click;
                    break;
            }
        }

        void choiceAdd_click(object sender, System.EventArgs e)
        {
            setState("add");
        }

        void choiceRoll_click(object sender, System.EventArgs e)
        {
            setState("roll");
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
