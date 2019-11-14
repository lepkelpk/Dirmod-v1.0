$(document).ready(function () {

    //  Recuperar todos los clientes
    setTimeout(listarCotizaciones(), 50000);
});

function listarCotizaciones() {
    $.getJSON("http://localhost:1164/cotizacion",
        function (data) {
            $.each(data,
                function (key, val) {
                    var str = val.Moneda + ': ' + val.Precio;
                    $('<li>', { html: str }).appendTo($('#cotizaciones'));
                }
            );
        }
    );
}