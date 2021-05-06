var check = 0;
function getText() {
    if (check == 0) {
        var name = document.querySelector('.hoten1').value;
        alert('Welcome ' + name + '!');
        check = 1;
    }
    else {
        alert('You have already logged in!')
    }
}