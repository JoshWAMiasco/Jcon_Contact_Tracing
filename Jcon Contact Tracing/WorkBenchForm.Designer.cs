
namespace Jcon_Contact_Tracing
{
    partial class WorkBenchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkBenchForm));
            this.listError = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxDownload = new System.Windows.Forms.PictureBox();
            this.txtboxNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentResult = new System.Windows.Forms.Label();
            this.lstboxSearchItems = new System.Windows.Forms.ListBox();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // listError
            // 
            this.listError.ForeColor = System.Drawing.Color.Green;
            this.listError.FormattingEnabled = true;
            this.listError.HorizontalScrollbar = true;
            this.listError.Location = new System.Drawing.Point(12, 414);
            this.listError.Name = "listError";
            this.listError.Size = new System.Drawing.Size(439, 69);
            this.listError.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.picboxDownload);
            this.panel1.Controls.Add(this.txtboxNotes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCurrentResult);
            this.panel1.Location = new System.Drawing.Point(457, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 470);
            this.panel1.TabIndex = 10;
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
            this.txtboxNotes.Size = new System.Drawing.Size(408, 368);
            this.txtboxNotes.TabIndex = 3;
            this.txtboxNotes.Text = "Some Comment Here";
            this.txtboxNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxNotes_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(146, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notepad";
            // 
            // lblCurrentResult
            // 
            this.lblCurrentResult.AutoSize = true;
            this.lblCurrentResult.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.lblCurrentResult.Location = new System.Drawing.Point(3, 52);
            this.lblCurrentResult.Name = "lblCurrentResult";
            this.lblCurrentResult.Size = new System.Drawing.Size(135, 23);
            this.lblCurrentResult.TabIndex = 1;
            this.lblCurrentResult.Text = "Current Result";
            // 
            // lstboxSearchItems
            // 
            this.lstboxSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.lstboxSearchItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxSearchItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.lstboxSearchItems.FormattingEnabled = true;
            this.lstboxSearchItems.ItemHeight = 19;
            this.lstboxSearchItems.Location = new System.Drawing.Point(12, 121);
            this.lstboxSearchItems.Name = "lstboxSearchItems";
            this.lstboxSearchItems.Size = new System.Drawing.Size(439, 289);
            this.lstboxSearchItems.TabIndex = 9;
            this.lstboxSearchItems.DoubleClick += new System.EventHandler(this.lstboxSearchItems_DoubleClick);
            // 
            // txtboxInput
            // 
            this.txtboxInput.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInput.Location = new System.Drawing.Point(13, 13);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(438, 41);
            this.txtboxInput.TabIndex = 8;
            this.txtboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxInput_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(12, 65);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 28);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Result";
            // 
            // WorkBenchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 495);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.listError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstboxSearchItems);
            this.Controls.Add(this.txtboxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkBenchForm";
            this.Text = "WorkBenchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxDownload;
        private System.Windows.Forms.TextBox txtboxNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentResult;
        private System.Windows.Forms.ListBox lstboxSearchItems;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Label lblResult;
    }
}