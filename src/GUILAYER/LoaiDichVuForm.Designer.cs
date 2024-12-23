﻿namespace GUILAYER
{
    partial class LoaiDichVuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiDichVuForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.Bar1 = new DevExpress.XtraBars.Bar();
            this.NutThem = new DevExpress.XtraBars.BarButtonItem();
            this.NutSua = new DevExpress.XtraBars.BarButtonItem();
            this.NutXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BarDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.BarDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BangDuLieu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MALOAIDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAIDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Bar1});
            this.BarManager.DockControls.Add(this.BarDockControlTop);
            this.BarManager.DockControls.Add(this.BarDockControlBottom);
            this.BarManager.DockControls.Add(this.BarDockControlLeft);
            this.BarManager.DockControls.Add(this.BarDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.NutThem,
            this.NutXoa,
            this.NutSua});
            this.BarManager.MainMenu = this.Bar1;
            this.BarManager.MaxItemId = 5;
            // 
            // Bar1
            // 
            this.Bar1.BarName = "Main menu";
            this.Bar1.DockCol = 0;
            this.Bar1.DockRow = 0;
            this.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.NutThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.NutSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.NutXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.Bar1.OptionsBar.MultiLine = true;
            this.Bar1.OptionsBar.UseWholeRow = true;
            this.Bar1.Text = "Main menu";
            // 
            // NutThem
            // 
            this.NutThem.Caption = "THÊM";
            this.NutThem.Id = 0;
            this.NutThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutThem.ImageOptions.SvgImage")));
            this.NutThem.Name = "NutThem";
            this.NutThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutThem_ItemClick);
            // 
            // NutSua
            // 
            this.NutSua.Caption = "CẬP NHẬT";
            this.NutSua.Enabled = false;
            this.NutSua.Id = 3;
            this.NutSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutSua.ImageOptions.SvgImage")));
            this.NutSua.Name = "NutSua";
            this.NutSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutSua_ItemClick);
            // 
            // NutXoa
            // 
            this.NutXoa.Caption = "XÓA";
            this.NutXoa.Enabled = false;
            this.NutXoa.Id = 1;
            this.NutXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NutXoa.ImageOptions.SvgImage")));
            this.NutXoa.Name = "NutXoa";
            this.NutXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NutXoa_ItemClick);
            // 
            // BarDockControlTop
            // 
            this.BarDockControlTop.CausesValidation = false;
            this.BarDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.BarDockControlTop.Manager = this.BarManager;
            this.BarDockControlTop.Size = new System.Drawing.Size(1883, 34);
            // 
            // BarDockControlBottom
            // 
            this.BarDockControlBottom.CausesValidation = false;
            this.BarDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarDockControlBottom.Location = new System.Drawing.Point(0, 741);
            this.BarDockControlBottom.Manager = this.BarManager;
            this.BarDockControlBottom.Size = new System.Drawing.Size(1883, 0);
            // 
            // BarDockControlLeft
            // 
            this.BarDockControlLeft.CausesValidation = false;
            this.BarDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.BarDockControlLeft.Manager = this.BarManager;
            this.BarDockControlLeft.Size = new System.Drawing.Size(0, 707);
            // 
            // BarDockControlRight
            // 
            this.BarDockControlRight.CausesValidation = false;
            this.BarDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarDockControlRight.Location = new System.Drawing.Point(1883, 34);
            this.BarDockControlRight.Manager = this.BarManager;
            this.BarDockControlRight.Size = new System.Drawing.Size(0, 707);
            // 
            // BangDuLieu
            // 
            this.BangDuLieu.AllowUserToAddRows = false;
            this.BangDuLieu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangDuLieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BangDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangDuLieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BangDuLieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangDuLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangDuLieu.ColumnHeadersHeight = 40;
            this.BangDuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAIDV,
            this.TENLOAIDV,
            this.MOTA,
            this.Column1});
            this.BangDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangDuLieu.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangDuLieu.EnableHeadersVisualStyles = false;
            this.BangDuLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.BangDuLieu.Location = new System.Drawing.Point(0, 34);
            this.BangDuLieu.Name = "BangDuLieu";
            this.BangDuLieu.ReadOnly = true;
            this.BangDuLieu.RowHeadersVisible = false;
            this.BangDuLieu.RowHeadersWidth = 51;
            this.BangDuLieu.RowTemplate.Height = 40;
            this.BangDuLieu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BangDuLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BangDuLieu.Size = new System.Drawing.Size(1883, 707);
            this.BangDuLieu.TabIndex = 10;
            this.BangDuLieu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BangDuLieu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BangDuLieu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.BangDuLieu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.BangDuLieu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.BangDuLieu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangDuLieu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangDuLieu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BangDuLieu.ThemeStyle.HeaderStyle.Height = 40;
            this.BangDuLieu.ThemeStyle.ReadOnly = true;
            this.BangDuLieu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BangDuLieu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BangDuLieu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangDuLieu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.ThemeStyle.RowsStyle.Height = 40;
            this.BangDuLieu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.BangDuLieu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BangDuLieu.SelectionChanged += new System.EventHandler(this.BangDuLieu_SelectionChanged);
            // 
            // MALOAIDV
            // 
            this.MALOAIDV.DataPropertyName = "MALOAIDV";
            this.MALOAIDV.HeaderText = "MÃ LOẠI DỊCH VỤ";
            this.MALOAIDV.MinimumWidth = 6;
            this.MALOAIDV.Name = "MALOAIDV";
            this.MALOAIDV.ReadOnly = true;
            // 
            // TENLOAIDV
            // 
            this.TENLOAIDV.DataPropertyName = "TENLOAIDV";
            this.TENLOAIDV.HeaderText = "TÊN LOẠI DỊCH VỤ";
            this.TENLOAIDV.MinimumWidth = 6;
            this.TENLOAIDV.Name = "TENLOAIDV";
            this.TENLOAIDV.ReadOnly = true;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "MÔ TẢ";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DICHVU_TBL";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // LoaiDichVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 741);
            this.Controls.Add(this.BangDuLieu);
            this.Controls.Add(this.BarDockControlLeft);
            this.Controls.Add(this.BarDockControlRight);
            this.Controls.Add(this.BarDockControlBottom);
            this.Controls.Add(this.BarDockControlTop);
            this.IconOptions.Image = global::GUILAYER.Properties.Resources.Logo;
            this.Name = "LoaiDichVuForm";
            this.Text = "LOẠI DỊCH VỤ";
            this.Load += new System.EventHandler(this.LoaiDVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDuLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar Bar1;
        private DevExpress.XtraBars.BarButtonItem NutThem;
        private DevExpress.XtraBars.BarButtonItem NutSua;
        private DevExpress.XtraBars.BarButtonItem NutXoa;
        private DevExpress.XtraBars.BarDockControl BarDockControlTop;
        private DevExpress.XtraBars.BarDockControl BarDockControlBottom;
        private DevExpress.XtraBars.BarDockControl BarDockControlLeft;
        private DevExpress.XtraBars.BarDockControl BarDockControlRight;
        private Guna.UI2.WinForms.Guna2DataGridView BangDuLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAIDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}