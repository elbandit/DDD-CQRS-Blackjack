<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BlackjackLayout.Master" Inherits="System.Web.Mvc.ViewPage<KojackGames.Blackjack.UI.Web.Models.ViewModels.CashInView>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cash in for $30.00</h2>

    <% using (Html.BeginForm()) {%>                    
        <input  class="basic-btn" type="submit" value="Cash in for $30.00" /> <% } %>

</asp:Content>

