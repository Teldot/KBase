using KBase.Logic.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using KBase.Data.Model;

namespace KBase.View.Forms
{
    public partial class MDIParentMain : Form
    {
        #region Atributes
        private int childFormNumber = 0;
        ArticleController controller;
        FArticle fArticle;
        #endregion

        #region Constructor
        public MDIParentMain()
        {
            InitializeComponent();
            controller = new ArticleController();
        }
        #endregion

        #region Events
        private void MDIParentMain_Load(object sender, EventArgs e)
        {
            GetData(ArticleController.DataType.LoadAll);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fArticle = new FArticle(ArticleController.DataType.New);
            fArticle.ShowDialog();

        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            FPreferences fPreferences = new FPreferences();
            fPreferences.ShowDialog();
        }

        private void tvArticles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                fArticle = new FArticle(ArticleController.DataType.Edit, (Guid)e.Node.Tag);
                fArticle.ShowDialog();
                tvArticles.Nodes.Clear();
                GetData(ArticleController.DataType.LoadAll);
            }
        }
        #endregion

        #region Events
        private object GetData(ArticleController.DataType dataType)
        {
            try
            {
                switch (dataType)
                {
                    case ArticleController.DataType.AddContent:
                        break;
                    case ArticleController.DataType.CanRemoveContent:
                        break;
                    case ArticleController.DataType.RemoveContent:
                        break;
                    case ArticleController.DataType.Load:
                        break;
                    case ArticleController.DataType.LoadThems:
                        break;
                    case ArticleController.DataType.LoadKAreas:
                        break;
                    case ArticleController.DataType.LoadTags:
                        break;
                    case ArticleController.DataType.LoadContenType:
                        break;
                    case ArticleController.DataType.LoadAll:
                        #region Load All
                        string allArt = (string)controller.GetData(ArticleController.DataType.LoadAll);

                        if (string.IsNullOrEmpty(allArt)) return null;

                        List<KAreaItem> kTree = JsonConvert.DeserializeObject<List<KAreaItem>>(allArt);

                        foreach (var item in kTree)
                        {
                            TreeNode tnKArea = new TreeNode(string.Format("{0} ({1})     ", item.KAreaName,
                                item.Themes == null ? "0" : item.Themes.Count.ToString()));

                            tnKArea.NodeFont = new Font("Sans Serif", 8, FontStyle.Bold);
                            if (item.Themes != null)
                                foreach (var th in item.Themes)
                                {
                                    TreeNode tnThem = new TreeNode(string.Format("{0} ({1})     ", th.ThemeName,
                                        th.Articls == null ? "0" : th.Articls.Count.ToString()));
                                    tnThem.NodeFont = new Font("Sans Serif", 8, FontStyle.Bold);
                                    if (th.Articls != null)
                                        foreach (var are in th.Articls)
                                        {
                                            TreeNode tnAr = new TreeNode(are.ArticleTitle + " - " + are.ArticleDescription);
                                            tnAr.Tag = are.ArticleId;
                                            tnThem.Nodes.Add(tnAr);
                                        }
                                    tnKArea.Nodes.Add(tnThem);
                                }
                            tvArticles.Nodes.Add(tnKArea);

                        }
                        tvArticles.ExpandAll();
                        return null;
                    #endregion
                    case ArticleController.DataType.LoadById:
                        break;
                    case ArticleController.DataType.New:
                        break;
                    case ArticleController.DataType.Edit:
                        break;
                    case ArticleController.DataType.Save:
                        break;
                    case ArticleController.DataType.DeleteById:
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
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return null;
        }
        #endregion

        #region Methods MDI
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        

        #endregion


    }
}
