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
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập tên của bạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormTaoPhong formTaoPhong = new FormTaoPhong();
                formTaoPhong.Show();
                this.Hide();
            }
        }
    }
}
