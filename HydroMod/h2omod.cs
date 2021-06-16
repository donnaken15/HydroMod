
using DDS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Be.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace HydroMod
{
    public partial class h2omod : Form
    {
        List<Lux> myLuxs = new List<Lux>();
        char[] bUnits = " KMGT".ToCharArray();
        uint bThousand = 1024; // based *ibibytes
        CommonOpenFileDialog luxCtnrXtrctDiag = new CommonOpenFileDialog();

        public string FileSize(long length)
        {
            float newSize = length;
            byte bUnit = 0;
            while (newSize >= bThousand && bUnit < bUnits.Length - 1)
            {
                bUnit++;
                newSize /= bThousand;
            }
            if (bUnit == 0)
                return newSize.ToString("0") + " bytes";
            else
                return newSize.ToString("0.0 ") + bUnits[bUnit] + 'B';
        }

        public h2omod()
        {
            InitializeComponent();
            luxView.Nodes.Clear();
            openLuxDiag.InitialDirectory = Directory.GetCurrentDirectory();
            luxCtnrXtrctDiag.InitialDirectory = Directory.GetCurrentDirectory();
            luxCtnrXtrctDiag.IsFolderPicker = true;
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
                TreeNode/*myNewLux.*/_treeNode = luxView.Nodes.Add(F, Path.GetFileName(F), 1, 1);
                //myNewLux._treeNode.Nodes.Add(System.Text.Encoding.ASCII.GetString(myNewLux.Get("")));
                myLuxs.Add(myNewLux);
                foreach (LuxFile myLuxFile in myNewLux.FileList)
                {
                    int nodeIcon = 0;
                    // should probably make this its own function and return an id or something
                    switch (myLuxFile.Name.Substring(0, 5))
                    {
                        case "txtr1":
                            nodeIcon = 2;
                            break;
                        case "data.":
                            byte[] tmp = myNewLux.Get(myLuxFile.Name);
                            char[] tmp2 = new char[5];
                            if (tmp.Length > tmp2.Length)
                            {
                                Array.Copy(tmp, 0, tmp2, 0, tmp2.Length);
                                switch (new string(tmp2))
                                {
                                    case " Volu":
                                        nodeIcon = 6;
                                        break;
                                    case "<?xml":
                                        nodeIcon = 4;
                                        break;
                                    case "textu":
                                        nodeIcon = 7;
                                        break;
                                    case "// Tu":
                                    case "// Th":
                                        nodeIcon = 5;
                                        break;
                                    default:
                                        nodeIcon = 0;
                                        break;
                                }
                            }
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
                    "\nSize     : " + curFile.Length.ToString("X8") + " (" + FileSize(curFile.Length) + ")";
                dataViewImage.Size = new Size(512, 512);
                dataViewImage.Image = null;
                dataViewBin.ByteProvider = new DynamicByteProvider(curLux.Get(e.Node.Text));
                ddsCtxtXport.Enabled = false;
                switch (e.Node.Text.Substring(0, 5))
                {
                    case "txtr1":
                        DDSImage myTex = DDSImage.Load(curLux.Get(e.Node.Text));
                        dataViewImage.Image = myTex.Images[0];
                        //byte[] _DDS = new byte[curFile.Length - 0x1C];
                        //curLux.luxStream.Position = curFile.Address;
                        //curLux.luxStream.Read(_DDS, 0x1C, _DDS.Length);
                        //Array.Copy(curLux.Get(e.Node.Text), 0x1C, DDS, 0, DDS.Length);
                        ddsCtxtXport.Enabled = true;
                        dataViewTabs.SelectedIndex = 0;
                        luxView.Focus();
                        break;
                    case "data.":
                        string curFileString = new string(Encoding.ASCII.GetChars(curLux.Get(e.Node.Text))).Replace("\0", "\x01");
                        dataViewText.Text = curFileString;
                        dataViewText.MaxLength = curFileString.Length;

                        dataViewTabs.SelectedIndex = 2;
                        luxView.Focus();
                        break;
                    case "mesh3":
                    case "anim4":
                    case "fbnk.":
                    case "shad4":
                    case "coll4":
                        dataViewTabs.SelectedIndex = 1;
                        luxView.Focus();
                        break;
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
                    luxCtnrCtxtM.Show(Cursor.Position);
                }
            }
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        private void closeLux(object sender, EventArgs e)
        {
            int killLux;
            if (luxView.SelectedNode.Parent == null)
            {
                killLux = luxView.SelectedNode.Index;
            }
            else
            {
                killLux = luxView.SelectedNode.Parent.Index;
            }
            luxView.Nodes.RemoveAt(killLux);
            myLuxs[killLux].Dispose();
            myLuxs.RemoveAt(killLux);
            luxTextMeta.Text = "No file selected";
            dataViewImage.Size = new Size(512, 512);
            dataViewImage.Image = null;
        }

        private void luxCtnrXtrctAll(object sender, EventArgs e)
        {
            if (luxCtnrXtrctDiag.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (MessageBox.Show(
    "This could take a while depending on your system performance, " +
    "file extensions won't be set to their appropriate counterparts, " +
    // (i.e. txtr1.dummy --(/)-> dummy.dds)
    "and " + FileSize(myLuxs[0].luxStream.Length) + " of data will be copied. Click 'Yes' to continue.",
        "Warning", MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2
    ) == DialogResult.Yes)
                    foreach (LuxFile myLuxFile in myLuxs[luxView.SelectedNode.Index].FileList)
                    {
                        File.WriteAllBytes(
                            luxCtnrXtrctDiag.FileName + '\\' + myLuxFile.Name,
                            myLuxs[luxView.SelectedNode.Index].Get(myLuxFile.Name));
                    }
            }
        }

        private void ddsXport(object sender, EventArgs e)
        {
            ddsXportFDiag.ShowDialog();
        }

        private void Exit(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            for (int i = 0; i < myLuxs.Count; i++)
            {
                myLuxs[i].Dispose();
            }
            myLuxs.Clear();
            Application.Exit();
        }

        private void ddsXportFDiagConf(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Path.GetExtension(ddsXportFDiag.FileName) != ".dds")
                dataViewImage.Image.Save(ddsXportFDiag.FileName);
            else
            {
                byte[] tmp = myLuxs[luxView.SelectedNode.Parent.Index].Get(luxView.SelectedNode.Text),
                    tmp2 = new byte[tmp.Length - 0x1C];
                Array.Copy(tmp, 0x1C, tmp2, 0, tmp2.Length);
                File.WriteAllBytes(ddsXportFDiag.FileName, tmp2);
            }
        }
    }
}
