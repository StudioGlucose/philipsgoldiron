using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhilipGoldIron.Bll;

namespace PhilipGoldIron
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            InitialProc("");
            
        }

        public Boolean ValidateData(string ddd)
        {
            bool result = false;

           

            return result;
        }

        
        public Boolean InitialProc(string sIDNo)
        {
            PhilipGoldIron.Bll.Processing proc = new Processing();
            bool result = false;

            //Verify ID Number
            bool test = proc.VerifyPeopleID(sIDNo);

            return result;
        }
    }
}
