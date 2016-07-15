using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBase.View.AFWControls
{
    public partial class UcRemovableLabel : UserControl
    {
        #region Atributes
        public delegate void OnRemoveLabelEventHandler(OnRemoveLabelEventArgs e);

        public event EventHandler OnRemoveLabel;

        #endregion
        #region Properties
        public long LabelId { get; set; }
        public string LabelText
        {
            get { return lbLabel.Text; }
            set { lbLabel.Text = value; }
        }
        #endregion

        public UcRemovableLabel()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Remove Tag - {0} -?", LabelText), "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OnOnRemoveLabel(new OnRemoveLabelEventArgs() { TagId = LabelId, TagName = LabelText });
                Parent.Controls.Remove(this);
                Dispose();
            }
        }

        protected virtual void OnOnRemoveLabel(OnRemoveLabelEventArgs e)
        {
            EventHandler handler = OnRemoveLabel;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class OnRemoveLabelEventArgs: EventArgs
    {
        public long TagId { get; set; }
        public string TagName { get; set; }
    }
}
