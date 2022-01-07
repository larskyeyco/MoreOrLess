using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace moonlight
{
    public partial class MOL_RankingGame_2 : Form
    {
        public MOL_RankingGame_2()
        {
            InitializeComponent();
            ShowRanking();
        }
        public void ShowRanking()
        {
            using (var context = new moreorlessEntities())
            {
                var rankingGame2List = Queryable.Take(GetRankingCost(context), 10).OrderByDescending(x => x.Score).ToList();
                foreach (var rankingCost in rankingGame2List)
                {
                    ListViewItem playerName = new ListViewItem(rankingCost.PlayerName);
                    playerName.SubItems.Add(rankingCost.Score.ToString());
                    listView1.Items.Add(playerName);
                }
            }
        }
        private static DbSet<RankingCost> GetRankingCost(moreorlessEntities context)
        {
            return context.RankingCost;
        }
    }
}