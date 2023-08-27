function addItem() {
    let inputEl = document.getElementById('newItemText');
    let liEl = document.createElement('li');
    let deleteEl = document.createElement('a');
    deleteEl.setAttribute('href', '#');
    deleteEl.innerHTML = '[Delete]';

    liEl.innerHTML = inputEl.value;
    liEl.appendChild(deleteEl);

    deleteEl.addEventListener('click', function(e) {
        let parentEl = e.target.parentElement;
        parentEl.remove();
    });

    let ulEl = document.getElementById('items');
    ulEl.appendChild(liEl);
    inputEl.value = '';
}