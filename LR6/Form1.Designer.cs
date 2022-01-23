
namespace LR6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbSquare = new System.Windows.Forms.PictureBox();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.pbTriangle = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbTriangle);
            this.panel1.Controls.Add(this.pbCircle);
            this.panel1.Controls.Add(this.pbSquare);
            this.panel1.Controls.Add(this.pbRed);
            this.panel1.Controls.Add(this.pbBlue);
            this.panel1.Controls.Add(this.pbBlack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 106);
            this.panel1.TabIndex = 0;
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbBlack.Location = new System.Drawing.Point(0, 0);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(83, 62);
            this.pbBlack.TabIndex = 0;
            this.pbBlack.TabStop = false;
            this.pbBlack.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pbBlue
            // 
            this.pbBlue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbBlue.Location = new System.Drawing.Point(89, -1);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(81, 63);
            this.pbBlue.TabIndex = 1;
            this.pbBlue.TabStop = false;
            this.pbBlue.Click += new System.EventHandler(this.pbBlue_Click);
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Red;
            this.pbRed.Location = new System.Drawing.Point(176, 0);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(79, 62);
            this.pbRed.TabIndex = 2;
            this.pbRed.TabStop = false;
            this.pbRed.Click += new System.EventHandler(this.pbRed_Click);
            // 
            // pbSquare
            // 
            this.pbSquare.Image = ((System.Drawing.Image)(resources.GetObject("pbSquare.Image")));
            this.pbSquare.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSquare.InitialImage")));
            this.pbSquare.Location = new System.Drawing.Point(305, 3);
            this.pbSquare.Name = "pbSquare";
            this.pbSquare.Size = new System.Drawing.Size(110, 79);
            this.pbSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSquare.TabIndex = 3;
            this.pbSquare.TabStop = false;
            this.pbSquare.Click += new System.EventHandler(this.pbSquare_Click);
            // 
            // pbCircle
            // 
            this.pbCircle.Image = ((System.Drawing.Image)(resources.GetObject("pbCircle.Image")));
            this.pbCircle.Location = new System.Drawing.Point(455, 3);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(110, 79);
            this.pbCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCircle.TabIndex = 4;
            this.pbCircle.TabStop = false;
            this.pbCircle.Click += new System.EventHandler(this.pbCircle_Click);
            // 
            // pbTriangle
            // 
            this.pbTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pbTriangle.Image")));
            this.pbTriangle.Location = new System.Drawing.Point(604, 3);
            this.pbTriangle.Name = "pbTriangle";
            this.pbTriangle.Size = new System.Drawing.Size(110, 79);
            this.pbTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTriangle.TabIndex = 5;
            this.pbTriangle.TabStop = false;
            this.pbTriangle.Click += new System.EventHandler(this.pbTriangle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(1, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1582, 521);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbTriangle;
        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.PictureBox pbSquare;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Panel panel2;
    }
}

