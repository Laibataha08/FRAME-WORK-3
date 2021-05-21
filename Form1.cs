using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Game game;


        public Form1()
        {
            InitializeComponent();
            
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.update();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            game = Game.getInstance();
            GameObject p = new GameObject(pictureBox1, new Moveupleft(),2, Type.player, label1);

            GameObject redGhost = new GameObject(pictureBox2 , new MoveLeft(), 2 , Type.ghost , label2);

            GameObject pinkGhost = new GameObject(pictureBox3, new MoveRight(), 2, Type.ghost , label2);

            GameObject yellowGhost = new GameObject(pictureBox4 , new Falling(), 3 , Type.ghost , label2);

            game.AddObjects(p);
            game.AddObjects(redGhost);
            game.AddObjects(pinkGhost);
            game.AddObjects(yellowGhost);
            game.getcount();

        }

      
    }
}
