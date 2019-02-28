using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Project_1
{
    public partial class Technicians : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                lblError.Text = "";
                LoadTechs();
            }
        }

        private void LoadTechs()
        {
            DataSet dsData;
            lblError.Text = "";

            dsData = clsDatabase.GetTechnicians();
            {
                drpTech.DataSource = dsData.Tables[0];
                drpTech.DataTextField = "FName";
                drpTech.DataValueField = "TechnicianID";
                drpTech.DataBind();

                dsData.Dispose();
            }
        }

        public void Clear()
        {
            txtFName.Text = "";
            txtMInit.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtDept.Text = "";
            txtPhone.Text = "";
            txtHRate.Text = "";
        }

        public void ButtonsOn()
        {
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
            btnRemove.Enabled = true;
            btnClear.Enabled = true;
            btnNew.Enabled = false;
            drpTech.Enabled = false;
        }

        public void ButtonsOff()
        {
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
            btnNew.Enabled = true;
            drpTech.Enabled = true;
        }

        protected void btnInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Default.aspx");
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            lblError.Text = "";
            ButtonsOn();

        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonsOff();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            lblError.Text = "";
        }

        private void DisplayTechnician(String strTechID)
        {
            DataSet dsData;

            dsData = clsDatabase.GetTechnicianByID(strTechID);
            if (dsData == null)
            {
                lblError.Text = "Error retrieving Technicians";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving Technicians";
                dsData.Dispose();
            }
            else
            {
                if (dsData.Tables[0].Rows[0]["FName"] == DBNull.Value)
                {
                    txtFName.Text = "";
                }
                else
                {
                    txtFName.Text = dsData.Tables[0].Rows[0]["FName"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["LName"] == DBNull.Value)
                {
                    txtLName.Text = "";
                }
                else
                {
                    txtLName.Text = dsData.Tables[0].Rows[0]["LName"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["MInit"] == DBNull.Value)
                {
                    txtMInit.Text = "";
                }
                else
                {
                    txtMInit.Text = dsData.Tables[0].Rows[0]["MInit"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["EMail"] == DBNull.Value)
                {
                    txtEmail.Text = "";
                }
                else
                {
                    txtEmail.Text = dsData.Tables[0].Rows[0]["EMail"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["Dept"] == DBNull.Value)
                {
                    txtDept.Text = "";
                }
                else
                {
                    txtDept.Text = dsData.Tables[0].Rows[0]["Dept"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["Phone"] == DBNull.Value)
                {
                    txtPhone.Text = "";
                }
                else
                {
                    txtPhone.Text = dsData.Tables[0].Rows[0]["Phone"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["HRate"] == DBNull.Value)
                {
                    txtHRate.Text = "";
                }
                else
                {
                    txtHRate.Text = dsData.Tables[0].Rows[0]["HRate"].ToString();
                }
            }
        }


        protected void drpTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTechnician(drpTech.SelectedValue.ToString());
        }


        public bool ValidateText()
        {
            bool flag = false;
            long num2 = -1L;
            decimal num = 0M;
            string str = "";
            if (this.txtFName.Text.Trim().Length < 1)
            {
                flag = true;
                if (str.Trim().Length > 0)
                {
                    str = str + "; ";
                }
                str = str + "First Name is required";
            }
            if (this.txtLName.Text.Trim().Length < 1)
            {
                flag = true;
                if (str.Trim().Length > 0)
                {
                    str = str + "; ";
                }
                str = str + "Last Name is required";
            }
            if (this.txtPhone.Text.Trim().Length < 1)
            {
                flag = true;
                if (str.Trim().Length > 0)
                {
                    str = str + "; ";
                }
                str = str + "Telephone is required";
            }
            else if (this.txtPhone.Text.Trim().Length < 10)
            {
                flag = true;
                if (str.Trim().Length > 0)
                {
                    str = str + "; ";
                }
                str = str + "Telephone must be 10 digits";
            }
            else
            {
                try
                {
                    num2 = Convert.ToInt64(this.txtPhone.Text);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    Exception exception = ex;
                    num2 = -1L;
                }
                if (num2 < 0L)
                {
                    flag = true;
                    if (str.Trim().Length > 0)
                    {
                        str = str + "; ";
                    }
                    str = str + "Telephone must be numeric";
                }
            }
            if (this.txtHRate.Text.Trim().Length < 1)
            {
                flag = true;
                if (str.Trim().Length > 0)
                {
                    str = str + "; ";
                }
                str = str + "Hourly Rate is required";
            }
            else
            {
                try
                {
                    num = Convert.ToDecimal(this.txtHRate.Text);
                }
                catch (Exception exception3)
                {
                    Exception ex = exception3;
                    Exception exception2 = ex;
                    num = -1M;
                }
                if (decimal.Compare(num, 0M) < 0)
                {
                    flag = true;
                    if (str.Trim().Length > 0)
                    {
                        str = str + "; ";
                    }
                    str = str + "Hourly Rate must be numeric";
                }
            }
            this.lblError.Text = str;
            return !flag;
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            ValidateText();
            ValidateText();
        }
    }
}