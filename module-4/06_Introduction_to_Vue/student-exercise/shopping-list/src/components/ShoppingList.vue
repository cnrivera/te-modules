<template>
  <div class="shopping-list">
      <h1>My Shopping List</h1>
    <ul>
        <li class = "completed">apples</li>
        <li class = "completed">spinach</li>
        <li class = "completed">cucumber</li>
        <li>strawberries</li>
        <li>olive oil</li>
        <li>oranges</li>
        <li>soda water</li>
        <li>mixed nuts</li>
        <li>salad dressing</li>
        <li>melon</li>
    </ul>
  </div>
</template>

<script>
export default {
    name: 'shopping-list'
   
    
};
</script>

<style>
.shopping-list {
    width:450px;
    background: #fff;
    margin: 50px auto;
    font-family: 'Roboto Condensed', sans-serif;
    border-radius: 10px;
}
h1 {
    background:#f2f2f2;
    color:#5c8578;
    padding:10px;
    font-size:24px;
    text-transform: uppercase;
    text-align: center;
    margin-bottom: 0px;
    border-top-left-radius: 10px;
    border-top-right-radius: 10px;
}
ul {
    list-style-type: none;
    margin:0px;
    padding:0px;
}
li {
    font-size: 24px;
    border-bottom:1px solid #f2f2f2;
    padding:10px 20px;
}
li:last-child{
    border:0px;
}
li.completed {
    text-decoration: line-through;
    color:darkgrey;
}
</style>