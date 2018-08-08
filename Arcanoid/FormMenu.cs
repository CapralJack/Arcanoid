using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_start_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.ShowDialog();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
