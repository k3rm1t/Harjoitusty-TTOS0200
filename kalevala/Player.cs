using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Player class
/// Takes 2 parameters Name1&Name2
/// 30.3.2017
/// Teemu 
/// </summary>
namespace kalevala
{
    public class Player
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public int Points { get; set; }
        

        // constructor
        public Player() { }
        public Player(string name1, string name2)
        {
            Name1 = name1;
            Name2 = name2;
        }
        
        /*
        static void Save(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(@"c:\saved.file");
                outputFile.WriteLine("players here");
            }
            catch (Exception ex)
            {
                GamePage.MessageBox.Show("ex.Message");
            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }*/
        /*
        public int P1Points { get; set; }
        private int P2Points { get; set; }
       // private int Score = 0;
        public int NewScore { get; private set; }
        public int Score { get; set; }
        public void AddScore(int NewScore)
        {
            Score += NewScore;
            UpdateScore();
        }
        void UpdateScore()
        {
            GamePage.Player1Points.Text = Convert.ToString(NewScore);
        }

        /*public override string ToString()
        {
            return Name1; //Name2
            //return base.ToString();
            
        }*/
    }
}
