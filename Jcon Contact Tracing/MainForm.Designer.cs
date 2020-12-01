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
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstboxSearchItems = new System.Windows.Forms.ListBox();
            this.txtboxNotes = new System.Windows.Forms.TextBox();
            this.lblCurrentResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxDownload = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.listError = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxInput
            // 
            this.txtboxInput.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInput.Location = new System.Drawing.Point(18, 73);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(422, 49);
            this.txtboxInput.TabIndex = 0;
            this.txtboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxInput_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.lblResult.Location = new System.Drawing.Point(457, 78);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 37);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // lstboxSearchItems
            // 
            this.lstboxSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.lstboxSearchItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxSearchItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.lstboxSearchItems.FormattingEnabled = true;
            this.lstboxSearchItems.ItemHeight = 23;
            this.lstboxSearchItems.Location = new System.Drawing.Point(18, 235);
            this.lstboxSearchItems.Name = "lstboxSearchItems";
            this.lstboxSearchItems.Size = new System.Drawing.Size(423, 234);
            this.lstboxSearchItems.TabIndex = 2;
            this.lstboxSearchItems.DoubleClick += new System.EventHandler(this.lstboxSearchItems_DoubleClick);
            // 
            // txtboxNotes
            // 
            this.txtboxNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.txtboxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNotes.Enabled = false;
            this.txtboxNotes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNotes.ForeColor = System.Drawing.Color.Red;
            this.txtboxNotes.Location = new System.Drawing.Point(7, 87);
            this.txtboxNotes.Multiline = true;
            this.txtboxNotes.Name = "txtboxNotes";
            this.txtboxNotes.Size = new System.Drawing.Size(408, 242);
            this.txtboxNotes.TabIndex = 3;
            this.txtboxNotes.Text = "Some Comment Here";
            this.txtboxNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxNotes_KeyDown);
            // 
            // lblCurrentResult
            // 
            this.lblCurrentResult.AutoSize = true;
            this.lblCurrentResult.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.lblCurrentResult.Location = new System.Drawing.Point(9, 47);
            this.lblCurrentResult.Name = "lblCurrentResult";
            this.lblCurrentResult.Size = new System.Drawing.Size(171, 28);
            this.lblCurrentResult.TabIndex = 1;
            this.lblCurrentResult.Text = "Current Result";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.picboxDownload);
            this.panel1.Controls.Add(this.txtboxNotes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCurrentResult);
            this.panel1.Location = new System.Drawing.Point(457, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 334);
            this.panel1.TabIndex = 5;
            // 
            // picboxDownload
            // 
            this.picboxDownload.Enabled = false;
            this.picboxDownload.Image = ((System.Drawing.Image)(resources.GetObject("picboxDownload.Image")));
            this.picboxDownload.Location = new System.Drawing.Point(349, 20);
            this.picboxDownload.Name = "picboxDownload";
            this.picboxDownload.Size = new System.Drawing.Size(55, 55);
            this.picboxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDownload.TabIndex = 6;
            this.picboxDownload.TabStop = false;
            this.picboxDownload.Click += new System.EventHandler(this.picboxDownload_Click);
            this.picboxDownload.MouseLeave += new System.EventHandler(this.picboxDownload_MouseLeave);
            this.picboxDownload.MouseHover += new System.EventHandler(this.picboxDownload_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(146, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notepad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(266, 9);
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
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(792, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "version 1.0";
            // 
            // listError
            // 
            this.listError.ForeColor = System.Drawing.Color.Green;
            this.listError.FormattingEnabled = true;
            this.listError.HorizontalScrollbar = true;
            this.listError.ItemHeight = 20;
            this.listError.Location = new System.Drawing.Point(18, 136);
            this.listError.Name = "listError";
            this.listError.Size = new System.Drawing.Size(422, 84);
            this.listError.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(902, 492);
            this.Controls.Add(this.listError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstboxSearchItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtboxInput);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Jcon Contact Tracing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstboxSearchItems;
        private System.Windows.Forms.TextBox txtboxNotes;
        private System.Windows.Forms.Label lblCurrentResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picboxDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listError;
    }
}

