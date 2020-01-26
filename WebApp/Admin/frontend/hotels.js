const server = 'https://localhost:44394/api/hotels';
let page = 1, pc = 0;

function loadData() {
    $(".card > table > tbody").empty();
    $(".card > table > tbody").load("frontend/spinner.html");
    $.get("frontend/hotel-item.html", data => $.template("info", data));
    $.getJSON(server, obj => {
        $.tmpl("info", obj.Page).appendTo(".card > table > tbody");
        pc = obj.PageCount;
        $("#spinner").hide();
    });
}

$(window).on('load', () => loadData());