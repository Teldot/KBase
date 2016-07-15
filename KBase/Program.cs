using KBase.Logic.Controllers;
using KBase.View.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadSeed();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParentMain());
        }

        private static void LoadSeed()
        {
            //CatalogeController catController = new CatalogeController();
            //catController.GetData(CatalogeController.DataTypes.LoadSeeds);
        }
    }
}
