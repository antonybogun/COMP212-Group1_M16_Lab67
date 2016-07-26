using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Group1_M16_Lab67
{
    public partial class Form1 : Form
    {
        Dictionary<string, object> GGObject = new Dictionary<string, object>();
        Random random = new Random();
        int randomNum;
        
        public Form1()
        {
            InitializeComponent();
            
            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[100];
            int locationX = 10, locationY = 17;
            
            for (int i=0;i<10;i++)
            { 
                for(int j=0;j<10;j++)
                {
                    int index = i * 10 + j;
                    buttons[index] = new Button();
                    buttons[index].Size = new System.Drawing.Size(50, 50);
                    buttons[index].Location = new System.Drawing.Point(locationX, locationY);
                    locationX += buttons[index].Size.Width;
                    buttons[index].Text = (index + 1).ToString();
                    buttons[index].Click += Button_Click;

                    // Include buttons into Group box to control buttons as group 
                    this.groupBox1.Controls.Add(buttons[index]);
                }
                locationX = 10;
                locationY += buttons[0].Size.Height;
            }
            setGGObject();

        }
        // Handles number button event
        private void Button_Click(object sender, EventArgs e)
        {
            
            if (!GGObject.ContainsKey("lives"))
            {
                MessageBox.Show("Please Click Start button");
            }else
            {
                showClickResult(sender);
            }

        }
        // Process show click result 
        private void showClickResult(object btn)
        {
            Button clickedBtn = (Button)btn;
            int userNum = Convert.ToInt32(clickedBtn.Text);
            
            // Greater than random number
            if (userNum > randomNum)
            {
                showMessage("subMessage");
                clickedBtn.BackColor = Color.Red;
                clickedBtn.Enabled = false;
                btnPlayAgain.Focus();
                falseResult();
            }// Less than random number
            else if (userNum < randomNum)
            {
                showMessage("infMessage");
                clickedBtn.BackColor = Color.Yellow;
                clickedBtn.Enabled = false;
                btnPlayAgain.Focus();
                falseResult();
            }// Same with random number
            else
            {
                showMessage("winMessage");
                clickedBtn.BackColor = Color.Green;
                btnPlayAgain.PerformClick();
            }
        }
        // Handles start button event
        private void btnStartGame_Click(object sender, EventArgs e)
        {
           initializeGame();

        }
        // Initialize cores and message
        private void initializeGame()
        {
            randomNum = random.Next(0, 100);
            GGObject["score"] = 100;
            GGObject["lives"] = 10;
            btnStartGame.Visible = false;
            txtMessage.Text = "";
            txtScore.Text = GGObject["score"].ToString();
            txtLives.Text = GGObject["lives"].ToString();
            Console.WriteLine("RANDOM NUM:" + randomNum);
 
        }
        // Show value from dictionary into message box 
        private void showMessage(string key)
        {
            txtMessage.Text = GGObject[key].ToString();
        }
        // Process false result 
        private void falseResult()
        {
            int score = Convert.ToInt32(GGObject["score"]);
            int lives = Convert.ToInt32(GGObject["lives"]);
            GGObject["score"] = score - 10;
            GGObject["lives"] = lives - 1;
            txtScore.Text = GGObject["score"].ToString();
            txtLives.Text = GGObject["lives"].ToString();

            if (Convert.ToInt32(GGObject["lives"]) < 1)
            {
                showMessage("finalMessage");
                btnPlayAgain.PerformClick();
            }
        }
        // Set game messages
        private void setGGObject()
        {
            GGObject.Add("startGame", "Start the Game");
            GGObject.Add("finalMessage", "SORRY GAME OVER");
            GGObject.Add("winMessage", "CONGRATUATION, YOU WON THE GAME");
            GGObject.Add("infMessage", "Number provided is less than the number picked by the program,.. Please try again");
            GGObject.Add("subMessage", "Number provided is greater than the number picked by the program,.. Please try again");
            GGObject.Add("playAgainMessage", "Would you like to play again?");
        }
        // Handle play again button click event
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Displays the MessageBox
            DialogResult result;
            result = MessageBox.Show(GGObject["playAgainMessage"].ToString(), "Confirm", MessageBoxButtons.YesNo);           
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                setBtnColorBack(groupBox1.Controls);
                initializeGame();
            }
            else
            {
                // finish game
                this.Close();
            }
            
        }
        // Reset color of clicked button 
        private void setBtnColorBack(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }

            foreach (Button btn in controlCollection.OfType<Button>())
            {
                btn.BackColor = BackColor = SystemColors.Control;
                btn.UseVisualStyleBackColor = true;
                btn.Enabled = true;
            }
        }
}
}
