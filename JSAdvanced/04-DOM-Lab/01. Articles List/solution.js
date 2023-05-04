function createArticle() {
	let titleInputElement = document.getElementById('createTitle');
	let contentInputElement = document.getElementById('createContent');
	titleInputElement.setAttribute('placeholder', 'Pesho');
	titleInputElement.removeAttribute('placeholder');
	// console.log(titleElement.value);
	// console.log(createContentElement.value);

	let headingElement = document.createElement("h3");
	headingElement.innerHTML = titleInputElement.value;
	titleInputElement.value = '';

	let contentElement = document.createElement("p");
	contentElement.textContent = contentInputElement.value;
	contentInputElement.value = '';
	console.log(contentInputElement.getAttribute('id'));
	
	let articleElement = document.createElement("article");
	articleElement.appendChild(headingElement);
	articleElement.appendChild(contentElement);

	let articleSectionElement = document.getElementById('articles');
	articleSectionElement.appendChild(articleElement);
}
