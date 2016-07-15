using KBase.Data.Model2;
using KBase.Data.Model.Catalogs;
using KBase.Logic.Controllers;
using KBase.View.AFWControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBase.View.Forms
{
    public partial class FArticle : Form
    {
        #region Atributes
        ArticleController controller;
        private ArticleController.DataType Action;
        Dictionary<long, string> Tags, ContentType;
        Timer tMessage;
        #endregion

        #region Constructor
        public FArticle(ArticleController.DataType action)
        {
            InitializeComponent();
            if (action == ArticleController.DataType.New)
                controller = new ArticleController(action);

            Action = action;
        }
        public FArticle(ArticleController.DataType action, Guid articleId)
        {
            InitializeComponent();
            if (action == ArticleController.DataType.Edit)
                controller = new ArticleController(action, articleId);

            Action = action;
        }
        #endregion

        #region Events
        private void FMain_Load(object sender, EventArgs e)
        {
            LoadCombos(false);
            GetData(ArticleController.DataType.Load);
            //Button b = new Button() { Name = "botton1", Text = "button 1", Location = new Point() { X = 100, Y = 25 } };
            //this.tcContent.Controls.Add(b);
            //b.BringToFront();
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            cmsMenuTags.Show(MousePosition);
        }

        private void tscbInsertTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbInsertTags.SelectedIndex == -1) return;

            long id = Tags.FirstOrDefault(t => t.Value == tscbInsertTags.SelectedItem.ToString()).Key;
            if (controller.CurrentArticle != null && !string.IsNullOrEmpty(controller.CurrentArticle.Tags) && controller.CurrentArticle.Tags.Split(',').Contains(id.ToString()))
            {
                MessageBox.Show("Tag is already inserted"); return;
            }
            else
                controller.CurrentArticle.Tags = string.IsNullOrEmpty(controller.CurrentArticle.Tags) ?
                    id.ToString() :
                    string.Format("{0},{1}", controller.CurrentArticle.Tags, id.ToString());

            DrawTag(id, tscbInsertTags.SelectedItem.ToString());

            tscbInsertTags.SelectedIndex = -1;
        }

        private void tstbManageTags_Click(object sender, EventArgs e)
        {
            FAdminCats fAdminCats = new FAdminCats(CatTypes.Tags);
            fAdminCats.ShowDialog();
            LoadCombos(true);
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            controller.CurrentArticle.Title = llTitle.Text = ((TextBox)sender).Text;
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            controller.CurrentArticle.Description = ((TextBox)sender).Text;
        }

        private void cbKArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (long.Parse(((ComboBox)sender).SelectedValue.ToString()) != -1)
            {
                controller.CurrentArticle.KnowledgeAreaId = long.Parse(((ComboBox)sender).SelectedValue.ToString());
                llKArea.Text = ((ComboBox)sender).Text;
            }
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (long.Parse(((ComboBox)sender).SelectedValue.ToString()) != -1)
            {
                controller.CurrentArticle.ThemeId = long.Parse(((ComboBox)sender).SelectedValue.ToString());
                llTheme.Text = ((ComboBox)sender).Text;
            }
        }

        private void RlOne_OnRemoveLabel(object sender, EventArgs e)
        {
            List<string> _tags = controller.CurrentArticle.Tags.Split(',').ToList();
            _tags.Remove(((OnRemoveLabelEventArgs)e).TagId.ToString());
            controller.CurrentArticle.Tags = Tags.Count > 0 ? string.Join(",", _tags) : string.Empty;
        }

        private void tcContent_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = this.tcContent.TabPages[e.Index];
            var tabRect = this.tcContent.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            if (e.Index == this.tcContent.TabCount - 1)
            {
                var addImage = Properties.Resources.plusImg.GetThumbnailImage(16, 16, null, IntPtr.Zero);
                e.Graphics.DrawImage(addImage,
                    tabRect.Left + (tabRect.Width - addImage.Width) / 2,
                    tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                var closeImage = Properties.Resources.removeImg.GetThumbnailImage(16, 16, null, IntPtr.Zero);
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
        }

        private void tcContent_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tcContent.TabCount - 1;
            if (this.tcContent.GetTabRect(lastIndex).Contains(e.Location))
            {
                cmsContentType.Show(MousePosition);
            }
            else
            {
                for (var i = 0; i < this.tcContent.TabPages.Count; i++)
                {
                    var tabRect = this.tcContent.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.removeImg.GetThumbnailImage(16, 16, null, IntPtr.Zero);
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width,
                        closeImage.Height);
                    if (imageRect.Contains(e.Location))
                    {
                        if (CanRemoveContent(i))
                            this.tcContent.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tcContent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tcContent.TabCount - 1;
            if (!this.tcContent.GetTabRect(lastIndex).Contains(e.Location))
            {
                for (int i = 0; i < this.tcContent.TabPages.Count; i++)
                {
                    var tabRect = this.tcContent.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.removeImg.GetThumbnailImage(16, 16, null, IntPtr.Zero);
                    var imageRect = new Rectangle(
                                tabRect.Left,
                                tabRect.Top,
                                tabRect.Width - closeImage.Width,
                                tabRect.Height);
                    if (imageRect.Contains(e.Location))
                    {
                        TextBox tbTabLabel = new TextBox();
                        tbTabLabel.Location = new Point(imageRect.X + tcContent.Location.X, imageRect.Y + tcContent.Location.Y);
                        tbTabLabel.Size = imageRect.Size;
                        gbContent.Controls.Add(tbTabLabel);
                        tbTabLabel.KeyPress += TbTabLabel_KeyPress;
                        tbTabLabel.BringToFront();
                        tbTabLabel.Focus();
                        break;
                    }
                }
            }
        }

        private void TbTabLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tcContent.SelectedTab.Text = ((TextBox)sender).Text;
                ((TextBox)sender).Dispose();
            }
        }

        private void tcContent_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tcContent.TabCount - 1)
                e.Cancel = true;
        }

        private void tscbContentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbContentType.SelectedIndex <= 0) return;

            GetData(ArticleController.DataType.AddContent);
        }

        private void btnSaveArticle_Click(object sender, EventArgs e)
        {
            GetData(ArticleController.DataType.Save);
        }

        private void TMessage_Tick(object sender, EventArgs e)
        {
            lbMessage.Text = string.Empty;
            tMessage.Stop();
        }
        #endregion

        #region Methods

        object GetData(ArticleController.DataType dataType)
        {
            try
            {
                switch (dataType)
                {
                    case ArticleController.DataType.Load:
                        #region Load
                        if (controller.Action != ArticleController.DataType.Edit)// !string.IsNullOrEmpty(controller.CurrentArticle.Tags))
                            return null;
                        tbTitle.Text = controller.CurrentArticle.Title;
                        tbDescription.Text = controller.CurrentArticle.Description;
                        cbKArea.SelectedValue = controller.CurrentArticle.KnowledgeAreaId;
                        cbTheme.SelectedValue = controller.CurrentArticle.ThemeId;
                        DrawTags();
                        LoadContents();
                        break;
                    #endregion
                    case ArticleController.DataType.LoadKAreas:
                    case ArticleController.DataType.LoadTags:
                    case ArticleController.DataType.LoadThems:
                    case ArticleController.DataType.LoadContenType:
                        return controller.GetData(dataType);
                    case ArticleController.DataType.AddContent:
                        #region Add Content
                        var conType = (CatContentType)ContentType.Where(c => c.Value == tscbContentType.SelectedItem.ToString()).FirstOrDefault().Key;
                        var _lastIndex = this.tcContent.TabCount - 1;

                        UcContent newContent = null;

                        switch (conType)
                        {
                            case CatContentType.Image:
                                break;
                            case CatContentType.PlainText:
                                #region Plain Text
                                this.tcContent.TabPages.Insert(_lastIndex, "New Text Content");
                                this.tcContent.SelectedIndex = _lastIndex;
                                tcContent.TabPages[_lastIndex].TextChanged += SelectedTab_TextChanged;

                                newContent = new UcSingleTextEditor();
                                newContent.Name = "TextContent";
                                newContent.Dock = DockStyle.Fill;

                                break;
                            #endregion
                            case CatContentType.Audio:
                                break;
                            case CatContentType.Video:
                                break;
                            case CatContentType.WebContent:
                                #region Web Content
                                tcContent.TabPages.Insert(_lastIndex, "New Web Content");
                                tcContent.SelectedIndex = _lastIndex;
                                tcContent.TabPages[_lastIndex].TextChanged += SelectedTab_TextChanged;

                                newContent = new UcWebContent();
                                newContent.Name = "WebContent";
                                newContent.Dock = DockStyle.Fill;

                                break;
                            #endregion
                            case CatContentType.OtherContent:
                                break;
                            default:
                                return null;

                        }
                        tcContent.TabPages[_lastIndex].Controls.Add(newContent);

                        newContent.ContentType = conType;
                        newContent.ArticleContentId = Guid.NewGuid();
                        newContent.ArticleId = controller.CurrentArticle.ArticleId;
                        newContent.ArticleName = tcContent.TabPages[_lastIndex].Text;
                        //newContent.set

                        tscbContentType.SelectedIndex = 0;
                        cmsContentType.Close();

                        #endregion

                        break;
                    case ArticleController.DataType.CanRemoveContent:
                    #region Can Remove Content



                    #endregion
                    case ArticleController.DataType.RemoveContent:

                        break;
                    case ArticleController.DataType.Save:
                        if (controller.CurrentArticle.ArticleContents == null)
                            controller.CurrentArticle.ArticleContents = new List<ArticleContent>();
                        for (long i = 0; i < tcContent.TabPages.Count; i++)
                        {
                            TabPage tab = tcContent.TabPages[int.Parse(i.ToString())];

                            UcContent con = tab.Controls.OfType<UcContent>().FirstOrDefault();
                            if (con == null) continue;

                            ArticleContent aC = controller.CurrentArticle.ArticleContents.Where(ac => ac.ArticleContentId == con.ArticleContentId).FirstOrDefault();

                            bool _new = aC == null;
                            if (_new)
                            {
                                aC = new ArticleContent();
                                aC.ArticleContentId = con.ArticleContentId;
                                aC.ArticleId = con.ArticleId;
                                aC.CreationDate = DateTime.Now;
                            }
                            aC.ModificationDate = DateTime.Now;
                            aC.Object = con.GetContent();
                            aC.ObjectIndex = i;
                            aC.ObjectTypeId = long.Parse(((int)con.ContentType).ToString());
                            aC.ObjectUrl = con.GetContentUrl();
                            aC.ObjectName = con.ArticleName;
                            aC.DynamicContent = con.GetDynamicContent();

                            if (_new)
                                controller.CurrentArticle.ArticleContents.Add(aC);
                        }

                        controller.GetData(dataType);
                        ShowMessage(5000, "Saved Data", Color.DarkGreen);
                        break;
                    case ArticleController.DataType.UpdateById:
                        break;
                    case ArticleController.DataType.FindByKArea:
                        break;
                    case ArticleController.DataType.FindByTheme:
                        break;
                    case ArticleController.DataType.FindByTitle:
                        break;
                    case ArticleController.DataType.FindByDescrip:
                        break;
                    case ArticleController.DataType.FindByContent:
                        break;
                    case ArticleController.DataType.FindByTags:
                        break;
                    case ArticleController.DataType.ValidateContent:
                        #region Validate Content
                        if (tbDescription.Text.Trim() == string.Empty)
                            throw new ArticleControllerException("-Title- field is required");
                        if (cbKArea.SelectedIndex == -1)
                            throw new ArticleControllerException("-Knowledge Area- field is required");
                        if (cbTheme.SelectedIndex == -1)
                            throw new ArticleControllerException("-Theme- field is required");
                        #endregion
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(15000, "Error: " + ex.Message, Color.Red);
                //MessageBox.Show(ex.Message, "Error");
            }
            return null;
        }

        private void SelectedTab_TextChanged(object sender, EventArgs e)
        {
            UcContent con = ((TabPage)sender).Controls.OfType<UcContent>().FirstOrDefault();
            con.ArticleName = ((TabPage)sender).Text;
        }

        private void AdjustControls()
        {
            foreach (Control c in flpTags.Controls)
                if (c.GetType() == typeof(UcRemovableLabel))
                    c.Size = new Size(((UcRemovableLabel)c).lbLabel.Width + ((UcRemovableLabel)c).btnRemove.Width + 30, c.Height);
        }


        void LoadCombos(bool changedTags)
        {
            Tags = (Dictionary<long, string>)GetData(ArticleController.DataType.LoadTags);
            tscbInsertTags.Items.Clear();
            tscbInsertTags.Items.AddRange(Tags.Select(t => t.Value).ToArray());

            if (!changedTags)
            {
                cbKArea.ValueMember = "CatValId";
                cbKArea.DisplayMember = "Val";
                cbKArea.DataSource = GetData(ArticleController.DataType.LoadKAreas);

                cbTheme.ValueMember = "CatValId";
                cbTheme.DisplayMember = "Val";
                cbTheme.DataSource = GetData(ArticleController.DataType.LoadThems);

                ContentType = (Dictionary<long, string>)GetData(ArticleController.DataType.LoadContenType);
                tscbContentType.Items.AddRange(ContentType.Values.ToArray());
                tscbContentType.SelectedIndex = 0;
            }
        }

        private bool CanRemoveContent(int i)
        {
            TabPage tP = tcContent.TabPages[i];
            UcContent con = tP.Controls.OfType<UcContent>().FirstOrDefault();
            if (con == null) return false;

            switch (con.ContentType)
            {
                case CatContentType.Image:
                    break;
                case CatContentType.PlainText:
                    if (((UcSingleTextEditor)con).GetCurrentDocument.Text.Trim().Length > 0)
                        return MessageBox.Show("Remove content?", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes;

                    break;
                case CatContentType.Audio:
                    break;
                case CatContentType.Video:
                    break;
                case CatContentType.WebContent:
                    break;
                case CatContentType.OtherContent:
                    break;
                default:
                    break;
            }
            return true;
        }

        private void DrawTags()
        {
            if (!string.IsNullOrEmpty(controller.CurrentArticle.Tags))
                foreach (var item in controller.CurrentArticle.Tags.Split(','))
                    DrawTag(long.Parse(item), Tags.Where(t => t.Key == long.Parse(item)).FirstOrDefault().Value);
        }

        void DrawTag(long id, string text)
        {
            UcRemovableLabel rlOne = new UcRemovableLabel();
            rlOne.LabelText = text;
            rlOne.LabelId = id;

            rlOne.OnRemoveLabel += RlOne_OnRemoveLabel;

            flpTags.Controls.Add(rlOne);
            rlOne.AutoSize = false;

            rlOne.Size = new Size(rlOne.lbLabel.Width + rlOne.btnRemove.Width + 30, rlOne.Height);
        }

        void AddContents(List<ArticleContent> artCont)
        {
            if (artCont == null) return;
            foreach (ArticleContent aC in artCont.OrderBy(ac => ac.ObjectIndex))
            {
                #region Add Content
                var _lastIndex = this.tcContent.TabCount - 1;

                UcContent newContent = null;

                switch ((CatContentType)int.Parse(aC.ObjectTypeId.ToString()))
                {
                    case CatContentType.Image:
                    case CatContentType.Audio:
                    case CatContentType.Video:
                    case CatContentType.OtherContent:
                        break;
                    case CatContentType.PlainText:
                        #region Plain Text
                        this.tcContent.TabPages.Insert(_lastIndex, aC.ObjectName);
                        this.tcContent.SelectedIndex = _lastIndex;
                        tcContent.TabPages[_lastIndex].TextChanged += SelectedTab_TextChanged;

                        newContent = new UcSingleTextEditor();
                        newContent.Name = "TextContent";
                        newContent.Dock = DockStyle.Fill;

                        break;
                    #endregion
                    case CatContentType.WebContent:
                        #region Web Content
                        tcContent.TabPages.Insert(_lastIndex, aC.ObjectName);
                        tcContent.SelectedIndex = _lastIndex;
                        tcContent.TabPages[_lastIndex].TextChanged += SelectedTab_TextChanged;

                        newContent = new UcWebContent();
                        newContent.Name = "WebContent";
                        newContent.Dock = DockStyle.Fill;

                        break;
                    #endregion

                    default:
                        return;

                }
                tcContent.TabPages[_lastIndex].Controls.Add(newContent);

                newContent.ContentType = (CatContentType)int.Parse(aC.ObjectTypeId.ToString());
                newContent.ArticleContentId = aC.ArticleContentId;
                newContent.ArticleId = aC.ArticleId;
                newContent.ArticleName = aC.ObjectName;
                newContent.SetDynamicContent(aC.DynamicContent.Value);
                newContent.SetContentUrl(aC.ObjectUrl);
                newContent.SetContent(aC.Object);


                tscbContentType.SelectedIndex = 0;
                cmsContentType.Close();

                #endregion
            }
        }

        private void LoadContents()
        {
            AddContents(controller.CurrentArticle.ArticleContents.ToList());
        }

        void ShowMessage(int time, string message, Color textColor)
        {
            if (tMessage == null)
            {
                tMessage = new Timer();
                tMessage.Interval = 5000;
                tMessage.Tick += TMessage_Tick;
            }
            lbMessage.ForeColor = textColor;
            lbMessage.Text = message;
            tMessage.Start();
        }

        #endregion


    }
}
