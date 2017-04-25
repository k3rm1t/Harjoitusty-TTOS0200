using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Kalevala fishing game. 
/// Teemu did this
/// 31.3.2017
/// </summary>
namespace kalevala
{
    public partial class ScoreCount //
    {
   /*     public GUIText scoreText;
        public int score;
        public void AddScore(int NewScore)
        {
            score += NewScore;
            updatescore();
        }
        void updatescore()
        {
            scoreText.Text = score;
        }
        */


        //add scores
        private int Score;

        public static ScoreCount Current { get; internal set; }
        public int NewScore { get; set; }
        public int Number { get; internal set; }

        private int AddScore()
        {
            Score += NewScore;
            UpdateScore();
            return NewScore;
        }
        // decrease scores
        private int DecScore()
        {
            Score -= NewScore;
            UpdateScore();
            return NewScore;
        }
        //updates scores

        void UpdateScore()
        {

            // currentplayer.Text = Convert.Tostring(Score);
            //scoreText.text = "Score: " + score; //orginall
           // GamePage.Player1Points.Text = Convert.ToString(NewScore);//NewScore.ToString(); // 
            return;
        }


    }

}
