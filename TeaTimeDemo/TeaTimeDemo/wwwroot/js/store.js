var dataTable;
$(document).ready(function () {loadDataTable();});
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/admin/store/getall'
        },
        "columns": [
            { data: 'name', "width": "10%" },
            { data: 'address', "width": "30%" },
            { data: 'city', "width": "15%" },
            { data: 'phoneNumber', "width": "10%" },
            { data: 'description', "width": "20%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div calss="w-75 btn-group" role="group">
                    <a href="/admin/store/upsert?id=${data}"
                    class="btn btn-primary mx-2">
                    <i class="bi bi-pencil-square"></i>Edit</a>

                    <a onClick=Delete('/admin/store/delete/${data}')
                    class="btn btn-danger mx-2">
                    <i class="bi bi-trash-fill"></i>Delete</a>
                    </div>`
                },
                "width": "15%"
            }
        ]
    });
}
function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: rul,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}