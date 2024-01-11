using Domain.Entities;

namespace FilRouge
{
    partial class affichage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvCategorie = new DataGridView();
            dgvMateriel = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtBoxCategorie = new TextBox();
            btModCat = new Button();
            btSupCat = new Button();
            btAjouterCat = new Button();
            btActualiser = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtBoxMateriel = new TextBox();
            btModifierMat = new Button();
            btSupMat = new Button();
            btAjouterMat = new Button();
            btQuitter = new Button();
            btAssigner = new Button();
            BSCategorie = new BindingSource(components);
            BSMateriel = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriel).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSCategorie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSMateriel).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvCategorie, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvMateriel, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.48921F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.51079F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tableLayoutPanel1.Size = new Size(984, 451);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvCategorie
            // 
            dgvCategorie.AllowUserToAddRows = false;
            dgvCategorie.AllowUserToDeleteRows = false;
            dgvCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorie.Dock = DockStyle.Fill;
            dgvCategorie.Location = new Point(3, 110);
            dgvCategorie.MultiSelect = false;
            dgvCategorie.Name = "dgvCategorie";
            dgvCategorie.RowHeadersWidth = 51;
            dgvCategorie.RowTemplate.Height = 29;
            dgvCategorie.Size = new Size(486, 165);
            dgvCategorie.TabIndex = 0;
            dgvCategorie.CurrentCellChanged += dgvCategorie_CurrentCellChangedAsync;
            // 
            // dgvMateriel
            // 
            dgvMateriel.AllowUserToAddRows = false;
            dgvMateriel.AllowUserToDeleteRows = false;
            dgvMateriel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriel.Dock = DockStyle.Fill;
            dgvMateriel.Location = new Point(495, 110);
            dgvMateriel.Name = "dgvMateriel";
            dgvMateriel.RowHeadersWidth = 51;
            dgvMateriel.RowTemplate.Height = 29;
            dgvMateriel.Size = new Size(486, 165);
            dgvMateriel.TabIndex = 1;
            dgvMateriel.CellClick += dgvMateriel_CellClickAsync;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(486, 101);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Catégories";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(495, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(486, 101);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Matériel";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtBoxCategorie, 1, 0);
            tableLayoutPanel2.Controls.Add(btModCat, 0, 0);
            tableLayoutPanel2.Controls.Add(btSupCat, 0, 1);
            tableLayoutPanel2.Controls.Add(btAjouterCat, 0, 2);
            tableLayoutPanel2.Controls.Add(btActualiser, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 281);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.Size = new Size(486, 167);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // txtBoxCategorie
            // 
            txtBoxCategorie.Dock = DockStyle.Fill;
            txtBoxCategorie.Location = new Point(246, 3);
            txtBoxCategorie.Name = "txtBoxCategorie";
            txtBoxCategorie.Size = new Size(237, 27);
            txtBoxCategorie.TabIndex = 0;
            // 
            // btModCat
            // 
            btModCat.Dock = DockStyle.Fill;
            btModCat.Location = new Point(3, 3);
            btModCat.Name = "btModCat";
            btModCat.Size = new Size(237, 45);
            btModCat.TabIndex = 1;
            btModCat.Text = "Modifier nom";
            btModCat.UseVisualStyleBackColor = true;
            btModCat.Click += btModCat_Click;
            // 
            // btSupCat
            // 
            btSupCat.Dock = DockStyle.Fill;
            btSupCat.Location = new Point(3, 54);
            btSupCat.Name = "btSupCat";
            btSupCat.Size = new Size(237, 45);
            btSupCat.TabIndex = 2;
            btSupCat.Text = "Supprimer catégorie";
            btSupCat.UseVisualStyleBackColor = true;
            btSupCat.Click += btSupCat_Click;
            // 
            // btAjouterCat
            // 
            btAjouterCat.Dock = DockStyle.Fill;
            btAjouterCat.Location = new Point(3, 106);
            btAjouterCat.Margin = new Padding(3, 4, 3, 4);
            btAjouterCat.Name = "btAjouterCat";
            btAjouterCat.Size = new Size(237, 57);
            btAjouterCat.TabIndex = 3;
            btAjouterCat.Text = "Ajouter catégorie";
            btAjouterCat.UseVisualStyleBackColor = true;
            btAjouterCat.Click += btAjouterCat_Click;
            // 
            // btActualiser
            // 
            btActualiser.Dock = DockStyle.Fill;
            btActualiser.Location = new Point(246, 105);
            btActualiser.Name = "btActualiser";
            btActualiser.Size = new Size(237, 59);
            btActualiser.TabIndex = 4;
            btActualiser.Text = "Actualiser";
            btActualiser.UseVisualStyleBackColor = true;
            btActualiser.Click += btActualiser_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txtBoxMateriel, 1, 0);
            tableLayoutPanel3.Controls.Add(btModifierMat, 0, 0);
            tableLayoutPanel3.Controls.Add(btSupMat, 0, 1);
            tableLayoutPanel3.Controls.Add(btAjouterMat, 0, 2);
            tableLayoutPanel3.Controls.Add(btQuitter, 1, 2);
            tableLayoutPanel3.Controls.Add(btAssigner, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(495, 281);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel3.Size = new Size(486, 167);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // txtBoxMateriel
            // 
            txtBoxMateriel.Dock = DockStyle.Fill;
            txtBoxMateriel.Location = new Point(246, 3);
            txtBoxMateriel.Name = "txtBoxMateriel";
            txtBoxMateriel.Size = new Size(237, 27);
            txtBoxMateriel.TabIndex = 0;
            // 
            // btModifierMat
            // 
            btModifierMat.Dock = DockStyle.Fill;
            btModifierMat.Location = new Point(3, 4);
            btModifierMat.Margin = new Padding(3, 4, 3, 4);
            btModifierMat.Name = "btModifierMat";
            btModifierMat.Size = new Size(237, 46);
            btModifierMat.TabIndex = 1;
            btModifierMat.Text = "Modifier nom";
            btModifierMat.UseVisualStyleBackColor = true;
            btModifierMat.Click += btModifierMat_Click;
            // 
            // btSupMat
            // 
            btSupMat.Dock = DockStyle.Fill;
            btSupMat.Location = new Point(3, 58);
            btSupMat.Margin = new Padding(3, 4, 3, 4);
            btSupMat.Name = "btSupMat";
            btSupMat.Size = new Size(237, 46);
            btSupMat.TabIndex = 2;
            btSupMat.Text = "Supprimer matériel";
            btSupMat.UseVisualStyleBackColor = true;
            btSupMat.Click += btSupMat_Click;
            // 
            // btAjouterMat
            // 
            btAjouterMat.Dock = DockStyle.Fill;
            btAjouterMat.Location = new Point(3, 112);
            btAjouterMat.Margin = new Padding(3, 4, 3, 4);
            btAjouterMat.Name = "btAjouterMat";
            btAjouterMat.Size = new Size(237, 51);
            btAjouterMat.TabIndex = 3;
            btAjouterMat.Text = "Ajouter matériel";
            btAjouterMat.UseVisualStyleBackColor = true;
            btAjouterMat.Click += btAjouterMat_Click;
            // 
            // btQuitter
            // 
            btQuitter.Dock = DockStyle.Fill;
            btQuitter.Location = new Point(246, 111);
            btQuitter.Name = "btQuitter";
            btQuitter.Size = new Size(237, 53);
            btQuitter.TabIndex = 4;
            btQuitter.Text = "Quitter";
            btQuitter.UseVisualStyleBackColor = true;
            btQuitter.Click += btQuitter_Click;
            // 
            // btAssigner
            // 
            btAssigner.Dock = DockStyle.Fill;
            btAssigner.Location = new Point(246, 57);
            btAssigner.Name = "btAssigner";
            btAssigner.Size = new Size(237, 48);
            btAssigner.TabIndex = 5;
            btAssigner.Text = "Assigner Matériel";
            btAssigner.UseVisualStyleBackColor = true;
            btAssigner.Click += btAssigner_Click;
            // 
            // affichage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 451);
            Controls.Add(tableLayoutPanel1);
            Name = "affichage";
            Text = "Affichage";
            Load += affichage_LoadAsync;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriel).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BSCategorie).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSMateriel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvCategorie;
        private DataGridView dgvMateriel;
        private BindingSource BSCategorie;
        private BindingSource BSMateriel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtBoxCategorie;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btModCat;
        private Button btSupCat;
        private TextBox txtBoxMateriel;
        private Button btAjouterCat;
        private Button btModifierMat;
        private Button btSupMat;
        private Button btAjouterMat;
        private Button btActualiser;
        private Button btQuitter;
        private Button btAssigner;
    }
}