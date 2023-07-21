﻿using ClassLibrary;
using System;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer.Firstname = txtFirstname.Text;
        AnCustomer.Lastname = txtLastname.Text;
        AnCustomer.Email = txtEmail.Text;
        AnCustomer.Postcode = txtPostcode.Text;
        AnCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
        AnCustomer.Active = chkActive.Checked;
        Session["AnCustomer"] = AnCustomer;
        Response.Redirect("CustomerViewer.aspx");
    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = AnCustomer.Find(CustomerID);
        if (Found == true)
        {
            txtFirstname.Text = AnCustomer.Firstname;
            txtLastname.Text = AnCustomer.Lastname;
            txtEmail.Text = AnCustomer.Email;
            txtPostcode.Text = AnCustomer.Postcode;
            txtDOB.Text = AnCustomer.DOB.ToString();
            chkActive.Checked = AnCustomer.Active;
        }
    }
}