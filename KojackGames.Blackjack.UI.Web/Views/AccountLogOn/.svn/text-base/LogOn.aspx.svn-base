<%@ Page Language="C#" Title="Login" MasterPageFile="~/Views/Shared/BlackjackLayout.Master" Inherits="System.Web.Mvc.ViewPage<KojackGames.Blackjack.UI.Web.Models.ViewModels.AccountLogOnFormView>" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
     <div id="leftCol">
        <div class="titleBlock">Welcome Back</div>             
        <p>Please enter your password to continue.</p>
    </div>
    <div id="rightCol" >
        <div class="titleBlock">Login</div>  
        <% using (Html.BeginForm()) { %>        
            <p>
                <label for="username">Username:</label><br />
                <%= Html.TextBox("email") %>
                <%= Html.ValidationMessage("email") %>
            </p>
            <p>
                <label for="password">Password:</label><br />
                <%= Html.Password("password") %>
                <%= Html.ValidationMessage("password") %>
            </p>               
            <p>
                <input type="submit" id="btnLogin" class="basic-btn" value="Log On" />
            </p>                    
    <% } %>       
    </div>
</asp:Content>
