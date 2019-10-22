using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        FormState formState = new FormState();
        public Form1()
        {
            InitializeComponent();
            photoEditor1.HideAndShowThumbnail_Changed += PhotoEditor1_HideAndShowThumbnail_Changed;
            photoEditor1.PopupMenuPhotoViewer_Clicked += PhotoEditor1_PopupMenuPhotoViewer_Clicked;

        }

        private void PhotoEditor1_PopupMenuPhotoViewer_Clicked(object sender, PopupMenuPhotoViewerClickedEventArgs e)
        {
            if(sender is SimpleButton)
            {
                var control = (SimpleButton)sender;
                if (control.Name == "btn_dong")
                {
                    this.Close();
                }
                else if (control.Name == "btn_mini")
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                else if (control.Name == "btn_max")
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }

            else
            {
                if (e == null) { return; }
                if (e.ButtonNameClicked.Name == "btn_close")
                {
                    this.Close();
                }
                else if (e.ButtonNameClicked.Name == "btn_mini")
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                else if (e.ButtonNameClicked.Name == "btn_them")
                {

                }
                else if (e.ButtonNameClicked.Name == "btn_xoa")
                {

                }
            }
            

           
        }

        private void PhotoEditor1_HideAndShowThumbnail_Changed(object sender, PhotoViewerHideAndShowThumbnailEventArgs e)
        {
            if (e.Status)
            {
                formState.Maximize(this);
            }
            else
            {
                formState.Restore(this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            photoEditor1.URL_IMAGE = @"images";
            formState.Maximize(this);


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }



}
