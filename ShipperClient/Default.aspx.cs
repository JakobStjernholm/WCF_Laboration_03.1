using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShipperClient.ServiceReference1;

namespace ShipperClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = "";
            Label4.Text = "";
        }

        protected void getShipperButton_Click1(object sender, EventArgs e)
        {
            try
            {
                Label5.Text = "";
                ShipperServiceClient client = new ShipperServiceClient();
                var result = client.GetShipperById(int.Parse(shipperIdText.Text));
                shipperIdTextResult.Text = result.ShipperId.ToString();
                shipperCompanyNameText.Text = result.CompanyName;
                shipperPhoneText.Text = result.Phone;
            }
            catch (Exception ex)
            {
                Label5.Text = "Something went wrong " + ex.Message;
                
            }
            
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShipperServiceClient client = new ShipperServiceClient();
                Label4.Text = "";
                var shipper = new Shipper
                {
                   

                CompanyName = shipperCompanyNameText.Text,
                    Phone = shipperPhoneText.Text,
                    ShipperId = int.Parse(shipperIdTextResult.Text)
                };
                bool flag = client.UpdateShipper(shipper);
                if (flag == true)
                    Label4.Text = "Allting uppdaterades som det skulle!";
                else
                    Label4.Text = "Något gick fel när datan skulle sparas i databasen";
            }
            catch (Exception ex)
            {
                Label5.Text = "Something went wrong " + ex.Message;
                
            }
            
        }

        
    }
}