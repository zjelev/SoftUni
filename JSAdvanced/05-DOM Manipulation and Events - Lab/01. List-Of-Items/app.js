function addItem() {
    let inputEl = document.getElementById('newItemText');
    let liEl = document.createElement('li');
    liEl.innerHTML = inputEl.value;
    let ulEl = document.getElementById('items');
    ulEl.appendChild(liEl);
    inputEl.value = '';
}