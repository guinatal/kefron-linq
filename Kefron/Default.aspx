<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kefron._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />

    <div class="form-group">
        <asp:TextBox ID="txtName" runat="server" MaxLength="50" placeholder="Name" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:TextBox ID="txtAddress" runat="server" MaxLength="50" placeholder="Address" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:TextBox ID="txtDateOfBirth" runat="server" MaxLength="50" placeholder="Date Of Birth" TextMode="Date" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:TextBox ID="txtEmail" runat="server" MaxLength="50" placeholder="Email" TextMode="Email" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:ListBox ID="listMenu" runat="server" SelectionMode="Multiple" CssClass="form-control"></asp:ListBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" CssClass="btn btn-primary" />
    </div>

</asp:Content>
