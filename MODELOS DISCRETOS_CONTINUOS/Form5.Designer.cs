﻿
namespace MODELOS_DISCRETOS_CONTINUOS
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textnumMuestras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.errorNumero = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEcuacionRecta = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listRespuestas = new System.Windows.Forms.ListBox();
            this.labelERecta = new System.Windows.Forms.Label();
            this.btnZoom1 = new System.Windows.Forms.Button();
            this.btnZoom2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textnumMuestras1 = new System.Windows.Forms.TextBox();
            this.btnGenerar2 = new System.Windows.Forms.Button();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el numero de Muestras";
            // 
            // textnumMuestras
            // 
            this.textnumMuestras.Location = new System.Drawing.Point(12, 36);
            this.textnumMuestras.Name = "textnumMuestras";
            this.textnumMuestras.Size = new System.Drawing.Size(100, 20);
            this.textnumMuestras.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(230, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(136, 35);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // errorNumero
            // 
            this.errorNumero.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(656, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(262, 188);
            this.dataGridView2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ecuación de la Recta";
            // 
            // labelEcuacionRecta
            // 
            this.labelEcuacionRecta.AutoSize = true;
            this.labelEcuacionRecta.Location = new System.Drawing.Point(16, 228);
            this.labelEcuacionRecta.Name = "labelEcuacionRecta";
            this.labelEcuacionRecta.Size = new System.Drawing.Size(0, 13);
            this.labelEcuacionRecta.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(924, 36);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(229, 188);
            this.dataGridView3.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(12, 298);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(311, 269);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea7.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart2.Legends.Add(legend7);
            this.chart2.Location = new System.Drawing.Point(367, 261);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(354, 300);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // listRespuestas
            // 
            this.listRespuestas.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRespuestas.FormattingEnabled = true;
            this.listRespuestas.ItemHeight = 42;
            this.listRespuestas.Location = new System.Drawing.Point(737, 261);
            this.listRespuestas.Name = "listRespuestas";
            this.listRespuestas.Size = new System.Drawing.Size(416, 256);
            this.listRespuestas.TabIndex = 11;
            // 
            // labelERecta
            // 
            this.labelERecta.AutoSize = true;
            this.labelERecta.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelERecta.Location = new System.Drawing.Point(13, 252);
            this.labelERecta.Name = "labelERecta";
            this.labelERecta.Size = new System.Drawing.Size(85, 33);
            this.labelERecta.TabIndex = 12;
            this.labelERecta.Text = "label3";
            // 
            // btnZoom1
            // 
            this.btnZoom1.Location = new System.Drawing.Point(240, 537);
            this.btnZoom1.Name = "btnZoom1";
            this.btnZoom1.Size = new System.Drawing.Size(75, 23);
            this.btnZoom1.TabIndex = 13;
            this.btnZoom1.Text = "Zoom";
            this.btnZoom1.UseVisualStyleBackColor = true;
            this.btnZoom1.Click += new System.EventHandler(this.btnZoom1_Click);
            // 
            // btnZoom2
            // 
            this.btnZoom2.Location = new System.Drawing.Point(645, 536);
            this.btnZoom2.Name = "btnZoom2";
            this.btnZoom2.Size = new System.Drawing.Size(75, 23);
            this.btnZoom2.TabIndex = 14;
            this.btnZoom2.Text = "Zoom";
            this.btnZoom2.UseVisualStyleBackColor = true;
            this.btnZoom2.Click += new System.EventHandler(this.btnZoom2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Calcular valores en especifico para \"Y\"";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(337, 71);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(100, 149);
            this.dataGridView4.TabIndex = 16;
            // 
            // textnumMuestras1
            // 
            this.textnumMuestras1.Location = new System.Drawing.Point(337, 48);
            this.textnumMuestras1.Name = "textnumMuestras1";
            this.textnumMuestras1.Size = new System.Drawing.Size(100, 20);
            this.textnumMuestras1.TabIndex = 17;
            // 
            // btnGenerar2
            // 
            this.btnGenerar2.Location = new System.Drawing.Point(443, 46);
            this.btnGenerar2.Name = "btnGenerar2";
            this.btnGenerar2.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar2.TabIndex = 18;
            this.btnGenerar2.Text = "Generar";
            this.btnGenerar2.UseVisualStyleBackColor = true;
            this.btnGenerar2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(524, 45);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular2.TabIndex = 19;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(444, 76);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(206, 144);
            this.dataGridView5.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(734, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tabla Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(992, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tabla Final";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.btnGenerar2);
            this.Controls.Add(this.textnumMuestras1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnZoom2);
            this.Controls.Add(this.btnZoom1);
            this.Controls.Add(this.labelERecta);
            this.Controls.Add(this.listRespuestas);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.labelEcuacionRecta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textnumMuestras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnumMuestras;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ErrorProvider errorNumero;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelEcuacionRecta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ListBox listRespuestas;
        private System.Windows.Forms.Label labelERecta;
        private System.Windows.Forms.Button btnZoom2;
        private System.Windows.Forms.Button btnZoom1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerar2;
        private System.Windows.Forms.TextBox textnumMuestras1;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}