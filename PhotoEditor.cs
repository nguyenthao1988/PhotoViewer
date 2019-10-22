using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Imaging;
using System.IO;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;

namespace PhotoViewer
{
    public partial class PhotoEditor : DevExpress.XtraEditors.XtraUserControl
    {
        [Description("Photo Viewer"), Category("Data")]
        private bool _allowAddPicture = false;
        public bool _allowDeletePicture = false;
        public string _url_Image = "";
        public  string URL_IMAGE
        {
            get { return _url_Image; }
            set
            {
                if (_url_Image == value) return;
                _url_Image = value;
                InitializeImages();
                if (!string.IsNullOrEmpty(URL_IMAGE))
                {
                    InitializeContent();
                    SetImage(Images[0]);
                    this.IndexImage = 0;
                    tileControl1.SelectedItem = group.Items[0];

                }

            }
        }
 

        public bool AllowAddPicture
        {
            set { _allowAddPicture = value; }
            get { return _allowAddPicture; }
        }

        public bool AllowDeletePicture
        {
            set { _allowDeletePicture = value; }
            get { return _allowDeletePicture; }
        }


        public int index_img;
        public event EventHandler ImageChanged;
        public event PhotoViewerHideAndShowThumbnailEventHandler HideAndShowThumbnail_Changed;
        public event PopupMenuPhotoViewerClickedEventHandler PopupMenuPhotoViewer_Clicked;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Left))
            {
                if (this.IndexImage > 0)
                {
                    this.IndexImage--;
                    var img = group.Items[this.IndexImage].BackgroundImage;
                    SetImage(img);
                    if (tileControl1.Visible == true)
                    {
                        try
                        {
                            tileControl1.SelectedItem = group.Items[this.IndexImage];
                        }
                        catch (Exception) { }
                    }

                }
                return true;
            }
            else if (keyData == (Keys.Right))
            {
                if (this.IndexImage < total_img - 1)
                {
                    this.IndexImage++;
                    var img = group.Items[this.IndexImage].BackgroundImage;
                    SetImage(img);
                    if (tileControl1.Visible == true)
                    {
                        try
                        {
                            tileControl1.SelectedItem = group.Items[this.IndexImage];
                        }
                        catch (Exception) { }
                    }

                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected virtual void OnImageIndexChanged()
        {
            if (ImageChanged != null) ImageChanged(this, EventArgs.Empty);

            if (IndexImage == 0)
            {
                HiddenContextButton(0, ContextItemVisibility.Hidden);
            }
            else
            {
                HiddenContextButton(0, ContextItemVisibility.Auto);
            }

            if (IndexImage == total_img - 1)
            {
                HiddenContextButton(1, ContextItemVisibility.Hidden);
            }
            else
            {
                HiddenContextButton(1, ContextItemVisibility.Auto);
            }
        }

        public int IndexImage
        {
            get
            {
                return index_img;
            }

            set
            {
                index_img = value;
                OnImageIndexChanged();
            }
        }


        public int total_img;
        public int rotate_left = 0;
        public PhotoEditor()
        {
            InitializeComponent();
            this.peCurrentImage.Properties.ContextButtonValueChanged += new ContextButtonValueChangedEventHandler(this.peCurrentImage_Properties_ContextButtonValueChanged);
           // tileControl1.SelectionColor = Color.FromArgb(190, Color.Red); 
            //flyoutPanel1.ShowPopup();
            //URL_IMAGE = @"C:\Users\nguyenthao\Desktop\PhotoViewer\PhotoViewer\PhotoViewer\PhotoViewer\bin\Debug\images";

        }

        public void HiddenContextButton(int index, ContextItemVisibility isHidden)
        {
            ContextItem contextBtn = peCurrentImage.Properties.ContextButtons[index];
            contextBtn.Visibility = isHidden;
        }

        protected virtual void InitializeContent()
        {
            InitializeTileControl();
          
        }
        protected virtual void InitializeTileControl()
        {
            (tileControl1 as ITileControl).ViewInfo.UseAdvancedTextRendering = false;
            if (TileGroupImages == null) return;
            TileControl.Groups.Clear();
            TileControl.Groups.Add(TileGroupImages);
        }
        protected virtual void InitializeImages()
        {
            if (string.IsNullOrEmpty(URL_IMAGE)) return;
            Images = new List<Image>();
            string[] files = Directory.GetFiles(URL_IMAGE, "*.jpg");
            total_img = files.Length;
            foreach (string file in files)
            {
                Image img = Bitmap.FromFile(file);
                img.Tag = file;
                Images.Add(img);
            }
            InitializeTileControl();
        }

        protected virtual List<Image> Images { get; set; }
        protected virtual TileControl TileControl { get { return tileControl1; } }
        protected virtual PictureEdit PictureEdit { get { return peCurrentImage; } }
        Image originalImageCore;
        protected virtual Image OriginalImage
        {
            get { return originalImageCore; }
            set
            {
                originalImageCore = value;
                peCurrentImage.Image = originalImageCore;
            }
        }

        Image currentImageCore;
        protected virtual Image CurrentImage
        {
            get { return currentImageCore; }
            set
            {
                currentImageCore = value;
                if (CurrentImage == null) return;
                PictureEdit.Image = CurrentImage;
                CalcCurrentImageZoomPercent(currentImageCore);              
            }
        }
        protected virtual void CalcCurrentImageZoomPercent(Image img)
        {
            PictureEdit.Properties.ZoomPercent = Math.Min(((double)PictureEdit.Height / (double)img.Height) * 100, 100);
        }
     
        TileGroup group;
        protected virtual TileGroup TileGroupImages
        {
            get
            {
                if (group == null)
                    group = CreateTileGroupImages();
                return group;
            }
        }


        string name;

        protected virtual void SetImage(Image img)
        {

            CurrentImage = img;
            string size = ImageHelper.GetSize(img);
            name = ImageHelper.GetName(img);
            string demension = ImageHelper.GetDimension(img);

            lbl_status.Text = "Tên hình ảnh: " + name + " - Kích thước: " + size + $" ({demension})";

            OriginalImage = img;
            ContextItem contextBtn = peCurrentImage.Properties.ContextButtons[6];
            ((TrackBarContextButton)contextBtn).Value = 150;
        }

        protected virtual void OnTileControlItemClick(object sender, TileItemEventArgs e)
        {
            if (e.Item != null)
            {
                SetImage(e.Item.BackgroundImage);
                this.IndexImage = group.Items.IndexOf(e.Item);
                e.Item.Checked = true;                
            }
        }     

        void ContextItemClick(object sender, ContextItemClickEventArgs e)
        {
            if (e.Item.Name == "back")
            {
                if (this.IndexImage > 0)
                {
                    this.IndexImage--;
                    var img = group.Items[this.IndexImage].BackgroundImage;
                    SetImage(img);
                    if (tileControl1.Visible == true)
                    {
                        try
                        {
                            tileControl1.SelectedItem = group.Items[this.IndexImage];
                        }
                        catch (Exception) { }
                    }

                }
            }
            else if (e.Item.Name == "next")
            {
                if (this.IndexImage < total_img - 1)
                {
                    this.IndexImage++;
                    var img = group.Items[this.IndexImage].BackgroundImage;
                    SetImage(img);
                    if (tileControl1.Visible == true)
                    {
                        try
                        {
                            tileControl1.SelectedItem = group.Items[this.IndexImage];
                        }
                        catch (Exception) { }
                    }

                }
            }
            else if (e.Item.Name == "hide")
            {
                PhotoViewerHideAndShowThumbnailEventArgs myArgs;
                if (tableLayoutPanel1.RowStyles[2].Height > 0)
                {
                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[2].Height = 0;
                    tableLayoutPanel1.RowStyles[0].Height = 0;
                    myArgs = new PhotoViewerHideAndShowThumbnailEventArgs(true);
                }
                else
                {
                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[2].Height = 110;
                    tableLayoutPanel1.RowStyles[0].Height = 25;
                    tileControl1.SelectedItem = group.Items[this.IndexImage];
                    myArgs = new PhotoViewerHideAndShowThumbnailEventArgs(false);
                }               
           
                this.HideAndShowThumbnail_Changed(sender, myArgs);

            }
           
            else if (e.Item.Name == "rotate_left")
            {
                var img = peCurrentImage.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);

                SetImage(img);


            }
            else if (e.Item.Name == "rotate_right")
            {
                var img = peCurrentImage.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);

                SetImage(img);


            }
            else if (e.Item.Name == "download")
            {
                var dlg = new XtraSaveFileDialog();
                dlg.Filter = "Jpeg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                dlg.FileName = name;
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var img = peCurrentImage.Image;
                    img.Save(Path.GetFullPath(dlg.FileName));

                }
            }
            else if (e.Item.Name == "brightness")
            {
                int value = ((TrackBarContextButton)e.Item).Value;
                Task.Factory.StartNew(new Action(() => {
                    peCurrentImage.BeginInvoke(new Action(() => {
                        peCurrentImage.Image = AdjustBrightness(OriginalImage, (float)(value / 100.0));
                    }));
                }));
               

            }


        }

        private void peCurrentImage_Properties_ContextButtonValueChanged(object sender, ContextButtonValueEventArgs e)
        {
            if (e.Item.Name == "brightness")
            {
                int value = ((TrackBarContextButton)e.Item).Value;

                Task.Factory.StartNew(new Action(() => {
                    peCurrentImage.BeginInvoke(new Action(() => {
                        peCurrentImage.Image = AdjustBrightness(OriginalImage, (float)(value / 100.0));
                    }));
                }));


            }
        }

        private Bitmap AdjustBrightness(Image image, float brightness)
        {          
            float b = brightness;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
            new float[] {b, 0, 0, 0, 0},
            new float[] {0, b, 0, 0, 0},
            new float[] {0, 0, b, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);        
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);           
            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }       
            return bm;
        }      
        protected virtual TileGroup CreateTileGroupImages()
        {
            if (Images == null || Images.Count == 0) return null;
            TileGroup g = new TileGroup();
            foreach (Image img in Images)
            {
                TileItem item = new TileItem() { BackgroundImage = img, BackgroundImageScaleMode = TileItemImageScaleMode.StretchHorizontal, BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter };


                g.Items.Add(item);
            }
            return g;
        }




        private void peCurrentImage_Properties_ContextButtonClick(object sender, ContextItemClickEventArgs e)
        {
            ContextItemClick(sender, e);
        }

        private void tileControl1_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            if (e.Item != null)
            {
                SetImage(e.Item.BackgroundImage);     
                       this.IndexImage = group.Items.IndexOf(e.Item);
                e.Item.Checked = true;
            }
        }

        private void btn_taihinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            if (e.Item.Name == "btn_taihinh")
            {
                var dlg = new XtraSaveFileDialog();
                dlg.Filter = "Jpeg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                dlg.FileName = name;
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var img = peCurrentImage.Image;
                    img.Save(Path.GetFullPath(dlg.FileName));

                }
            }                        
        }

        private void popupMenu1_BeforePopup(object sender, CancelEventArgs e)
        {
            BarItemLinkCollection items = (sender as DevExpress.XtraBars.PopupMenu).ItemLinks;
            items[1].Item.Enabled = AllowAddPicture;
            items[2].Item.Enabled = AllowDeletePicture ;           
        }

        private void btn_them_ItemClick(object sender, ItemClickEventArgs e)
        {
            PopupMenuPhotoViewerClickedEventArgs myArgs = new PopupMenuPhotoViewerClickedEventArgs(e.Item);
            this.PopupMenuPhotoViewer_Clicked(sender, myArgs);
        }

        private void btn_xoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            PopupMenuPhotoViewerClickedEventArgs myArgs = new PopupMenuPhotoViewerClickedEventArgs(e.Item);
            this.PopupMenuPhotoViewer_Clicked(sender, myArgs);
        }

        private void btn_mini_ItemClick(object sender, ItemClickEventArgs e)
        {
            PopupMenuPhotoViewerClickedEventArgs myArgs = new PopupMenuPhotoViewerClickedEventArgs(e.Item);
            this.PopupMenuPhotoViewer_Clicked(sender, myArgs);
        }

        private void btn_close_ItemClick(object sender, ItemClickEventArgs e)
        {
            PopupMenuPhotoViewerClickedEventArgs myArgs = new PopupMenuPhotoViewerClickedEventArgs(e.Item);
            this.PopupMenuPhotoViewer_Clicked(sender, myArgs);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {            
            this.PopupMenuPhotoViewer_Clicked(sender, null);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.PopupMenuPhotoViewer_Clicked(sender, null);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.PopupMenuPhotoViewer_Clicked(sender, null);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.PopupMenuPhotoViewer_Clicked(sender, null);
        }
    }



    public static class ImageHelper
    {
        public static string GetDimension(Image img)
        {
            try
            {
                if (img == null) return "0x0";
                return string.Format("{0}x{1}", img.Width, img.Height);
            }
            catch (Exception)
            {
                return "0x0";
            }
        }
        public static string GetName(Image img)
        {


            try
            {
                if (img == null) return string.Empty;
                return Path.GetFileName(img.Tag.ToString());
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string GetSize(Image img)
        {
            try
            {
                if (img == null) return "0 KB";
                return (new FileInfo(img.Tag.ToString()).Length / 1024).ToString() + " KB";
            }
            catch (Exception)
            {
                return "0 KB";
            }

        }


    }

    #region "Tạo event"
    public delegate void PhotoViewerHideAndShowThumbnailEventHandler(object sender, PhotoViewerHideAndShowThumbnailEventArgs e);
    public class PhotoViewerHideAndShowThumbnailEventArgs : EventArgs
    {       

        private bool status;
      
        public PhotoViewerHideAndShowThumbnailEventArgs(bool _status)
        {
            this.status = _status;       
        }

        public bool Status {get { return status; } }
      
    }


    //event menu popup click
    public delegate void PopupMenuPhotoViewerClickedEventHandler(object sender, PopupMenuPhotoViewerClickedEventArgs e);
    public class PopupMenuPhotoViewerClickedEventArgs : EventArgs
    {

        private BarItem buttonNameClicked;

        public PopupMenuPhotoViewerClickedEventArgs(BarItem _buttonNameClicked)
        {
            this.buttonNameClicked = _buttonNameClicked;
        }

        public BarItem ButtonNameClicked { get { return buttonNameClicked; } }

    }

    #endregion


}

