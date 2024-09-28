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
    public partial class Private_Public : Form
    {
        public Private_Public()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomWaiting formPrivate = new RoomWaiting();
            formPrivate.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            RoomWaiting formPrivate = new RoomWaiting();
            formPrivate.Show();
            this.Hide();
        }
    }
}
