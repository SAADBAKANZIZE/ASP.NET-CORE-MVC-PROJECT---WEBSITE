

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "10%" },
            { data: 'description', "width": "10%" },
            { data: 'isbn', "width": "10%" },
            { data: 'category.name', "width": "10%" },
            /*{ data: ' imageUrl', "width": "25%" },*/
            {
                data: 'id',
                "render": function (data) {
                    return `<a href="/admin/product/details?id=${data}" class="btn btn-success mx-2">
                        <i class="bi bi-eye" ></i > View  </a > 
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2">
                        <i class="bi bi-pencil"></i> Edit </a>
                        <a href="/admin/product/delete?id=${data}" class="btn btn-danger mx-2">
                        <i class="bi bi-trash"></i> Delete
                        `
                },
                "width": "35%"
            }



            
    ]
    });
}