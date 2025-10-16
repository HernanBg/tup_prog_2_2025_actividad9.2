namespace Ejercicio1
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
            tbPatente = new TextBox();
            tbImporte = new TextBox();
            button1 = new Button();
            btnActualizar = new Button();
            btnImporte = new Button();
            button4 = new Button();
            lstVer = new ListBox();
            dtpVencimiento = new DateTimePicker();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(82, 39);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(222, 23);
            tbPatente.TabIndex = 0;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(82, 125);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(222, 23);
            tbImporte.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(375, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(375, 278);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnImporte
            // 
            btnImporte.Location = new Point(375, 346);
            btnImporte.Name = "btnImporte";
            btnImporte.Size = new Size(75, 23);
            btnImporte.TabIndex = 5;
            btnImporte.Text = "Importar";
            btnImporte.UseVisualStyleBackColor = true;
            btnImporte.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(375, 401);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Exportar";
            button4.UseVisualStyleBackColor = true;
            // 
            // lstVer
            // 
            lstVer.FormattingEnabled = true;
            lstVer.ItemHeight = 15;
            lstVer.Location = new Point(8, 230);
            lstVer.Name = "lstVer";
            lstVer.Size = new Size(313, 214);
            lstVer.TabIndex = 7;
            lstVer.SelectedIndexChanged += lstVer_SelectedIndexChanged;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(92, 78);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(200, 23);
            dtpVencimiento.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(dtpVencimiento);
            Controls.Add(lstVer);
            Controls.Add(button4);
            Controls.Add(btnImporte);
            Controls.Add(btnActualizar);
            Controls.Add(button1);
            Controls.Add(tbImporte);
            Controls.Add(tbPatente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPatente;
        private TextBox tbImporte;
        private Button button1;
        private Button btnActualizar;
        private Button btnImporte;
        private Button button4;
        private ListBox lstVer;
        private DateTimePicker dtpVencimiento;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
