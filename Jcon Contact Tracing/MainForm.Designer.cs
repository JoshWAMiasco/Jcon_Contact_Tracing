namespace Jcon_Contact_Tracing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWorkbench = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.btnUpdates = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWorkbench)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdates)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "JCon Contact Tracing";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "download_52px.png");
            this.imageList1.Images.SetKeyName(1, "downpx.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(321, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "JCon Contact Tracing";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdates);
            this.panel2.Controls.Add(this.btnWorkbench);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 57);
            this.panel2.TabIndex = 8;
            // 
            // btnWorkbench
            // 
            this.btnWorkbench.BackColor = System.Drawing.Color.SeaGreen;
            this.btnWorkbench.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkbench.Image")));
            this.btnWorkbench.ImageActive = null;
            this.btnWorkbench.Location = new System.Drawing.Point(495, 0);
            this.btnWorkbench.Name = "btnWorkbench";
            this.btnWorkbench.Size = new System.Drawing.Size(58, 57);
            this.btnWorkbench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnWorkbench.TabIndex = 2;
            this.btnWorkbench.TabStop = false;
            this.btnWorkbench.Zoom = 10;
            this.btnWorkbench.Click += new System.EventHandler(this.btnWorkbench_Click);
            // 
            // PanelForms
            // 
            this.PanelForms.Location = new System.Drawing.Point(12, 76);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(870, 495);
            this.PanelForms.TabIndex = 9;
            // 
            // btnUpdates
            // 
            this.btnUpdates.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdates.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdates.Image")));
            this.btnUpdates.ImageActive = null;
            this.btnUpdates.Location = new System.Drawing.Point(568, 0);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(58, 57);
            this.btnUpdates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdates.TabIndex = 2;
            this.btnUpdates.TabStop = false;
            this.btnUpdates.Zoom = 10;
            this.btnUpdates.Click += new System.EventHandler(this.btnUpdates_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(899, 583);
            this.Controls.Add(this.PanelForms);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Jcon Contact Tracing";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWorkbench)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnWorkbench;
        public System.Windows.Forms.Panel PanelForms;
        private Bunifu.Framework.UI.BunifuImageButton btnUpdates;
    }
}

