const url = 'https://localhost:44394/api/hotels'; let page = 1, pc = 0;

function loadData() {
    $(".card > table > tbody").empty(); $("#edit").empty();
    $("#first").unbind(); $("#back").unbind(); $("#forward").unbind(); $("#last").unbind();
    $(".card > table > tbody").load("frontend/spinner.html");
    $.get("frontend/hotel-item.html", data => $.template("info", data));
    $.getJSON(url + "?page=" + page, obj => {
        $.tmpl("info", obj.Page).appendTo(".card > table > tbody"); pc = obj.PageCount;
        if (pc === 1) {
            $("#paginator").empty();
        } else {
            $("#info").text('Page ' + page + ' of ' + pc);
            $("#first").click(() => { if (page != 1) { page = 1; loadData(); } });
            $("#back").click(() => { if (page > 1) { page--; loadData(); } });
            $("#forward").click(() => { if (page < pc) { page++; loadData(); } });
            $("#last").click(() => { if (page != pc) { page = pc; loadData(); } });
        }
        $("#spinner").hide();
    });
}
$(window).on('load', () => loadData());