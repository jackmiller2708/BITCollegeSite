<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfRegister.aspx.cs" Inherits="BITCollegeSite.wfRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 292px; margin-top: 25px">
        
        <asp:Label ID="lblStudentName" runat="server" Font-Bold="True" Font-Size="Large" Text="Student Name"></asp:Label>
        <div style="height: 28px; margin-top: 6px" class="form-inline">
            <div class="form-group">
                <asp:Label ID="lblCourseSelector" runat="server" Text="Course Selector"></asp:Label>
                :&nbsp;
                <asp:DropDownList ID="drpCourseSelector" CssClass="form-control" runat="server" AutoPostBack="True" Height="30px" Width="255px" Font-Size="Small">
                </asp:DropDownList>
            </div>
        </div>
        <div style="height: 28px; margin-top: 19px" class="form-inline">
            <div class="form-group">
                <asp:Label ID="lblRegistrationNotes" runat="server" Text="Registration Notes"></asp:Label>
                :
                <asp:TextBox ID="txtNotes" CssClass="form-control" runat="server" Height="30px" Width="244px" ToolTip="Password must be between 6-12 characters and include 1 capital letter, 1 lowercase letter, and 1 number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reValidator" runat="server" ControlToValidate="txtNotes" ErrorMessage=" Notes are Required for Web Registrations"></asp:RequiredFieldValidator>
                <div style="margin-top: 15px">
                    <asp:LinkButton ID="lbtnRegister" runat="server" OnClick="lbtnRegister_Click">Register</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="lbtnReturn" runat="server" OnClick="lbtnReturn_Click" CausesValidation="False">Return to Registration Listing</asp:LinkButton>
                </div>
                <div style="margin-top: 12px">
                    <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Medium" ForeColor="Red" Text="Error Message" Visible="False"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
