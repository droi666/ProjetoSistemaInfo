// JavaScript source code

function cadastro() {
   
            debugger;
        var form = {};
        form.nome = document.getElementById("inputNome").value;
        form.sobrenome = document.getElementById("inputSobrenome").value;
        form.cpf = document.getElementById("inputCpf").value;
        form.endereco = document.getElementById("inputEndereco").value;
        form.cep = document.getElementById("inputCep").value;
        form.cidade = document.getElementById("inputCidade").value;
        form.estado = document.getElementById("inputEstado").value;
        form.telefone = document.getElementById("inputTelefone").value;
        form.celular = document.getElementById("inputCelular").value;
        form.email = document.getElementById("inputEmail").value;
        form.observacoes = document.getElementById("textArea").value;

        var myJSON = JSON.stringify(form);


    $.post("https://localhost:44320/cadastro/SalvarCadastro", { form: myJSON }
        , function (data) {
            alert(data);
        });

    /*debugger;
    $.get("https://localhost:44320/cadastro/SalvarCadastro", function (data) {

    }
        debugger;
        alert(data);
    });
*/
}

    

 