using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PropertyFileProject
{
    public partial class FrmPropertyFile : Form
    {
        public FrmPropertyFile()
        {
            InitializeComponent();
        }

        private void BtnRetrieveProperty_Click(object sender, EventArgs e)
        {
            string _path = @"C:\Database\SQL2005\Readme.txt";

            StringBuilder _stringFile = new StringBuilder();
            FileAttributes _fileAttributes = new FileAttributes();

            _stringFile.Append("File : " + _path + "\r\n");
            _stringFile.Append("Create Date : " + File.GetCreationTime(_path ) + "\r\n");
            _stringFile.Append("Last Access Date : " + File.GetLastAccessTime(_path) + "\r\n");
            _stringFile.Append("Last Write Date : " + File.GetLastWriteTime(_path) + "\r\n");
            _stringFile.Append("File Attribute : " + File.GetAttributes(_path) + "\r\n");

            _stringFile.Append("Normal : " + Convert.ToBoolean((_fileAttributes & FileAttributes.Normal) == FileAttributes.Normal) + "\r\n");
            _stringFile.Append("Hidden : " + Convert.ToBoolean((_fileAttributes & FileAttributes.Hidden) == FileAttributes.Hidden) + "\r\n");
            _stringFile.Append("ReadOnly : " + Convert.ToBoolean((_fileAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) + "\r\n");
            _stringFile.Append("System : " + Convert.ToBoolean((_fileAttributes & FileAttributes.System) == FileAttributes.System) + "\r\n");
            _stringFile.Append("Archive : " + Convert.ToBoolean((_fileAttributes & FileAttributes.Archive) == FileAttributes.Archive) + "\r\n");

            MessageBox.Show(_stringFile.ToString());

        }
    }
}
