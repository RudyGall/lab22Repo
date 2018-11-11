function isValid(regEx, val) {
    if (regEx.test(val)) {
        return true;
    }
    else {
        return false;
    }
}
$(function () {
    $("#FirstName").change(function () {
        var val = $("#FirstName").val();
        val = isValid(/^[a-zA-Z]{2,}$/, val);
        if (val) {
            $("#FirstNameValid").show();
            $("#FirstNameInvalid").hide();
        }
        else {
            $("#FirstNameInvalid").show();
            $("#FirstNameValid").hide();
        }
    })  
})
$(function () {
    $("#LastName").change(function () {
        var val = $("#LastName").val();
        val = isValid(/^[a-zA-Z]{2,}$/, val);
        if (val) {
            $("#LastNameValid").show();
            $("#LastNameInvalid").hide();
        }
        else {
            $("#LastNameInvalid").show();
            $("#LastNameValid").hide();
        }
    })
})
$(function () {
    $("#Email").change(function () {
        var val = $("#Email").val();
        val = isValid(/^[A-z0-9]{5,30}(@)(.+){5,10}$/, val);
        if (val) {
            $("#EmailValid").show();
            $("#EmailInvalid").hide();
        }
        else {
            $("#EmailInvalid").show();
            $("#EmailValid").hide();
        }
    })
})
$(function () {
    $("#PhoneNumber").change(function () {
        var val = $("#PhoneNumber").val();
        val = isValid(/^\d{10}$/, val);
        if (val) {
            $("#PhoneNumberValid").show();
            $("#PhoneNumberInvalid").hide();
        }
        else {
            $("#PhoneNumberInvalid").show();
            $("#PhoneNumberValid").hide();
        }
    })
})
$(function () {
    $("#PassWord").change(function () {
        var val = $("#PassWord").val();
        val = isValid(/^[a-zA-Z]\w{3,14}$/, val);
        if (val) {
            $("#PassWordValid").show();
            $("#PassWordInvalid").hide();
        }
        else {
            $("#PassWordInvalid").show();
            $("#PassWordValid").hide();
        }
    })
})
$(function () {
    $("#Date").change(function () {
        var val = $("#Date").val();
        
        val = isValid(/^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$/, val);
        if (val) {
            $("#DateValid").show();
            $("#DateInvalid").hide();
            
        }
        else {
            $("#DateInvalid").show();
            $("#DateValid").hide();
        }
    })
})
function ValidateAge() {
    var agePattern = /^[1-9]$|^[1-9][0-9]$|^(100)$/;
     
    if (agePattern.test(document.getElementById("Age").value)) {
        document.getElementById("AgeValid").style.display = "block";
        document.getElementById("AgeInvalid").style.display = "none";
    }
    else {
        document.getElementById("AgeValid").style.display = "none";
        document.getElementById("AgeInvalid").style.display = "block";
    }
}
function ValidateSSN() {
    var ssnPattern = /^\d{3}-?\d{2}-?\d{4}$/;

    if (ssnPattern.test(document.getElementById("SSN").value)) {
        document.getElementById("SSNValid").style.display = "block";
        document.getElementById("SSNInvalid").style.display = "none";
    }
    else {
        document.getElementById("SSNValid").style.display = "none";
        document.getElementById("SSNInvalid").style.display = "block";
    }
}