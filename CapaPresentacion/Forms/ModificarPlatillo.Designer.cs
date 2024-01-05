namespace CapaPresentacion.Forms
{
    partial class ModificarPlatillo
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
            label1 = new Label();
            cboxPlatillos = new ComboBox();
            tboxPlatillos = new TextBox();
            label2 = new Label();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el platillo:";
            // 
            // cboxPlatillos
            // 
            cboxPlatillos.FormattingEnabled = true;
            cboxPlatillos.Location = new Point(12, 40);
            cboxPlatillos.Name = "cboxPlatillos";
            cboxPlatillos.Size = new Size(284, 23);
            cboxPlatillos.TabIndex = 1;
            // 
            // tboxPlatillos
            // 
            tboxPlatillos.Location = new Point(12, 97);
            tboxPlatillos.Name = "tboxPlatillos";
            tboxPlatillos.Size = new Size(161, 23);
            tboxPlatillos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 3;
            label2.Text = "¿Cuántos platillos?";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(12, 149);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(223, 62);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ModificarPlatillo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 223);
            Controls.Add(btnActualizar);
            Controls.Add(label2);
            Controls.Add(tboxPlatillos);
            Controls.Add(cboxPlatillos);
            Controls.Add(label1);
            Name = "ModificarPlatillo";
            Text = "ModificarPlatillo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboxPlatillos;
        private TextBox tboxPlatillos;
        private Label label2;
        private Button btnActualizar;
    }
}