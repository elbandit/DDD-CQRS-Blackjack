<%@ Page Language="C#" MasterPageFile="~/Views/Shared/BlackjackLayout.Master" Inherits="System.Web.Mvc.ViewPage<KojackGames.Blackjack.UI.Web.Models.ViewModels.GamePlayView>" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
       
    <div id="playerspot">        
        Your pot: <span class="pot_amount"><%=Model.table.dollars_in_pot_formatted%></span> | <%:Html.ActionLink("Cash In?", "Cashin", "Cashin")%>                   
    </div> 
    <div id="table">
            
    <div class="game_status"><%=Model.table.game_message%></div>
     
     <div class="dealers_hand"> 
        
     <div class="handtitle">Dealers Hand</div>
      <ul class="cards">
        <% foreach (var card in Model.table.dealers_hand.cards)
           { %>
            <li><img alt="<%=card.name%>"  width="72" height="96" src="/Images/cards/<%=card.name.Replace(" ", "_")%>.png" /></li>
        <% }%>              
      </ul>
    </div>
    
    <table align="center">
        <tr>
            <% foreach (var hand in Model.table.players_hands)
               { %>                                   
            <td width="50%" valign="top">           
                <div class="players_hand_<%=hand.hand_letter%>"> 
                    <div class="handtitle">Hand <%=hand.hand_letter%><br /><%:hand.wager_formatted %></div>                                                       
                    <div class="player_hand_status_<%=hand.hand_letter%>"><%:hand.state %></div>
                    <div class="playerscards">                       
                    <ul class="cards">
                    <% foreach (var card in hand.cards) { %>
                        <li><img alt="<%=card.name%>" width="72" height="96" src="/Images/cards/<%=card.name.Replace(" ", "_")%>.png" /></li>                         
                    <% }  %>
                    </ul>
                    </div>
                    <% if (hand.is_active) { %>
                    <div class="activehand">Active</div>
                    <%}%>                    
                </div>                  
            </td><%                            
           }%>
        </tr>
    </table>                                                        
    </div>

    <div id="playeroptionzone">            
    <% if (Model.table.players_hands.Count(x => x.is_active) > 0)
       {
           var hand = Model.table.players_hands.Where(x => x.is_active).First();
           %>
         <div class="clear"></div> 
         <div class="playeractions">
         <ul>
            <li>
            <% using (Html.BeginForm("Index", "Stick" )) {%>
               <input id="btnStick" type="submit" value="Stick" class="basic-btn" />
            <% } %>
            </li>
            <li>
            <%       
               using (Html.BeginForm("HitActiveHand", "Hit")) {%>
               <input id="btnHit" type="submit" value="Hit" class="basic-btn" />
            <% } %>
            </li>
            <%  
               if (hand.can_double_down) {
               %><li><%
                  using (Html.BeginForm("DoubleDown", "DoubleDown")) {%>
                  <input id="btnDouble" type="submit" value="Double" class="basic-btn"/>
               <% } 
               %></li><% }

               if (hand.can_split) {
                %><li><%
                   using (Html.BeginForm("Split", "Split")) { %>
                   <input id="btnSplit" type="submit" value="Split" class="basic-btn" />
               <% }
               %></li><% }

               if (hand.can_take_insurance) {
               %><li><%               
                   using (Html.BeginForm("Insurance", "Insurance")) { %>
                    <input id="btnInsurance" type="submit" value="Insurance" class="basic-btn"/>
               <% } 
               %></li><% }
           %>
          </ul></div>
         <%                             
           } 
        %>  
         <% if (Model.table.finished) { %>
        <div class="newgamebutton">
        <% using (Html.BeginForm("NewGame", "CreateNewGame")) { %>
            <input id="btnNewGame" class="basic-btn" type="submit" value="Start A New Game?" /> <% }                   
     %></div><%
        } %>      
    </div>    
</asp:Content>
