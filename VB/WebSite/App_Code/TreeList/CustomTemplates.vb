Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxTreeList

Public Class TreeListTutorialCustomDataCellTemplate
	Implements ITemplate
	Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		Dim cellContainer As TreeListDataCellTemplateContainer = TryCast(container, TreeListDataCellTemplateContainer)
		Dim text As String = cellContainer.Text
		If cellContainer.Level < 4 Then
			Dim button As LinkButton = New LinkButton()
			button.Text = text.ToUpper()
			button.CommandArgument = cellContainer.NodeKey
			AddHandler button.Command, AddressOf OnCommand
			container.Controls.Add(button)
		Else
			container.Controls.Add(New LiteralControl(text))
		End If
	End Sub

	Private Sub OnCommand(ByVal sender As Object, ByVal e As CommandEventArgs)
		Dim control As Control = TryCast(sender, Control)
		Dim page As Page = control.Page
		Dim infoLabel As Label = TryCast(page.FindControl("lblInfo"), Label)
		Dim treeList As ASPxTreeList = TryCast(page.FindControl("tree"), ASPxTreeList)
		Dim node As TreeListNode = treeList.FindNodeByKeyValue(e.CommandArgument.ToString())
		infoLabel.Text = String.Format("Budget of <b>{0}</b> is <b>{1:C}</b>", node("Department"), node("Budget"))
	End Sub
End Class