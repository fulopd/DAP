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

        /// <summary>
        /// Módosítja a kapott dokumentumot az adatbázisban
        /// </summary>
        /// <param name="modDocument"></param>
        public void modifySelectedDocumentIntoDatabase(Document modDocument) {
            if (modDocument != null)
            {
                SQLiteAdapter.modifyItem(modDocument);
            }
        }

        /// <summary>
        /// Törli a kiválasztott elemet ID alapján az adatbázisból
        /// </summary>
        /// <param name="id"></param>
        public void deleteSelectedDocumentIntoDatabase(string id) {
            if (id != "") {
                SQLiteAdapter.deleteItem(id);
            }
        }

        // <summary>
        /// Lekéri az adatbázistól az összes megadott oszlophoz tartozó egyedi adatot
        /// </summary>
        /// <param name="columnName">Oszlp neve</param>
        /// <returns>Egyedi adatok a megadott oszloptól</returns>       
        public List<string> getUnicCompany(string columnName) {
            List<string> unicCompany;            
            return unicCompany = SQLiteAdapter.getUnicItemsIntoColumn(columnName);
        }

    }
}
