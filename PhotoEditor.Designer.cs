namespace PhotoViewer
{
    partial class PhotoEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.ContextButton contextButton7 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton8 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton9 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoEditor));
            DevExpress.Utils.ContextButton contextButton10 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton11 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton12 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.TrackBarContextButton trackBarContextButton2 = new DevExpress.Utils.TrackBarContextButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.peCurrentImage = new DevExpress.XtraEditors.PictureEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_taihinh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_fullscreen = new DevExpress.XtraEditors.SimpleButton();
            this.btn_mini = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_status = new DevExpress.XtraEditors.LabelControl();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCurrentImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.peCurrentImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 527);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // peCurrentImage
            // 
            this.peCurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.peCurrentImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peCurrentImage.Location = new System.Drawing.Point(3, 28);
            this.peCurrentImage.MenuManager = this.barManager1;
            this.peCurrentImage.Name = "peCurrentImage";
            this.barManager1.SetPopupContextMenu(this.peCurrentImage, this.popupMenu1);
            this.peCurrentImage.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.False;
            this.peCurrentImage.Properties.AllowDisposeImage = true;
            this.peCurrentImage.Properties.AllowFocused = false;
            this.peCurrentImage.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.peCurrentImage.Properties.AllowScrollViaMouseDrag = true;
            this.peCurrentImage.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.peCurrentImage.Properties.Appearance.BackColor = System.Drawing.Color.Gray;
            this.peCurrentImage.Properties.Appearance.Options.UseBackColor = true;
            this.peCurrentImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCurrentImage.Properties.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.SequenceAnimation;
            this.peCurrentImage.Properties.ContextButtonOptions.BottomPanelPadding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.peCurrentImage.Properties.ContextButtonOptions.ItemCursor = System.Windows.Forms.Cursors.Hand;
            contextButton7.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Left;
            contextButton7.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center;
            contextButton7.Id = new System.Guid("11e6f7e9-2ad6-4cd2-981b-e057aa59dca8");
            contextButton7.ImageOptions.Image = global::PhotoViewer.Properties.Resources.back;
            contextButton7.Name = "back";
            contextButton8.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Right;
            contextButton8.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center;
            contextButton8.Id = new System.Guid("fc2a5a5a-5f3d-453e-af23-17aadcf65c30");
            contextButton8.ImageOptions.Image = global::PhotoViewer.Properties.Resources.next;
            contextButton8.Name = "next";
            contextButton9.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton9.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton9.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton9.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton9.AppearanceHover.Options.UseBackColor = true;
            contextButton9.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton9.AppearanceNormal.Options.UseBackColor = true;
            contextButton9.Id = new System.Guid("e82d3487-8ad9-4ed1-8d29-c8a137410289");
            contextButton9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            contextButton9.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton9.Name = "rotate_right";
            contextButton9.ToolTip = "Xoay hình sang phải";
            contextButton10.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton10.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton10.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton10.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton10.AppearanceHover.Options.UseBackColor = true;
            contextButton10.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton10.AppearanceNormal.Options.UseBackColor = true;
            contextButton10.Id = new System.Guid("61168245-4827-4994-88a3-1980b815a454");
            contextButton10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            contextButton10.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton10.Name = "rotate_left";
            contextButton10.ToolTip = "Xoay hình sang trái";
            contextButton11.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton11.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton11.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton11.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton11.AppearanceHover.Options.UseBackColor = true;
            contextButton11.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton11.AppearanceNormal.Options.UseBackColor = true;
            contextButton11.Id = new System.Guid("e2262d08-ecbd-485a-9b96-f1aee27a41d1");
            contextButton11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            contextButton11.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton11.Name = "download";
            contextButton11.ToolTip = "Tải hình ảnh về máy";
            contextButton12.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton12.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton12.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton12.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton12.AppearanceHover.Options.UseBackColor = true;
            contextButton12.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton12.AppearanceNormal.Options.UseBackColor = true;
            contextButton12.Id = new System.Guid("2a8d0ecb-9546-4bcb-b156-077ea33924cf");
            contextButton12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
            contextButton12.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton12.Name = "hide";
            contextButton12.ToolTip = "Ẩn hiện ảnh thu nhỏ";
            trackBarContextButton2.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            trackBarContextButton2.Id = new System.Guid("6108d49f-88c5-4ed9-9245-f9a436e9afae");
            trackBarContextButton2.Name = "brightness";
            trackBarContextButton2.ShowToolTips = false;
            trackBarContextButton2.ToolTip = "Chỉnh sáng tối hình ảnh";
            trackBarContextButton2.TrackWidth = 100;
            trackBarContextButton2.Value = 150;
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton7);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton8);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton9);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton10);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton11);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton12);
            this.peCurrentImage.Properties.ContextButtons.Add(trackBarContextButton2);
            this.peCurrentImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCurrentImage.Properties.ShowMenu = false;
            this.peCurrentImage.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.peCurrentImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peCurrentImage.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.peCurrentImage.Properties.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.peCurrentImage_Properties_ContextButtonClick);
            this.peCurrentImage.Size = new System.Drawing.Size(898, 386);
            this.peCurrentImage.TabIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.btn_xoa,
            this.btn_taihinh,
            this.barStaticItem1});
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_taihinh, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.BeforePopup += new System.ComponentModel.CancelEventHandler(this.popupMenu1_BeforePopup);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Chọn chức năng";
            this.barStaticItem1.Id = 4;
            this.barStaticItem1.ItemAppearance.Normal.BackColor = System.Drawing.Color.Gray;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.ItemInMenuAppearance.Normal.BackColor = System.Drawing.Color.DimGray;
            this.barStaticItem1.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.barStaticItem1.ItemInMenuAppearance.Normal.Options.UseBackColor = true;
            this.barStaticItem1.ItemInMenuAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm hình";
            this.btn_them.Id = 1;
            this.btn_them.ImageOptions.Image = global::PhotoViewer.Properties.Resources.add_16x16;
            this.btn_them.ImageOptions.LargeImage = global::PhotoViewer.Properties.Resources.add_32x32;
            this.btn_them.Name = "btn_them";
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa hình";
            this.btn_xoa.Id = 2;
            this.btn_xoa.ImageOptions.Image = global::PhotoViewer.Properties.Resources.removepivotfield_16x16;
            this.btn_xoa.ImageOptions.LargeImage = global::PhotoViewer.Properties.Resources.removepivotfield_32x32;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoa_ItemClick);
            // 
            // btn_taihinh
            // 
            this.btn_taihinh.Caption = "Tải hình về máy";
            this.btn_taihinh.Id = 3;
            this.btn_taihinh.ImageOptions.Image = global::PhotoViewer.Properties.Resources.next_16x16;
            this.btn_taihinh.ImageOptions.LargeImage = global::PhotoViewer.Properties.Resources.next_32x32;
            this.btn_taihinh.Name = "btn_taihinh";
            this.btn_taihinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_taihinh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(904, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 527);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(904, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 527);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(904, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 527);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // panelControl5
            // 
            this.panelControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl5.Appearance.Options.UseBackColor = true;
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.tileControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(3, 420);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.panelControl5.Size = new System.Drawing.Size(898, 104);
            this.panelControl5.TabIndex = 2;
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowDragTilesBetweenGroups = false;
            this.tileControl1.AllowItemHover = true;
            this.tileControl1.AppearanceGroupHighlighting.HoveredMaskColor = System.Drawing.Color.Empty;
            this.tileControl1.AppearanceGroupHighlighting.MaskColor = System.Drawing.Color.Empty;
            this.tileControl1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileControl1.AppearanceItem.Selected.BackColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileControl1.AppearanceText.Options.UseBackColor = true;
            this.tileControl1.BackColor = System.Drawing.Color.Gray;
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.EnableItemDoubleClickEvent = false;
            this.tileControl1.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.tileControl1.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            this.tileControl1.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            this.tileControl1.ItemPadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.tileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.OptionsAdaptiveLayout.ScrollMode = DevExpress.XtraEditors.TileControlAdaptiveLayoutScrollMode.ItemScrolling;
            this.tileControl1.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl1.SelectionColor = System.Drawing.Color.Empty;
            this.tileControl1.Size = new System.Drawing.Size(894, 104);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileControl1_SelectedItemChanged);
            this.tileControl1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.OnTileControlItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_max);
            this.panelControl1.Controls.Add(this.btn_fullscreen);
            this.panelControl1.Controls.Add(this.btn_mini);
            this.panelControl1.Controls.Add(this.btn_dong);
            this.panelControl1.Controls.Add(this.lbl_status);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(904, 25);
            this.panelControl1.TabIndex = 3;
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.ImageOptions.SvgImage = global::PhotoViewer.Properties.Resources.maximize;
            this.btn_max.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_max.Location = new System.Drawing.Point(845, 1);
            this.btn_max.Name = "btn_max";
            this.btn_max.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_max.Size = new System.Drawing.Size(27, 23);
            this.btn_max.TabIndex = 4;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_fullscreen
            // 
            this.btn_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fullscreen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_fullscreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fullscreen.ImageOptions.SvgImage = global::PhotoViewer.Properties.Resources.full_screen;
            this.btn_fullscreen.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btn_fullscreen.Location = new System.Drawing.Point(782, 0);
            this.btn_fullscreen.Name = "btn_fullscreen";
            this.btn_fullscreen.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_fullscreen.Size = new System.Drawing.Size(27, 23);
            this.btn_fullscreen.TabIndex = 3;
            this.btn_fullscreen.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mini.ImageOptions.SvgImage = global::PhotoViewer.Properties.Resources.minimize;
            this.btn_mini.ImageOptions.SvgImageSize = new System.Drawing.Size(28, 28);
            this.btn_mini.Location = new System.Drawing.Point(812, -10);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_mini.Size = new System.Drawing.Size(38, 46);
            this.btn_mini.TabIndex = 2;
            this.btn_mini.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_dong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_dong.ImageOptions.SvgImage")));
            this.btn_dong.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btn_dong.Location = new System.Drawing.Point(874, 1);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_dong.Size = new System.Drawing.Size(27, 23);
            this.btn_dong.TabIndex = 1;
            this.btn_dong.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Appearance.Options.UseFont = true;
            this.lbl_status.Appearance.Options.UseForeColor = true;
            this.lbl_status.LineVisible = true;
            this.lbl_status.Location = new System.Drawing.Point(8, 3);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(75, 16);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "labelControl1";
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // PhotoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PhotoEditor";
            this.Size = new System.Drawing.Size(904, 527);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peCurrentImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PictureEdit peCurrentImage;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        public DevExpress.XtraBars.BarButtonItem btn_taihinh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_status;
        private DevExpress.XtraEditors.SimpleButton btn_dong;
        private DevExpress.XtraEditors.SimpleButton btn_fullscreen;
        private DevExpress.XtraEditors.SimpleButton btn_mini;
        private DevExpress.XtraEditors.SimpleButton btn_max;
    }
}
