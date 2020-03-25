let shoppingList = [];

function loadShoppingList() {
    console.log("Loading shopping list . . .");
    console.error("Shopping list failed to load.")
    //fetch('https://localhost:44322/api/groceries') // -- Joe, this is the API for part 2 that we were asked to add, but the cypress tests won't run with it, and it has to be run with Visual Studio project running. I put the folder with the API docs in the exercises folder. 
    fetch('assets/data/shopping-list.json') //-- Joe, this is the local .json doc that will make the cypress tests run correctly.
        .then((response) => {
            return response.json();
        })

        .then((data) => {
            shoppingList = data;
            displayShoppingList();
            const button = document.querySelector('.loadingButton');
            button.removeEventListener('click', loadShoppingList)
        })
        .catch((err) => { console.error(err) });
    console.log("Finished loading shopping list");
}


document.addEventListener('DOMContentLoaded', () => {
    const button = document.querySelector('.loadingButton');
    button.addEventListener('click', loadShoppingList)

})

function displayShoppingList() {
    console.log("List groceries....");

    if('content' in document.createElement('template')) {
        const container = document.querySelector("ul")
        shoppingList.forEach((item) => {
          const tmpl = document.getElementById('shopping-list-item-template').content.cloneNode(true);
  
          tmpl.querySelector('li').insertAdjacentHTML('afterbegin', item.name)
          if (item.completed) {
              const circleCheck = tmpl.querySelector('.fa-check-circle');
              circleCheck.classList.add ("completed");
          }
          container.appendChild(tmpl);

          
        });
      } else {
        console.error('Your browser does not support templates');
      }
}
