function fnLoginChatRoom() {

    ShowMessageBox("Iniciando sesion...", "Iniciando sesion...");

    csaspnetajaxwebchat.transition.UserLogin(
                $("#txtUsuario").val(),
                $("#txtPWD").val(),
                fnLoginChatRoomOnSuccessCallBack
                );

}

function ShowMessageBox(Title, Message) {
    $("#DivMessage").html(Message);
    $("#DivMessage").dialog({ modal: true, title: Title });
}

function fnLoginChatRoomOnSuccessCallBack(args) {
    CloseMessageBox();
}

function CloseMessageBox() {
    $("#DivMessage").dialog('close');
}
