using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace moonlight
{
    public partial class MOL_Add_Skin : Form
    {
        public MOL_Add_Skin()
        {
            InitializeComponent();
            LoadChampions();
        }
        private void LoadChampions()
        {
            using (var context = new moreorlessEntities())
            {
                cb_MOL_Champion_Name.Items.AddRange(context.Champions.Select(x => x.ChampionName).Distinct().ToArray());
            }
        }

        private void btn_MOL_Add_Skin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                using (var context = new moreorlessEntities())
                {
                    context.SkinAdd(tb_MOL_Skin_Name.Text.Trim(), cb_MOL_Champion_Name.Text);
                    MessageBox.Show("Champion added to pool");
                }
        }

        private void tb_MOL_Skin_Name_Validating(object sender, CancelEventArgs e)
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

        private void cb_MOL_Champion_Name_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as ComboBox;
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
    }
}