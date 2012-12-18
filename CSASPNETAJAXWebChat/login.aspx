<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebChat.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js"></script>
    <script type="text/javascript" src="http://ajax.microsoft.com/ajax/jquery.ui/1.8.5/jquery-ui.min.js"></script>

    <link rel="Stylesheet" type="text/css" href="http://ajax.microsoft.com/ajax/jquery.ui/1.8.5/themes/dark-hive/jquery-ui.css" />
    <script type="text/javascript">
        function fnLoginChatRoom() {

            ShowMessageBox("Iniciando sesion...", "Iniciando sesion...");
            csaspnetajaxwebchat.transition.UserLogin($('#<%=txtUsuario.ClientID%>').val(), $('#<%=txtPWD.ClientID%>').val(),
                            fnLoginChatRoomOnSuccessCallBack,
                            ajaxErrorCallBack
                            );
        }

        function ShowMessageBox(Title, Message) {
            $("#DivMessage").html(Message);
            $("#DivMessage").dialog({ modal: true, title: Title });
        }

        function fnLoginChatRoomOnSuccessCallBack() {
            CloseMessageBox();
        }

        function CloseMessageBox() {
            $("#DivMessage").dialog('close');
        }

        function ajaxErrorCallBack(args) {
            $("#DivMessage").dialog("close");
        }


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="Password">
            <div class="ImagenLogin">
            </div>
            <div class="DatosLogin">
                <br />
                <table style="width: 390px">
                    <tr> 
                        <td style="text-align:right" class="style1"> Usuario:
                        </td>
                        <td style="text-align:left">
                            <asp:TextBox ID="txtUsuario" runat="server" Font-Size="10pt" Width="180px"></asp:TextBox> 
                        </td>
                    </tr>
                    <tr> 
                        <td style="text-align:right" class="style1"> Contraseña:
                        </td>
                        <td style="text-align:left"> 
                            <asp:TextBox ID="txtPWD" runat="server" Font-Size="10pt" TextMode="Password" 
                                Width="180px"></asp:TextBox> 
                        </td>
                    </tr>
                </table>
                <br />
                <div class="BotonLogin">
                    <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClientClick="fnLoginChatRoom();return false;"/>
                </div>
            </div>
        </div>
        <br />
        <asp:CustomValidator ID="cvUsuario" runat="server" ErrorMessage="CustomValidator" Display="None" ></asp:CustomValidator>
        <asp:ValidationSummary ID="vsResumen" CssClass="ResumenValidacion" runat="server" />

</asp:Content>
