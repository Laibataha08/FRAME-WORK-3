using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp4
{
    class GameObject
    {
        IMovement move;

        PictureBox pictureBox;
        public int speed;
        IMovement movement;
        Type type;
        Label label;
        public static int player = 0;
        public static int ghost ;


        public GameObject(PictureBox pictureBox , IMovement movement , int speed, Type type, Label label)
        {
            this.pictureBox = pictureBox;
            this.movement = movement;
            this.speed = speed;
            this.type = type;
            this.label = label;
        }

        public void updateposition()
        {
            move = movement;
            move.typeofmovement(speed, pictureBox);    
        }


        public void getcount()
        {
            if (Type.player == type)
            {
                player++;
                label.Text = "player  : " + player ;
            }


            if (Type.ghost == type )
            {
                ghost++;
                label.Text = "ghost : " + ghost;
            }
        }
       
    }

    enum Type
    {
        player,
        ghost,
    }
}
