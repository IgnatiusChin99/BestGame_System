using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGame_Classes;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

     

    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
        
        //create a new instance of clsOrder
        clsOrder Order = new clsOrder();
        //capture the Order Info
        Order.Info = txtInfo.Text;
        //capture the Order ID
        Order.OrderID = Convert.ToInt32(txtOrder_ID.Text);
        //capture the

        //store the order in the session object
        Session["Order"] = Order;
        //redirect to the viewer page
        Response.Redirect("OrderView.aspx");

    }

    protected void txtOrder_ID_TextChanged(object sender, EventArgs e)
    {

    }
}