const loginEmail = "igor@gmail.com";
const loginSenha = 123456;

var botao = document.getElementById("button_login").addEventListener("click", 
    function pegarValores() {
        var email = document.getElementById("email_user").value;
        var senha = document.getElementById("senha_user").value;
        verificarCampos(email, senha)
    })

function verificarCampos(campo1, campo2) {
    if (campo1 == "" || campo2 == "") {
        window.alert("Você precisa preencher os campos!!!")
    } 
    else if (campo1 == loginEmail && campo2 == loginSenha) {
        window.alert("Login Realizado")
    } else {
        window.alert("Login Inválido!!!")
    }
}
