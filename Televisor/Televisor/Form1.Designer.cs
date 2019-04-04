namespace Televisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bplay = new System.Windows.Forms.Button();
            this.bUpcanal = new System.Windows.Forms.Button();
            this.bDowncanal = new System.Windows.Forms.Button();
            this.bUpV = new System.Windows.Forms.Button();
            this.bDownV = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.canalBox = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(620, 351);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // bplay
            // 
            this.bplay.Location = new System.Drawing.Point(799, 25);
            this.bplay.Name = "bplay";
            this.bplay.Size = new System.Drawing.Size(70, 45);
            this.bplay.TabIndex = 1;
            this.bplay.Text = "Apagar";
            this.bplay.UseVisualStyleBackColor = true;
            this.bplay.Click += new System.EventHandler(this.bplay_Click);
            // 
            // bUpcanal
            // 
            this.bUpcanal.Location = new System.Drawing.Point(903, 89);
            this.bUpcanal.Name = "bUpcanal";
            this.bUpcanal.Size = new System.Drawing.Size(70, 45);
            this.bUpcanal.TabIndex = 2;
            this.bUpcanal.Text = "Arriba";
            this.bUpcanal.UseVisualStyleBackColor = true;
            this.bUpcanal.Click += new System.EventHandler(this.bUpcanal_Click);
            // 
            // bDowncanal
            // 
            this.bDowncanal.Location = new System.Drawing.Point(903, 152);
            this.bDowncanal.Name = "bDowncanal";
            this.bDowncanal.Size = new System.Drawing.Size(70, 45);
            this.bDowncanal.TabIndex = 3;
            this.bDowncanal.Text = "Abajo";
            this.bDowncanal.UseVisualStyleBackColor = true;
            this.bDowncanal.Click += new System.EventHandler(this.bDowncanal_Click);
            // 
            // bUpV
            // 
            this.bUpV.Location = new System.Drawing.Point(684, 89);
            this.bUpV.Name = "bUpV";
            this.bUpV.Size = new System.Drawing.Size(70, 45);
            this.bUpV.TabIndex = 4;
            this.bUpV.Text = "V+";
            this.bUpV.UseVisualStyleBackColor = true;
            this.bUpV.Click += new System.EventHandler(this.bUpV_Click);
            // 
            // bDownV
            // 
            this.bDownV.Location = new System.Drawing.Point(684, 152);
            this.bDownV.Name = "bDownV";
            this.bDownV.Size = new System.Drawing.Size(70, 45);
            this.bDownV.TabIndex = 5;
            this.bDownV.Text = "V--";
            this.bDownV.UseVisualStyleBackColor = true;
            this.bDownV.Click += new System.EventHandler(this.bDownV_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(783, 96);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 31);
            this.b1.TabIndex = 6;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(839, 96);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 31);
            this.b2.TabIndex = 7;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(783, 145);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 31);
            this.b3.TabIndex = 8;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(839, 145);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 31);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(783, 196);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 31);
            this.b5.TabIndex = 10;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(839, 196);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 31);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(724, 240);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 31);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(783, 240);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 31);
            this.b8.TabIndex = 13;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(839, 240);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 31);
            this.b9.TabIndex = 14;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(894, 240);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(40, 31);
            this.b0.TabIndex = 15;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // canalBox
            // 
            this.canalBox.Location = new System.Drawing.Point(829, 301);
            this.canalBox.Name = "canalBox";
            this.canalBox.ReadOnly = true;
            this.canalBox.Size = new System.Drawing.Size(58, 20);
            this.canalBox.TabIndex = 16;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(903, 288);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(70, 45);
            this.Buscar.TabIndex = 17;
            this.Buscar.Text = "Ir a Canal";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Canal Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.canalBox);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bDownV);
            this.Controls.Add(this.bUpV);
            this.Controls.Add(this.bDowncanal);
            this.Controls.Add(this.bUpcanal);
            this.Controls.Add(this.bplay);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button bplay;
        private System.Windows.Forms.Button bUpcanal;
        private System.Windows.Forms.Button bDowncanal;
        private System.Windows.Forms.Button bUpV;
        private System.Windows.Forms.Button bDownV;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.TextBox canalBox;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

