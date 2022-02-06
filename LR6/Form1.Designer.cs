
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_ungroop = new System.Windows.Forms.Button();
            this.btn_groop = new System.Windows.Forms.Button();
            this.pbTriangle = new System.Windows.Forms.PictureBox();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.pbSquare = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_ungroop);
            this.panel1.Controls.Add(this.btn_groop);
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
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(926, 49);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(95, 23);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "Восстановить";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(926, 11);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_ungroop
            // 
            this.btn_ungroop.Location = new System.Drawing.Point(775, 49);
            this.btn_ungroop.Name = "btn_ungroop";
            this.btn_ungroop.Size = new System.Drawing.Size(107, 23);
            this.btn_ungroop.TabIndex = 13;
            this.btn_ungroop.Text = "Разгруппировать";
            this.btn_ungroop.UseVisualStyleBackColor = true;
            this.btn_ungroop.Click += new System.EventHandler(this.btn_ungroop_Click);
            // 
            // btn_groop
            // 
            this.btn_groop.Location = new System.Drawing.Point(775, 11);
            this.btn_groop.Name = "btn_groop";
            this.btn_groop.Size = new System.Drawing.Size(107, 23);
            this.btn_groop.TabIndex = 12;
            this.btn_groop.Text = "Сгруппировать";
            this.btn_groop.UseVisualStyleBackColor = true;
            this.btn_groop.Click += new System.EventHandler(this.btn_groop_Click);
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
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(77, 68);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(108, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Изменить цвет";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
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
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_ungroop;
        private System.Windows.Forms.Button btn_groop;
        private System.Windows.Forms.Button btnColor;
    }
}

