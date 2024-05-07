namespace CajeroATM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enter = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNip = new System.Windows.Forms.TextBox();
            this.tbCta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.borrar = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrar);
            this.groupBox1.Controls.Add(this.button_9);
            this.groupBox1.Controls.Add(this.enter);
            this.groupBox1.Controls.Add(this.button_0);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.button_7);
            this.groupBox1.Controls.Add(this.button_5);
            this.groupBox1.Controls.Add(this.button_1);
            this.groupBox1.Controls.Add(this.button_2);
            this.groupBox1.Controls.Add(this.button_8);
            this.groupBox1.Controls.Add(this.button_3);
            this.groupBox1.Controls.Add(this.button_6);
            this.groupBox1.Controls.Add(this.button_4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(248, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Lime;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.enter.Location = new System.Drawing.Point(226, 209);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(155, 57);
            this.enter.TabIndex = 12;
            this.enter.Text = "ACEPTAR";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Yellow;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.clear.Location = new System.Drawing.Point(226, 83);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(155, 57);
            this.clear.TabIndex = 11;
            this.clear.Text = "LIMPIAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button12_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cancel.Location = new System.Drawing.Point(226, 144);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(155, 57);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "CANCELAR";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(26, 208);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(183, 57);
            this.button_0.TabIndex = 9;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(27, 144);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(57, 57);
            this.button_7.TabIndex = 8;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(90, 144);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(57, 57);
            this.button_8.TabIndex = 7;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(153, 145);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(57, 57);
            this.button_9.TabIndex = 6;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(153, 82);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(57, 57);
            this.button_6.TabIndex = 5;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(90, 20);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(57, 57);
            this.button_2.TabIndex = 4;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(153, 20);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(57, 57);
            this.button_3.TabIndex = 3;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(27, 82);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(57, 57);
            this.button_4.TabIndex = 2;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(90, 82);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(57, 57);
            this.button_5.TabIndex = 1;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(27, 20);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(57, 57);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(463, 747);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(22, 747);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 67);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.date2);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.tbNip);
            this.groupBox2.Controls.Add(this.tbCta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(47, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 447);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbNip
            // 
            this.tbNip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.tbNip.Location = new System.Drawing.Point(470, 390);
            this.tbNip.Multiline = true;
            this.tbNip.Name = "tbNip";
            this.tbNip.PasswordChar = '*';
            this.tbNip.Size = new System.Drawing.Size(294, 37);
            this.tbNip.TabIndex = 3;
            this.tbNip.TextChanged += new System.EventHandler(this.tbNip_TextChanged);
            // 
            // tbCta
            // 
            this.tbCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.tbCta.Location = new System.Drawing.Point(470, 331);
            this.tbCta.Name = "tbCta";
            this.tbCta.Size = new System.Drawing.Size(294, 37);
            this.tbCta.TabIndex = 2;
            this.tbCta.TextChanged += new System.EventHandler(this.tbCta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label2.Location = new System.Drawing.Point(234, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el NIP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(63, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de cuenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.SlateGray;
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(226, 20);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(155, 57);
            this.borrar.TabIndex = 13;
            this.borrar.Text = "BORRAR";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Date.Location = new System.Drawing.Point(368, 16);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(64, 25);
            this.Date.TabIndex = 14;
            this.Date.Text = "label3";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.date2.Location = new System.Drawing.Point(369, 52);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(50, 20);
            this.date2.TabIndex = 15;
            this.date2.Text = "date2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(914, 826);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNip;
        private System.Windows.Forms.TextBox tbCta;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date2;
    }
}

