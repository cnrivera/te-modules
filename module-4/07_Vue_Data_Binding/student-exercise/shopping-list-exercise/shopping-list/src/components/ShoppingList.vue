<template>
  <div class="shopping-list">
    <h1>My Shopping List</h1>
    <ul>
      <li v-bind:class="{completed: grocery.completed}" v-for="grocery in groceries" v-bind:key=grocery> {{grocery.item}}</li>
      
    </ul>
  </div>
</template>

<script>
export default {
  data () {
      return {
        groceries: [
          {
            item: 'strawberries',
            completed: true,
          },
          {
            item: 'onions',
            completed: true,
          },
          {
            item: 'creamer',
            completed: true,
          },
          {
            item: 'bread',
            completed: false,
          },
          {
            item: 'grapes',
            completed: false,
          },
          {
            item: 'deodorant',
            completed: false,
          },
          {
            item: 'crackers',
            completed: false,
          },
          {
            item: 'soda',
            completed: false,
          },
          {
            item: 'yogurt',
            completed: false
          }
        ]
    }
  }
}
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
