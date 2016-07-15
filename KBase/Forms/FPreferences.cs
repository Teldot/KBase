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
    public partial class FPreferences : Form
    {
        #region Atributes
        CatalogeController controller;
        #endregion
        #region Constructor
        public FPreferences()
        {
            InitializeComponent();
            controller = new CatalogeController();
        }
        #endregion

#region Events
        private void FPreferences_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.configIcon;
        }

        private void llMKAreas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAdminCats fAdminCats = new FAdminCats(CatTypes.KnowledgeAreas);
            fAdminCats.ShowDialog();
        }

        private void llMThemes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAdminCats fAdminCats = new FAdminCats(CatTypes.Themes);
            fAdminCats.ShowDialog();
        }

        private void llMTags_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAdminCats fAdminCats = new FAdminCats(CatTypes.Tags);
            fAdminCats.ShowDialog();
        }
        #endregion
    }
}
