using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace moonlight
{
    public partial class MOL_ChooseGame_1 : Form
    {
        private static int iCountQ1 = 0;
        public MOL_ChooseGame_1()
        {
            InitializeComponent();
            DrawNew();
            iCountQ1 = 0;
        }
        private void DrawNew()
        {
            using(var context = new moreorlessEntities())
            {
                lbl_MOL_PlayerName.Visible = false;
                tb_MOL_PlayerName.Visible = false;
                btn_MOL_Submit_Game_1_Score.Visible = false;
                lbl_MOL_Skins_Count_2.Visible = false;
                lbl_MOL_ChampionName_1.Text = context.Champions.Select(x=>x.ChampionName).OrderBy(r=> Guid.NewGuid()).Take(1).FirstOrDefault().ToString();
                lbl_MOL_Skins_Count_1.Text = context.Skins.Where(x => x.ChampionName == lbl_MOL_ChampionName_1.Text).Count().ToString();
                Bitmap bmp;
                Bitmap bmp2;
                using (var ms = new MemoryStream(context.Champions.Where(x => x.ChampionName == lbl_MOL_ChampionName_1.Text).Select(x => x.ChampionIcon).FirstOrDefault()))
                {
                    bmp = new Bitmap(ms);
                    pb_MOL_Champion_1_Icon.Image = bmp;
                }
                lbl_MOL_ChampionName_2.Text = context.Champions.Select(x => x.ChampionName).OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault().ToString();
                lbl_MOL_Skins_Count_2.Text = context.Skins.Where(x => x.ChampionName == lbl_MOL_ChampionName_2.Text).Count().ToString();
                using (var ms2 = new MemoryStream(context.Champions.Where(x => x.ChampionName == lbl_MOL_ChampionName_2.Text).Select(x => x.ChampionIcon).FirstOrDefault()))
                {
                    bmp2 = new Bitmap(ms2);
                    pb_MOL_Champion_2_Icon.Image = bmp2;
                }
            }
        }
        private void btn_MOL_More_Skins_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_MOL_Skins_Count_2.Text) > int.Parse(lbl_MOL_Skins_Count_1.Text) || int.Parse(lbl_MOL_Skins_Count_2.Text) == int.Parse(lbl_MOL_Skins_Count_1.Text))
            {
                AddScore();
                DrawNew();
            }
            else 
            {
                ShowResult();
            }
        }
        private void btn_MOL_Less_Skins_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_MOL_Skins_Count_2.Text) < int.Parse(lbl_MOL_Skins_Count_1.Text) || int.Parse(lbl_MOL_Skins_Count_2.Text) == int.Parse(lbl_MOL_Skins_Count_1.Text))
            {
                AddScore();
                DrawNew();
            }
            else
            {
                ShowResult();
            }
        }
        private void btn_MOL_Submit_Game_1_Score_Click(object sender, EventArgs e)
        {
            if (tb_MOL_PlayerName.Text == "")
                MessageBox.Show("Please fill mandatory field");
            else
                using (var context = new moreorlessEntities())
                {
                    context.ScoreSkinAdd(tb_MOL_PlayerName.Text, iCountQ1);
                    MessageBox.Show("Score added to ranking!");
                    ClearAll();
                    DrawNew();
                    btn_MOL_Less_Skins.Visible = true;
                    btn_MOL_More_Skins.Visible = true;
                }
        }

        private void tb_MOL_PlayerName_Validating(object sender, CancelEventArgs e)
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
        private void ShowResult()
        {
            btn_MOL_Less_Skins.Visible = false;
            btn_MOL_More_Skins.Visible = false;
            lbl_MOL_Skins_Count_2.Visible = true;
            lbl_MOL_PlayerName.Visible = true;
            tb_MOL_PlayerName.Visible = true;
            btn_MOL_Submit_Game_1_Score.Visible = true;
        }
        private void ClearAll()
        {
            tb_MOL_PlayerName.Text = "";
            lbl_MOL_PlayerScore.Text = "0";
            iCountQ1 = 0;
        }
        private void AddScore()
        {
            iCountQ1 = Math.Max(iCountQ1 + 1, 0);
            lbl_MOL_PlayerScore.Text = iCountQ1.ToString();
        }
    }
}