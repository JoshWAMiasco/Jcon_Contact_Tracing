
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
            this.listError.ItemHeight = 16;
            this.listError.Location = new System.Drawing.Point(17, 368);
            this.listError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listError.Name = "listError";
            this.listError.Size = new System.Drawing.Size(488, 84);
            this.listError.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.picboxDownload);
            this.panel1.Controls.Add(this.txtboxNotes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCurrentResult);
            this.panel1.Location = new System.Drawing.Point(513, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 434);
            this.panel1.TabIndex = 10;
            // 
            // picboxDownload
            // 
            this.picboxDownload.Enabled = false;
            this.picboxDownload.Image = ((System.Drawing.Image)(resources.GetObject("picboxDownload.Image")));
            this.picboxDownload.Location = new System.Drawing.Point(336, 24);
            this.picboxDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxDownload.Name = "picboxDownload";
            this.picboxDownload.Size = new System.Drawing.Size(73, 68);
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
            this.txtboxNotes.Location = new System.Drawing.Point(9, 107);
            this.txtboxNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxNotes.Multiline = true;
            this.txtboxNotes.Name = "txtboxNotes";
            this.txtboxNotes.Size = new System.Drawing.Size(442, 310);
            this.txtboxNotes.TabIndex = 3;
            this.txtboxNotes.Text = "Some Comment Here";
            this.txtboxNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxNotes_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notepad";
            // 
            // lblCurrentResult
            // 
            this.lblCurrentResult.AutoSize = true;
            this.lblCurrentResult.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.lblCurrentResult.Location = new System.Drawing.Point(4, 64);
            this.lblCurrentResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentResult.Name = "lblCurrentResult";
            this.lblCurrentResult.Size = new System.Drawing.Size(171, 28);
            this.lblCurrentResult.TabIndex = 1;
            this.lblCurrentResult.Text = "Current Result";
            // 
            // lstboxSearchItems
            // 
            this.lstboxSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.lstboxSearchItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxSearchItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.lstboxSearchItems.FormattingEnabled = true;
            this.lstboxSearchItems.ItemHeight = 23;
            this.lstboxSearchItems.Location = new System.Drawing.Point(16, 149);
            this.lstboxSearchItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstboxSearchItems.Name = "lstboxSearchItems";
            this.lstboxSearchItems.Size = new System.Drawing.Size(489, 211);
            this.lstboxSearchItems.TabIndex = 9;
            this.lstboxSearchItems.DoubleClick += new System.EventHandler(this.lstboxSearchItems_DoubleClick);
            // 
            // txtboxInput
            // 
            this.txtboxInput.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInput.Location = new System.Drawing.Point(17, 16);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(488, 49);
            this.txtboxInput.TabIndex = 8;
            this.txtboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxInput_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(16, 80);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 37);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Result";
            // 
            // WorkBenchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(991, 465);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstboxSearchItems);
            this.Controls.Add(this.txtboxInput);
            this.Controls.Add(this.listError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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