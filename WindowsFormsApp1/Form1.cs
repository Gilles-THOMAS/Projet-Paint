using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Layer_Manager = new LayerManager();
            //this.Layer_Listbox = new ListBox();
            //this.Objects_Listbox = new ListBox();
            //this.Infos_Groupbox = new GroupBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.splitContainer1.Panel1.Size = new System.Drawing.Size(Convert.ToInt32(Convert.ToDouble(this.Width) * 0.1), this.Height);
            //this.splitContainer2.Panel1.Size = new System.Drawing.Size(Convert.ToInt32(Convert.ToDouble(this.Width) * 0.8), this.Height);
            //this.splitContainer2.Panel2.Size = new System.Drawing.Size(Convert.ToInt32(Convert.ToDouble(this.Width) * 0.1), this.Height);

            //this.splitContainer3.Panel2.Size = new System.Drawing.Size(Convert.ToInt32(Convert.ToDouble(this.splitContainer2.Panel2.Width) * 0.5), Convert.ToInt32(Convert.ToDouble(this.splitContainer2.Panel2.Height) * 0.5));
            //this.splitContainer4.Panel1.Size = new System.Drawing.Size(Convert.ToInt32(Convert.ToDouble(this.splitContainer2.Panel2.Width) * 0.5), Convert.ToInt32(Convert.ToDouble(this.splitContainer2.Panel2.Height) * 0.5));
            //this.splitContainer4.Panel2.Size = new System.Drawing.Size(Convert.ToInt32(Convert.ToDouble(this.splitContainer2.Panel2.Width) * 0.5), Convert.ToInt32(Convert.ToDouble(this.splitContainer2.Panel2.Height) * 0.5));

            this.splitContainer1.SplitterDistance = Convert.ToInt32(Convert.ToDouble(this.Width) * 0.1);
            this.splitContainer2.SplitterDistance = Convert.ToInt32(Convert.ToDouble(this.Width) * 0.75);
            this.splitContainer3.SplitterDistance = Convert.ToInt32(Convert.ToDouble(this.splitContainer2.Panel2.Height) * 0.5);
            this.splitContainer4.SplitterDistance = Convert.ToInt32(Convert.ToDouble(this.splitContainer3.Panel1.Width) * 0.5);

            //this.LayerManager = new LayerManager(this);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        

        private void new_img_btn_Click(object sender, EventArgs e)
        {
            //this.LayerManager = new LayerManager(this);
            SizeChooser sizeChooser_popup = new SizeChooser(this, this.new_img_btn);
            sizeChooser_popup.Show();
            
        }

        private void new_clq_btn_Click(object sender, EventArgs e)
        {
            this.Layer_Manager.New_Canvas(this.Layer_Manager.Get_Canvas_Ref_Size());
            this.Update_Panel(this.Layer_Manager.Get_Layer_Listbox(), this.splitContainer4.Panel1);
            //this.Update_Layer_Listbox();
        }

        private void new_rect_btn_Click(object sender, EventArgs e)
        {
            SizeChooser sizeChooser_popup = new SizeChooser(this, this.new_rect_btn);
            sizeChooser_popup.Show();
        }
    }
}
