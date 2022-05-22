using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeControl
{
    internal class GameController
    {
        private Label coinLabel;
        private int coinNumber=0;
        public GameController(Label coinLabel)
        {
            this.coinLabel = coinLabel;
            if (File.Exists(TimeControlFile.GameData))
                coinNumber = Convert.ToInt32
                    (File.ReadAllText(TimeControlFile.GameData));
        }
        public void AddCoin(int number)
        {
            coinNumber += number;
            UpdateGame();
        }
        private void UpdateGame()
        {
            coinLabel.Text = coinNumber.ToString();
            File.WriteAllText(TimeControlFile.GameData,coinNumber.ToString());
        }
        
    }
}
