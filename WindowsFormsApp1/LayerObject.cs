using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class LayerObject
    {
        private Form1 Form_ref;
        private PictureBox Canvas_ref;
        private Point obj_location;
        private Size obj_size;
        private Object obj;

        private Color color;
        private Pen pen;

        private Rectangle rect;

        private Image img;

        private String obj_type;
        private String name;
        private Point location;
        private Size size;
        private int id;

        //TODO add a list of "names" ("rect"...) to create the object to override Object

        //TODO essaie d'initialiser les attributs de LayerObjects() pour pouvoir les omettres

        public LayerObject(Form1 F_ref, PictureBox Pb_ref, String name, String type, int id, Color col, float thick, Point loc, Size size)
        {
            this.Form_ref = F_ref;
            this.Canvas_ref = Pb_ref;
            this.name = name;
            this.obj_type = type;
            this.id = id;
            this.location = loc;
            this.size = size;
            this.pen = new Pen(col, thick);
            if (obj_type == Objects.rect)
            {
                CreateRect(loc, size);
            }
        }

        public LayerObject(Form1 F_ref, PictureBox Pb_ref, String name, String type, int id, Color col, float thick)
        {
            this.Form_ref = F_ref;
            this.Canvas_ref = Pb_ref;
            this.name = name;
            this.obj_type = type;
            this.id = id;
            this.pen = new Pen(col, thick);
        }

        public String Get_Object_Name()
        {
            return (name);
        }

        public void CreateRect(Point loc, Size size)
        {
            this.rect = new Rectangle(loc, size);
        }

        public Object Get_Object()
        {
            return (this.obj);
        }

        public Rectangle Get_Rect()
        {
            return (this.rect);
        }

        public String Get_Type()
        {
            return (this.obj_type);
        }

        public Pen Get_Pen()
        {
            return (this.pen);
        }
    }
}
