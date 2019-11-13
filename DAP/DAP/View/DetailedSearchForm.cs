using DAP.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<string> categoryList;
        private List<string> contentList;

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

            listBox1.DataSource = companyList;
            listBox2.DataSource = categoryList;
            listBox3.DataSource = contentList;
        }


        List<string> searchedItems = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchedItems.Clear();
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                foreach (string item in companyList)
                {
                    if (item.Contains(textBox1.Text))
                    {
                        searchedItems.Add(item);
                    }
                }
                listBox1.DataSource = null;
                listBox1.DataSource = searchedItems;
            }
            else
            {
                listBox1.DataSource = companyList;
                searchedItems.Clear();
            }
        }

        List<string> selectedItems = new List<string>();
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            selectedItems.Add(listBox1.Items[selectedIndex].ToString());
            listBox4.DataSource = null;
            listBox4.DataSource = selectedItems;

        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
