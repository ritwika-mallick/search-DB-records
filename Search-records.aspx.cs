using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Search-records : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = "Data Source=RITWIKAM;Initial Catalog=li;Integrated Security=True";
        con.Open();
        
        SqlDataAdapter da = new SqlDataAdapter("select * from emp where Name like'" + TextBox1.Text + "%' ", con);

        DataSet ds = new Dataset();
        da.Fill(ds);
        GridView1.DataSource=ds;
        GridView1.DataBind();
    }
    
//On button click search records similar to username given in textbox
    
protected void Button1_Click(object sender, EventArgs e)
{

if (ds.Rows.Count == 0)
{
  GridView1.Visible=false;
  Label1.Visible=true;
  Label.Text="Search term not found in Database!!";
}
else
{
    ds.Read();
    GridView1.Visible=true;
    
}
}
