
using S16.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
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
            {
                Lux curLux = myLuxs[e.Node.Parent.Index];
                LuxFile curFile = curLux.FileList[e.Node.Index];
                luxTextMeta.Text = "Filename : " + e.Node.Text +
                    "\nAddress  : " + curFile.Address.ToString("X8") +
                    "\nSize     : " + curFile.Length.ToString("X8");
                string curFileString = new string(Encoding.ASCII.GetChars(curLux.Get(e.Node.Text))).Replace("\0", "\x01");
                dataViewText.Text = curFileString;
                dataViewText.MaxLength = curFileString.Length;
                DDSImage curFileImage = new DDSImage(curLux.Get(e.Node.Text));
                if (curFileImage != null)
                {
                    /*{
                    Stream myImage = new MemoryStream();
                        DDSImage.Save(curFileImage, myImage, curFileImage.Format);
                        byte[] test = new byte[0x20];
                        myImage.Read(test, 0, 0x20);
                        MessageBox.Show(BitConverter.ToString(test));
                    myImage.Close();
                    }*/
                    dataViewImage.Image = (curFileImage.BitmapImage);
                    curFileImage.BitmapImage.Save("TEST.PNG");
                }
            }
        }

        private void saveLuxFile(object sender, EventArgs e)
        {
            saveLuxFDiag.ShowDialog();
        }

        private void saveLuxFDiagOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.WriteAllBytes(saveLuxFDiag.FileName, myLuxs[luxView.SelectedNode.Parent.Index].Get(luxView.SelectedNode.Text));
        }

        private void luxViewClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Parent != null)
                {
                    luxFileCtxtM.Show(Cursor.Position);
                }
                else
                {

                }
            }
        }
    }
}
