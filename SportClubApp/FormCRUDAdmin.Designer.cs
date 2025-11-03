namespace SportClubApp
{
    partial class FormCRUDAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            dgvAdministradores = new DataGridView();
            label3 = new Label();
            btnNuevoAdmin = new Button();
            btnEditarAdmin = new Button();
            btnEliminarAdmin = new Button();
            btnCerrar = new Button();
            colId = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(198, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(311, 26);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE ADMINISTRADORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(198, 96);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(277, 92);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(263, 26);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvAdministradores
            // 
            dgvAdministradores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdministradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdministradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministradores.Columns.AddRange(new DataGridViewColumn[] { colId, colEstado, colFecha, colUsername });
            dgvAdministradores.Location = new Point(67, 234);
            dgvAdministradores.Margin = new Padding(0);
            dgvAdministradores.MultiSelect = false;
            dgvAdministradores.Name = "dgvAdministradores";
            dgvAdministradores.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvAdministradores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvAdministradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdministradores.Size = new Size(686, 379);
            dgvAdministradores.TabIndex = 3;
            dgvAdministradores.CellDoubleClick += dgvAdministradores_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 198);
            label3.Name = "label3";
            label3.Size = new Size(231, 26);
            label3.TabIndex = 4;
            label3.Text = "Total: 0 administradores";
            // 
            // btnNuevoAdmin
            // 
            btnNuevoAdmin.Location = new Point(304, 144);
            btnNuevoAdmin.Margin = new Padding(3, 4, 3, 4);
            btnNuevoAdmin.Name = "btnNuevoAdmin";
            btnNuevoAdmin.Size = new Size(161, 29);
            btnNuevoAdmin.TabIndex = 5;
            btnNuevoAdmin.Text = "Nuevo Administrador";
            btnNuevoAdmin.UseVisualStyleBackColor = true;
            btnNuevoAdmin.Click += btnNuevoAdmin_Click;
            // 
            // btnEditarAdmin
            // 
            btnEditarAdmin.Location = new Point(198, 562);
            btnEditarAdmin.Margin = new Padding(3, 4, 3, 4);
            btnEditarAdmin.Name = "btnEditarAdmin";
            btnEditarAdmin.Size = new Size(86, 29);
            btnEditarAdmin.TabIndex = 6;
            btnEditarAdmin.Text = "Editar";
            btnEditarAdmin.UseVisualStyleBackColor = true;
            btnEditarAdmin.Click += btnEditarAdmin_Click;
            // 
            // btnEliminarAdmin
            // 
            btnEliminarAdmin.Location = new Point(329, 562);
            btnEliminarAdmin.Margin = new Padding(3, 4, 3, 4);
            btnEliminarAdmin.Name = "btnEliminarAdmin";
            btnEliminarAdmin.Size = new Size(86, 29);
            btnEliminarAdmin.TabIndex = 7;
            btnEliminarAdmin.Text = "Eliminar";
            btnEliminarAdmin.UseVisualStyleBackColor = true;
            btnEliminarAdmin.Click += btnEliminarAdmin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(455, 562);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(86, 29);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // colId
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colEstado
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colEstado.DefaultCellStyle = dataGridViewCellStyle3;
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 80;
            // 
            // colFecha
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colFecha.DefaultCellStyle = dataGridViewCellStyle4;
            colFecha.HeaderText = "Fecha Creación";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 150;
            // 
            // colUsername
            // 
            colUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colUsername.DefaultCellStyle = dataGridViewCellStyle5;
            colUsername.HeaderText = "Usuario";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 150;
            // 
            // FormCRUDAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 628);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminarAdmin);
            Controls.Add(btnEditarAdmin);
            Controls.Add(btnNuevoAdmin);
            Controls.Add(label3);
            Controls.Add(dgvAdministradores);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCRUDAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Administradores";
            ((System.ComponentModel.ISupportInitialize)dgvAdministradores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label2;
        private TextBox txtBuscar;
        private DataGridView dgvAdministradores;
        private Label label3;
        private Button btnNuevoAdmin;
        private Button btnEditarAdmin;
        private Button btnEliminarAdmin;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colUsername;
    }
}