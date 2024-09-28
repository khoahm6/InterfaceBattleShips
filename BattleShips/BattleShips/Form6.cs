using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class FormPrivate : Form
    {
        public FormPrivate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormCreateRoom formCreateRoom = new FormCreateRoom();
            formCreateRoom.Show();
            this.Close();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            ShipDeployment shipDeployment = new ShipDeployment();   
            shipDeployment.Show();

            this.Hide();
        }
    }
}
