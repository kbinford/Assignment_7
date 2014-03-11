using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceReference1.CommunityAssistServicesClient casc = new ServiceReference1.CommunityAssistServicesClient();


        List<ServiceReference1.ComService> ourServices=new List<ServiceReference1.ComService>();
        
        ourServices=casc.GetServices().ToList();



        DataList1.DataSource = ourServices;
        foreach (ServiceReference1.ComService cs in ourServices)
        {
            DataList1.DataMember = cs.ServiceName;
            DataList1.DataMember = cs.ServiceDescription;
            DataList1.DataBind();
        }
        

    }
}