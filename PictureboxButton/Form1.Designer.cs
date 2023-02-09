namespace PictureboxButton
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
            this.components = new System.ComponentModel.Container();
            this.pictureofLondon1 = new System.Windows.Forms.PictureBox();
            this.pictureofBaku = new System.Windows.Forms.PictureBox();
            this.button_baku = new System.Windows.Forms.Button();
            this.button_london = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Baku_date_time = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureofLondon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureofBaku)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureofLondon1
            // 
            this.pictureofLondon1.Image = global::PictureboxButton.Properties.Resources._89;
            this.pictureofLondon1.Location = new System.Drawing.Point(0, 0);
            this.pictureofLondon1.Name = "pictureofLondon1";
            this.pictureofLondon1.Size = new System.Drawing.Size(1104, 593);
            this.pictureofLondon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureofLondon1.TabIndex = 0;
            this.pictureofLondon1.TabStop = false;
            // 
            // pictureofBaku
            // 
            this.pictureofBaku.Image = global::PictureboxButton.Properties.Resources.Baku_Flame_Towers_Skyline_02_1900;
            this.pictureofBaku.Location = new System.Drawing.Point(-11, -10);
            this.pictureofBaku.Name = "pictureofBaku";
            this.pictureofBaku.Size = new System.Drawing.Size(1071, 593);
            this.pictureofBaku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureofBaku.TabIndex = 1;
            this.pictureofBaku.TabStop = false;
            // 
            // button_baku
            // 
            this.button_baku.AutoSize = true;
            this.button_baku.BackColor = System.Drawing.Color.RosyBrown;
            this.button_baku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_baku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_baku.Location = new System.Drawing.Point(71, 495);
            this.button_baku.Name = "button_baku";
            this.button_baku.Size = new System.Drawing.Size(144, 34);
            this.button_baku.TabIndex = 2;
            this.button_baku.Text = "Click for Baku";
            this.button_baku.UseVisualStyleBackColor = false;
            this.button_baku.Click += new System.EventHandler(this.button_baku_Click);
            // 
            // button_london
            // 
            this.button_london.AutoSize = true;
            this.button_london.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_london.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_london.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_london.Location = new System.Drawing.Point(817, 495);
            this.button_london.Name = "button_london";
            this.button_london.Size = new System.Drawing.Size(165, 35);
            this.button_london.TabIndex = 3;
            this.button_london.Text = "Click for London";
            this.button_london.UseVisualStyleBackColor = false;
            this.button_london.Click += new System.EventHandler(this.button_london_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(817, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "London_date_time: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Baku_date_time
            // 
            this.Baku_date_time.AutoSize = true;
            this.Baku_date_time.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Baku_date_time.Location = new System.Drawing.Point(71, 465);
            this.Baku_date_time.Name = "Baku_date_time";
            this.Baku_date_time.Size = new System.Drawing.Size(126, 27);
            this.Baku_date_time.TabIndex = 5;
            this.Baku_date_time.Text = "Baku_date_time:";
            this.Baku_date_time.Click += new System.EventHandler(this.Baku_date_time_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 586);
            this.Controls.Add(this.Baku_date_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_london);
            this.Controls.Add(this.button_baku);
            this.Controls.Add(this.pictureofBaku);
            this.Controls.Add(this.pictureofLondon1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureofLondon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureofBaku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureofLondon1;
        private PictureBox pictureofBaku;
        private Button button_baku;
        private Button button_london;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label Baku_date_time;
        private System.Windows.Forms.Timer timer2;
    }
}