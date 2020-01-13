namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataView1 = new System.Data.DataView();
            this.dataView2 = new System.Data.DataView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hayvan Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "accept.ico");
            this.ımageList1.Images.SetKeyName(1, "back.ico");
            this.ımageList1.Images.SetKeyName(2, "bt-play.ico");
            this.ımageList1.Images.SetKeyName(3, "bt-skip-rw.ico");
            this.ımageList1.Images.SetKeyName(4, "Delete.ico");
            this.ımageList1.Images.SetKeyName(5, "floppyj.ico");
            this.ımageList1.Images.SetKeyName(6, "Floppyn.ico");
            this.ımageList1.Images.SetKeyName(7, "HP-Documents-Folder.ico");
            this.ımageList1.Images.SetKeyName(8, "HP-FolderMusic.ico");
            this.ımageList1.Images.SetKeyName(9, "HP-Pictures-Folder.ico");
            this.ımageList1.Images.SetKeyName(10, "snake-4.ico");
            this.ımageList1.Images.SetKeyName(11, "taxi.ico");
            this.ımageList1.Images.SetKeyName(12, "Tips.ico");
            this.ımageList1.Images.SetKeyName(13, "Error.ico");
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 10;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(103, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hayvansever Kayıt";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 13;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(195, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "Çıkış";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(12, 116);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(420, 184);
            this.dataGrid1.TabIndex = 3;
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(12, 319);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(634, 208);
            this.dataGrid2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hayvan Kayıt Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hayvansever Kayıt Bilgileri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGrid dataGrid2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Data.DataView dataView1;
        private System.Data.DataView dataView2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

