$(function () {
    //$("#btnSalvar").click(salvar);

    $("#btnNovo").click(limparProduto);
    
});

function limparProduto() {
    $("#Codigo").val("");
    $("#Nome").val("");
    $("#Descricao").val("");
    $("#UnidadeMedida").val("");
    $("#Categoria").val("");
    $("#Quantidade").val("");                
}

function salvar(e) {
    e.preventDefault();
}

function Editar(codigo) {
    $.ajax({
        type: "GET",
        url: ROOT + "produtos/obterProdutoPorId?codigo=" + codigo,        
        success: function (data) {
            if (data.sucesso) {
                console.log(data.produto);
                $("#Codigo").val(data.produto.Codigo);
                $("#Nome").val(data.produto.Nome);
                $("#Descricao").val(data.produto.Descricao);
                $("#UnidadeMedida").val(data.produto.UnidadeMedida);
                $("#Categoria").val(data.produto.Categoria);                
                $("#Quantidade").val(data.produto.Quantidade);   
                $('#collapsePanel').modal('show');
            } else {
                limparProduto();                 
            }
        },
        dataType: 'json'
    });
}

function postForm(url, data) {
    $.ajax({
        type: "POST",
        url: ROOT + "produtos/obterProdutoPorId",
        data: data,
        success: function (data, textStatus, jqXHR) {
            if (data.sucesso) {
                //msgboxui("Sucesso", data.mensagem);
                //if ($('#Id').val() == 0) {
                //    window.location = window.location.reload(true);
                //} else {
                //    $('.btn_class').removeAttr('disabled');
                //}
                if ($('#Id').val() > 0) {
                    if (data.dados.excluido) {
                        location.href = ROOT + 'eletro/rateletro/consulta';
                    } else {
                        location.href = ROOT + 'eletro/rateletro/editar/' + data.dados.idRatEletro;
                    }

                } else {
                    location.href = ROOT + 'eletro/rateletro/editar/' + data.dados.idRatEletro;

                }

            } else {
                msgboxui("Erro", data.mensagem);
                $('.btn_class').removeAttr('disabled');
            }
        },
        error: function () {
            $('.btn_class').removeAttr('disabled');
        },
        dataType: 'json'
    });
}
