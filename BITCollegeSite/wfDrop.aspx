<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfDrop.aspx.cs" Inherits="BITCollegeSite.wfDrop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 205px; width: 1356px; margin-left: 28px; margin-top: 15px; margin-bottom: 0px;">
        <asp:DetailsView ID="dtvCourse" runat="server" Height="50px" Width="293px" AutoGenerateRows="False" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" BorderColor="Gray" BorderStyle="Solid" OnPageIndexChanging="dtvCourse_PageIndexChanging">
             <AlternatingRowStyle BackColor="White" />
             <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
             <EditRowStyle BackColor="#2461BF" />
             <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
             <Fields>
                <asp:BoundField HeaderText="Registration" DataField="RegistrationNumber" NullDisplayText="&amp;nbsp;" />
                <asp:BoundField HeaderText="Student" NullDisplayText="&amp;nbsp;"      />
                <asp:BoundField HeaderText="Course" NullDisplayText="&amp;nbsp;"       />
                <asp:BoundField HeaderText="Date"         DataField="RegistrationDate" DataFormatString="{0:d}" NullDisplayText="&amp;nbsp;" />
                <asp:BoundField HeaderText="Grade"        DataField="Grade" DataFormatString="{0:p}" NullDisplayText="&amp;nbsp;" />
            </Fields>
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        <div style="width: 296px; margin-left: 20px; margin-top: 9px;">
            <asp:LinkButton ID="lbntDropCourse" runat="server" Enabled="False" OnClick="lbntDropCourse_Click">Drop Course</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbntReturnListing" runat="server" OnClick="lbntReturnListing_Click">Return to Registration Listing</asp:LinkButton>
            <div>
                <br />
                <asp:Label ID="lblErrorMessage" runat="server" Font-Bold="True" ForeColor="Red" Text="This will be the error message" Visible="False"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
