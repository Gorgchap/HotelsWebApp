const url = 'https://localhost:44394/api/hotels';
let page = 1, pc = 0;

function loadData() {
    $(".card > table > tbody").empty();
    $("#paginator").empty();
    $("#editable").empty();
    $(".card > table > tbody").load("frontend/spinner.html");
    $("#editable").load("frontend/edit.html");
    $.get("frontend/hotel-item.html", data => $.template("info", data));
    $.getJSON(url, obj => {
        $.tmpl("info", obj.Page).appendTo(".card > table > tbody");
        pc = obj.PageCount;
        $("#spinner").hide();
        $(".card > #paginator").show();
        $("#paginator").load("frontend/paginator.html");
    });
}

$(window).on('load', () => loadData());