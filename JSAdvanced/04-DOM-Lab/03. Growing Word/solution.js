function growingWord() {
  let heading = document.querySelector('h1');
  // let colors = document.getElementById('colors');

  if (!heading.style.fontSize) {
    let firstColorElement = document.getElementById('blueDiv');
    firstColorElement.setAttribute('current-color', true);
    heading.style.fontSize = '2px';
  } else {
    let size = parseInt(heading.style.fontSize);
    heading.style.fontSize = `${size + 2}px`;

    let colorElements = document.querySelector('#colors');
    for (const element of colorElements.children) {
      element.style.color = 'blue';  
     };
  }
}