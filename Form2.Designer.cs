namespace MEMORY
{
    partial class Form2
    {
        Form1 okno;
        Form3 okno2;
        Form4 okno3;
        Form5 okno4;
        public int x;
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
            this.łatwy = new System.Windows.Forms.Button();
            this.średni = new System.Windows.Forms.Button();
            this.trudny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.koniec = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // łatwy
            // 
            this.łatwy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.łatwy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.łatwy.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.łatwy.ForeColor = System.Drawing.Color.Black;
            this.łatwy.Location = new System.Drawing.Point(150, 100);
            this.łatwy.Name = "łatwy";
            this.łatwy.Size = new System.Drawing.Size(300, 80);
            this.łatwy.TabIndex = 0;
            this.łatwy.Text = "łatwy";
            this.łatwy.UseVisualStyleBackColor = false;
            this.łatwy.Click += new System.EventHandler(this.łatwy_Click);
            // 
            // średni
            // 
            this.średni.BackColor = System.Drawing.Color.Lime;
            this.średni.Font = new System.Drawing.Font("Trebuchet MS", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.średni.ForeColor = System.Drawing.Color.Black;
            this.średni.Location = new System.Drawing.Point(150, 186);
            this.średni.Name = "średni";
            this.średni.Size = new System.Drawing.Size(300, 80);
            this.średni.TabIndex = 1;
            this.średni.Text = "średni";
            this.średni.UseVisualStyleBackColor = false;
            this.średni.Click += new System.EventHandler(this.średni_Click);
            // 
            // trudny
            // 
            this.trudny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trudny.Font = new System.Drawing.Font("Trebuchet MS", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trudny.ForeColor = System.Drawing.Color.Black;
            this.trudny.Location = new System.Drawing.Point(150, 272);
            this.trudny.Name = "trudny";
            this.trudny.Size = new System.Drawing.Size(300, 80);
            this.trudny.TabIndex = 2;
            this.trudny.Text = "trudny";
            this.trudny.UseVisualStyleBackColor = false;
            this.trudny.Click += new System.EventHandler(this.trudny_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(150, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz poziom:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // koniec
            // 
            this.koniec.Font = new System.Drawing.Font("Trebuchet MS", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koniec.ForeColor = System.Drawing.Color.Black;
            this.koniec.Location = new System.Drawing.Point(22, 469);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(150, 50);
            this.koniec.TabIndex = 5;
            this.koniec.Text = "Koniec";
            this.koniec.UseVisualStyleBackColor = true;
            this.koniec.Click += new System.EventHandler(this.koniec_Click);
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Trebuchet MS", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.ForeColor = System.Drawing.Color.Black;
            this.info.Location = new System.Drawing.Point(374, 469);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(150, 50);
            this.info.TabIndex = 6;
            this.info.Text = "Info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.info);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trudny);
            this.Controls.Add(this.średni);
            this.Controls.Add(this.łatwy);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Nowa gra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button łatwy;
        private System.Windows.Forms.Button średni;
        private System.Windows.Forms.Button trudny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button koniec;
        private System.Windows.Forms.Button info;
    }
}