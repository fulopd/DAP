using DAP.Model;
using DAP.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAP.Controller
{
    class DocumentController
    {
        private SQLiteAdapter SQLiteAdapter;
        private List<Document> docs;
        

        public DocumentController()
        {
            SQLiteAdapter = new SQLiteAdapter();
        }

        /// <summary>
        /// Lekéri az adatbázis összes elemét és DataTale Formára alakítja
        /// </summary>
        /// <returns></returns>
        public DataTable getAllDocumentsFromDatabase() {

            docs = SQLiteAdapter.getData();
            DataTable dt = SQLiteAdapter.convertToDataTable(docs);
            return dt;
        }

        /// <summary>
        /// Feltölt az adatbázisba egy új dokumentumot
        /// </summary>
        /// <param name="newDocument"></param>
        public void insertNewDocumentIntoDatabase(Document newDocument) {

            if (newDocument != null)
            {
                SQLiteAdapter.insertData(newDocument);
            }
        }
    }
}
