namespace TexturesToRGBchannels
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.red = new System.Windows.Forms.PictureBox();
            this.rLoad = new System.Windows.Forms.Button();
            this.rClear = new System.Windows.Forms.Button();
            this.gClear = new System.Windows.Forms.Button();
            this.gLoad = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.PictureBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.PictureBox();
            this.aClear = new System.Windows.Forms.Button();
            this.aLoad = new System.Windows.Forms.Button();
            this.alpha = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(28, 32);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(156, 165);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red.TabIndex = 0;
            this.red.TabStop = false;
            // 
            // rLoad
            // 
            this.rLoad.Location = new System.Drawing.Point(28, 204);
            this.rLoad.Name = "rLoad";
            this.rLoad.Size = new System.Drawing.Size(75, 23);
            this.rLoad.TabIndex = 1;
            this.rLoad.Text = "Load";
            this.rLoad.UseVisualStyleBackColor = true;
            this.rLoad.Click += new System.EventHandler(this.rLoad_Click);
            // 
            // rClear
            // 
            this.rClear.Location = new System.Drawing.Point(109, 204);
            this.rClear.Name = "rClear";
            this.rClear.Size = new System.Drawing.Size(75, 23);
            this.rClear.TabIndex = 2;
            this.rClear.Text = "Clear";
            this.rClear.UseVisualStyleBackColor = true;
            this.rClear.Click += new System.EventHandler(this.rClear_Click);
            // 
            // gClear
            // 
            this.gClear.Location = new System.Drawing.Point(293, 204);
            this.gClear.Name = "gClear";
            this.gClear.Size = new System.Drawing.Size(75, 23);
            this.gClear.TabIndex = 5;
            this.gClear.Text = "Clear";
            this.gClear.UseVisualStyleBackColor = true;
            this.gClear.Click += new System.EventHandler(this.gClear_Click);
            // 
            // gLoad
            // 
            this.gLoad.Location = new System.Drawing.Point(212, 204);
            this.gLoad.Name = "gLoad";
            this.gLoad.Size = new System.Drawing.Size(75, 23);
            this.gLoad.TabIndex = 4;
            this.gLoad.Text = "Load";
            this.gLoad.UseVisualStyleBackColor = true;
            this.gLoad.Click += new System.EventHandler(this.gLoad_Click);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(212, 32);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(156, 165);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.green.TabIndex = 3;
            this.green.TabStop = false;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(480, 204);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(399, 204);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 7;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(399, 32);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(156, 165);
            this.blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blue.TabIndex = 6;
            this.blue.TabStop = false;
            // 
            // aClear
            // 
            this.aClear.Location = new System.Drawing.Point(662, 204);
            this.aClear.Name = "aClear";
            this.aClear.Size = new System.Drawing.Size(75, 23);
            this.aClear.TabIndex = 11;
            this.aClear.Text = "Clear";
            this.aClear.UseVisualStyleBackColor = true;
            this.aClear.Click += new System.EventHandler(this.aClear_Click);
            // 
            // aLoad
            // 
            this.aLoad.Location = new System.Drawing.Point(581, 204);
            this.aLoad.Name = "aLoad";
            this.aLoad.Size = new System.Drawing.Size(75, 23);
            this.aLoad.TabIndex = 10;
            this.aLoad.Text = "Load";
            this.aLoad.UseVisualStyleBackColor = true;
            this.aLoad.Click += new System.EventHandler(this.aLoad_Click);
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(581, 32);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(156, 165);
            this.alpha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alpha.TabIndex = 9;
            this.alpha.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Red channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Green channel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Blue channel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Alpha channel";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(28, 272);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(82, 45);
            this.save.TabIndex = 16;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 369);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aClear);
            this.Controls.Add(this.aLoad);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.gClear);
            this.Controls.Add(this.gLoad);
            this.Controls.Add(this.green);
            this.Controls.Add(this.rClear);
            this.Controls.Add(this.rLoad);
            this.Controls.Add(this.red);
            this.Name = "Form1";
            this.Text = "Channel Packing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.Button rLoad;
        private System.Windows.Forms.Button rClear;
        private System.Windows.Forms.Button gClear;
        private System.Windows.Forms.Button gLoad;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.Button aClear;
        private System.Windows.Forms.Button aLoad;
        private System.Windows.Forms.PictureBox alpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
    }
}

