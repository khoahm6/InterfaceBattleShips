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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Private_Public formPhong = new Private_Public();
            formPhong.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NamingForm nameForm = new NamingForm();
            nameForm.Show();
            this.Close();
        }
    }
}
