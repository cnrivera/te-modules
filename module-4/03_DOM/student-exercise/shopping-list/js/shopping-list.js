// add pageTitle
let pageTitle = 'My Shopping List';
// add groceries
let groceries = [
  {item: 'apples'},
  {item: 'oranges'},
  {item: 'strawberries'},
  {item: 'toilet paper'},
  {item: 'veggie meatballs'},
  {item: 'notebook'},
  {item: 'squishmallow'},
  {item: 'almond milk creamer'},
  {item: 'green tea'},
  {item: 'coconut yogurt'}
];
/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const heading = document.getElementById('title')
  heading.innerText = pageTitle;
 }

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() { 
  const ul = document.getElementById('groceries');
  
  groceries.forEach(groceries=> {
    const li = document.createElement('li')
    li.innerText = groceries.item
    ul.appendChild(li)
});
}
/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() { 
  const groceryList = document.querySelectorAll ('#groceries li');

  groceryList.forEach( (item) => {
    item.classList.add('completed');
  })
  
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
