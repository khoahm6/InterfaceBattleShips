namespace BattleShips
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameForm nameForm = new NameForm();
            nameForm.Show();
            this.Hide();
        }

        private void BtnLuat_Click(object sender, EventArgs e)
        {
            LuatForm luatForm = new LuatForm(); 
            luatForm.Show();
            this.Hide();
        }
        
    }
}
