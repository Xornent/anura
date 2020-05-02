using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anura.Windows {
    public class Mismatch : Form {
        public Mismatch () {
            InitializeComponent ();
            this.MaximizeBox = false;
            bool flag = true;
            foreach(string str in Resources.Global.Dependencies) {
                if(!System.IO.File.Exists(Application.StartupPath+@"\"+str))
                    flag = false;
            }
            if ( flag ) {

                // TODO: 检测成功后启动主程序窗体
                new Render().Show();

                asyn.Interval = 50;
                asyn.Enabled = true;
                asyn.Tick += AsyncHide;
            } else {
                this.lbStatus.Visible = true;
            }
        }

        private void AsyncHide (object sender, EventArgs e) {
            this.Hide ();
            asyn.Enabled = false;
        }

        private void Resume (object sender, MouseEventArgs e) {

        }

        #region Windows Design

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        private void InitializeComponent () {
            this.picLogo = new System.Windows.Forms.PictureBox ();
            this.lbProduct = new System.Windows.Forms.Label ();
            this.lbStatus = new System.Windows.Forms.Label ();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit ();
            this.SuspendLayout ();

            this.picLogo.Image = Resources.ResourceLoader.LoadBitmap("application/logo/anura.ico");
            this.picLogo.Location = new System.Drawing.Point (127, 66);
            this.picLogo.Size = new System.Drawing.Size (128, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;

            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font ("PingFang SC Regular", 26F);
            this.lbProduct.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.lbProduct.Location = new System.Drawing.Point (136, 200);
            this.lbProduct.Size = new System.Drawing.Size (118, 37);
            this.lbProduct.TabIndex = 1;
            this.lbProduct.Text = "Anura";

            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font ("PingFang SC Regular", 15F);
            this.lbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lbStatus.Location = new System.Drawing.Point (69, 273);
            this.lbStatus.Size = new System.Drawing.Size (252, 27);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "依赖项缺失或程序组件损坏";
            this.lbStatus.Visible = false;
            // 
            // Mismatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size (384, 361);
            this.Controls.Add (this.lbStatus);
            this.Controls.Add (this.lbProduct);
            this.Controls.Add (this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Resources.ResourceLoader.LoadIcon("application/logo/anura.ico");
            this.Name = "Mismatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "组件检测";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler (this.Resume);
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbStatus;
        Timer asyn = new Timer ();

        #endregion
    }
}