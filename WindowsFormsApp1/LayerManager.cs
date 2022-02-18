using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class LayerManager
    {
        private List<Layer> Layers;
        private Form1 Form_ref;
        private int Selected;
        private Int16 Size;

        private Point default_location;

        private ListBox Layers_Listbox;
        private ListBox Objects_Listbox;
        private GroupBox Infos_Groupbox;

        public LayerManager()
        {
            this.Layers = new List<Layer>();
            this.Selected = -1;
            this.Size = 0;

            this.Layers_Listbox = new ListBox();
            this.Objects_Listbox = new ListBox();
            this.Infos_Groupbox = new GroupBox();

            this.Layers_Listbox.SelectionMode = SelectionMode.One;
            this.Objects_Listbox.SelectionMode = SelectionMode.One;
            
            this.Layers_Listbox.Click += new System.EventHandler(Layer_Select);
        }

        public LayerManager(Form1 F_ref)
        {
            this.Layers = new List<Layer>();
            this.Form_ref = F_ref;
            this.Selected = -1;
            this.Size = 0;

            this.Layers_Listbox = new ListBox();
            this.Objects_Listbox = new ListBox();
            this.Infos_Groupbox = new GroupBox();

            this.Layers_Listbox.SelectionMode = SelectionMode.One;
            this.Objects_Listbox.SelectionMode = SelectionMode.One;

            this.Layers_Listbox.Click += new System.EventHandler(Layer_Select);
        }

        public void Set_Form_Ref(Form1 F_ref)
        {
            this.Form_ref = F_ref;
        }

        public void New_Canvas(Size Canvas_size)
        {
            String name = "canvas_";
            if (Selected == -1)
            {
                Selected = 0;
            }
            name += Convert.ToString(Size);
            Layers.Add(new Layer(this.Form_ref, name, Size));
            Layers[Size].Set_CanvasSize(Canvas_size);
            if (Size > 0)
            {
                Set_Canvas_BackColor(Size, Color.FromArgb(0, 255, 255, 255));
                Set_Canvas_Location(Size);
                this.Form_ref.Add_Control_To_Panel(this.Layers[Size].Get_Canvas(), this.Form_ref.GetSplitContainer2().Panel1);
            }
            this.Layers[Size].Get_Canvas().BringToFront();
            Update_Layers_Listbox();
            ++Size;
        }

        public void Set_Canvas_BackColor(int index, Color argb)
        {
            this.Layers[index].Set_CanvasBgColor(argb);
        }

        public void Set_Canvas_Selected_BackColor(Color argb)
        {
            this.Layers[Selected].Set_CanvasBgColor(argb);
        }

        public void Set_Default_Location(Point def_loc)
        {
            this.default_location = def_loc;
        }

        public Point Get_Default_Canvas_Location()
        {
            return (this.default_location);
        }

        public void Set_Canvas_Location(int index)
        {
            this.Layers[index].Set_CanvasLocation(this.default_location);
        }

        public void Set_Canvas_Size(Size cv_size)
        {
            this.Layers[Selected].Set_CanvasSize(cv_size);
        }

        public String Get_Selected_Layer_Name()
        {
            return (this.Layers[Selected].Get_Canvas_Name());
        }

        public Layer Get_Selected_Layer()
        {
            return (this.Layers[Selected]);
        }

        public Size Get_Canvas_Ref_Size()
        {
            return (this.Layers[0].Get_CanvasSize());
        }

        public void Set_Selected(Int16 sel)
        {
            Selected = sel;
        }

        public List<Layer> Get_All_Layers()
        {
            return (Layers);
        }

        public ListBox Get_Layer_Listbox()
        {
            return (Layers_Listbox);
        }

        public ListBox Get_Objects_Listbox()
        {
            return (Objects_Listbox);
        }

        public GroupBox Get_Infos_Groupbox()
        {
            return (Infos_Groupbox);
        }

        public void Update_Layers_Listbox()
        {
            int i = 0;
            this.Layers_Listbox.Items.Clear();
            this.Layers_Listbox.BeginUpdate();
            while(i < Layers.Count)
            {
                this.Layers_Listbox.Items.Add(Layers[i].Get_Canvas_Name());
                ++i;
            }
            this.Layers_Listbox.EndUpdate();

        }

        public void Layer_Select(object sender, EventArgs e)
        {
            
            if ((this.Layers_Listbox.SelectedIndex > -1))
            {
                Selected = this.Layers_Listbox.SelectedIndex;
            }
            
            Update_Objects_Listbox();
            Update_Canvas();
        }

        public void Update_Objects_Listbox()
        {
            int i = 0;
            int cnt = 0;

            this.Objects_Listbox.Items.Clear();

            if (Layers[Selected].Get_Size() == 0)
            {
                return;
            }

            cnt = Layers[Selected].Get_Layer_Objects().Count;
                        
            this.Objects_Listbox.BeginUpdate();
            
            while (i < cnt)
            {
                this.Objects_Listbox.Items.Add(Layers[Selected].Get_Object(i).Get_Object_Name());
                ++i;
            }
            this.Objects_Listbox.EndUpdate();
        }

        public void Update_Infos_Groupbox()
        {
            this.Infos_Groupbox.Controls.Clear();
            
        }

        public void Update_Canvas()
        {
            int i = 0;

            while (i < this.Layers.Count)
            {
                this.Layers[i].Get_Canvas().Refresh();
                ++i;
            }
        }
    }
}
