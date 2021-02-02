
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HydroMod
{
    public partial class h2omod : Form
    {
        List<Lux> myLuxs = new List<Lux>();

        public h2omod()
        {
            InitializeComponent();
            luxView.Nodes.Clear();
        }

        private void showLegend(object sender, EventArgs e)
        {
            new itemLegend().ShowDialog();
        }

        private void findLux(object sender, EventArgs e)
        {
            openLuxDiag.ShowDialog();
        }

        private void findLuxOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (string F in openLuxDiag.FileNames)
            {
                Lux myNewLux = new Lux(F);
                TreeNode/*myNewLux.*/_treeNode = luxView.Nodes.Add("", Path.GetFileName(F), 1, 1);
                //myNewLux._treeNode.Nodes.Add(System.Text.Encoding.ASCII.GetString(myNewLux.Get("")));
                myLuxs.Add(myNewLux);
                int nodeIcon = 0;
                foreach (LuxFile myLuxFile in myNewLux.FileList)
                {
                    switch (myLuxFile.Name.Substring(0,5))
                    {
                        case "txtr1":
                            nodeIcon = 2;
                            break;
                        case "data.":
                            nodeIcon = 0;
                            break;
                        case "mesh3":
                            break;
                        case "anim4":
                            break;
                        case "fbnk.":
                            nodeIcon = 3;
                            break;
                        case "shad4":
                            break;
                        case "coll4":
                            break;

                    }
                    _treeNode.Nodes.Add("", myLuxFile.Name, nodeIcon, nodeIcon);
                }
            }
        }

        private void selectLuxFile(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
                MessageBox.Show(
                    BitConverter.ToString(myLuxs[e.Node.Parent.Index].Get(e.Node.Text))
                );
        }
    }
}
