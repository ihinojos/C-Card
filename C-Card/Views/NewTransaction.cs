using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using System.Data.SqlClient;

namespace C_Card.Views
{
    public partial class NewTransaction : XtraForm
    {
        private readonly SqlConnection sql;
        public NewTransaction()
        {
            InitializeComponent();
            sql = new SqlConnection(Data.cn);
        }

        private void windowsUIButtonPanel_ButtonClick(object sender, ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "save":
                    SaveRec();
                    break;
                case "cancel":
                    Dispose();
                    break;
            }
        }

        private void SaveRec()
        {
            var name = nameBox.Text;
            var card = cardBox.Text;
            var amount = amountBox.Text;
            var concept = conceptBox.Text;
            var entity = entityBox.Text;
            var notes = notesBox.Text;
            var date = datePicker.Value.ToString("MM/dd/yyyy HH:mm:ss");

            var query = "INSERT INTO Transactions ([Id], [CardHolder], [CardNumber], [Amount], [Concept], [Entity], [Notes], [Date]) VALUES (NEWID(),'"+name+"'," +
                            ""+card+", "+amount+", '"+concept+"', '"+entity+"', '"+notes+"', '"+date+"')";
            SqlCommand command = new SqlCommand(query, sql);
            command.Connection.Open();
            var res = command.ExecuteNonQuery();
            command.Connection.Close();

            if (res == 1)
            {
                MessageBox.Show("The record has been saved.");
                Controller.GetInstance().mainView.RefreshView();
                Dispose();
            }

        }
    }
}
