using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    partial class Form1
    {

        private LayerManager Layer_Manager;// { get; set; } // = new LayerManager(this);
        private ListBox Layer_Listbox;
        private ListBox Objects_Listbox;
        private GroupBox Infos_Groupbox;

        public System.Windows.Forms.SplitContainer GetSplitContainer1()
        {
            return (splitContainer1);
        }

        public System.Windows.Forms.SplitContainer GetSplitContainer2()
        {
            return (splitContainer2);
        }

        public System.Windows.Forms.SplitContainer GetSplitContainer3()
        {
            return (splitContainer3);
        }

        public System.Windows.Forms.SplitContainer GetSplitContainer4()
        {
            return (splitContainer4);
        }

        public Size Get_Panel_Size(Panel pnl)
        {
            return (new Size(pnl.Width, pnl.Height));
        }

        /*
        public void Set_LayerManager(LayerManager LM)
        {
            this.Layer_Manager = LM;
        }
        */
        
        public LayerManager Get_LayerManager()
        {
            return (this.Layer_Manager); 
        }

        public ListBox Get_Layer_Listbox()
        {
            return (this.Layer_Listbox);
        }

        public ListBox Get_Objects_Listbox()
        {
            return (this.Objects_Listbox);
        }

        public GroupBox Get_Infos_Groupbox()
        {
            return (this.Infos_Groupbox);
        }

        public void Add_Control_To_Panel(Control ctrl, Panel pnl)
        {
            pnl.Controls.Add(ctrl);
        }
        
        public void Update_Panel(Control ctrl, Panel pnl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(ctrl);
        }
    }
}
