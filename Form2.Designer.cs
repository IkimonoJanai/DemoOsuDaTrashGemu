namespace DemoOsuDaTrashGemu
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.picSaberUwU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaberUwU)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(174, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 177);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nhấp vào để tìm hiểu về Danh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh that ra la 1 con co ho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picArrow
            // 
            this.picArrow.Image = global::DemoOsuDaTrashGemu.Properties.Resources.red_arrow;
            this.picArrow.Location = new System.Drawing.Point(101, 362);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(30, 25);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrow.TabIndex = 3;
            this.picArrow.TabStop = false;
            // 
            // picSaberUwU
            // 
            this.picSaberUwU.Image = global::DemoOsuDaTrashGemu.Properties.Resources._12188955_498880390293647_3589557645439156003_n;
            this.picSaberUwU.Location = new System.Drawing.Point(-2, 318);
            this.picSaberUwU.Name = "picSaberUwU";
            this.picSaberUwU.Size = new System.Drawing.Size(97, 110);
            this.picSaberUwU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaberUwU.TabIndex = 2;
            this.picSaberUwU.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 426);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.picSaberUwU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaberUwU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picSaberUwU;
        private System.Windows.Forms.PictureBox picArrow;
    }
}