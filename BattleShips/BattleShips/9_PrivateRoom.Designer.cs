namespace BattleShips
{
    partial class PrivateRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateRoom));
            LbEnemy = new Label();
            LbMe = new Label();
            btnBack = new Button();
            btnReady = new Button();
            PBoxEnemy = new PictureBox();
            PBoxMe = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PBoxEnemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBoxMe).BeginInit();
            SuspendLayout();
            // 
            // LbEnemy
            // 
            LbEnemy.AutoSize = true;
            LbEnemy.BackColor = Color.Transparent;
            LbEnemy.FlatStyle = FlatStyle.Flat;
            LbEnemy.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbEnemy.Location = new Point(553, 197);
            LbEnemy.Name = "LbEnemy";
            LbEnemy.Size = new Size(74, 22);
            LbEnemy.TabIndex = 15;
            LbEnemy.Text = "Name:";
            // 
            // LbMe
            // 
            LbMe.AutoSize = true;
            LbMe.BackColor = Color.Transparent;
            LbMe.FlatStyle = FlatStyle.Flat;
            LbMe.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbMe.Location = new Point(102, 197);
            LbMe.Name = "LbMe";
            LbMe.Size = new Size(74, 22);
            LbMe.TabIndex = 14;
            LbMe.Text = "Name:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(40, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 38);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnReady
            // 
            btnReady.BackColor = Color.Transparent;
            btnReady.FlatAppearance.BorderSize = 0;
            btnReady.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReady.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReady.FlatStyle = FlatStyle.Flat;
            btnReady.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReady.Location = new Point(373, 397);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(122, 38);
            btnReady.TabIndex = 12;
            btnReady.Text = "Ready";
            btnReady.UseVisualStyleBackColor = false;
            btnReady.Click += btnReady_Click;
            // 
            // PBoxEnemy
            // 
            PBoxEnemy.BackgroundImage = (Image)resources.GetObject("PBoxEnemy.BackgroundImage");
            PBoxEnemy.BackgroundImageLayout = ImageLayout.Stretch;
            PBoxEnemy.Location = new Point(553, 242);
            PBoxEnemy.Name = "PBoxEnemy";
            PBoxEnemy.Size = new Size(207, 150);
            PBoxEnemy.TabIndex = 11;
            PBoxEnemy.TabStop = false;
            // 
            // PBoxMe
            // 
            PBoxMe.BackgroundImage = (Image)resources.GetObject("PBoxMe.BackgroundImage");
            PBoxMe.BackgroundImageLayout = ImageLayout.Stretch;
            PBoxMe.InitialImage = (Image)resources.GetObject("PBoxMe.InitialImage");
            PBoxMe.Location = new Point(102, 242);
            PBoxMe.Name = "PBoxMe";
            PBoxMe.Size = new Size(207, 150);
            PBoxMe.TabIndex = 10;
            PBoxMe.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(255, 57);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(347, 22);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 57);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 8;
            label1.Text = "ROom id:";
            // 
            // PrivateRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(LbEnemy);
            Controls.Add(LbMe);
            Controls.Add(btnBack);
            Controls.Add(btnReady);
            Controls.Add(PBoxEnemy);
            Controls.Add(PBoxMe);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PrivateRoom";
            Text = "PrivateRoom";
            ((System.ComponentModel.ISupportInitialize)PBoxEnemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxMe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbEnemy;
        private Label LbMe;
        private Button btnBack;
        private Button btnReady;
        private PictureBox PBoxEnemy;
        private PictureBox PBoxMe;
        private TextBox textBox1;
        private Label label1;
    }
}