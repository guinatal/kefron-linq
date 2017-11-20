using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kefron
{

    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                using (VivaLaRevolutionEntities objVivaLaRevolutionEntities = new VivaLaRevolutionEntities())
                {
                    listMenu.DataTextField = "name";
                    listMenu.DataValueField = "id";
                    listMenu.DataSource = objVivaLaRevolutionEntities.Menus.Select(x => new { x.id, x.name }).ToList();
                    listMenu.DataBind();
                };

            }

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

            // Customer
            Customer customer = new Customer
            {
                name = txtName.Text,
                address = txtAddress.Text,
                date_of_birth = txtDateOfBirth.Text,
                email = txtEmail.Text
            };

            using (VivaLaRevolutionEntities objVivaLaRevolutionEntities = new VivaLaRevolutionEntities())
            {
                objVivaLaRevolutionEntities.Customers.Add(customer);
                objVivaLaRevolutionEntities.SaveChanges();
            };

            // Customer X Menu
            foreach (ListItem item in listMenu.Items)
            {
                if (item.Selected)
                {

                    Customer_X_Menu customer_x_menu = new Customer_X_Menu
                    {
                        id_customer = customer.id,
                        id_menu = int.Parse(item.Value)
                    };

                    using (VivaLaRevolutionEntities objVivaLaRevolutionEntities = new VivaLaRevolutionEntities())
                    {
                        objVivaLaRevolutionEntities.Customer_X_Menu.Add(customer_x_menu);
                        objVivaLaRevolutionEntities.SaveChanges();
                    };

                }
            }

        }
    }
}