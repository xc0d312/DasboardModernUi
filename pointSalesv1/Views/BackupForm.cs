using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using pointSalesv1.Repository.ORMDataModelCode;
using pointSalesv1.Messages;

namespace pointSalesv1.Views
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            var obj = new repository();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(saveFileDialog1.FileName);


                using (var connection = obj.backupConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        using (var backup = new MySqlBackup(cmd))
                        {
                            string route = path.Replace(@"\", @"\\");
                            backup.ExportToFile(route);
                            NotifyForm.showMessageForm("Backup creada");
                        }
                    }
                }

            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            var obj = new repository();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // string path = Path.GetFullPath(saveFileDialog1.FileName);
                string path = Path.GetFullPath(openFileDialog1.FileName);


                using (var connection = obj.backupConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        using (var backup = new MySqlBackup(cmd))
                        {
                            string route = path.Replace(@"\", @"\\");
                            backup.ImportFromFile(route);
                            NotifyForm.showMessageForm("Backup restaurada");
                        }
                    }
                }

            }
        }
    }
}
