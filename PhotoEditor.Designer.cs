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
            DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton3 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoEditor));
            DevExpress.Utils.ContextButton contextButton4 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton5 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton6 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.TrackBarContextButton trackBarContextButton1 = new DevExpress.Utils.TrackBarContextButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.peCurrentImage = new DevExpress.XtraEditors.PictureEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_taihinh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_mini = new DevExpress.XtraBars.BarButtonItem();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.lbl_status = new DevExpress.XtraEditors.LabelControl();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCurrentImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.peCurrentImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_status, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 527);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // peCurrentImage
            // 
            this.peCurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.peCurrentImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peCurrentImage.Location = new System.Drawing.Point(3, 33);
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
            contextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Left;
            contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center;
            contextButton1.Id = new System.Guid("11e6f7e9-2ad6-4cd2-981b-e057aa59dca8");
            contextButton1.ImageOptions.Image = global::PhotoViewer.Properties.Resources.back;
            contextButton1.Name = "back";
            contextButton2.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Right;
            contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Center;
            contextButton2.Id = new System.Guid("fc2a5a5a-5f3d-453e-af23-17aadcf65c30");
            contextButton2.ImageOptions.Image = global::PhotoViewer.Properties.Resources.next;
            contextButton2.Name = "next";
            contextButton3.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton3.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton3.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton3.AppearanceHover.Options.UseBackColor = true;
            contextButton3.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton3.AppearanceNormal.Options.UseBackColor = true;
            contextButton3.Id = new System.Guid("e82d3487-8ad9-4ed1-8d29-c8a137410289");
            contextButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            contextButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton3.Name = "rotate_right";
            contextButton3.ToolTip = "Xoay hình sang phải";
            contextButton4.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton4.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton4.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton4.AppearanceHover.Options.UseBackColor = true;
            contextButton4.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton4.AppearanceNormal.Options.UseBackColor = true;
            contextButton4.Id = new System.Guid("61168245-4827-4994-88a3-1980b815a454");
            contextButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            contextButton4.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton4.Name = "rotate_left";
            contextButton4.ToolTip = "Xoay hình sang trái";
            contextButton5.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton5.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton5.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton5.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton5.AppearanceHover.Options.UseBackColor = true;
            contextButton5.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton5.AppearanceNormal.Options.UseBackColor = true;
            contextButton5.Id = new System.Guid("e2262d08-ecbd-485a-9b96-f1aee27a41d1");
            contextButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            contextButton5.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton5.Name = "download";
            contextButton5.ToolTip = "Tải hình ảnh về máy";
            contextButton6.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            contextButton6.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton6.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton6.AppearanceHover.BackColor = System.Drawing.Color.Transparent;
            contextButton6.AppearanceHover.Options.UseBackColor = true;
            contextButton6.AppearanceNormal.BackColor = System.Drawing.Color.Black;
            contextButton6.AppearanceNormal.Options.UseBackColor = true;
            contextButton6.Id = new System.Guid("2a8d0ecb-9546-4bcb-b156-077ea33924cf");
            contextButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
            contextButton6.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            contextButton6.Name = "hide";
            contextButton6.ToolTip = "Ẩn hiện ảnh thu nhỏ";
            trackBarContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom;
            trackBarContextButton1.Id = new System.Guid("6108d49f-88c5-4ed9-9245-f9a436e9afae");
            trackBarContextButton1.Name = "brightness";
            trackBarContextButton1.ShowToolTips = false;
            trackBarContextButton1.ToolTip = "Chỉnh sáng tối hình ảnh";
            trackBarContextButton1.TrackWidth = 100;
            trackBarContextButton1.Value = 150;
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton1);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton2);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton3);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton4);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton5);
            this.peCurrentImage.Properties.ContextButtons.Add(contextButton6);
            this.peCurrentImage.Properties.ContextButtons.Add(trackBarContextButton1);
            this.peCurrentImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCurrentImage.Properties.ShowMenu = false;
            this.peCurrentImage.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.peCurrentImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peCurrentImage.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.peCurrentImage.Properties.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.peCurrentImage_Properties_ContextButtonClick);
            this.peCurrentImage.Size = new System.Drawing.Size(898, 381);
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
            this.barStaticItem1,
            this.btn_mini,
            this.btn_close});
            this.barManager1.MaxItemId = 7;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_taihinh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_mini, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_close)});
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
            // btn_mini
            // 
            this.btn_mini.Caption = "Thu nhỏ màn hình";
            this.btn_mini.Id = 5;
            this.btn_mini.ImageOptions.Image = global::PhotoViewer.Properties.Resources.remove_16x16;
            this.btn_mini.ImageOptions.LargeImage = global::PhotoViewer.Properties.Resources.remove_32x32;
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_mini_ItemClick);
            // 
            // btn_close
            // 
            this.btn_close.Caption = "Đóng màn hình";
            this.btn_close.Id = 6;
            this.btn_close.ImageOptions.Image = global::PhotoViewer.Properties.Resources.closeheaderandfooter_16x16;
            this.btn_close.ImageOptions.LargeImage = global::PhotoViewer.Properties.Resources.closeheaderandfooter_32x32;
            this.btn_close.Name = "btn_close";
            this.btn_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_close_ItemClick);
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
            this.tileControl1.AllowSelectedItem = true;
            this.tileControl1.AppearanceGroupHighlighting.HoveredMaskColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceGroupHighlighting.MaskColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Red;
            this.tileControl1.AppearanceItem.Hovered.BackColor2 = System.Drawing.Color.White;
            this.tileControl1.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.White;
            this.tileControl1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Hovered.Options.UseBorderColor = true;
            this.tileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileControl1.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Transparent;
            this.tileControl1.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileControl1.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.tileControl1.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.White;
            this.tileControl1.AppearanceItem.Selected.BorderColor = System.Drawing.Color.White;
            this.tileControl1.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileControl1.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileControl1.AppearanceText.Options.UseBackColor = true;
            this.tileControl1.BackColor = System.Drawing.Color.Gray;
            this.tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            this.tileControl1.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            this.tileControl1.ItemPadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.tileControl1.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Hover;
            this.tileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl1.SelectionColor = System.Drawing.Color.Transparent;
            this.tileControl1.Size = new System.Drawing.Size(894, 104);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileControl1_SelectedItemChanged);
            this.tileControl1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.OnTileControlItemClick);
            // 
            // lbl_status
            // 
            this.lbl_status.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbl_status.Appearance.Options.UseBackColor = true;
            this.lbl_status.Appearance.Options.UseFont = true;
            this.lbl_status.Appearance.Options.UseForeColor = true;
            this.lbl_status.Appearance.Options.UseTextOptions = true;
            this.lbl_status.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_status.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbl_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status.Location = new System.Drawing.Point(3, 3);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbl_status.Size = new System.Drawing.Size(898, 24);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "status";
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
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCurrentImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PictureEdit peCurrentImage;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.LabelControl lbl_status;
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
        private DevExpress.XtraBars.BarButtonItem btn_mini;
        private DevExpress.XtraBars.BarButtonItem btn_close;
        public DevExpress.XtraBars.BarButtonItem btn_taihinh;
    }
}
