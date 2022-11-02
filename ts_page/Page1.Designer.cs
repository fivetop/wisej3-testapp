namespace ts_page
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.navigationBar1 = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navigationBarItem1 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem2 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 63);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "Panel1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = Wisej.Web.DockStyle.Left;
            this.navigationBar1.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navigationBarItem1,
            this.navigationBarItem2});
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(239, 550);
            this.navigationBar1.TabIndex = 2;
            this.navigationBar1.Text = "navigationBar1";
            this.navigationBar1.SelectedItemChanged += new System.EventHandler(this.navigationBar1_SelectedItemChanged);
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem1.Name = "NavigationBarItem";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem2.Name = "NavigationBarItem";
            this.navigationBarItem2.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 487);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(239, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 550);
            this.panel3.TabIndex = 4;
            this.panel3.Text = "Panel1";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.navigationBar1);
            this.Dock = Wisej.Web.DockStyle.None;
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1461, 550);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.Button button1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button button3;
        private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar1;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarItem1;
        private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarItem2;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel3;
    }
}

