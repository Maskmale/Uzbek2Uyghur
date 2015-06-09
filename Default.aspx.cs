using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using net.UyghurDev.Text.Converter;

public partial class Uzbek2Uyghur_Default : System.Web.UI.Page
{
    Uzbek2Uyghur objTranclate;
    protected void Page_Load(object sender, EventArgs e)
    {

            objTranclate = new Uzbek2Uyghur();
        
    }
    protected void btnTranclate_Click(object sender, EventArgs e)
    {
        ltrlUyghur.Text = objTranclate.uzbekLatin2Uyghur(txtUzbek.Text);
    }
}
