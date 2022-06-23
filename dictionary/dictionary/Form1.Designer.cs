namespace dictionary
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
            this.components = new System.ComponentModel.Container();
            this.til = new System.Windows.Forms.Label();
            this.asosiy = new System.Windows.Forms.Label();
            this.uqilishi = new System.Windows.Forms.Label();
            this.tarjima = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.linklabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // til
            // 
            this.til.AutoSize = true;
            this.til.BackColor = System.Drawing.Color.LimeGreen;
            this.til.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.til.Cursor = System.Windows.Forms.Cursors.Hand;
            this.til.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.til.ForeColor = System.Drawing.Color.White;
            this.til.Location = new System.Drawing.Point(288, 23);
            this.til.Name = "til";
            this.til.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.til.Size = new System.Drawing.Size(127, 37);
            this.til.TabIndex = 0;
            this.til.Text = "English";
            this.til.Click += new System.EventHandler(this.til_Click);
            // 
            // asosiy
            // 
            this.asosiy.AutoSize = true;
            this.asosiy.BackColor = System.Drawing.Color.Gainsboro;
            this.asosiy.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asosiy.ForeColor = System.Drawing.Color.Black;
            this.asosiy.Location = new System.Drawing.Point(300, 101);
            this.asosiy.Name = "asosiy";
            this.asosiy.Padding = new System.Windows.Forms.Padding(3);
            this.asosiy.Size = new System.Drawing.Size(106, 37);
            this.asosiy.TabIndex = 0;
            this.asosiy.Text = "asosiy";
            this.asosiy.Resize += new System.EventHandler(this.asosiy_Resize);
            // 
            // uqilishi
            // 
            this.uqilishi.AutoSize = true;
            this.uqilishi.BackColor = System.Drawing.Color.LightGray;
            this.uqilishi.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uqilishi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uqilishi.Location = new System.Drawing.Point(295, 235);
            this.uqilishi.Margin = new System.Windows.Forms.Padding(3);
            this.uqilishi.Name = "uqilishi";
            this.uqilishi.Padding = new System.Windows.Forms.Padding(3);
            this.uqilishi.Size = new System.Drawing.Size(112, 35);
            this.uqilishi.TabIndex = 0;
            this.uqilishi.Text = "uqilishi";
            this.uqilishi.Resize += new System.EventHandler(this.asosiy_Resize);
            // 
            // tarjima
            // 
            this.tarjima.AutoSize = true;
            this.tarjima.BackColor = System.Drawing.Color.White;
            this.tarjima.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tarjima.ForeColor = System.Drawing.Color.Black;
            this.tarjima.Location = new System.Drawing.Point(290, 168);
            this.tarjima.Name = "tarjima";
            this.tarjima.Padding = new System.Windows.Forms.Padding(3);
            this.tarjima.Size = new System.Drawing.Size(123, 37);
            this.tarjima.TabIndex = 0;
            this.tarjima.Text = "tarjima";
            this.tarjima.Visible = false;
            this.tarjima.Resize += new System.EventHandler(this.asosiy_Resize);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // linklabel
            // 
            this.linklabel.AutoSize = true;
            this.linklabel.BackColor = System.Drawing.Color.LightGray;
            this.linklabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linklabel.ForeColor = System.Drawing.Color.Black;
            this.linklabel.Location = new System.Drawing.Point(19, 344);
            this.linklabel.Name = "linklabel";
            this.linklabel.Size = new System.Drawing.Size(87, 19);
            this.linklabel.TabIndex = 1;
            this.linklabel.Text = "Fayl tanlang";
            this.linklabel.Click += new System.EventHandler(this.linklabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "(1)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDown1.Location = new System.Drawing.Point(51, 324);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::dictionary.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 378);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklabel);
            this.Controls.Add(this.uqilishi);
            this.Controls.Add(this.tarjima);
            this.Controls.Add(this.asosiy);
            this.Controls.Add(this.til);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label til;
        private System.Windows.Forms.Label asosiy;
        private System.Windows.Forms.Label uqilishi;
        private System.Windows.Forms.Label tarjima;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label linklabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

