﻿using DAP.Model;
using DAP.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
            FileAdapter fa = new FileAdapter("0");
            if (newDocument != null)
            {
                SQLiteAdapter.insertData(newDocument);
            }

            if (fa.folderExists())
            {
                fa.renameFolder(Convert.ToString(SQLiteAdapter.getLastInserItemID()));
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
        public List<string> getUnicData(string columnName) {
            List<string> unicCompany;            
            return unicCompany = SQLiteAdapter.getUnicItemsIntoColumn(columnName);
        }

        /// <summary>
        /// Keresés az adatbázisban kiválasztotta kategóriákban keresési érték alapján
        /// </summary>
        /// <param name="searchValue">Keresési érték</param>
        /// <param name="category">Kiválasztott kategóriák</param>
        /// <returns></returns>
        public DataTable searchIntoDatabase(string searchValue, List<string>category) {
            DataTable dt = null;
            if (category.Count > 0 )
            {
                docs = SQLiteAdapter.searchData(searchValue, category);
                dt = SQLiteAdapter.convertToDataTable(docs);
            }
            return dt;
        }

        /// <summary>
        /// ID alapján lekéri az összes filt az adott elemhez
        /// </summary>
        /// <param name="id">Kívánt elem azonosítója</param>
        /// <returns>DirectoryInfoban az összes hozzá tartozo elem</returns>
        public DirectoryInfo getAllFilesById(string id) {
            FileAdapter fa = new FileAdapter(id);
            DirectoryInfo di = fa.getAllFiles();
            return di;

        }

        /// <summary>
        /// ID alapján ha még nem létezik létrehoz egy mappát és átmásolja a kijelölt filokat
        /// </summary>
        /// <param name="id"></param>
        /// <param name="openFileDialogFileNames"></param>
        /// <param name="openFileDialogSafeFileNames"></param>
        public void uplodeFilesById(string id, string[] openFileDialogFileNames, string[] openFileDialogSafeFileNames) {
            FileAdapter fa = new FileAdapter(id);
            fa.createFolderByID();
            fa.copyFiles(openFileDialogFileNames, openFileDialogSafeFileNames);
        }

        /// <summary>
        /// ID alapján törli a megadott mappát és tartalmát
        /// </summary>
        /// <param name="id"></param>
        public void deleteFolder(string id) {
            FileAdapter fa = new FileAdapter(id);

            if (fa.folderExists())
            {
                fa.deleteFolder();
            }
        }
    }
}
