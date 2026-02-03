
namespace MY_Mini_Ağrı_Projesi
{
    partial class Frmnufuslar
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
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Merkez");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Doğubeyazıt");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Patnos");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Diyadin");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Eleşkirt");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Taşlıçay");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Tutak");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Hamur");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Ağrı", new System.Windows.Forms.TreeNode[] {
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95,
            treeNode96,
            treeNode97,
            treeNode98});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode91.Name = "Node1";
            treeNode91.Text = "Merkez";
            treeNode92.Name = "Node2";
            treeNode92.Text = "Doğubeyazıt";
            treeNode93.Name = "Node3";
            treeNode93.Text = "Patnos";
            treeNode94.Name = "Node4";
            treeNode94.Text = "Diyadin";
            treeNode95.Name = "Node5";
            treeNode95.Text = "Eleşkirt";
            treeNode96.Name = "Node6";
            treeNode96.Text = "Taşlıçay";
            treeNode97.Name = "Node7";
            treeNode97.Text = "Tutak";
            treeNode98.Name = "Node8";
            treeNode98.Text = "Hamur";
            treeNode99.Name = "Node0";
            treeNode99.Text = "Ağrı";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode99});
            this.treeView1.Size = new System.Drawing.Size(776, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(350, 221);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(438, 217);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(12, 189);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(332, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 221);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 217);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İlçe Adı";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nüfus";
            this.columnHeader2.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "%123";
            // 
            // Frmnufuslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Frmnufuslar";
            this.Text = "Frmnufuslar";
            this.Load += new System.EventHandler(this.Frmnufuslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
    }
}