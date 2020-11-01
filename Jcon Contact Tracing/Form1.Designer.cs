namespace Jcon_Contact_Tracing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstboxResults = new System.Windows.Forms.ListBox();
            this.txtboxResultNote = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCurrentResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTakeNote = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSaveData = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxInput
            // 
            this.txtboxInput.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxInput.Location = new System.Drawing.Point(12, 77);
            this.txtboxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(378, 41);
            this.txtboxInput.TabIndex = 0;
            this.txtboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxInput_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.lblResult.Location = new System.Drawing.Point(12, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(84, 28);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            this.lblResult.Visible = false;
            // 
            // lstboxResults
            // 
            this.lstboxResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.lstboxResults.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.lstboxResults.FormattingEnabled = true;
            this.lstboxResults.ItemHeight = 19;
            this.lstboxResults.Location = new System.Drawing.Point(12, 174);
            this.lstboxResults.Name = "lstboxResults";
            this.lstboxResults.Size = new System.Drawing.Size(378, 156);
            this.lstboxResults.TabIndex = 2;
            this.lstboxResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstboxResults_MouseDoubleClick);
            // 
            // txtboxResultNote
            // 
            this.txtboxResultNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.txtboxResultNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxResultNote.Enabled = false;
            this.txtboxResultNote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxResultNote.Location = new System.Drawing.Point(12, 59);
            this.txtboxResultNote.Multiline = true;
            this.txtboxResultNote.Name = "txtboxResultNote";
            this.txtboxResultNote.Size = new System.Drawing.Size(352, 151);
            this.txtboxResultNote.TabIndex = 3;
            this.txtboxResultNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxResultNote_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.ImageKey = "(none)";
            this.btnSubmit.Location = new System.Drawing.Point(12, 580);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 40);
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
            this.lblCurrentResult.Location = new System.Drawing.Point(111, 13);
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
            this.btnAdd.Location = new System.Drawing.Point(102, 580);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTakeNote
            // 
            this.btnTakeNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(122)))));
            this.btnTakeNote.Enabled = false;
            this.btnTakeNote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeNote.ForeColor = System.Drawing.Color.Black;
            this.btnTakeNote.Location = new System.Drawing.Point(179, 580);
            this.btnTakeNote.Name = "btnTakeNote";
            this.btnTakeNote.Size = new System.Drawing.Size(95, 40);
            this.btnTakeNote.TabIndex = 4;
            this.btnTakeNote.Text = "Take Note";
            this.btnTakeNote.UseVisualStyleBackColor = false;
            this.btnTakeNote.Click += new System.EventHandler(this.btnTakeNote_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.txtboxResultNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCurrentResult);
            this.panel1.Location = new System.Drawing.Point(12, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 225);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notepad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "J Con Contact Tracing";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picSaveData
            // 
            this.picSaveData.Image = ((System.Drawing.Image)(resources.GetObject("picSaveData.Image")));
            this.picSaveData.Location = new System.Drawing.Point(337, 572);
            this.picSaveData.Name = "picSaveData";
            this.picSaveData.Size = new System.Drawing.Size(52, 48);
            this.picSaveData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaveData.TabIndex = 6;
            this.picSaveData.TabStop = false;
            this.picSaveData.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(401, 632);
            this.Controls.Add(this.picSaveData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTakeNote);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstboxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtboxInput);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Jcon Contact Tracing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstboxResults;
        private System.Windows.Forms.TextBox txtboxResultNote;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCurrentResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTakeNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picSaveData;
    }
}

