using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kefron
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                using (VivaLaRevolutionEntities objVivaLaRevolutionEntities = new VivaLaRevolutionEntities())
                {
                    gvCustomerList.DataSource = objVivaLaRevolutionEntities.Customers.ToList();
                    gvCustomerList.DataBind();
                };

            }

        }
    }
}