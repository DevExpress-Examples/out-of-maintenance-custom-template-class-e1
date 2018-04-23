#region Using
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxTreeList;
#endregion

public partial class TreeList_Templates_CustomTemplateClass_Default : System.Web.UI.Page {

	protected override void OnLoad(EventArgs e) {
		base.OnLoad(e);
		((TreeListDataColumn)tree.Columns["Department"]).DataCellTemplate = new TreeListTutorialCustomDataCellTemplate();		
	}
}
