using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace moonlight
{
    public partial class MOL_RankingGame_1 : Form
    {
        public MOL_RankingGame_1()
        {
            InitializeComponent();
            ShowRanking();
        }
        public void ShowRanking()
        {
            using (var context = new moreorlessEntities())
            {
                var rankingGame1List = context.RankingSkin.OrderByDescending(x => x.Score).Take(10).ToList();
                foreach (var rankingSkin in rankingGame1List)
                {
                    ListViewItem playerName = new ListViewItem(rankingSkin.PlayerName);
                    playerName.SubItems.Add(rankingSkin.Score.ToString());
                    listView1.Items.Add(playerName);
                }
            }
        }
    }
}