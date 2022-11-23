namespace FourDScheduling
{
    partial class CreateSigmaFile
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
            this.listOfElements = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.identification = new System.Windows.Forms.ListView();
            this.nameIdentification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueIdentification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.ifcViewer = new Xbim.Presentation.DrawingControl3D();
            this.quantities = new System.Windows.Forms.ListView();
            this.nameQuantities = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueQuantities = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnIFCfile2 = new System.Windows.Forms.Button();
            this.btnIFCfile = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnDirectory2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfElements
            // 
            this.listOfElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfElements.CheckBoxes = true;
            this.listOfElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.listOfElements.HideSelection = false;
            this.listOfElements.Location = new System.Drawing.Point(0, 0);
            this.listOfElements.Name = "listOfElements";
            this.listOfElements.Size = new System.Drawing.Size(270, 660);
            this.listOfElements.TabIndex = 1;
            this.listOfElements.UseCompatibleStateImageBehavior = false;
            this.listOfElements.View = System.Windows.Forms.View.Details;
            this.listOfElements.Click += new System.EventHandler(this.listView1_Click);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 259;
            // 
            // identification
            // 
            this.identification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.identification.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameIdentification,
            this.valueIdentification});
            this.identification.HideSelection = false;
            this.identification.Location = new System.Drawing.Point(0, 0);
            this.identification.Name = "identification";
            this.identification.Size = new System.Drawing.Size(345, 326);
            this.identification.TabIndex = 2;
            this.identification.UseCompatibleStateImageBehavior = false;
            this.identification.View = System.Windows.Forms.View.Details;
            // 
            // nameIdentification
            // 
            this.nameIdentification.Text = "Name";
            this.nameIdentification.Width = 180;
            // 
            // valueIdentification
            // 
            this.valueIdentification.Text = "Value";
            this.valueIdentification.Width = 145;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(778, 693);
            this.elementHost1.TabIndex = 3;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.ifcViewer;
            // 
            // quantities
            // 
            this.quantities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameQuantities,
            this.valueQuantities});
            this.quantities.HideSelection = false;
            this.quantities.Location = new System.Drawing.Point(0, 0);
            this.quantities.Name = "quantities";
            this.quantities.Size = new System.Drawing.Size(345, 327);
            this.quantities.TabIndex = 4;
            this.quantities.UseCompatibleStateImageBehavior = false;
            this.quantities.View = System.Windows.Forms.View.Details;
            // 
            // nameQuantities
            // 
            this.nameQuantities.Text = "Name";
            this.nameQuantities.Width = 192;
            // 
            // valueQuantities
            // 
            this.valueQuantities.Text = "Value";
            this.valueQuantities.Width = 143;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.elementHost1);
            this.splitContainer1.Size = new System.Drawing.Size(1406, 693);
            this.splitContainer1.SplitterDistance = 624;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnIFCfile2);
            this.splitContainer3.Panel1.Controls.Add(this.btnIFCfile);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(622, 693);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.TabIndex = 6;
            // 
            // btnIFCfile2
            // 
            this.btnIFCfile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIFCfile2.Location = new System.Drawing.Point(583, 0);
            this.btnIFCfile2.Name = "btnIFCfile2";
            this.btnIFCfile2.Size = new System.Drawing.Size(39, 27);
            this.btnIFCfile2.TabIndex = 1;
            this.btnIFCfile2.Text = ". . .";
            this.btnIFCfile2.UseVisualStyleBackColor = true;
            this.btnIFCfile2.Click += new System.EventHandler(this.btnIFCfile2_Click);
            // 
            // btnIFCfile
            // 
            this.btnIFCfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIFCfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIFCfile.Location = new System.Drawing.Point(0, 0);
            this.btnIFCfile.Name = "btnIFCfile";
            this.btnIFCfile.Size = new System.Drawing.Size(571, 27);
            this.btnIFCfile.TabIndex = 0;
            this.btnIFCfile.UseVisualStyleBackColor = true;
            this.btnIFCfile.Click += new System.EventHandler(this.btnIFCfile_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listOfElements);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(622, 660);
            this.splitContainer2.SplitterDistance = 273;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.identification);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.quantities);
            this.splitContainer4.Size = new System.Drawing.Size(345, 660);
            this.splitContainer4.SplitterDistance = 329;
            this.splitContainer4.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 719);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(235, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1230, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Sigma file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectory.Location = new System.Drawing.Point(308, 719);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(636, 28);
            this.btnDirectory.TabIndex = 9;
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnDirectory2
            // 
            this.btnDirectory2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectory2.Location = new System.Drawing.Point(950, 719);
            this.btnDirectory2.Name = "btnDirectory2";
            this.btnDirectory2.Size = new System.Drawing.Size(39, 28);
            this.btnDirectory2.TabIndex = 10;
            this.btnDirectory2.Text = ". . .";
            this.btnDirectory2.UseVisualStyleBackColor = true;
            this.btnDirectory2.Click += new System.EventHandler(this.btnDirectory2_Click);
            // 
            // CreateSigmaFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 759);
            this.Controls.Add(this.btnDirectory2);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(900, 520);
            this.Name = "CreateSigmaFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listOfElements;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ListView identification;
        private System.Windows.Forms.ColumnHeader nameIdentification;
        private System.Windows.Forms.ColumnHeader valueIdentification;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Xbim.Presentation.DrawingControl3D ifcViewer;
        private System.Windows.Forms.ListView quantities;
        private System.Windows.Forms.ColumnHeader nameQuantities;
        private System.Windows.Forms.ColumnHeader valueQuantities;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnDirectory2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnIFCfile2;
        private System.Windows.Forms.Button btnIFCfile;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}