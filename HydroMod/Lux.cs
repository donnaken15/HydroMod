
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HydroMod
{
    public enum FileType
    {
        Unknown,
        Container,
        Image,
        Audio,
        XML,
        INI,
        Consolelog
    }

    public struct LuxFile
    {
        public string Name;

        public uint Address;

        public uint Length;
    }

    public class Lux : IDisposable
    {
        public const int LUX_PTR_FILECNT = 4;
        public const int LUX_PTR_FILELST = 8;

        public Stream luxStream;

        //public TreeNode _treeNode;

        public List<LuxFile> FileList    = new List<LuxFile>();
        public List<string>  FileListStr = new List<string >();

        public uint FileLstAddr, FileCntAddr;

        public byte[] Get(string fileName)
        {
            LuxFile fileToRead = FileList[FileListStr.IndexOf(fileName)];
            luxStream.Position = fileToRead.Address;
            byte[] file = new byte[fileToRead.Length];
            luxStream.Read(file, 0, file.Length);
            return file;
        }

        public Lux(string fName)
        {
            luxStream = new FileStream(fName, FileMode.Open, FileAccess.ReadWrite);

            byte[] buf = new byte[8];
            luxStream.Position = LUX_PTR_FILECNT;
            luxStream.Read(buf, 0, 8);
            //luxStream.Position = LUX_PTR_FILELST;
            //luxStream.Read(buf, 0, 4);
            FileCntAddr = BitConverter.ToUInt32(buf, 0);
            FileLstAddr = BitConverter.ToUInt32(buf, 4);

            //MessageBox.Show(FileCntAddr.ToString("X"));

            luxStream.Position = FileLstAddr;

            for (int i = 0; i < FileCntAddr; i++)
            {
                LuxFile newFile = new LuxFile();
                // read file listing item
                buf = new byte[0x60];
                luxStream.Read(buf, 0, 0x60);
                //MessageBox.Show(BitConverter.ToString(buf));
                // copy id of item
                int j;
                for (j = 0; j < 0x23; j++)
                {
                    if (buf[j] == 0x00)
                        break;
                }
                char[] id = new char[j];
                Array.Copy(buf, id, j);
                newFile.Name = new string(id);
                FileListStr.Add(newFile.Name);
                // copy address
                //byte[] ptr = new byte[4];
                //Array.Copy(buf, 0x48, ptr, 0, 4);
                newFile.Address = BitConverter.ToUInt32(buf, 0x48);
                newFile.Length = BitConverter.ToUInt32(buf, 0x40);
                FileList.Add(newFile);
            }
        }

        public void Dispose()
        {
            luxStream.Close();
            FileList = null;
            FileListStr = null;
            FileCntAddr = 0;
            FileLstAddr = 0;
        }
    }
}
