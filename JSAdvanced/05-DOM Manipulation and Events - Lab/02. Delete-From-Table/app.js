function deleteByEmail() {
    let inputEl = document.getElementsByTagName("input")[0];
    let resultEl = document.getElementById('result');

    var rows =document.getElementsByTagName("tbody")[0].rows;
    for (var i = 0; i < rows.length; i++) {
        var trEl = rows[i];
        var td = trEl.getElementsByTagName("td")[1];

        if (inputEl.value == td.innerHTML) {
            trEl.remove();
            resultEl.innerHTML = 'Deleted.';
        } else {
            resultEl.innerHTML = 'Not found.';
        }
    }
}

function changeBg(e) {
    e.target.style.backgroundColor = "gray";
}

function resetBg(e) {
    e.target.style.backgroundColor = '';
}