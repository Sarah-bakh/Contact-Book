using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ContactDB
{
    internal interface IContactRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int contactID);
        DataTable Search(string parameter);
        bool Insert(string name ,string family ,string adress, string emaill,string mobile ,int age);
        bool Update(int contactID , string name, string family, string adress, string emaill, string mobile, int age);
        bool Delete(int contactID);

    }
}
