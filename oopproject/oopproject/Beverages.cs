using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopproject
{
    class Beverages
    {
        private string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=oopproject";
        private string Query = "select * from beverages;";
        private string B_id;
        private string B_name;


        public Beverages() { }
        public Beverages(string id, string n)
        {
            this.B_id = id;
            this.B_name = n;

        }
        public string getMycon()
        {
            return this.MyConnection2;
        }
        public string getQuery()
        {
            return this.Query;
        }
        public string AddBeverages()
        {
            return "insert into Beverages(B_id,B_name) values('" + this.B_id + "','" + this.B_name + "');";
        }
        public string DeBeverages()
        {
            return "delete from Beverages where `B_id`='" + this.B_id + "';";

        }
        public string UpBeverages()
        {
            return "update `Beverages` set `B_name`='" + this.B_name +"', where `B_id`='" + this.B_id + "';";
        }

    }
}
