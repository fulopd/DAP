using DAP.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAP.View
{
    public partial class DetailedSearchForm : Form
    {
        private DocumentController dc;
        private List<string> companyList;
        private List<string> resultCompanyList = new List<string>();
        private List<string> categoryList;
        private List<string> contentList;

        private List<string> searchedItems = new List<string>();        //Ideiglenes tároló keresésez

        public DetailedSearchForm()
        {
            InitializeComponent();
        }

        private void DetailedSearchForm_Load(object sender, EventArgs e)
        {
            dc = new DocumentController();

            companyList = dc.getUnicData("Company");
            categoryList = dc.getUnicData("Category");
            contentList = dc.getUnicData("Content");

            listBoxCompany.DataSource = companyList;
            listBoxCategory.DataSource = categoryList;
            listBoxContent.DataSource = contentList;
        }


        

        /// <summary>
        /// Keresés a kiválasztott ListBox -ban
        /// </summary>
        /// <param name="lb">ListBox amiben keresni akarunk</param>
        /// <param name="tb">TextBox ahova a keresési kifejezés kerül</param>
        /// <param name="originalList">Eredeti lista, amiben keresünk (alapból ez az adatforrása a Listbox-nak)</param>
        private void searchInListBox(ListBox lb, TextBox tb, List<string> originalList)
        {
            searchedItems.Clear( );
            if (!string.IsNullOrEmpty(tb.Text))
            {
                foreach (string item in originalList)
                {
                    string lowerCaseItem = item.ToLower();
                    string lowerCaseText = tb.Text.ToLower();
                    if (lowerCaseItem.Contains(lowerCaseText))
                    {
                        searchedItems.Add(item);
                    }
                }
                lb.DataSource = null;
                lb.DataSource = searchedItems;
            }
            else
            {
                lb.DataSource = null;
                lb.DataSource = originalList;
                searchedItems.Clear();
            }
        }

        /// <summary>
        /// Dupla kattintás lista elemen, áthelyezés másik listába / ListbBox-ba
        /// </summary>
        /// <param name="sourceLB">Forrás ListBox</param>
        /// <param name="targetLB">Cél ListBox</param>
        /// <param name="sourceList">Forrás string lista</param>
        /// <param name="targetList">Cél string Lista</param>
        private void sourceListBoxDoubleClickEvent(ListBox sourceLB, ListBox targetLB, List<string> sourceList, List<string> targetList)
        {
            try
            {
                string selectedItem = sourceLB.SelectedItem.ToString();
                targetList.Add(selectedItem);
                sourceList.Remove(selectedItem);
                targetLB.DataSource = null;
                targetLB.DataSource = targetList;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Részletes keresés dupla klikk: (Egyéb hiba): " + e.Message);
            }
        }


        //Company
        private void textBoxSearchCompany_TextChanged(object sender, EventArgs e)
        {
            searchInListBox(listBoxCompany, textBoxSearchCompany, companyList);
        }        
        private void listBoxCompany_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sourceListBoxDoubleClickEvent(listBoxCompany, listBoxResultCompany, companyList, resultCompanyList);
            searchInListBox(listBoxCompany, textBoxSearchCompany, companyList);
        }
        private void listBoxResultCompany_DoubleClick(object sender, EventArgs e)
        {            
            sourceListBoxDoubleClickEvent(listBoxResultCompany, listBoxCompany, resultCompanyList, companyList);
            listBoxResultCompany.DataSource = null;
            listBoxResultCompany.DataSource = resultCompanyList;
            searchInListBox(listBoxCompany, textBoxSearchCompany, companyList);
        }









        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
