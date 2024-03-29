﻿using DAP.Model;
using DAP.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;


namespace DAP.Controller
{
    class DocumentController
    {
        private SQLiteAdapter SQLiteAdapter;        
        

        public DocumentController()
        {
            SQLiteAdapter = new SQLiteAdapter();
        }

        public DataTable getAllDocumentsFromDatabase()
        {            
            return SQLiteAdapter.getData();
        }

        
        /// <summary>
        /// Feltölt az adatbázisba egy új dokumentumot
        /// </summary>
        /// <param name="newDocument"></param>
        public int insertNewDocumentIntoDatabase(Document newDocument) {
            FileAdapter fa = new FileAdapter("0");
            if (newDocument != null)
            {
                SQLiteAdapter.insertData(newDocument);
            }

            if (fa.folderExists())
            {
                fa.renameFolder(Convert.ToString(SQLiteAdapter.getLastInserItemID()));
            }

            return SQLiteAdapter.getLastInserItemID();
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
        public void deleteSelectedDocumentIntoDatabase(HashSet<string> ids) {
            if (ids.Count != 0) {
                SQLiteAdapter.deleteItems(ids);
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
            return SQLiteAdapter.searchData(searchValue, category);
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

        /// <summary>
        /// Tömeges törléshez:
        /// ID alapján törli a megadott mappát és tartalmát
        /// </summary>
        /// <param name="ids"></param>
        public void deleteFolderMulti(HashSet<string> ids) 
        {
            foreach (string item in ids)
            {
                FileAdapter fa = new FileAdapter(item);

                if (fa.folderExists())
                {
                    fa.deleteFolder();
                }
            }
            
        }
        

        /// <summary>
        /// Idhoz tartozó file törlése
        /// </summary>
        /// <param name="id">Kiválasztott ID</param>
        /// <param name="filename">Törölni kívánt file neve</param>
        public void deleteFile(string id, string filename) {
            FileAdapter fa = new FileAdapter(id);
            fa.deleteFile(filename);
        }

        /// <summary>
        /// Kiválasztott file megnyitása id és file név alapján windows alapértelmezett program segítségével
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filename"></param>
        public void openFile(string id, string filename) {

            FileAdapter fa = new FileAdapter(id);
            fa.openFile(filename);
        }


        /// <summary>
        /// Tömeges módosítás
        /// </summary>
        /// <param name="id"></param>
        /// <param name="columnName"></param>
        /// <param name="newValue"></param>
        public void updateAllSelectedItem(HashSet<string> ids, string columnName, string newValue) {

            SQLiteAdapter.multiUpdate(ids, columnName, newValue);            
            
        }


        public void exportExcelSelectedItems(HashSet<string> selectedId, string savePathWhitFileNameAndExtension)
        {
            DataSet ds = SQLiteAdapter.getSelectedData(selectedId);

            bool export = CreateExcelFile.CreateExcelDocument(ds, savePathWhitFileNameAndExtension);
            try
            {
                if (export)
                {
                    System.Diagnostics.Process.Start(savePathWhitFileNameAndExtension);
                }
                
            }
            catch (Exception)
            {

                throw;
            }


        }

        /// <summary>
        /// Táblában található elemek számát adja vissza
        /// </summary>
        /// <returns></returns>
        public int getNumberOfRows()
        {
            return SQLiteAdapter.getNumberOfRows();
        }





    }
}
