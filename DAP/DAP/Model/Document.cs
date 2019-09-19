using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAP.Model
{
    class Document
    {
        private int id;
        private string company;
        private string category;
        private string content;
        private string date;
        private string description;      

        public Document(int id, string company, string category, string content, string date, string description)
        {
            this.id = id;
            this.company = company;
            this.category = category;
            this.content = content;
            this.date = date;
            this.description = description;           
        }
               
        #region Getters and Setters
        public int getID()
        {
            return id;
        }

        public string getCompany()
        {
            return company;
        }

        public string getCategory()
        {
            return category;
        }

        public string getContent()
        {
            return content;
        }

        public string getDate()
        {
            return date;
        }

        public string getDescription()
        {
            return description;
        }        
        #endregion
       

    }
}
