﻿namespace BattleShips
{
    partial class FormPrivate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrivate));
            label1 = new Label();
            textBox1 = new TextBox();
            PBoxMe = new PictureBox();
            PBoxEnemy = new PictureBox();
            btnReady = new Button();
            btnBack = new Button();
            LbMe = new Label();
            LbEnemy = new Label();
            ((System.ComponentModel.ISupportInitialize)PBoxMe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBoxEnemy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 39);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 0;
            label1.Text = "ROom id:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(215, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(347, 22);
            textBox1.TabIndex = 1;
            // 
            // PBoxMe
            // 
            PBoxMe.BackgroundImage = (Image)resources.GetObject("PBoxMe.BackgroundImage");
            PBoxMe.BackgroundImageLayout = ImageLayout.Stretch;
            PBoxMe.InitialImage = (Image)resources.GetObject("PBoxMe.InitialImage");
            PBoxMe.Location = new Point(62, 224);
            PBoxMe.Name = "PBoxMe";
            PBoxMe.Size = new Size(207, 150);
            PBoxMe.TabIndex = 2;
            PBoxMe.TabStop = false;
            // 
            // PBoxEnemy
            // 
            PBoxEnemy.BackgroundImage = (Image)resources.GetObject("PBoxEnemy.BackgroundImage");
            PBoxEnemy.BackgroundImageLayout = ImageLayout.Stretch;
            PBoxEnemy.Location = new Point(513, 224);
            PBoxEnemy.Name = "PBoxEnemy";
            PBoxEnemy.Size = new Size(207, 150);
            PBoxEnemy.TabIndex = 3;
            PBoxEnemy.TabStop = false;
            // 
            // btnReady
            // 
            btnReady.BackColor = Color.Transparent;
            btnReady.FlatAppearance.BorderSize = 0;
            btnReady.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReady.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReady.FlatStyle = FlatStyle.Flat;
            btnReady.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReady.Location = new Point(333, 379);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(122, 38);
            btnReady.TabIndex = 4;
            btnReady.Text = "Ready";
            btnReady.UseVisualStyleBackColor = false;
            btnReady.Click += btnReady_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(0, -2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 38);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // LbMe
            // 
            LbMe.AutoSize = true;
            LbMe.BackColor = Color.Transparent;
            LbMe.FlatStyle = FlatStyle.Flat;
            LbMe.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbMe.Location = new Point(62, 179);
            LbMe.Name = "LbMe";
            LbMe.Size = new Size(74, 22);
            LbMe.TabIndex = 6;
            LbMe.Text = "Name:";
            // 
            // LbEnemy
            // 
            LbEnemy.AutoSize = true;
            LbEnemy.BackColor = Color.Transparent;
            LbEnemy.FlatStyle = FlatStyle.Flat;
            LbEnemy.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbEnemy.Location = new Point(513, 179);
            LbEnemy.Name = "LbEnemy";
            LbEnemy.Size = new Size(74, 22);
            LbEnemy.TabIndex = 7;
            LbEnemy.Text = "Name:";
            // 
            // FormPrivate
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
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Name = "FormPrivate";
            ((System.ComponentModel.ISupportInitialize)PBoxMe).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxEnemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox PBoxMe;
        private PictureBox PBoxEnemy;
        private Button btnReady;
        private Button btnBack;
        private Label LbMe;
        private Label LbEnemy;
    }
}