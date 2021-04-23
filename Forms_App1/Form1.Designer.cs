
namespace Forms_App1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Curso1 = new System.Windows.Forms.ComboBox();
            this.Profesor1 = new System.Windows.Forms.TextBox();
            this.Alumnos1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Alumnos1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Curso";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Curso1
            // 
            this.Curso1.FormattingEnabled = true;
            this.Curso1.Location = new System.Drawing.Point(108, 126);
            this.Curso1.Name = "Curso1";
            this.Curso1.Size = new System.Drawing.Size(121, 24);
            this.Curso1.TabIndex = 4;
            this.Curso1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Profesor1
            // 
            this.Profesor1.Location = new System.Drawing.Point(108, 222);
            this.Profesor1.Name = "Profesor1";
            this.Profesor1.Size = new System.Drawing.Size(121, 22);
            this.Profesor1.TabIndex = 5;
            // 
            // Alumnos1
            // 
            this.Alumnos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alumnos1.Location = new System.Drawing.Point(362, 144);
            this.Alumnos1.Name = "Alumnos1";
            this.Alumnos1.RowHeadersWidth = 51;
            this.Alumnos1.RowTemplate.Height = 24;
            this.Alumnos1.Size = new System.Drawing.Size(389, 61);
            this.Alumnos1.TabIndex = 6;
            this.Alumnos1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Alumnos1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.Alumnos1);
            this.Controls.Add(this.Profesor1);
            this.Controls.Add(this.Curso1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Alumnos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Curso1;
        private System.Windows.Forms.TextBox Profesor1;
        private System.Windows.Forms.DataGridView Alumnos1;
    }
}

