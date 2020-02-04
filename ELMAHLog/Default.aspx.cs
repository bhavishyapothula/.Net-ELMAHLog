using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elmah;

namespace ELMAHLog
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Throwing divide by zero exception
                throw new DivideByZeroException();
            }
            catch(Exception ex)
            {
                //Handling exception
                ErrorSignal.FromCurrentContext().Raise(ex);
            }

        }
    }
}