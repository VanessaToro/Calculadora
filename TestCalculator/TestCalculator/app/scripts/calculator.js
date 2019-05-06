$(document).ready(function () {

    ///Limpiar campos.
    $("#btnLimpiar").click(function () {
        $("#digito1").val("0");
        $("#digito2").val("0");
        $("#digito3").val("0");
        $("#result").text("");
    });

    function Validacion() {
        if ($("#digito1").val() === "") {
            $("#result").text("Ingrese el primer número en la casilla correspondiente.");
            return false;
        }
        else if ($("#digito1").val() === "" && $("#digito2").val() == "" && $("#digito3").val() == "") {
            $("#result").text("Ingrese los datos a calcular.");
            return false;
        }
        else {
            if ($("#digito1").val() == "") { $("#digito1").val("0") }
            if ($("#digito2").val() == "") { $("#digito2").val("0") }
            if ($("#digito3").val() == "") { $("#digito3").val("0") }

            return true;
        }
    }

    //Consumir API calculo de suma.
    $("#btnSum").click(function () {
        if (Validacion()) {
            var digito1 = $("#digito1").val();
            var digito2 = $("#digito2").val();
            var digito3 = $("#digito3").val();

            $.getJSON("api/Calculator/GetSum?digito1=" + digito1 + "&digito2=" + digito2 + "&digito3=" + digito3, function (data) {
                $("#result").text(data);
            })
        }
       
    });

    //Consumir API calculo resta.
    $("#btnRest").click(function () {
        if (Validacion()) {
            var digito1 = $("#digito1").val();
            var digito2 = $("#digito2").val();
            var digito3 = $("#digito3").val();

            $.getJSON("api/Calculator/GetSustration?digito1=" + digito1 + "&digito2=" + digito2 + "&digito3=" + digito3, function (data) {
                $("#result").text(data);
            })
        }       
    })

    //Consumir API calculo multiplicación.
    $("#btnMult").click(function () {
        if (Validacion()) {
            var digito1 = $("#digito1").val();
            var digito2 = $("#digito2").val();
            var digito3 = $("#digito3").val();

            $.getJSON("api/Calculator/GetMultiplication?digito1=" + digito1 + "&digito2=" + digito2 + "&digito3=" + digito3, function (data) {
                $("#result").text(data);
            })
        }
        
    })

    //Consumo API calcular división
    $("#btnDiv").click(function () {
        if (Validacion()) {
            var digito1 = $("#digito1").val();
            var digito2 = $("#digito2").val();
            var digito3 = $("#digito3").val();

            $.getJSON("api/Calculator/GetDivision?digito1=" + digito1 + "&digito2=" + digito2 + "&digito3=" + digito3, function (data) {
                $("#result").text(data);
            })
        }
        
    })

    //Consumo API calcular Raíz
    $("#btnRaiz").click(function () {
        if (Validacion()) {
            var digito1 = ($("#digito1").val());
            var digito2 = $("#digito2").val();
            var digito3 = $("#digito3").val();

            $.getJSON("api/Calculator/GetRaizCuadrada?digito1=" + digito1 + "&digito2=" + digito2 + "&digito3=" + digito3, function (data) {
                $("#result").text(data);
            })
        }
        
    })
});