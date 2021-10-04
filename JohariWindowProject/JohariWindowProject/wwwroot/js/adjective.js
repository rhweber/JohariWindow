var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/adjective",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { data: "adjectiveName", width: "50%" },
            { data: "displayOrder", width: "50%" }
        ],
        "language": {
            "emptyTable": "no data found."
        },
        "width": "100%"
    });
}
