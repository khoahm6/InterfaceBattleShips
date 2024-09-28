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
    public partial class FormTaoPhong : Form
    {
        public FormTaoPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreateRoom formPhong = new FormCreateRoom();
            formPhong.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NameForm nameForm = new NameForm();
            nameForm.Show();
            this.Close();
        }
    }
}
