function Calculate() {
    let iHours = parseFloat($('#hours').val());
    console.log("iHours", iHours)

    //Validation to make sure they actually entered a positive number
    if (iHours < 0) {
        alert('Try a number more than 0!');
        $('#hours').val(0);
    }
    else {
        let iRate = parseFloat($('#rate').val());
        console.log("Rate", iRate)

        let iTotal = iHours * iRate;
        console.log("iTotal", iTotal)

        $('#total').html(iTotal);
    }
}