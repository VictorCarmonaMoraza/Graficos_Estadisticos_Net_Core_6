
//Cargar grafico cuando carga la pantalla
window.onload = function () {
    //Llamada desde nuestro js a nuestro controller
    //fetchGet(Controlador/nombremetodo, "tipo que devuelve metodo controlador", function data()
    fetchGet("Grafico/graficoInicial", "text", function (data) {
        document.getElementById("imgFoto").src = "data:image/png;base64," + data;
    })
}