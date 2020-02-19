using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estoque_projeto_udemy
{
    public partial class Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           DAL obJDAL =  new DAL();
            obJDAL.ExecutarComandoSQL("insert to categoria(nome) values('bebidas')");


        }
    }
}