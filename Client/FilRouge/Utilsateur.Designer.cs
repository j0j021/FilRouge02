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
            label1 = new Label();
            dtpDebut = new DateTimePicker();
            label2 = new Label();
            dtpFin = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            proprietaire = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
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
            flowLayoutPanel1.Size = new Size(1020, 510);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.40088F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.59911871F));
            tableLayoutPanel1.Controls.Add(dgvUser, 0, 1);
            tableLayoutPanel1.Controls.Add(NomMateriel, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(proprietaire, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.673317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.32668F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(908, 470);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.Location = new Point(3, 134);
            dgvUser.Margin = new Padding(3, 4, 3, 4);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(833, 286);
            dgvUser.TabIndex = 0;
            // 
            // NomMateriel
            // 
            NomMateriel.AutoSize = true;
            NomMateriel.Dock = DockStyle.Fill;
            NomMateriel.Location = new Point(3, 0);
            NomMateriel.Name = "NomMateriel";
            NomMateriel.Size = new Size(833, 130);
            NomMateriel.TabIndex = 1;
            NomMateriel.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btRetour);
            flowLayoutPanel2.Controls.Add(btAssigner);
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(dtpDebut);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(dtpFin);
            flowLayoutPanel2.Controls.Add(dateTimePicker1);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 428);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(833, 38);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Debut :";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(250, 3);
            dtpDebut.MinDate = new DateTime(2024, 1, 10, 0, 0, 0, 0);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(250, 27);
            dtpDebut.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 4;
            label2.Text = "Fin :";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(547, 3);
            dtpFin.MinDate = new DateTime(2024, 1, 10, 0, 0, 0, 0);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(250, 27);
            dtpFin.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // proprietaire
            // 
            proprietaire.AutoSize = true;
            proprietaire.Location = new Point(842, 0);
            proprietaire.Name = "proprietaire";
            proprietaire.Size = new Size(0, 20);
            proprietaire.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(842, 427);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(63, 40);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // Utilsateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 510);
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
            flowLayoutPanel2.PerformLayout();
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
        private Label label1;
        private DateTimePicker dtpDebut;
        private Label label2;
        private DateTimePicker dtpFin;
        private DateTimePicker dateTimePicker1;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}