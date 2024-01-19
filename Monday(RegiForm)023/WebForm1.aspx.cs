using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Monday_RegiForm_023
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        static String imagelink;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String imagelink1;
            String mycon = @"data source=DESKTOP-A8OGLN5\SQLEXPRESS;initial catalog=Santosh;integrated security=true";
            String myquery = "Select * from StudentRegi where Student_ID =" + TextBox2.Text;
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label2.Text = "Particular Roll Number Found";
                TextBox3.Text = ds.Tables[0].Rows[0]["StudentName"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["FatherName"].ToString();
                TextBox5.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
                imagelink1 = ds.Tables[0].Rows[0]["profileimage"].ToString();
                Image1.ImageUrl = imagelink1 + "?n=" + DateTime.Now.Second.ToString();
            }
            else
            {
                Label3.Text = "Particular Roll Number Not Found";

            }
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                if (uploadimage() == true)
                {
                    String mycon = @"Data Source=DESKTOP-A8OGLN5\SQLEXPRESS;Initial Catalog=Santosh;Integrated Security=True";
                    String updatedata = "Update StudentRegi set StudentName='" + TextBox3.Text + "', FatherName='" + TextBox4.Text + "', LastName='" + TextBox5.Text + "', profileimage='" + imagelink + "' where rollno=" + TextBox2.Text;
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = updatedata;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    Label3.Text = "Record Has Been Updated Successfully";
                }
            }
            else
            {
                String mycon = @"Data Source=DESKTOP-A8OGLN5\SQLEXPRESS;Initial Catalog=Santosh;Integrated Security=True";
                String updatedata = "Update StudentRegi set StudentName='" + TextBox3.Text + "', FatherName='" + TextBox4.Text + "', LastName='" + TextBox5.Text + "' where Student_ID=" + TextBox2.Text;
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand(); 
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Label3.Text = "Record Has Been Updated Successfully";
            }
        }

        private Boolean uploadimage()
        {
            Boolean imagesaved = false;
            if (FileUpload1.HasFile == true)
            {

                String contenttype = FileUpload1.PostedFile.ContentType;

                if (contenttype == "image/jpeg")
                {
                    int filesize;
                    filesize = FileUpload1.PostedFile.ContentLength;

                    if (filesize <= 51200)
                    {
                        System.Drawing.Image img = System.Drawing.Image.FromStream(FileUpload1.PostedFile.InputStream);
                        int height = img.Height;
                        int width = img.Width;
                        if (height == 200 && width == 200)
                        {
                            FileUpload1.SaveAs(Server.MapPath("~/ProfileImage/") + TextBox2.Text + ".jpg");
                            Image1.ImageUrl = "~/ProfileImage/" + TextBox2.Text + ".jpg";
                            imagelink = "ProfileImage/" + TextBox2.Text + ".jpg";
                            imagesaved = true;
                        }
                        else
                        {
                            Label3.Text = "Kindly Upload JPEG Image in Proper Dimensions 200 x 200";
                        }




                    }
                    else
                    {
                        Label3.Text = "File Size exceeds 50 KB - Please Upload File Size Maximum 50 KB";
                    }

                }
                else
                {
                    Label3.Text = "Only JPEG/JPG Image File Acceptable - Please Upload Image File Again";
                }
            }
            else
            {
                Label3.Text = "You have not selected any file - Browse and Select File First";
            }

            return imagesaved;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String mycon = @"Data Source=DESKTOP-A8OGLN5\SQLEXPRESS;Initial Catalog=Santosh;Integrated Security=True";
            String savedata = "insert into StudentRegi StudentName='" + TextBox3.Text + "', FatherName='" + TextBox4.Text + "', LastName='" + TextBox5.Text + "', profileimage='" + imagelink;   // + "' where rollno=" + TextBox2.Text; 
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = savedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label3.Text = "Record Has Been Updated Successfully";
        }
    }

}