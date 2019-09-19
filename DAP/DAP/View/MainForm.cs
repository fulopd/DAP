using DAP.Model;
using DAP.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAP
{
    public partial class MainForm : Form
    {
        private SQLiteAdapter SQLiteAdapter;
        private List<Document> docs;

        public MainForm()
        {
            InitializeComponent();

            SQLiteAdapter = new SQLiteAdapter();

            Document test = new Document(0, "obiteszt", "obicategory", "Harcsa", "1922.02.01", "Valaamiii iii i ii i i i i ii i i iiiiii iii");
            SQLiteAdapter.insertData(test);
            //MessageBox.Show("" + SQLiteAdapter.getLastInserItemID());

            //Document test = new Document(2, "modCompany2", "egy új kategória", "banana", "1999.05.01", "Mod hosszú leírás sok sok karakterrel ellátva hogy ilyen is legyen benne", "valami.txt");
            //SQLiteAdapter.modifyItem(test);

            docs = SQLiteAdapter.getData();

            DataTable dt = SQLiteAdapter.convertToDataTable(docs);
            dataGridViewMainGrid.DataSource = dt;
        }
    }
}
