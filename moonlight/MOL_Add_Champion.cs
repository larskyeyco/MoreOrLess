using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace moonlight
{
    public partial class MOL_Add_Champion : Form
    {
        byte[] imageBytes;
        public MOL_Add_Champion()
        {
            InitializeComponent();
        }

        private void btn_MOL_Add_Champion_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                using (var context = new moreorlessEntities())
            {
                context.ChampionAdd_1(tb_MOL_Champion_Name.Text, int.Parse(tb_MOL_Champion_Cost.Text), imageBytes);
                MessageBox.Show("Champion added to pool");
            }
        }

        private void btn_MOL_Choose_Champion_Icon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "jpg files (*.jpg)|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.FileName;
                    imageBytes = File.ReadAllBytes(path);
                    pb_MOL_Champion_Icon.Image = Image.FromFile(path);
                }
            }
        }

        private void tb_MOL_Champion_Name_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            if (string.IsNullOrEmpty(txt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txt, "This fleld connot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt, null);
            }
        }

        private void tb_MOL_Champion_Cost_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            if (string.IsNullOrEmpty(txt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txt, "This fleld connot be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt, null);
            }
        }

        private void pb_MOL_Champion_Icon_Validating(object sender, CancelEventArgs e)
        {
            var picture = sender as PictureBox;
            if (picture.Image == null)
            {
                e.Cancel = true;
                errorProvider.SetError(btn_MOL_Choose_Champion_Icon, "Please choose a picture.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(btn_MOL_Choose_Champion_Icon, null);
            }
        }
    }
}
