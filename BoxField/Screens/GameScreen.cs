using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //used to draw boxes on screen
        SolidBrush boxBrush = new SolidBrush(Color.White);

        // create a list of Boxes
        List<Box> boxes = new List<Box>();

        int waitTime = 9;
        Random randNum = new Random();
        int boxNumbRound = 16;
        int playerboxrounds = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Box b = new Box(500, 0);
            boxes.Add(b);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            waitTime--;

            if (waitTime == 0)
            {

                Box b = new Box(randNum.Next(0, this.Width - 30), 0);
                boxes.Add(b);
                waitTime = 9;
                boxBrush.Color = Color.FromArgb(randNum.Next(0, 256), randNum.Next(0, 256), randNum.Next(0, 256));
                playerboxrounds++;
            }
            if (playerboxrounds == boxNumbRound)
            {

            }

            if (playerboxrounds != boxNumbRound)
            {

            }

            // update position of each box
            for (int i = 0; i < boxes.Count(); i++)
            {
                boxes[i].y += 4;
            }

            

            // remove box from list if it is off screen
            if (boxes[0].y > 450)
            {
                boxes.RemoveAt(0);
            }


            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // draw each box to the screen
            foreach (var b in boxes)
            {
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, 30, 30);
            }
            
            e.Graphics.FillPolygon

        }


    }
}
