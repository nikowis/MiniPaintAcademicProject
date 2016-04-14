namespace PwsgWinFormsLab2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elipsaButton = new System.Windows.Forms.Button();
            this.prostokatButton = new System.Windows.Forms.Button();
            this.liniaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Blue;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            this.splitContainer1.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseUp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(893, 563);
            this.splitContainer1.SplitterDistance = 666;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elipsaButton);
            this.groupBox1.Controls.Add(this.prostokatButton);
            this.groupBox1.Controls.Add(this.liniaButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rysowanie";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // elipsaButton
            // 
            this.elipsaButton.Location = new System.Drawing.Point(22, 77);
            this.elipsaButton.Name = "elipsaButton";
            this.elipsaButton.Size = new System.Drawing.Size(75, 23);
            this.elipsaButton.TabIndex = 2;
            this.elipsaButton.Text = "Elipsa";
            this.elipsaButton.UseVisualStyleBackColor = true;
            this.elipsaButton.Click += new System.EventHandler(this.elipsaButton_Click);
            // 
            // prostokatButton
            // 
            this.prostokatButton.Location = new System.Drawing.Point(22, 48);
            this.prostokatButton.Name = "prostokatButton";
            this.prostokatButton.Size = new System.Drawing.Size(75, 23);
            this.prostokatButton.TabIndex = 1;
            this.prostokatButton.Text = "Prostokąt";
            this.prostokatButton.UseVisualStyleBackColor = true;
            this.prostokatButton.Click += new System.EventHandler(this.prostokatButton_Click);
            // 
            // liniaButton
            // 
            this.liniaButton.Location = new System.Drawing.Point(22, 19);
            this.liniaButton.Name = "liniaButton";
            this.liniaButton.Size = new System.Drawing.Size(75, 23);
            this.liniaButton.TabIndex = 0;
            this.liniaButton.Text = "Linia";
            this.liniaButton.UseVisualStyleBackColor = true;
            this.liniaButton.Click += new System.EventHandler(this.liniaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 563);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Drawing Transparent";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button elipsaButton;
        private System.Windows.Forms.Button prostokatButton;
        private System.Windows.Forms.Button liniaButton;
    }
}

