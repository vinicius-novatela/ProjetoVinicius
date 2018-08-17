$(Document).ready(function () {





})



$("#form-panel-renal").validate({
        errorClass: "input-error",
        rules: {
            nome: "required",
            cpf: "required",
            cep: "required",
            sexo: "required",
            rua: "required",
            bairro: "required",
            estado: "required",
            data: "required",        
        },       
});


function DeletePessoa(id) {
   // alert('chamou funcao');

    $.ajax({
        method: 'POST',
        url: 'DeletePessoa',
        data: {id:id},
       
        success: function (response) {
           
            if (response == "1") {
                notif({
                    msg: "Deletado com sucesso ! ",
                    type: "success",
                    position: "center"
                })
                setTimeout(function () {
                    window.location.reload(true);
                }, 2000);
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