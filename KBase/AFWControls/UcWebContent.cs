using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebKit;

namespace KBase.View.AFWControls
{
    public partial class UcWebContent : UcContent
    {
        #region Atributes
        Timer _hideProgressBar;
        #endregion

        #region Constructor
        public UcWebContent()
        {
            InitializeComponent();
            wBrowser.Navigated += WBrowser_Navigated;
            wBrowser.Navigating += WBrowser_Navigating;
            wBrowser.DocumentCompleted += WBrowser_DocumentCompleted;
            pbLoad.Hide();
        }


        #endregion

        #region Properties
        public override byte[] GetContent()
        {
            _content = Encoding.UTF8.GetBytes(wBrowser.DocumentText);
            return base.GetContent();
        }
        public override void SetContent(byte[] content)
        {
            base.SetContent(content);
            if (_dynamicContent)
                Go(new Uri(tbUrl.Text));
            else
                wBrowser.DocumentText = Encoding.UTF8.GetString(_content);
        }

        public override void SetContentUrl(string url)
        {
            tbUrl.KeyPress -= tbUrl_KeyPress;
            tbUrl.Text = url;
            tbUrl.KeyPress += tbUrl_KeyPress;
            base.SetContentUrl(url);
        }

        public override void SetDynamicContent(bool dynCon)
        {
            cbDynamicContent.CheckState = dynCon ? CheckState.Checked : CheckState.Unchecked;
            base.SetDynamicContent(dynCon);
        }

        public override bool GetDynamicContent()
        {
            _dynamicContent = cbDynamicContent.CheckState == CheckState.Checked;
            return base.GetDynamicContent();
        }
        #endregion


        #region Events
        private void btnGo_Click(object sender, EventArgs e)
        {
            Go(new Uri(tbUrl.Text));
        }

        private void tbUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Go(new Uri(tbUrl.Text));
                e.Handled = true;
            }
        }

        private void WBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if ((sender as WebKitBrowser).Url == null) return;
            tbUrl.Text = _contentUrl = e.Url.ToString();
            pbLoad.Maximum = 100;
            pbLoad.Value = 100;
            _hideProgressBar = new Timer();
            _hideProgressBar.Interval = 5000;
            _hideProgressBar.Tick += _hideProgressBar_Tick;
            _hideProgressBar.Start();
        }

        private void _hideProgressBar_Tick(object sender, EventArgs e)
        {
            pbLoad.Hide();
            _hideProgressBar.Stop();
            _hideProgressBar.Dispose();
        }

        private void WBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            pbLoad.Maximum = 100;
            pbLoad.Value = 20;
        }

        private void WBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            pbLoad.Show();
            pbLoad.Maximum = 100;
            pbLoad.Value = 0;
        }

        #endregion

        #region Methods




        void Go(Uri uri)
        {
            try
            {
                wBrowser.Navigate(uri.ToString());
                _contentUrl = uri.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion


    }
}
