﻿namespace FlatUI
{
  partial class Principal
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
      this.MenuPanel = new System.Windows.Forms.Panel();
      this.VendedoresBtn = new System.Windows.Forms.Button();
      this.ClienteBtn = new System.Windows.Forms.Button();
      this.ProdutoBtn = new System.Windows.Forms.Button();
      this.VendaBtn = new System.Windows.Forms.Button();
      this.PanelProfile = new System.Windows.Forms.Panel();
      this.BtnProfile = new System.Windows.Forms.Button();
      this.PanelHeader = new System.Windows.Forms.Panel();
      this.BtnClose = new System.Windows.Forms.Button();
      this.BtnMinimize = new System.Windows.Forms.Button();
      this.BtnMaximizeRestore = new System.Windows.Forms.Button();
      this.BtnCloseChildForm = new System.Windows.Forms.Button();
      this.LabelHeader = new System.Windows.Forms.Label();
      this.PanelDesktop = new System.Windows.Forms.Panel();
      this.MenuPanel.SuspendLayout();
      this.PanelProfile.SuspendLayout();
      this.PanelHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // MenuPanel
      // 
      this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.MenuPanel.BackColor = System.Drawing.Color.White;
      this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.MenuPanel.Controls.Add(this.VendedoresBtn);
      this.MenuPanel.Controls.Add(this.ClienteBtn);
      this.MenuPanel.Controls.Add(this.ProdutoBtn);
      this.MenuPanel.Controls.Add(this.VendaBtn);
      this.MenuPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.MenuPanel.Location = new System.Drawing.Point(0, 152);
      this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
      this.MenuPanel.Name = "MenuPanel";
      this.MenuPanel.Size = new System.Drawing.Size(239, 421);
      this.MenuPanel.TabIndex = 0;
      // 
      // VendedoresBtn
      // 
      this.VendedoresBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.VendedoresBtn.FlatAppearance.BorderSize = 0;
      this.VendedoresBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.VendedoresBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.VendedoresBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.VendedoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.VendedoresBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.VendedoresBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.VendedoresBtn.Image = global::FlatUI.Properties.Resources.icons8_supplier_48;
      this.VendedoresBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.VendedoresBtn.Location = new System.Drawing.Point(0, 180);
      this.VendedoresBtn.Margin = new System.Windows.Forms.Padding(0);
      this.VendedoresBtn.Name = "VendedoresBtn";
      this.VendedoresBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.VendedoresBtn.Size = new System.Drawing.Size(235, 60);
      this.VendedoresBtn.TabIndex = 5;
      this.VendedoresBtn.Text = " Vendedores";
      this.VendedoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.VendedoresBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.VendedoresBtn.UseVisualStyleBackColor = true;
      this.VendedoresBtn.Click += new System.EventHandler(this.VendedoresBtn_Click);
      // 
      // ClienteBtn
      // 
      this.ClienteBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.ClienteBtn.FlatAppearance.BorderSize = 0;
      this.ClienteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.ClienteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.ClienteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.ClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ClienteBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ClienteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.ClienteBtn.Image = global::FlatUI.Properties.Resources.icons8_customer_48;
      this.ClienteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ClienteBtn.Location = new System.Drawing.Point(0, 120);
      this.ClienteBtn.Margin = new System.Windows.Forms.Padding(0);
      this.ClienteBtn.Name = "ClienteBtn";
      this.ClienteBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.ClienteBtn.Size = new System.Drawing.Size(235, 60);
      this.ClienteBtn.TabIndex = 3;
      this.ClienteBtn.Text = " Cliente";
      this.ClienteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ClienteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ClienteBtn.UseVisualStyleBackColor = true;
      this.ClienteBtn.Click += new System.EventHandler(this.ClienteBtn_Click);
      // 
      // ProdutoBtn
      // 
      this.ProdutoBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.ProdutoBtn.FlatAppearance.BorderSize = 0;
      this.ProdutoBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.ProdutoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.ProdutoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.ProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ProdutoBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ProdutoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.ProdutoBtn.Image = global::FlatUI.Properties.Resources.icons8_product_48;
      this.ProdutoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ProdutoBtn.Location = new System.Drawing.Point(0, 60);
      this.ProdutoBtn.Margin = new System.Windows.Forms.Padding(0);
      this.ProdutoBtn.Name = "ProdutoBtn";
      this.ProdutoBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.ProdutoBtn.Size = new System.Drawing.Size(235, 60);
      this.ProdutoBtn.TabIndex = 2;
      this.ProdutoBtn.Text = " Produto";
      this.ProdutoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ProdutoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ProdutoBtn.UseVisualStyleBackColor = true;
      this.ProdutoBtn.Click += new System.EventHandler(this.ProdutoBtn_Click);
      // 
      // VendaBtn
      // 
      this.VendaBtn.Dock = System.Windows.Forms.DockStyle.Top;
      this.VendaBtn.FlatAppearance.BorderSize = 0;
      this.VendaBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.VendaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
      this.VendaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
      this.VendaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.VendaBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.VendaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.VendaBtn.Image = global::FlatUI.Properties.Resources.icons8_shopping_cart_48;
      this.VendaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.VendaBtn.Location = new System.Drawing.Point(0, 0);
      this.VendaBtn.Margin = new System.Windows.Forms.Padding(0);
      this.VendaBtn.Name = "VendaBtn";
      this.VendaBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
      this.VendaBtn.Size = new System.Drawing.Size(235, 60);
      this.VendaBtn.TabIndex = 1;
      this.VendaBtn.Tag = "";
      this.VendaBtn.Text = " Venda";
      this.VendaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.VendaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.VendaBtn.UseVisualStyleBackColor = true;
      this.VendaBtn.Click += new System.EventHandler(this.VendaBtn_Click);
      // 
      // PanelProfile
      // 
      this.PanelProfile.BackColor = System.Drawing.Color.White;
      this.PanelProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PanelProfile.Controls.Add(this.BtnProfile);
      this.PanelProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.PanelProfile.Location = new System.Drawing.Point(0, 0);
      this.PanelProfile.Margin = new System.Windows.Forms.Padding(0);
      this.PanelProfile.Name = "PanelProfile";
      this.PanelProfile.Size = new System.Drawing.Size(239, 154);
      this.PanelProfile.TabIndex = 0;
      // 
      // BtnProfile
      // 
      this.BtnProfile.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BtnProfile.FlatAppearance.BorderSize = 0;
      this.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnProfile.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.BtnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.BtnProfile.Image = global::FlatUI.Properties.Resources.male_user_96px2;
      this.BtnProfile.Location = new System.Drawing.Point(0, 0);
      this.BtnProfile.Margin = new System.Windows.Forms.Padding(0);
      this.BtnProfile.Name = "BtnProfile";
      this.BtnProfile.Size = new System.Drawing.Size(235, 150);
      this.BtnProfile.TabIndex = 3;
      this.BtnProfile.Tag = "";
      this.BtnProfile.Text = "Victor Rodrigues";
      this.BtnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.BtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.BtnProfile.UseVisualStyleBackColor = true;
      // 
      // PanelHeader
      // 
      this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PanelHeader.BackColor = System.Drawing.Color.White;
      this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.PanelHeader.Controls.Add(this.BtnClose);
      this.PanelHeader.Controls.Add(this.BtnMinimize);
      this.PanelHeader.Controls.Add(this.BtnMaximizeRestore);
      this.PanelHeader.Controls.Add(this.BtnCloseChildForm);
      this.PanelHeader.Controls.Add(this.LabelHeader);
      this.PanelHeader.Location = new System.Drawing.Point(237, 0);
      this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
      this.PanelHeader.Name = "PanelHeader";
      this.PanelHeader.Size = new System.Drawing.Size(845, 80);
      this.PanelHeader.TabIndex = 0;
      // 
      // BtnClose
      // 
      this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.BtnClose.AutoSize = true;
      this.BtnClose.FlatAppearance.BorderSize = 0;
      this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnClose.Image = global::FlatUI.Properties.Resources.icons8_close_32;
      this.BtnClose.Location = new System.Drawing.Point(803, 0);
      this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(38, 38);
      this.BtnClose.TabIndex = 2;
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // BtnMinimize
      // 
      this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnMinimize.AutoSize = true;
      this.BtnMinimize.FlatAppearance.BorderSize = 0;
      this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMinimize.Image = global::FlatUI.Properties.Resources.icons8_minimize_window_32;
      this.BtnMinimize.Location = new System.Drawing.Point(727, 0);
      this.BtnMinimize.Margin = new System.Windows.Forms.Padding(0);
      this.BtnMinimize.Name = "BtnMinimize";
      this.BtnMinimize.Size = new System.Drawing.Size(38, 38);
      this.BtnMinimize.TabIndex = 4;
      this.BtnMinimize.UseVisualStyleBackColor = true;
      this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
      // 
      // BtnMaximizeRestore
      // 
      this.BtnMaximizeRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnMaximizeRestore.AutoSize = true;
      this.BtnMaximizeRestore.FlatAppearance.BorderSize = 0;
      this.BtnMaximizeRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMaximizeRestore.Image = global::FlatUI.Properties.Resources.icons8_maximize_button_32;
      this.BtnMaximizeRestore.Location = new System.Drawing.Point(765, 0);
      this.BtnMaximizeRestore.Margin = new System.Windows.Forms.Padding(0);
      this.BtnMaximizeRestore.Name = "BtnMaximizeRestore";
      this.BtnMaximizeRestore.Size = new System.Drawing.Size(38, 38);
      this.BtnMaximizeRestore.TabIndex = 3;
      this.BtnMaximizeRestore.UseVisualStyleBackColor = true;
      this.BtnMaximizeRestore.Click += new System.EventHandler(this.BtnMaximizeRestore_Click);
      // 
      // BtnCloseChildForm
      // 
      this.BtnCloseChildForm.AutoSize = true;
      this.BtnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
      this.BtnCloseChildForm.FlatAppearance.BorderSize = 0;
      this.BtnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseChildForm.Image")));
      this.BtnCloseChildForm.Location = new System.Drawing.Point(0, 0);
      this.BtnCloseChildForm.Margin = new System.Windows.Forms.Padding(0);
      this.BtnCloseChildForm.Name = "BtnCloseChildForm";
      this.BtnCloseChildForm.Size = new System.Drawing.Size(63, 76);
      this.BtnCloseChildForm.TabIndex = 1;
      this.BtnCloseChildForm.UseVisualStyleBackColor = true;
      this.BtnCloseChildForm.Visible = false;
      this.BtnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
      // 
      // LabelHeader
      // 
      this.LabelHeader.BackColor = System.Drawing.Color.White;
      this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.LabelHeader.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(27)))));
      this.LabelHeader.Location = new System.Drawing.Point(0, 0);
      this.LabelHeader.Margin = new System.Windows.Forms.Padding(0);
      this.LabelHeader.Name = "LabelHeader";
      this.LabelHeader.Size = new System.Drawing.Size(841, 76);
      this.LabelHeader.TabIndex = 0;
      this.LabelHeader.Text = "Ether ERP";
      this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.LabelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelHeader_MouseDown);
      // 
      // PanelDesktop
      // 
      this.PanelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.PanelDesktop.ForeColor = System.Drawing.Color.Black;
      this.PanelDesktop.Location = new System.Drawing.Point(237, 80);
      this.PanelDesktop.Margin = new System.Windows.Forms.Padding(0);
      this.PanelDesktop.Name = "PanelDesktop";
      this.PanelDesktop.Padding = new System.Windows.Forms.Padding(20);
      this.PanelDesktop.Size = new System.Drawing.Size(845, 493);
      this.PanelDesktop.TabIndex = 2;
      // 
      // Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(1082, 573);
      this.ControlBox = false;
      this.Controls.Add(this.PanelProfile);
      this.Controls.Add(this.MenuPanel);
      this.Controls.Add(this.PanelHeader);
      this.Controls.Add(this.PanelDesktop);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.MinimumSize = new System.Drawing.Size(950, 500);
      this.Name = "Principal";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Ether Solutions";
      this.MenuPanel.ResumeLayout(false);
      this.PanelProfile.ResumeLayout(false);
      this.PanelHeader.ResumeLayout(false);
      this.PanelHeader.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Panel MenuPanel;
    private Button VendaBtn;
    private Panel PanelProfile;
    private Button VendedoresBtn;
    private Button ClienteBtn;
    private Button ProdutoBtn;
    private Panel PanelHeader;
    private Label LabelHeader;
    private Panel PanelDesktop;
    private Button BtnProfile;
    private Button BtnCloseChildForm;
    private Button BtnClose;
    private Button BtnMinimize;
    private Button BtnMaximizeRestore;
  }
}