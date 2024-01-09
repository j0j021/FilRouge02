namespace FilRouge
{
    partial class Utilsateur
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
            components = new System.ComponentModel.Container();
            BSUser = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvUser = new DataGridView();
            NomMateriel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btRetour = new Button();
            btAssigner = new Button();
            proprietaire = new Label();
            ((System.ComponentModel.ISupportInitialize)BSUser).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // BSUser
            // 
            BSUser.CurrentChanged += BSUser_CurrentChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 451);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.78796F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2120457F));
            tableLayoutPanel1.Controls.Add(dgvUser, 0, 1);
            tableLayoutPanel1.Controls.Add(NomMateriel, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(proprietaire, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.673317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.32668F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(797, 447);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.Location = new Point(3, 127);
            dgvUser.Margin = new Padding(3, 4, 3, 4);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(606, 270);
            dgvUser.TabIndex = 0;
            // 
            // NomMateriel
            // 
            NomMateriel.AutoSize = true;
            NomMateriel.Dock = DockStyle.Fill;
            NomMateriel.Location = new Point(3, 0);
            NomMateriel.Name = "NomMateriel";
            NomMateriel.Size = new Size(606, 123);
            NomMateriel.TabIndex = 1;
            NomMateriel.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btRetour);
            flowLayoutPanel2.Controls.Add(btAssigner);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 405);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(606, 38);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btRetour
            // 
            btRetour.Location = new Point(3, 4);
            btRetour.Margin = new Padding(3, 4, 3, 4);
            btRetour.Name = "btRetour";
            btRetour.Size = new Size(86, 31);
            btRetour.TabIndex = 0;
            btRetour.Text = "Retour";
            btRetour.UseVisualStyleBackColor = true;
            btRetour.Click += btRetour_Click_1;
            // 
            // btAssigner
            // 
            btAssigner.Location = new Point(95, 4);
            btAssigner.Margin = new Padding(3, 4, 3, 4);
            btAssigner.Name = "btAssigner";
            btAssigner.Size = new Size(86, 31);
            btAssigner.TabIndex = 1;
            btAssigner.Text = "Assigner";
            btAssigner.UseVisualStyleBackColor = true;
            btAssigner.Click += btAssigner_Click;
            // 
            // proprietaire
            // 
            proprietaire.AutoSize = true;
            proprietaire.Location = new Point(615, 0);
            proprietaire.Name = "proprietaire";
            proprietaire.Size = new Size(0, 20);
            proprietaire.TabIndex = 3;
            // 
            // Utilsateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(flowLayoutPanel1);
            Name = "Utilsateur";
            Text = "Utilsateur";
            Load += Utilsateur_Load;
            ((System.ComponentModel.ISupportInitialize)BSUser).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource BSUser;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvUser;
        private Label NomMateriel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btRetour;
        private Button btAssigner;
        private Label proprietaire;
    }
}