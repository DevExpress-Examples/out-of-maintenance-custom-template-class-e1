<%-- BeginRegion Page Settings --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="TreeList_Templates_CustomTemplateClass_Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.1" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<%-- EndRegion --%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Custom template class</title>
	<style type="text/css">
		body { font: 9pt Tahoma; }
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<dxwtl:ASPxTreeList ID="tree" runat="server" AutoGenerateColumns="False"
			DataSourceID="AccessDataSource1" KeyFieldName="ID" ParentFieldName="ParentID">
			<SettingsBehavior AutoExpandAllNodes="True"></SettingsBehavior>
			<Columns>
				<dxwtl:TreeListDataColumn FieldName="Department" VisibleIndex="0" />				
				<dxwtl:TreeListDataColumn FieldName="Location" VisibleIndex="1" />				
			</Columns>
		</dxwtl:ASPxTreeList>
		<br />
		<asp:Label ID="lblInfo" runat="server" />
		<br />
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/Departments.mdb"
			SelectCommand="SELECT [ID], [ParentID], [Department], [Budget], [Location] FROM [Departments]">
		</asp:AccessDataSource>
	</form>
</body>
</html>