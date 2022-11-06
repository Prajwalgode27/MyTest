$(document).ready(function () {
    GetApplication();
});

var SaveApplication = function () {
    var ApplicationName = $("#txtApplicationName").val();
    var Email = $("#txtEmail").val();
    var Mobile = $("#txtMobile").val();
    var Address = $("#txtAddress").val();
    var City = $("#txtCity").val();
    var State = $("#txtState").val();
    var PinCode = $("#txtPinCode").val();
    var model = {
        ApplicationName: ApplicationName,
        Email: Email,
        Mobile: Mobile,
        Address: Address,
        City: City,
        State: State,
        PinCode: PinCode, 
    };
    $.ajax({
        url: "/Application/SaveApplication",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (response) {
            alert(response.Message);
            AdminRegistrationList();
        }
    });
}

var GetApplication = function () {
    $.ajax({
        url: "/Application/GetApplication",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblApplication tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.ApplicationId +
                    "</td> <td>" + elementValue.ApplicationName +
                    "</td> <td>" + elementValue.Email +
                    "</td><td>" + elementValue.Mobile +
                    "</td> <td>" + elementValue.Address +
                    "</td><td>" + elementValue.City +
                    "</td> <td>" + elementValue.State +
                    "</td><td>" + elementValue.PinCode +
                    "</td></tr >";
            });
            $(tblApplication).append(html);
        }
    });
}