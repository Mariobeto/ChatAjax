function fnLoginChatRoom() {

    ShowMessageBox("Iniciando sesion...", "Iniciando sesion...");
    var Valor = $('#<%=txtUsuario.ClientID%>').val();
    //    csaspnetajaxwebchat.transition.UserLogin("mario82","123",
    //                fnLoginChatRoomOnSuccessCallBack,
    //                ajaxErrorCallBack
    //                );
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