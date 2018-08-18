
$(document).ready(function () {




    $("#form").validate({
        rules: {
            nome: "required",
            cpf: "required",
            cep: "required",
            sexo: "required",
            rua: "required",
            bairro: "required",
            estado: "required",
            Data: "required",
        },
    });
});



function DeletePessoa(id) {
    $.ajax({
        method: 'POST',
        url: 'Pessoas/DeletePessoa',
        data: { id: id },
        success: function (response) {
            if (response == "1") {
                //notif({
                //    msg: "Deletado com sucesso ! ",
                //    type: "success",
                //    position: "center",
                //    multiline: true
                //});
                location.reload();
            }
            else if (response == "2") {
                notif({
                    msg: "Erro ao deletar  ",
                    type: "error",
                    position: "center"
                });
            }
        },
    })
}