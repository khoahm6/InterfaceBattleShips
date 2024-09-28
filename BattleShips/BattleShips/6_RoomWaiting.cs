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
    public partial class RoomWaiting : Form
    {
        public RoomWaiting()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Private_Public formCreateRoom = new Private_Public();
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
