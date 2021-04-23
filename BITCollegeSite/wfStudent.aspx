<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfStudent.aspx.cs" Inherits="BITCollegeSite.wfStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 441px; margin-top: 0px;">
        <div style="width: 596px; margin-left: 22px; margin-top: 13px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblFullName" runat="server" Font-Bold="True" Font-Size="Large" Text="Full Name of Student"></asp:Label>
            <asp:GridView ID="grvRegisteredCourses" runat="server" Height="165px" OnSelectedIndexChanged="grvRegisteredCourses_SelectedIndexChanged" Width="534px" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BorderStyle="Solid" BorderWidth="2px" CellPadding="20" HorizontalAlign="Left">
                <Columns>
                    <asp:BoundField DataField="CourseNumber" HeaderText ="Course" >
                    <ControlStyle BorderStyle="Solid" BorderWidth="2px" />
                    <HeaderStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    <ItemStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Title" HeaderText ="Title" >
                    <HeaderStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    <ItemStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CreditHours" HeaderText ="Credit Hours" >
                    <HeaderStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    <ItemStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CourseType" HeaderText ="Course Type" >
                    <HeaderStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    <ItemStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TuitionAmount" HeaderText ="Tuition" DataFormatString="{0:C}" >
                    <HeaderStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" />
                    <ItemStyle BorderColor="Silver" BorderStyle="Solid" BorderWidth="2px" HorizontalAlign="Right" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
            <br />&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbtnRegisterCourse" runat="server" OnClick="lbtnRegisterCourse_Click">Click Here to Register For A Course</asp:LinkButton>
            <div style="margin-top: 83px">
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblErrorMessage" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="this will be the error messgae if there's any" Visible="False"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
