using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Layer
    {

        private List<Object> Objs;

        private List<LayerObject> LayerObjects;
        private PictureBox Canvas;
        private Form1 Form_ref;
        private String name;
        private int id;

        private Color canvas_bgcolor;

        private int selected_Object;

        private int size;

        private Label Layer_Label;

        public enum objects_types
        {
            rect,
            img,
            circle
        }


        //TODO create list of "names" ("rect", ...) to create the coresponding overrid object

        public Layer(Form1 F_ref, String name, Int16 id)
        {
            this.Form_ref = F_ref;
            this.Canvas = new PictureBox();
            this.LayerObjects = new List<LayerObject>();
            this.name = name;
            this.id = id;
            this.selected_Object = -1;
            this.size = 0;

            this.Layer_Label = new Label();
            this.Layer_Label.Text = name;
        }

        public void Set_CanvasSize(Size canvas_size)
        {
            this.Canvas.Size = canvas_size;
        }

        public Size Get_CanvasSize()
        {
            return (this.Canvas.Size);
        }

        public void Set_CanvasLocation(Point canvas_location)
        {
            this.Canvas.Location = canvas_location;
        }

        public Point Get_CanvasLocation()
        {
            return (this.Canvas.Location);
        }

        public void Set_CanvasBgColor(Color canvas_bg_color)
        {
            this.canvas_bgcolor = canvas_bg_color;
            this.Canvas.BackColor = canvas_bg_color;
        }

        public String Get_Canvas_Name()
        {
            return (this.name);
        }

        public int Get_Canvas_Id()
        {
            return (this.id);
        }

        public PictureBox Get_Canvas()
        {
            return (this.Canvas);
        }

        public Label Get_Layer_Label()
        {
            return (this.Layer_Label);
        }

        /*
         *TODO démerdes-toi pour pouvoir créer n'importe quel objet (CreateGraphics ??) et récupérer le pen
         * 
         */

        public void Create_NewObject(String type, Color col, float thickness, Point loc, Size sz)
        {
            String obj_name = type + "_" + Convert.ToString(this.size);
            this.LayerObjects.Add(new LayerObject(this.Form_ref, this.Canvas, obj_name, type, this.size, col, thickness, loc, sz));
            this.Form_ref.Get_LayerManager().Update_Objects_Listbox();
            this.Display_Rect(size);
            this.Update_Canvas();
            ++this.size;
        }

        public List<LayerObject> Get_Layer_Objects()
        {
            return (LayerObjects);
        }

        public LayerObject Get_Object(int Index)
        {
            return (LayerObjects[Index]);
        }

        public int Get_Size()
        {
            return (size);
        }

        /*
         * TODO get each "Pen and obj_type" to draw/redraw each objects from the LayerObjects list
         */

        public void Display_Rect(int index)
        {
            Graphics cg = this.Canvas.CreateGraphics();
            cg.DrawRectangle(this.LayerObjects[index].Get_Pen(), this.LayerObjects[index].Get_Rect());
            
        }

        public void Update_Canvas()
        {
            int i = 0;


            
            //this.Canvas.Controls.Clear();
            //this.Canvas.Refresh();
            /*
            while (i < this.LayerObjects.Count)
            {
                if (this.LayerObjects[i].Get_Type() == Objects.rect)
                {
                    Graphics cg = this.Canvas.CreateGraphics();
                    Pen u_pen = new Pen(Color.FromArgb(0, 0, 0, 255));
                    cg.DrawRectangle(u_pen, this.LayerObjects[i].Get_Rect());
                    //this.Canvas.Controls.Add(this.LayerObjects[i].Get_Rect());


                }
                ++i;
            }
            */
        }

    }
}
