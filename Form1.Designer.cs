namespace Examen1_997024_61421508
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lstRecursos = new System.Windows.Forms.ListView();
            this.lstProcesosTerminados = new System.Windows.Forms.ListView();
            this.btnProcesador = new System.Windows.Forms.Button();
            this.btnRecurso = new System.Windows.Forms.Button();
            this.btnProceso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstProcesos = new System.Windows.Forms.ListView();
            this.lstProcesadores = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.NoRec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoRec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdRec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstRecursos
            // 
            this.lstRecursos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdRec});
            this.lstRecursos.Location = new System.Drawing.Point(610, 47);
            this.lstRecursos.Name = "lstRecursos";
            this.lstRecursos.Size = new System.Drawing.Size(187, 185);
            this.lstRecursos.TabIndex = 3;
            this.lstRecursos.UseCompatibleStateImageBehavior = false;
            // 
            // lstProcesosTerminados
            // 
            this.lstProcesosTerminados.Location = new System.Drawing.Point(215, 456);
            this.lstProcesosTerminados.Name = "lstProcesosTerminados";
            this.lstProcesosTerminados.Size = new System.Drawing.Size(605, 150);
            this.lstProcesosTerminados.TabIndex = 4;
            this.lstProcesosTerminados.UseCompatibleStateImageBehavior = false;
            // 
            // btnProcesador
            // 
            this.btnProcesador.Location = new System.Drawing.Point(29, 50);
            this.btnProcesador.Name = "btnProcesador";
            this.btnProcesador.Size = new System.Drawing.Size(128, 40);
            this.btnProcesador.TabIndex = 5;
            this.btnProcesador.Text = "Procesador";
            this.btnProcesador.UseVisualStyleBackColor = true;
            this.btnProcesador.Click += new System.EventHandler(this.btnProcesador_Click);
            // 
            // btnRecurso
            // 
            this.btnRecurso.Location = new System.Drawing.Point(29, 111);
            this.btnRecurso.Name = "btnRecurso";
            this.btnRecurso.Size = new System.Drawing.Size(128, 40);
            this.btnRecurso.TabIndex = 6;
            this.btnRecurso.Text = "Recurso";
            this.btnRecurso.UseVisualStyleBackColor = true;
            this.btnRecurso.Click += new System.EventHandler(this.btnRecurso_Click);
            // 
            // btnProceso
            // 
            this.btnProceso.Location = new System.Drawing.Point(29, 173);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Size = new System.Drawing.Size(128, 40);
            this.btnProceso.TabIndex = 7;
            this.btnProceso.Text = "Proceso";
            this.btnProceso.UseVisualStyleBackColor = true;
            this.btnProceso.Click += new System.EventHandler(this.btnProceso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "CALENDARIZADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "LISTA DE RECURSOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "PROCESADORES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "LISTA DE PROCESOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "LISTA DE PROCESOS TERMINADOS";
            // 
            // lstProcesos
            // 
            this.lstProcesos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoRec,
            this.Prioridad,
            this.EstadoRec});
            this.lstProcesos.LabelEdit = true;
            this.lstProcesos.Location = new System.Drawing.Point(610, 265);
            this.lstProcesos.Name = "lstProcesos";
            this.lstProcesos.Size = new System.Drawing.Size(187, 150);
            this.lstProcesos.TabIndex = 13;
            this.lstProcesos.UseCompatibleStateImageBehavior = false;
            this.lstProcesos.View = System.Windows.Forms.View.Details;
            this.lstProcesos.SelectedIndexChanged += new System.EventHandler(this.lstRecursos_SelectedIndexChanged);
            // 
            // lstProcesadores
            // 
            this.lstProcesadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Estado,
            this.Hio});
            this.lstProcesadores.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstProcesadores.Location = new System.Drawing.Point(238, 265);
            this.lstProcesadores.Name = "lstProcesadores";
            this.lstProcesadores.Size = new System.Drawing.Size(186, 150);
            this.lstProcesadores.TabIndex = 14;
            this.lstProcesadores.UseCompatibleStateImageBehavior = false;
            this.lstProcesadores.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            // 
            // Hio
            // 
            this.Hio.Text = "Hilo";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(238, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(186, 182);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // NoRec
            // 
            this.NoRec.Text = "NoRec";
            // 
            // Prioridad
            // 
            this.Prioridad.Text = "Prioridad";
            // 
            // EstadoRec
            // 
            this.EstadoRec.Text = "Estado";
            // 
            // IdRec
            // 
            this.IdRec.Text = "IdRec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 557);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lstProcesadores);
            this.Controls.Add(this.lstProcesos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProceso);
            this.Controls.Add(this.btnRecurso);
            this.Controls.Add(this.btnProcesador);
            this.Controls.Add(this.lstProcesosTerminados);
            this.Controls.Add(this.lstRecursos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstRecursos;
        private System.Windows.Forms.ListView lstProcesosTerminados;
        private System.Windows.Forms.Button btnProcesador;
        private System.Windows.Forms.Button btnRecurso;
        private System.Windows.Forms.Button btnProceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstProcesos;
        private System.Windows.Forms.ListView lstProcesadores;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader Hio;
        private System.Windows.Forms.ColumnHeader NoRec;
        private System.Windows.Forms.ColumnHeader Prioridad;
        private System.Windows.Forms.ColumnHeader EstadoRec;
        private System.Windows.Forms.ColumnHeader IdRec;
    }
}

