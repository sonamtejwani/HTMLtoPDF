<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" Async="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div >
       <h1>Converting Multiple HTML Pages into Single HTML</h1>

       <p>Converting Following pages into PDF</p>
        <ul>
            <li>/dist/table.html</li>
            <li>/dist/table-datatable.html</li>
            <li>/dist/ui-chart-apexcharts.html</li>
            <li>/dist/component-card.html</li>
            <li>/dist/component-pagination.html</li>
            <li>/dist/component-progress.html</li>
            <li>/dist/form-element-checkbox.html</li>
            <li>/dist/ui-widgets-pricing.html</li>


        </ul>
            <asp:Button Text="Convert Html Pages to PDF" ID="btnPupet" runat="server" OnClick="btnPupet_Click" />

    </div>

</asp:Content>
