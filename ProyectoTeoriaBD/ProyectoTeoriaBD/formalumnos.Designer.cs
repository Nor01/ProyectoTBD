namespace ProyectoTeoriaBD
{
    partial class formalumnos
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
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nocuentaalumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrealumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraalumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.nocuentaalumno,
            this.nombrealumno,
            this.carreraalumno,
            this.totalpagar});
            this.gridAlumnos.Location = new System.Drawing.Point(-2, 61);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.Size = new System.Drawing.Size(547, 186);
            this.gridAlumnos.TabIndex = 0;
            // 
            // id_alumno
            // 
            this.id_alumno.DataPropertyName = "id_alumno";
            this.id_alumno.HeaderText = "id_alumno";
            this.id_alumno.Name = "id_alumno";
            // 
            // nocuentaalumno
            // 
            this.nocuentaalumno.DataPropertyName = "nocuentaalumno";
            this.nocuentaalumno.HeaderText = "nocuentaalumno";
            this.nocuentaalumno.Name = "nocuentaalumno";
            // 
            // nombrealumno
            // 
            this.nombrealumno.DataPropertyName = "nombrealumno";
            this.nombrealumno.HeaderText = "nombrealumno";
            this.nombrealumno.Name = "nombrealumno";
            // 
            // carreraalumno
            // 
            this.carreraalumno.DataPropertyName = "carreraalumno";
            this.carreraalumno.HeaderText = "carreraalumno";
            this.carreraalumno.Name = "carreraalumno";
            // 
            // totalpagar
            // 
            this.totalpagar.DataPropertyName = "totalpagar";
            this.totalpagar.HeaderText = "totalpagar";
            this.totalpagar.Name = "totalpagar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar Alumnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formalumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridAlumnos);
            this.Name = "formalumnos";
            this.Text = "Form Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nocuentaalumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrealumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraalumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpagar;
    }
}

