let password = document.getElementById('txtpassword');

$("#faeye").on("click", function () {
    if (password.type === 'password') {

        password.setAttribute('type', 'text');
        $("#faeyeslash").show();
        $("#faeye").hide();

    }

})

$("#faeyeslash").on("click", function () {
    if (password.type === 'text') {

        password.setAttribute('type', 'password');
        $("#faeyeslash").hide();
        $("#faeye").show();

    }

})

$("#btningresar").on("click", function () {
    let cc = $("#txtcc").val();
    let user = $("#txtuser").val();
    let pass = $("#txtpassword").val();

    if (cc.trim() == "") {
        $("#msjcc").html("* Ingrese un cc").css("color", "red");
    } else if (user.trim() == "") {
        $("#msjuser").html("* Ingrese un usuario").css("color", "red");
    } else if (pass.trim() == "") {
        $("#msjpasswords").html("* Ingrese una contraseña").css("color", "red");
    } else {

        var params = new Object();
        params.cc = cc;
        params.user = user;
        params.pass = pass;
        Post("Login/Acceder", params).done(function (datos) {

            if (datos.dt.response == "ok") {
                window.location = fnBaseURLWeb("Panel/Panel");
            } else {
                swal({
                    position: "top-end",
                    type: "error",
                    title: datos.dt.response,
                    text: 'Valide los campos solicitados o contacte con el administrador',
                    showConfirmButton: true,
                    timer: 60000,
                    confirmButtonText: 'Cerrar'
                })
            }
        });
    }
})

$("#txtcc").keyup(function () {
    $("#msjcc").html("").css("color", "red");
})

$("#txtuser").keyup(function () {
    $("#msjuser").html("").css("color", "red");
})

$("#txtpassword").keyup(function () {
    $("#msjpasswords").html("").css("color", "red");
})