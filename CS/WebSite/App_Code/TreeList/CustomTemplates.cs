using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTreeList;

public class TreeListTutorialCustomDataCellTemplate : ITemplate {
	public void InstantiateIn(Control container) {
		TreeListDataCellTemplateContainer cellContainer = container as TreeListDataCellTemplateContainer;
		string text = cellContainer.Text;
		if(cellContainer.Level < 4) {
			LinkButton button = new LinkButton();
			button.Text = text.ToUpper();
			button.CommandArgument = cellContainer.NodeKey;
			button.Command += new CommandEventHandler(OnCommand);
			container.Controls.Add(button);
		} else {
			container.Controls.Add(new LiteralControl(text));
		}
	}

	void OnCommand(object sender, CommandEventArgs e) {
		Control control = sender as Control;
		Page page = control.Page;
		Label infoLabel = page.FindControl("lblInfo") as Label;
		ASPxTreeList treeList = page.FindControl("tree") as ASPxTreeList;
		TreeListNode node = treeList.FindNodeByKeyValue(e.CommandArgument.ToString());
		infoLabel.Text = string.Format("Budget of <b>{0}</b> is <b>{1:C}</b>", node["Department"], node["Budget"]);
	}
}