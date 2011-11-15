<%@ Page Language="C#" MasterPageFile="~/Views/Shared/BlackjackLayout.Master" Inherits="System.Web.Mvc.ViewPage<KojackGames.Blackjack.UI.Web.Models.ViewModels.BetView>" %>


<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    
    <div id="playerspot">        
        Your pot: <span class="pot_amount"><%=Model.dollars_in_pot_formatted%></span> | <%:Html.ActionLink("Cash In?", "Cashin", "Cashin")%>          
    </div> 
    <div id="table">    
       <% foreach(var bet_placed in Model.bets_placed) { %>
            <p>You have bet <%: bet_placed.wager_formatted%></p><% } %>  
    </div> 
    <div id="playeroptionzone">             
    <% 
    if (Model.can_deal) {       
        using (Html.BeginForm("Index", "Deal")) {%>        
        <div class="betting">
            <input id="btnDeal" class="basic-btn" type="submit" value="Deal" />
        </div> <% }  
         
    }
    else if (Model.can_bet)
    {   
      %>
       <div class="clear"></div> 
      <div class="playeractions">
      <ul>
        <li><% using (Html.BeginForm()) {%>    
            <input id="bet5" value="5.00" name="bet" type="hidden" />
            <input id="btnBet_5" class="basic-btn" type="submit" value="Bet $5" /> <% } %>
        </li>        
        <li><% using (Html.BeginForm()) {%>         
            <input id="bet10" value="10.00" name="bet" type="hidden" />
            <input id="btnBet_10" class="basic-btn" type="submit" value="Bet $10" /> <% } %>
        </li>
        <li><% using (Html.BeginForm()) {%>      
            <input id="bet25" value="25.00" name="bet" type="hidden" />    
            <input id="btnBet_25" class="basic-btn" type="submit" value="Bet $25" /> <% } %>
        </li>
       </ul>
       </div><%  
    }%>   
        </div>                    
</asp:Content>
