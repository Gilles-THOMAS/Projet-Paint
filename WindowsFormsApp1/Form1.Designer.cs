using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.new_rect_btn = new System.Windows.Forms.Button();
            this.new_clq_btn = new System.Windows.Forms.Button();
            this.new_img_btn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.new_rect_btn);
            this.splitContainer1.Panel1.Controls.Add(this.new_clq_btn);
            this.splitContainer1.Panel1.Controls.Add(this.new_img_btn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1319, 738);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // new_rect_btn
            // 
            this.new_rect_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("new_rect_btn.BackgroundImage")));
            this.new_rect_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_rect_btn.Location = new System.Drawing.Point(101, 10);
            this.new_rect_btn.Name = "new_rect_btn";
            this.new_rect_btn.Size = new System.Drawing.Size(41, 41);
            this.new_rect_btn.TabIndex = 2;
            this.new_rect_btn.UseVisualStyleBackColor = true;
            this.new_rect_btn.Click += new System.EventHandler(this.new_rect_btn_Click);
            // 
            // new_clq_btn
            // 
            this.new_clq_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("new_clq_btn.BackgroundImage")));
            this.new_clq_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.new_clq_btn.Location = new System.Drawing.Point(53, 11);
            this.new_clq_btn.Name = "new_clq_btn";
            this.new_clq_btn.Size = new System.Drawing.Size(41, 39);
            this.new_clq_btn.TabIndex = 1;
            this.new_clq_btn.UseVisualStyleBackColor = true;
            this.new_clq_btn.Click += new System.EventHandler(this.new_clq_btn_Click);
            // 
            // new_img_btn
            // 
            this.new_img_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("new_img_btn.BackgroundImage")));
            this.new_img_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.new_img_btn.Location = new System.Drawing.Point(11, 11);
            this.new_img_btn.Name = "new_img_btn";
            this.new_img_btn.Size = new System.Drawing.Size(35, 40);
            this.new_img_btn.TabIndex = 0;
            this.new_img_btn.UseVisualStyleBackColor = true;
            this.new_img_btn.Click += new System.EventHandler(this.new_img_btn_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1138, 738);
            this.splitContainer2.SplitterDistance = 947;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer3.Size = new System.Drawing.Size(187, 738);
            this.splitContainer3.SplitterDistance = 326;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer4.Size = new System.Drawing.Size(187, 326);
            this.splitContainer4.SplitterDistance = 92;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer4_SplitterMoved);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1319, 738);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        /* TODO remove the following functions */

        public void AddControlToPanel(System.Windows.Forms.Panel pnl, System.Windows.Forms.PictureBox canvas)
        {
            pnl.Controls.Add(canvas);
        }

        public void AddControlToSplitContainer2Panel1(System.Windows.Forms.PictureBox canvas)
        {
            this.splitContainer2.Panel1.Controls.Add(canvas);
        }

        public void AddControlToSplitContainer4Panel1(System.Windows.Forms.ListBox layer_lb)
        {
            this.splitContainer4.Panel1.Controls.Add(layer_lb);
        }

        public void AddControlToSplitContainer3Panel2(System.Windows.Forms.GroupBox info_gb)
        {
            this.splitContainer3.Panel2.Controls.Add(info_gb);
        }

        public System.Drawing.Size GetSplitContainer4Panel1Size()
        {
            //Size = new System.Drawing.Size(splitContainer4.Panel1.Width, splitContainer4.Panel1.Height);
            return (new System.Drawing.Size(splitContainer4.Panel1.Width, splitContainer4.Panel1.Height));
        }

        public System.Drawing.Size GetSplitContainer3Panel2Size()
        {
            return (new System.Drawing.Size(splitContainer3.Panel2.Width, splitContainer3.Panel2.Height));
        }

        public System.Drawing.Size GetSplitContainer2Panel1Size()
        {
            return (new System.Drawing.Size(splitContainer2.Panel1.Width, splitContainer2.Panel1.Height));
        }


        #region
        //TODO remove the functions above
        #endregion

        
        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button new_rect_btn;
        private System.Windows.Forms.Button new_clq_btn;
        private System.Windows.Forms.Button new_img_btn;
    }
}

