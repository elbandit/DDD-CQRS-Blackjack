<%@ Page Language="C#" MasterPageFile="~/Views/Shared/BlackjackLayout.Master" Inherits="System.Web.Mvc.ViewPage<KojackGames.Blackjack.UI.Web.Models.ViewModels.AccountRegisterFormView>" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <div id="leftCol" >  
        <div class="titleBlock">Welcome</div>
        <p>
            Hello and welcome to Blackjack.</p>
        <p>            
            Already have an account? <%:Html.ActionLink("Login here", "LogOn", "AccountLogOn") %>.</p>
    </div>
    
    <div id="rightCol" >
        <div class="titleBlock">Create An Account</div>        
           <% using (Html.BeginForm()) { %>
        
                <p>
                    <label for="name">Name:</label><br />
                    <%: Html.TextBoxFor(model => model.name)%>
                    <%= Html.ValidationMessage("name") %>
                </p>            
                <p>
                    <label for="email">Email:</label><br />
                    <%: Html.TextBoxFor(model => model.email) %>
                    <%= Html.ValidationMessage("email") %>
                </p>
                <p>
                    <label for="password">Password:</label><br />
                    <%: Html.PasswordFor(model => model.password) %>
                    <%= Html.ValidationMessage("password") %>
                </p>                
                <p>
                    <input type="submit" id="btnRegister" class="basic-btn" value="Register" />
                </p>           
        
    <% } %>   
    </div>
</asp:Content>
