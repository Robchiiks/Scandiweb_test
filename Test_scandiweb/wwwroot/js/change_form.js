//$('div').hide();

//$('#type').change(function () {
//  var value = this.value;
//    $('div').hide();
//  $('#' + this.value).show();

//});
document.getElementById('Type').addEventListener('change', function () {
    document.getElementById('disc').style.display = 'none';
    document.getElementById('furniture').style.display = 'none';
    document.getElementById('book').style.display = 'none';


    switch (this.value) {
        case "disc":
            document.getElementById('disc').style.display = 'block';
            break;
        case "furniture":
            document.getElementById('furniture').style.display = 'block';
            break;
        case "book":
            document.getElementById('book').style.display = 'block';
            break;

    }
});