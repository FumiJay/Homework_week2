using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Homework_week2
{
    public partial class workform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert(object sender, EventArgs e)
        {
            string newID = this.textID.Text;
            string Name = this.textName.Text;
            string Br = this.textBir.Text;
            string Col = this.textcol.Text;
            Main_DBcontect.insert(newID, Name, Br, Col);
        }

        protected void Delete(object sender, EventArgs e)
        {
            this.Response.Write("");
            string newID = this.textID.Text;
            Main_DBcontect.Delete(newID);
        }

        protected void Updata(object sender, EventArgs e)
        {
            string newID = this.textID.Text;
            string Name = this.textName.Text;
            string Br = this.textBir.Text;
            string Col = this.textcol.Text;
            Main_DBcontect.Updata(newID, Name, Br, Col);
        }

        protected void Read(object sender, EventArgs e)
        {
            string Col = this.textcol.Text;
            GridView1.DataSource = Main_DBcontect.Read(Col);
            GridView1.DataBind();
        }
    }
}