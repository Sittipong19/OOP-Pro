using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopproject
{
    class Menu
    {
        private string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=oopproject";
        private string Query = "select * from menu;";
        private string M_name;
        private string M_price;
        private string M_id;


        public Menu() { }
        public Menu(string n, string p, string id)
        {
            this.M_name = n;
            this.M_price = p;
            this.M_id = id;

        }
        public string getMycon()
        {
            return this.MyConnection2;
        }
        public string getQuery()
        {
            return this.Query;
        }
        public string AddMenu()
        {
            return "insert into menu(M_id,M_name,M_price) values('" + this.M_id + "','" + this.M_name + "','"+this.M_price +"');";
        }
        public string DeMenu()
        {
            return "delete from menu where `M_id`='" + this.M_id + "';";

        }
        public string UpMenu()
        {
            return "update `Menu` set `M_name`='" + this.M_name + "',`M_price`='" + this.M_price + "', where `M_id`='" + this.M_id + "';";
        }

    }
}
