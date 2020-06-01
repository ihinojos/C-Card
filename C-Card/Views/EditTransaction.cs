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
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using DevExpress.Entity.Model.DescendantBuilding;
using System.Data.SqlClient;

namespace C_Card.Views
{
    public partial class EditTransaction : DevExpress.XtraEditors.XtraForm
    {
        private readonly string id;
        private readonly SqlConnection sql;
        public EditTransaction(string id)
        {
            this.id = id;
            InitializeComponent();
            sql = new SqlConnection(Data.cn);
            LoadInfo();
        }

        private void LoadInfo()
        {
            var cmd = "SELECT * From [Transactions] WHERE Id = '"+id+"'";
            SqlCommand command = new SqlCommand(cmd, sql);
            command.Connection.Open();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                }
                command.Connection.Close();
            }
            Console.WriteLine(id);
        }
    }
}