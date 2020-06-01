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
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using DevExpress.Utils.Extensions;

namespace C_Card.Views
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private readonly SqlConnection sql;

        public MainView()
        {
            InitializeComponent();
            sql = new SqlConnection(Data.cn);
            RefreshView();

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        public BindingList<Transaction> GetDataSource()
        {
            BindingList<Transaction> result = new BindingList<Transaction>();
            var query = "SELECT * FROM [Transactions]";
            SqlCommand command = new SqlCommand(query, sql);
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Transaction
                {
                    ID = reader[0].ToString(),
                    CardHolder = reader[1].ToString(),
                    CardNumber = reader[2].CastTo<Int32>(),
                    Concept = reader[4].ToString(),
                    Amount = reader[5].CastTo<Decimal>(),
                    Date = reader[6].ToString() ?? "null"
                });
            }
            reader.Close();
            command.Connection.Close();
            return result;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var instance = Controller.GetInstance().transactionView;
            if (instance != null) instance.Dispose();
            instance = Controller.GetInstance().transactionView = new NewTransaction();
            instance.Show();

        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.GetInstance().logIn.Show();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID").ToString();
            var instance = Controller.GetInstance().editTransaction;
            if (instance != null) instance.Dispose();
            instance = Controller.GetInstance().editTransaction = new EditTransaction(value);
            instance.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID").ToString();
            var query = "DELETE FROM Transactions WHERE Id = '" + value + "'";
            SqlCommand command = new SqlCommand(query, sql);
            command.Connection.Open();
            var res = command.ExecuteNonQuery();
            command.Connection.Close();
            if (res != 0) MessageBox.Show("The transaction has been deleted.");
            RefreshView();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshView();
        }

        public void RefreshView()
        {
            gridControl.DataSource = GetDataSource();
            BindingList<Transaction> dataSource = GetDataSource();
            gridControl.DataSource = dataSource;
            gridView.Columns[2].Visible = false;
            gridView.Columns[6].Visible = false;
            gridView.Columns[7].Visible = false;
            gridView.Columns[8].Visible = false;
            gridView.Columns[9].Visible = false;
            gridView.Columns[10].Visible = false;
            gridView.Columns[11].Visible = false;
            gridView.Columns[12].Visible = false;
            gridView.Columns[13].Visible = false;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
    }
}