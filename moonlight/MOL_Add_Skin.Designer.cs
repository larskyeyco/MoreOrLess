namespace moonlight
{
    partial class MOL_Add_Skin
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
            this.tb_MOL_Skin_Name = new System.Windows.Forms.TextBox();
            this.lbl_MOL_Skin_Name = new System.Windows.Forms.Label();
            this.cb_MOL_Champion_Name = new System.Windows.Forms.ComboBox();
            this.lbl_MOL_Champion_Name = new System.Windows.Forms.Label();
            this.btn_MOL_Add_Skin = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MOL_Skin_Name
            // 
            this.tb_MOL_Skin_Name.Location = new System.Drawing.Point(324, 36);
            this.tb_MOL_Skin_Name.Name = "tb_MOL_Skin_Name";
            this.tb_MOL_Skin_Name.Size = new System.Drawing.Size(133, 20);
            this.tb_MOL_Skin_Name.TabIndex = 0;
            this.tb_MOL_Skin_Name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_MOL_Skin_Name_Validating);
            // 
            // lbl_MOL_Skin_Name
            // 
            this.lbl_MOL_Skin_Name.AutoSize = true;
            this.lbl_MOL_Skin_Name.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MOL_Skin_Name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_MOL_Skin_Name.Location = new System.Drawing.Point(83, 78);
            this.lbl_MOL_Skin_Name.Name = "lbl_MOL_Skin_Name";
            this.lbl_MOL_Skin_Name.Size = new System.Drawing.Size(235, 62);
            this.lbl_MOL_Skin_Name.TabIndex = 1;
            this.lbl_MOL_Skin_Name.Text = "Champion Name";
            // 
            // cb_MOL_Champion_Name
            // 
            this.cb_MOL_Champion_Name.FormattingEnabled = true;
            this.cb_MOL_Champion_Name.Location = new System.Drawing.Point(324, 98);
            this.cb_MOL_Champion_Name.Name = "cb_MOL_Champion_Name";
            this.cb_MOL_Champion_Name.Size = new System.Drawing.Size(133, 21);
            this.cb_MOL_Champion_Name.TabIndex = 2;
            this.cb_MOL_Champion_Name.Validating += new System.ComponentModel.CancelEventHandler(this.cb_MOL_Champion_Name_Validating);
            // 
            // lbl_MOL_Champion_Name
            // 
            this.lbl_MOL_Champion_Name.AutoSize = true;
            this.lbl_MOL_Champion_Name.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MOL_Champion_Name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_MOL_Champion_Name.Location = new System.Drawing.Point(154, 16);
            this.lbl_MOL_Champion_Name.Name = "lbl_MOL_Champion_Name";
            this.lbl_MOL_Champion_Name.Size = new System.Drawing.Size(164, 62);
            this.lbl_MOL_Champion_Name.TabIndex = 3;
            this.lbl_MOL_Champion_Name.Text = "Skin Name";
            // 
            // btn_MOL_Add_Skin
            // 
            this.btn_MOL_Add_Skin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(29)))));
            this.btn_MOL_Add_Skin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MOL_Add_Skin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_MOL_Add_Skin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(194)))), ((int)(((byte)(232)))));
            this.btn_MOL_Add_Skin.Location = new System.Drawing.Point(333, 134);
            this.btn_MOL_Add_Skin.Name = "btn_MOL_Add_Skin";
            this.btn_MOL_Add_Skin.Size = new System.Drawing.Size(114, 39);
            this.btn_MOL_Add_Skin.TabIndex = 4;
            this.btn_MOL_Add_Skin.Text = "Add Skin";
            this.btn_MOL_Add_Skin.UseVisualStyleBackColor = true;
            this.btn_MOL_Add_Skin.Click += new System.EventHandler(this.btn_MOL_Add_Skin_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::moonlight.Properties.Resources.ryze;
            this.pictureBox2.Location = new System.Drawing.Point(518, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 343);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::moonlight.Properties.Resources.lux;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MOL_Add_Skin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_MOL_Add_Skin);
            this.Controls.Add(this.lbl_MOL_Champion_Name);
            this.Controls.Add(this.cb_MOL_Champion_Name);
            this.Controls.Add(this.lbl_MOL_Skin_Name);
            this.Controls.Add(this.tb_MOL_Skin_Name);
            this.Name = "MOL_Add_Skin";
            this.Text = "MOL_Add_Skin";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MOL_Skin_Name;
        private System.Windows.Forms.Label lbl_MOL_Skin_Name;
        private System.Windows.Forms.ComboBox cb_MOL_Champion_Name;
        private System.Windows.Forms.Label lbl_MOL_Champion_Name;
        private System.Windows.Forms.Button btn_MOL_Add_Skin;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}