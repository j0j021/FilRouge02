namespace FilRouge
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btValider = new Button();
            btQuitter = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(btValider, 1, 2);
            tableLayoutPanel1.Controls.Add(btQuitter, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
            tableLayoutPanel1.Size = new Size(800, 451);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Utilisateur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 171);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe :";
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(403, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(394, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(403, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(394, 27);
            txtPassword.TabIndex = 3;
            // 
            // btValider
            // 
            btValider.Dock = DockStyle.Fill;
            btValider.Location = new Point(403, 345);
            btValider.Name = "btValider";
            btValider.Size = new Size(394, 103);
            btValider.TabIndex = 4;
            btValider.Text = "Valider";
            btValider.UseVisualStyleBackColor = true;
            btValider.Click += btValider_Click_1;
            // 
            // btQuitter
            // 
            btQuitter.Dock = DockStyle.Fill;
            btQuitter.Location = new Point(3, 345);
            btQuitter.Name = "btQuitter";
            btQuitter.Size = new Size(394, 103);
            btQuitter.TabIndex = 5;
            btQuitter.Text = "Quitter";
            btQuitter.UseVisualStyleBackColor = true;
            btQuitter.Click += btQuitter_Click_1;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 451);
            Controls.Add(tableLayoutPanel1);
            Name = "Connexion";
            Text = "Connexion";
            Load += Connexion_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btValider;
        private Button btQuitter;
    }
}