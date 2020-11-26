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
            this.txtboxResultNote = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCurrentResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picboxDownload = new System.Windows.Forms.PictureBox();
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
            this.txtboxInput.Size = new System.Drawing.Size(422, 41);
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
            this.lblResult.Size = new System.Drawing.Size(79, 28);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // lstboxSearchItems
            // 
            this.lstboxSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.lstboxSearchItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxSearchItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.lstboxSearchItems.FormattingEnabled = true;
            this.lstboxSearchItems.ItemHeight = 19;
            this.lstboxSearchItems.Location = new System.Drawing.Point(17, 212);
            this.lstboxSearchItems.Name = "lstboxSearchItems";
            this.lstboxSearchItems.Size = new System.Drawing.Size(423, 251);
            this.lstboxSearchItems.TabIndex = 2;
            // 
            // txtboxResultNote
            // 
            this.txtboxResultNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.txtboxResultNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxResultNote.Enabled = false;
            this.txtboxResultNote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxResultNote.Location = new System.Drawing.Point(7, 87);
            this.txtboxResultNote.Multiline = true;
            this.txtboxResultNote.Name = "txtboxResultNote";
            this.txtboxResultNote.Size = new System.Drawing.Size(408, 242);
            this.txtboxResultNote.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.ImageKey = "(none)";
            this.btnSubmit.Location = new System.Drawing.Point(48, 489);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 55);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCurrentResult
            // 
            this.lblCurrentResult.AutoSize = true;
            this.lblCurrentResult.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.lblCurrentResult.Location = new System.Drawing.Point(9, 47);
            this.lblCurrentResult.Name = "lblCurrentResult";
            this.lblCurrentResult.Size = new System.Drawing.Size(135, 23);
            this.lblCurrentResult.TabIndex = 1;
            this.lblCurrentResult.Text = "Current Result";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(179, 489);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 55);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(303, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 55);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.txtboxResultNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCurrentResult);
            this.panel1.Location = new System.Drawing.Point(457, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 334);
            this.panel1.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 28);
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
            // picboxDownload
            // 
            this.picboxDownload.Image = ((System.Drawing.Image)(resources.GetObject("picboxDownload.Image")));
            this.picboxDownload.Location = new System.Drawing.Point(817, 489);
            this.picboxDownload.Name = "picboxDownload";
            this.picboxDownload.Size = new System.Drawing.Size(55, 55);
            this.picboxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDownload.TabIndex = 6;
            this.picboxDownload.TabStop = false;
            this.picboxDownload.MouseLeave += new System.EventHandler(this.picboxDownload_MouseLeave);
            this.picboxDownload.MouseHover += new System.EventHandler(this.picboxDownload_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(342, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "version 1.0";
            // 
            // listError
            // 
            this.listError.ForeColor = System.Drawing.Color.Green;
            this.listError.FormattingEnabled = true;
            this.listError.HorizontalScrollbar = true;
            this.listError.ItemHeight = 17;
            this.listError.Location = new System.Drawing.Point(18, 136);
            this.listError.Name = "listError";
            this.listError.Size = new System.Drawing.Size(422, 55);
            this.listError.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(902, 562);
            this.Controls.Add(this.picboxDownload);
            this.Controls.Add(this.listError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubmit);
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
        private System.Windows.Forms.TextBox txtboxResultNote;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCurrentResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picboxDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listError;
    }
}

