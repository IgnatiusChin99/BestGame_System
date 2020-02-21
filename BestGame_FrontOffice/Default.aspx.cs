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
        //clsOrder AnOrder = new clsOrder();
        //AnOrder = (clsOrder)Session["AnOrder"];
        //Response.Write(AnOrder.o_information);
    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {

        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the Order Info
        AnOrder.o_information = txtInfo.Text;
        //capture the Order ID
        AnOrder.o_id = Convert.ToInt32(txtOrder_ID.Text);
        
       

        //store the order in the session object
        Session["Order"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderView.aspx");

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 o_id;

        Boolean Found = false;

        o_id = Convert.ToInt32(txtOrder_ID.Text);

        Found = AnOrder.Find(o_id);

        if(Found == true)
        {
            txtInfo.Text = AnOrder.o_information;
        }

    }
}