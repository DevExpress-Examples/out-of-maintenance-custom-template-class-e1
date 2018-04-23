#Region "Using"

Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxTreeList
#End Region

Partial Public Class TreeList_Templates_CustomTemplateClass_Default
	Inherits System.Web.UI.Page

	Protected Overrides Sub OnLoad(ByVal e As EventArgs)
		MyBase.OnLoad(e)
		CType(tree.Columns("Department"), TreeListDataColumn).DataCellTemplate = New TreeListTutorialCustomDataCellTemplate()
	End Sub
End Class
