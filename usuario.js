// JavaScript source code
function login() {
    debugger;

    var form = {};

    form.Usuario = document.getElementById("userHelp1").value;
    form.Senha = document.getElementById("pwHelp1").value;


    var myJSON = JSON.stringify(form);


    $.post("https://localhost:44320/usuario/SalvarUsuario", { form: myJSON }
        , function (data) {
            if (data == "Bem vindo ao cadastro!") {
                alert(data);
                window.location.href = "cadastro.html";
            } else {
                alert(data);
            }
        });
    /*if (senha.value == "candidato123" && usuario.value == "Sistema") {
        alert("Seja bem vindo ao cadastro")
        window.location.href = "cadastro.html";


    }
    else {
        alert("Usuario ou senha incorretos")
    }
*/
}
