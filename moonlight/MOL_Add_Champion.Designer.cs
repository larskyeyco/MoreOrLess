namespace moonlight
{
    partial class MOL_Add_Champion
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
            this.tb_MOL_Champion_Name = new System.Windows.Forms.TextBox();
            this.tb_MOL_Champion_Cost = new System.Windows.Forms.TextBox();
            this.btn_MOL_Choose_Champion_Icon = new System.Windows.Forms.Button();
            this.btn_MOL_Add_Champion = new System.Windows.Forms.Button();
            this.lbl_MOL_Champion_Name = new System.Windows.Forms.Label();
            this.lbl_Champion_Cost = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_MOL_Champion_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MOL_Champion_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MOL_Champion_Name
            // 
            this.tb_MOL_Champion_Name.Location = new System.Drawing.Point(328, 88);
            this.tb_MOL_Champion_Name.Name = "tb_MOL_Champion_Name";
            this.tb_MOL_Champion_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_MOL_Champion_Name.TabIndex = 0;
            this.tb_MOL_Champion_Name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_MOL_Champion_Name_Validating);
            // 
            // tb_MOL_Champion_Cost
            // 
            this.tb_MOL_Champion_Cost.Location = new System.Drawing.Point(328, 168);
            this.tb_MOL_Champion_Cost.Name = "tb_MOL_Champion_Cost";
            this.tb_MOL_Champion_Cost.Size = new System.Drawing.Size(100, 20);
            this.tb_MOL_Champion_Cost.TabIndex = 1;
            this.tb_MOL_Champion_Cost.Validating += new System.ComponentModel.CancelEventHandler(this.tb_MOL_Champion_Cost_Validating);
            // 
            // btn_MOL_Choose_Champion_Icon
            // 
            this.btn_MOL_Choose_Champion_Icon.Location = new System.Drawing.Point(582, 230);
            this.btn_MOL_Choose_Champion_Icon.Name = "btn_MOL_Choose_Champion_Icon";
            this.btn_MOL_Choose_Champion_Icon.Size = new System.Drawing.Size(158, 23);
            this.btn_MOL_Choose_Champion_Icon.TabIndex = 3;
            this.btn_MOL_Choose_Champion_Icon.Text = "Choose Image";
            this.btn_MOL_Choose_Champion_Icon.UseVisualStyleBackColor = true;
            this.btn_MOL_Choose_Champion_Icon.Click += new System.EventHandler(this.btn_MOL_Choose_Champion_Icon_Click);
            // 
            // btn_MOL_Add_Champion
            // 
            this.btn_MOL_Add_Champion.Location = new System.Drawing.Point(313, 316);
            this.btn_MOL_Add_Champion.Name = "btn_MOL_Add_Champion";
            this.btn_MOL_Add_Champion.Size = new System.Drawing.Size(147, 23);
            this.btn_MOL_Add_Champion.TabIndex = 4;
            this.btn_MOL_Add_Champion.Text = "Add Champion";
            this.btn_MOL_Add_Champion.UseVisualStyleBackColor = true;
            this.btn_MOL_Add_Champion.Click += new System.EventHandler(this.btn_MOL_Add_Champion_Click);
            // 
            // lbl_MOL_Champion_Name
            // 
            this.lbl_MOL_Champion_Name.AutoSize = true;
            this.lbl_MOL_Champion_Name.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MOL_Champion_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_MOL_Champion_Name.Location = new System.Drawing.Point(48, 68);
            this.lbl_MOL_Champion_Name.Name = "lbl_MOL_Champion_Name";
            this.lbl_MOL_Champion_Name.Size = new System.Drawing.Size(235, 62);
            this.lbl_MOL_Champion_Name.TabIndex = 5;
            this.lbl_MOL_Champion_Name.Text = "Champion Name";
            // 
            // lbl_Champion_Cost
            // 
            this.lbl_Champion_Cost.AutoSize = true;
            this.lbl_Champion_Cost.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Champion_Cost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Champion_Cost.Location = new System.Drawing.Point(48, 148);
            this.lbl_Champion_Cost.Name = "lbl_Champion_Cost";
            this.lbl_Champion_Cost.Size = new System.Drawing.Size(220, 62);
            this.lbl_Champion_Cost.TabIndex = 6;
            this.lbl_Champion_Cost.Text = "Champion Cost";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::moonlight.Properties.Resources.teemo;
            this.pictureBox2.Location = new System.Drawing.Point(-58, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::moonlight.Properties.Resources.viktor;
            this.pictureBox1.Location = new System.Drawing.Point(511, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pb_MOL_Champion_Icon
            // 
            this.pb_MOL_Champion_Icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_MOL_Champion_Icon.Location = new System.Drawing.Point(540, 27);
            this.pb_MOL_Champion_Icon.Name = "pb_MOL_Champion_Icon";
            this.pb_MOL_Champion_Icon.Size = new System.Drawing.Size(228, 197);
            this.pb_MOL_Champion_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_MOL_Champion_Icon.TabIndex = 2;
            this.pb_MOL_Champion_Icon.TabStop = false;
            this.pb_MOL_Champion_Icon.Validating += new System.ComponentModel.CancelEventHandler(this.pb_MOL_Champion_Icon_Validating);
            // 
            // MOL_Add_Champion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Champion_Cost);
            this.Controls.Add(this.lbl_MOL_Champion_Name);
            this.Controls.Add(this.btn_MOL_Add_Champion);
            this.Controls.Add(this.btn_MOL_Choose_Champion_Icon);
            this.Controls.Add(this.pb_MOL_Champion_Icon);
            this.Controls.Add(this.tb_MOL_Champion_Cost);
            this.Controls.Add(this.tb_MOL_Champion_Name);
            this.Name = "MOL_Add_Champion";
            this.Text = "MOL_Add_Champion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MOL_Champion_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MOL_Champion_Name;
        private System.Windows.Forms.TextBox tb_MOL_Champion_Cost;
        private System.Windows.Forms.PictureBox pb_MOL_Champion_Icon;
        private System.Windows.Forms.Button btn_MOL_Choose_Champion_Icon;
        private System.Windows.Forms.Button btn_MOL_Add_Champion;
        private System.Windows.Forms.Label lbl_MOL_Champion_Name;
        private System.Windows.Forms.Label lbl_Champion_Cost;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}