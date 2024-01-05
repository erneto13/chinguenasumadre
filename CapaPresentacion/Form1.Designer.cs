namespace CapaPresentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAgregarDR = new Button();
            dgvDetalleRecetas = new DataGridView();
            dgvPlatillos = new DataGridView();
            btnModificarDR = new Button();
            btnEliminarDR = new Button();
            btnEliminarPL = new Button();
            btnModificarPL = new Button();
            btnAgregarPL = new Button();
            btnEliminarIG = new Button();
            btnModificarIG = new Button();
            btnAgregarIG = new Button();
            dgvIngredientes = new DataGridView();
            btnEliminarRC = new Button();
            btnModificarRC = new Button();
            btnAgregarRC = new Button();
            dgvRecetas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleRecetas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecetas).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarDR
            // 
            btnAgregarDR.Location = new Point(15, 12);
            btnAgregarDR.Name = "btnAgregarDR";
            btnAgregarDR.Size = new Size(115, 30);
            btnAgregarDR.TabIndex = 0;
            btnAgregarDR.Text = "Agregar";
            btnAgregarDR.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleRecetas
            // 
            dgvDetalleRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalleRecetas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetalleRecetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleRecetas.Location = new Point(136, 12);
            dgvDetalleRecetas.Name = "dgvDetalleRecetas";
            dgvDetalleRecetas.ReadOnly = true;
            dgvDetalleRecetas.Size = new Size(547, 147);
            dgvDetalleRecetas.TabIndex = 1;
            // 
            // dgvPlatillos
            // 
            dgvPlatillos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPlatillos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPlatillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlatillos.Location = new Point(136, 165);
            dgvPlatillos.Name = "dgvPlatillos";
            dgvPlatillos.ReadOnly = true;
            dgvPlatillos.Size = new Size(840, 147);
            dgvPlatillos.TabIndex = 2;
            // 
            // btnModificarDR
            // 
            btnModificarDR.Location = new Point(15, 48);
            btnModificarDR.Name = "btnModificarDR";
            btnModificarDR.Size = new Size(115, 30);
            btnModificarDR.TabIndex = 3;
            btnModificarDR.Text = "Modificar";
            btnModificarDR.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDR
            // 
            btnEliminarDR.Location = new Point(15, 84);
            btnEliminarDR.Name = "btnEliminarDR";
            btnEliminarDR.Size = new Size(115, 30);
            btnEliminarDR.TabIndex = 4;
            btnEliminarDR.Text = "Eliminar";
            btnEliminarDR.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPL
            // 
            btnEliminarPL.Location = new Point(15, 237);
            btnEliminarPL.Name = "btnEliminarPL";
            btnEliminarPL.Size = new Size(115, 30);
            btnEliminarPL.TabIndex = 7;
            btnEliminarPL.Text = "Eliminar";
            btnEliminarPL.UseVisualStyleBackColor = true;
            // 
            // btnModificarPL
            // 
            btnModificarPL.Location = new Point(15, 201);
            btnModificarPL.Name = "btnModificarPL";
            btnModificarPL.Size = new Size(115, 30);
            btnModificarPL.TabIndex = 6;
            btnModificarPL.Text = "Modificar";
            btnModificarPL.UseVisualStyleBackColor = true;
            btnModificarPL.Click += btnModificarPL_Click;
            // 
            // btnAgregarPL
            // 
            btnAgregarPL.Location = new Point(15, 165);
            btnAgregarPL.Name = "btnAgregarPL";
            btnAgregarPL.Size = new Size(115, 30);
            btnAgregarPL.TabIndex = 5;
            btnAgregarPL.Text = "Agregar";
            btnAgregarPL.UseVisualStyleBackColor = true;
            // 
            // btnEliminarIG
            // 
            btnEliminarIG.Location = new Point(15, 408);
            btnEliminarIG.Name = "btnEliminarIG";
            btnEliminarIG.Size = new Size(115, 30);
            btnEliminarIG.TabIndex = 11;
            btnEliminarIG.Text = "Eliminar";
            btnEliminarIG.UseVisualStyleBackColor = true;
            // 
            // btnModificarIG
            // 
            btnModificarIG.Location = new Point(15, 372);
            btnModificarIG.Name = "btnModificarIG";
            btnModificarIG.Size = new Size(115, 30);
            btnModificarIG.TabIndex = 10;
            btnModificarIG.Text = "Modificar";
            btnModificarIG.UseVisualStyleBackColor = true;
            // 
            // btnAgregarIG
            // 
            btnAgregarIG.Location = new Point(15, 336);
            btnAgregarIG.Name = "btnAgregarIG";
            btnAgregarIG.Size = new Size(115, 30);
            btnAgregarIG.TabIndex = 9;
            btnAgregarIG.Text = "Agregar";
            btnAgregarIG.UseVisualStyleBackColor = true;
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvIngredientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientes.Location = new Point(136, 336);
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.ReadOnly = true;
            dgvIngredientes.Size = new Size(710, 147);
            dgvIngredientes.TabIndex = 8;
            // 
            // btnEliminarRC
            // 
            btnEliminarRC.Location = new Point(15, 592);
            btnEliminarRC.Name = "btnEliminarRC";
            btnEliminarRC.Size = new Size(115, 30);
            btnEliminarRC.TabIndex = 15;
            btnEliminarRC.Text = "Eliminar";
            btnEliminarRC.UseVisualStyleBackColor = true;
            // 
            // btnModificarRC
            // 
            btnModificarRC.Location = new Point(15, 556);
            btnModificarRC.Name = "btnModificarRC";
            btnModificarRC.Size = new Size(115, 30);
            btnModificarRC.TabIndex = 14;
            btnModificarRC.Text = "Modificar";
            btnModificarRC.UseVisualStyleBackColor = true;
            // 
            // btnAgregarRC
            // 
            btnAgregarRC.Location = new Point(15, 520);
            btnAgregarRC.Name = "btnAgregarRC";
            btnAgregarRC.Size = new Size(115, 30);
            btnAgregarRC.TabIndex = 13;
            btnAgregarRC.Text = "Agregar";
            btnAgregarRC.UseVisualStyleBackColor = true;
            // 
            // dgvRecetas
            // 
            dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRecetas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRecetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecetas.Location = new Point(136, 520);
            dgvRecetas.Name = "dgvRecetas";
            dgvRecetas.ReadOnly = true;
            dgvRecetas.Size = new Size(710, 147);
            dgvRecetas.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 711);
            Controls.Add(btnEliminarRC);
            Controls.Add(btnModificarRC);
            Controls.Add(btnAgregarRC);
            Controls.Add(dgvRecetas);
            Controls.Add(btnEliminarIG);
            Controls.Add(btnModificarIG);
            Controls.Add(btnAgregarIG);
            Controls.Add(dgvIngredientes);
            Controls.Add(btnEliminarPL);
            Controls.Add(btnModificarPL);
            Controls.Add(btnAgregarPL);
            Controls.Add(btnEliminarDR);
            Controls.Add(btnModificarDR);
            Controls.Add(dgvPlatillos);
            Controls.Add(dgvDetalleRecetas);
            Controls.Add(btnAgregarDR);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniCRUD Productos";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleRecetas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecetas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarDR;
        private DataGridView dgvDetalleRecetas;
        private DataGridView dgvPlatillos;
        private Button btnModificarDR;
        private Button btnEliminarDR;
        private Button btnEliminarPL;
        private Button btnModificarPL;
        private Button btnAgregarPL;
        private Button btnEliminarIG;
        private Button btnModificarIG;
        private Button btnAgregarIG;
        private DataGridView dgvIngredientes;
        private Button btnEliminarRC;
        private Button btnModificarRC;
        private Button btnAgregarRC;
        private DataGridView dgvRecetas;
    }
}
