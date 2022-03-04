var num1 = 0.0;
var num2 = 0.0;
var result;



var soma = document.getElementById("botaoSoma").addEventListener("click",
    function somar() {

        var campo1 = document.getElementById("campo1").value;
        var campo2 = document.getElementById("campo2").value;
        result = parseFloat(campo1) + parseFloat(campo2);
        window.alert(result);
    })

var multi = document.getElementById("botaoMulti").addEventListener("click",
    function multiplicar() {

        var campo1 = document.getElementById("campo1").value;
        var campo2 = document.getElementById("campo2").value;
        result = parseFloat(campo1) * parseFloat(campo2);
        window.alert(result);
    })

var div = document.getElementById("botaoDiv").addEventListener("click",
    function multiplicar() {

        var campo1 = document.getElementById("campo1").value;
        var campo2 = document.getElementById("campo2").value;
        result = parseFloat(campo1) / parseFloat(campo2);
        window.alert(result);
    }) 

var sub = document.getElementById("botaoSub").addEventListener("click",
    function subtracao() {

        
        var campo1 = document.getElementById("campo1").value;
        var campo2 = document.getElementById("campo2").value;
        result = parseFloat(campo1) - parseFloat(campo2);
        window.alert(result); 

    })