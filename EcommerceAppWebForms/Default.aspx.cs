using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using My = EcommerceAppWebForms.Data.Entities;

namespace EcommerceAppWebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                My.User user = new My.User();
                if (TryUpdateModel<My.User>(user,new FormValueProvider(ModelBindingExecutionContext)))
                {
                    if (ModelState.IsValid)
                    {

                    }

                }
            }
        }
    }
}