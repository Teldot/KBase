using KBase.Data.Model;
using KBase.Data.Model.Catalogs;
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

namespace KBase.View.Forms
{
    public partial class FAdminCats : Form
    {
        #region Atributes
        CatalogeController controller;
        #endregion
        #region Properties
        /// <summary>
        /// Catalog to administrate
        /// </summary>
        public CatTypes Cat2Admin { get; set; }
        #endregion
        #region Contructor
        public FAdminCats(CatTypes cat2Admin)
        {
            Cat2Admin = cat2Admin;
            controller = new CatalogeController(Cat2Admin);
            InitializeComponent();
        }
        #endregion

        #region Events
        private void FAdminCats_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.configIcon;
            switch (Cat2Admin)
            {
                case CatTypes.KnowledgeAreas:
                    Text = "Admin Master Catalogs - Knowledge Areas";
                    cbKAreas.Visible = false;
                    LoadDataGrid();
                    break;
                case CatTypes.Themes:
                    Text = "Admin Master Catalogs - Themes";
                    LoadCombos();
                    break;
                case CatTypes.Tags:
                    Text = "Admin Master Catalogs - Tags";
                    cbKAreas.Visible = false;
                    LoadDataGrid();
                    break;
                default:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData()) return;

                controller.DataObject = new Dictionary<string, object>();
                if (tbNewCatVal.Tag != null)
                    controller.DataObject.Add(CatalogeController.DataFields.CatId.ToString(), tbNewCatVal.Tag);
                controller.DataObject.Add(CatalogeController.DataFields.Value.ToString(), tbNewCatVal.Text);
                switch (Cat2Admin)
                {
                    case CatTypes.Themes:
                        controller.DataObject.Add(CatalogeController.DataFields.Parent0.ToString(), cbKAreas.SelectedValue);
                        break;
                    default:
                        break;
                }
                controller.GetData(CatalogeController.DataTypes.Save);
                LoadDataGrid();
                //tbNewCatVal.Text = string.Empty;
                //cbKAreas.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateData()
        {
            if (tbNewCatVal.Text.Trim().Length == 0)
                throw new Exception("Must insert Catalog Value");
            switch (Cat2Admin)
            {
                case CatTypes.Themes:
                    if (cbKAreas.SelectedIndex == 0)
                    {
                        throw new Exception("Must select Knowledge Area");
                    }
                    break;
                default:
                    break;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods
        private void LoadCombos()
        {
            cbKAreas.DisplayMember = "Val";
            cbKAreas.ValueMember = "CatValId";
            cbKAreas.DataSource = controller.GetData(CatalogeController.DataTypes.LoadParentCat);
        }

        private void LoadDataGrid()
        {
            controller.DataObject = new Dictionary<string, object>();
            if (cbKAreas.SelectedIndex > 0)
            {
                controller.DataObject.Add(CatalogeController.DataFields.Parent0.ToString(),
                    cbKAreas.SelectedValue);
            }
            dgvCats.DataSource = controller.GetData(CatalogeController.DataTypes.Load);
            if (dgvCats.Columns.Count>0)
                dgvCats.Columns[0].Visible = false;

            dgvCats.ClearSelection();
        }


        #endregion

        private void dgvCats_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedCells != null &&
                ((DataGridView)sender).SelectedCells.Count > 0)
            {
                int r = ((DataGridView)sender).SelectedCells[0].RowIndex;

                tbNewCatVal.Text = dgvCats.Rows[r].Cells[1].Value.ToString();
                tbNewCatVal.Tag = dgvCats.Rows[r].Cells[0].Value;
            }
            else
            {
                tbNewCatVal.Text = string.Empty;
                tbNewCatVal.Tag = null;
            }

        }

        private void cbKAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGrid();
        }


    }
}
