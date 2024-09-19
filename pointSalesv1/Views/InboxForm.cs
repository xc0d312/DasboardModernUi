using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pointSalesv1.Views
{
    public partial class InboxForm : Form
    {
        private List<Mensaje> stockALertHistoryMessages;
        public InboxForm(List<Mensaje> stockAlertHistory)
        {
            InitializeComponent();
            stockALertHistoryMessages = stockAlertHistory;
            showALertHistoryMessagesInTable();
        }
        public InboxForm()
        {
            InitializeComponent();
           
        }
        private void customTable()
        {
            if(tableInbox.RowCount > 0)
            {
                tableInbox.Columns[0].Width = 130;
                tableInbox.Columns[1].Width = tableInbox.Width - 130;
            }
          
        }

        public void showALertHistoryMessagesInTable()
        {
            tableInbox.DataSource = stockALertHistoryMessages;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InboxForm_Load(object sender, EventArgs e)
        {
            customTable();
        }
    }
    public class Mensaje
    {
        public DateTime Fecha { get; set; }

        public string Contenido { get; set; }
    }
}
