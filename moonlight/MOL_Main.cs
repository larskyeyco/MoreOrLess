using System;
using System.Windows.Forms;

namespace moonlight
{

    public partial class Form_MOL_Main : Form
    {
        public Form_MOL_Main()
        {
            InitializeComponent();
            HidePanelsOnStart();
        }
        private void HidePanelsOnStart()
        {
            panel_MOL_ChooseGame.Visible = false;
            panel_MOL_ChooseRanking.Visible = false;
            panel_MOL_Add.Visible = false;
        }
        private void HideMOLMenu()
        {
            if (panel_MOL_ChooseGame.Visible == true)
                panel_MOL_ChooseGame.Visible = false;
            if (panel_MOL_ChooseRanking.Visible == true)
                panel_MOL_ChooseRanking.Visible = false;
            if (panel_MOL_Add.Visible == true)
                panel_MOL_Add.Visible = false;
        }
        private void ShowMOLMenu(Panel ShowMOLMenu)
        {
            if (ShowMOLMenu.Visible == false)
            {
                HideMOLMenu();
                ShowMOLMenu.Visible = true;
            }
            else
                ShowMOLMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_MOL_ShowOtherForms.Controls.Add(childForm);
            panel_MOL_ShowOtherForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_MOL_ChooseGame_Click(object sender, EventArgs e)
        {
            ShowMOLMenu(panel_MOL_ChooseGame);
        }

        private void btn_MOL_ChooseGame_1_Click(object sender, EventArgs e)
        {
            openChildForm(new MOL_ChooseGame_1());
            HideMOLMenu();
            pb_MOL_Logo_2.Visible = false;
        }

        private void btn_MOL_ChooseGame_2_Click(object sender, EventArgs e)
        {
            openChildForm(new MOL_ChooseGame_2());
            HideMOLMenu();
            pb_MOL_Logo_2.Visible = false;
        }

        private void btn_MOL_ChooseRanking_Click(object sender, EventArgs e)
        {
            ShowMOLMenu(panel_MOL_ChooseRanking);
        }

        private void btn_MOL_ChooseRanking_1_Click(object sender, EventArgs e)
        {
            openChildForm(new MOL_RankingGame_1());
            HideMOLMenu();
            pb_MOL_Logo_2.Visible = false;
        }

        private void btn_MOL_ChooseRanking_2_Click(object sender, EventArgs e)
        {
            openChildForm(new MOL_RankingGame_2());
            HideMOLMenu();
            pb_MOL_Logo_2.Visible = false;
        }

        private void btn_MOL_Add_Click(object sender, EventArgs e)
        {
            ShowMOLMenu(panel_MOL_Add);
        }

        private void btn_MOL_Add_Champion_Click(object sender, EventArgs e)
        {
            openChildForm(new MOL_Add_Champion());
            HideMOLMenu();
            pb_MOL_Logo_2.Visible = false;
        }

        private void btn_MOL_Add_Skin_Click(object sender, EventArgs e)
        {
            openChildForm(new MOL_Add_Skin());
            HideMOLMenu();
            pb_MOL_Logo_2.Visible = false;
        }

        private void btn_MOL_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
