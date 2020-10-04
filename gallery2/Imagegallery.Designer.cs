extern alias fx;

using fx::C1.C1Pdf;

namespace gallery2
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        private C1PdfDocument c1PdfDocument1;
        private System.Windows.Forms.SplitContainer s;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _searchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox _search;
        private System.Windows.Forms.PictureBox _exportImage;
        private C1.Win.C1Tile.C1TileControl _imageTileControl;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private C1.Win.C1Tile.Tile tile2;
        private C1.Win.C1Tile.Tile tile3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private C1.Win.C1Tile.Tile tile4;
        private C1.Win.C1Tile.Tile tile5;
        private C1.Win.C1Tile.Tile tile6;
        private C1.Win.C1Tile.Tile tile7;
        private C1.Win.C1Tile.Tile tile8;
        private C1.Win.C1Tile.Tile tile9;
       
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

        

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            this.s = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPane = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this.tile4 = new C1.Win.C1Tile.Tile();
            this.tile5 = new C1.Win.C1Tile.Tile();
            this.tile6 = new C1.Win.C1Tile.Tile();
            this.tile7 = new C1.Win.C1Tile.Tile();
            this.tile8 = new C1.Win.C1Tile.Tile();
            this.tile9 = new C1.Win.C1Tile.Tile();
            this._exportImage = new System.Windows.Forms.PictureBox();
            this.c1PdfDocument1 = new fx::C1.C1Pdf.C1PdfDocument();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            this.s.Panel1.SuspendLayout();
            this.s.Panel2.SuspendLayout();
            this.s.SuspendLayout();
            this.tableLayoutPane.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).BeginInit();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.s.IsSplitterFixed = true;
            this.s.Location = new System.Drawing.Point(0, 0);
            this.s.Margin = new System.Windows.Forms.Padding(2);
            this.s.Name = "s";
            this.s.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // s.Panel1
            // 
            this.s.Panel1.Controls.Add(this.tableLayoutPane);
            // 
            // s.Panel2
            // 
            this.s.Panel2.Controls.Add(this.statusStrip);
            this.s.Panel2.Controls.Add(this._imageTileControl);
            this.s.Panel2.Controls.Add(this._exportImage);
            this.s.Size = new System.Drawing.Size(764, 749);
            this.s.SplitterDistance = 40;
            this.s.TabIndex = 0;
            // 
            // tableLayoutPane
            // 
            this.tableLayoutPane.ColumnCount = 3;
            this.tableLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPane.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPane.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPane.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPane.Name = "tableLayoutPane";
            this.tableLayoutPane.RowCount = 1;
            this.tableLayoutPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPane.Size = new System.Drawing.Size(764, 40);
            this.tableLayoutPane.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(194, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // _searchBox
            // 
            this._searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._searchBox.Location = new System.Drawing.Point(16, 9);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(324, 13);
            this._searchBox.TabIndex = 0;
            this._searchBox.Text = "Search Image";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._search);
            this.panel2.Location = new System.Drawing.Point(479, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 12, 45, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 16);
            this.panel2.TabIndex = 1;
            // 
            // _search
            // 
            this._search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._search.Image = ((System.Drawing.Image)(resources.GetObject("_search.Image")));
            this._search.Location = new System.Drawing.Point(4, 1);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(40, 16);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 0;
            this._search.TabStop = false;
            this._search.Click += new System.EventHandler(this._search_ClickAsync);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 683);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(764, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // _imageTileControl
            // 
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.CellHeight = 85;
            this._imageTileControl.CellSpacing = 35;
            this._imageTileControl.CellWidth = 85;
            // 
            // 
            // 
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            this._imageTileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageTileControl.GroupPadding = new System.Windows.Forms.Padding(20, 40, 20, 40);
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.Location = new System.Drawing.Point(0, 0);
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Orientation = C1.Win.C1Tile.LayoutOrientation.Vertical;
            this._imageTileControl.Size = new System.Drawing.Size(764, 705);
            this._imageTileControl.SurfacePadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 20;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TabIndex = 3;
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileUnchecked);
            this._imageTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this._imageTileControl_Paint);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            this.group1.Tiles.Add(this.tile4);
            this.group1.Tiles.Add(this.tile5);
            this.group1.Tiles.Add(this.tile6);
            this.group1.Tiles.Add(this.tile7);
            this.group1.Tiles.Add(this.tile8);
            this.group1.Tiles.Add(this.tile9);
            // 
            // tile1
            // 
            this.tile1.Name = "tile1";
            // 
            // tile2
            // 
            this.tile2.Name = "tile2";
            // 
            // tile3
            // 
            this.tile3.Name = "tile3";
            // 
            // tile4
            // 
            this.tile4.Name = "tile4";
            this.tile4.Text = "Tile 4";
            // 
            // tile5
            // 
            this.tile5.Name = "tile5";
            // 
            // tile6
            // 
            this.tile6.Name = "tile6";
            // 
            // tile7
            // 
            this.tile7.Name = "tile7";
            // 
            // tile8
            // 
            this.tile8.Name = "tile8";
            // 
            // tile9
            // 
            this.tile9.Name = "tile9";
            // 
            // _exportImage
            // 
            this._exportImage.Image = ((System.Drawing.Image)(resources.GetObject("_exportImage.Image")));
            this._exportImage.Location = new System.Drawing.Point(29, 3);
            this._exportImage.Name = "_exportImage";
            this._exportImage.Size = new System.Drawing.Size(135, 28);
            this._exportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._exportImage.TabIndex = 3;
            this._exportImage.TabStop = false;
            this._exportImage.Visible = false;
            this._exportImage.Click += new System.EventHandler(this._exportImage_Click);
            this._exportImage.Paint += new System.Windows.Forms.PaintEventHandler(this._exportImage_Paint);
            // 
            // c1PdfDocument1
            // 
            this.c1PdfDocument1.DocumentInfo.Author = "";
            this.c1PdfDocument1.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.c1PdfDocument1.DocumentInfo.Creator = "";
            this.c1PdfDocument1.DocumentInfo.Keywords = "";
            this.c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.c1PdfDocument1.DocumentInfo.Subject = "";
            this.c1PdfDocument1.DocumentInfo.Title = "";
            this.c1PdfDocument1.MaxHeaderBookmarkLevel = 0;
            this.c1PdfDocument1.RotateAngle = 0F;
            this.c1PdfDocument1.UseFastTextOut = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(764, 749);
            this.Controls.Add(this.s);
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery";
            this.s.Panel1.ResumeLayout(false);
            this.s.Panel2.ResumeLayout(false);
            this.s.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            this.s.ResumeLayout(false);
            this.tableLayoutPane.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).EndInit();
            this.ResumeLayout(false);

        }

       

        
        
    }
}

