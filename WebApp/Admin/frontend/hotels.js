const url = 'https://localhost:44394/api/hotels'; let page = 1, pc = 0, temp = -1;

function loadData() {
    $(".card > table > tbody").empty(); $("#edit").empty();
    $("#first").unbind(); $("#back").unbind(); $("#forward").unbind(); $("#last").unbind();
    $(".card > table > tbody").load("frontend/spinner.html");
    $.get("frontend/hotel-item.html", data => $.template("info", data));
    $.getJSON(url + "?page=" + page, obj => {
        $.tmpl("info", obj.Page).appendTo(".card > table > tbody"); $("#spinner").hide();
        pc = obj.PageCount; if (page > pc) { page--; loadData(); } temp = -1;
        if (pc === 1) {
            $("#paginator").empty();
        } else {
            $("#info").text('Page ' + page + ' of ' + pc);
            $("#first").click(() => { if (page != 1) { page = 1; loadData(); } });
            $("#back").click(() => { if (page > 1) { page--; loadData(); } });
            $("#forward").click(() => { if (page < pc) { page++; loadData(); } });
            $("#last").click(() => { if (page != pc) { page = pc; loadData(); } });
        }
        $(".text-info").click(e => { temp = $(e.target).attr("item-id"); $("#edit").load("frontend/edit.html"); });
        $(".text-danger").click(e => {
            const id = $(e.target).attr("item-id"); $("#edit").empty();
            if (confirm('Are you going to delete hotel with id ' + id + '?')) {
                $.ajax({
                    url: url + "/" + id,
                    type: 'DELETE',
                    success: () => {
                        alert("Hotel with id " + id + " deleted");
                        loadData();
                    },
                    error: body => {
                        switch (body.status) {
                            case 409: alert("There's dependent information in database"); break;
                            case 500: alert("Server error"); break;
                        }
                    }
                });
            }
        });
    });
}
$(".text-success").click(() => { temp = -1; $("#edit").load("frontend/edit.html"); })
$(window).on('load', () => loadData());