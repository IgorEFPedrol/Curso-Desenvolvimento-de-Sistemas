var botao = document.getElementById("botao_OK").addEventListener("click",
    function pegarValores() {
        var campo1 = document.getElementById("campo1").value;
        var campo2 = document.getElementById("campo2").value;
        verificarCampos(campo1, campo2);
    })

function verificarCampos(campoNumero1, campoNumero2) {
     console.log(campoNumero1, campoNumero2);
     if (campoNumero1 == "" || campoNumero2 == "") {
         window.alert("Preencher os campos!!!")
     } else {
         converterValoresParaInteiro(campoNumero1, campoNumero2);
     }
}

function converterValoresParaInteiro(valorConverter1, valorConverter2) {
    var resultado = parseInt(valorConverter1) * parseInt(valorConverter2);
    var h1 = document.getElementById("h1_result").textContent = resultado; 
}