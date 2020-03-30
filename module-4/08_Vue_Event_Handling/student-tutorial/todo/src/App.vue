<template>
  <div id="todo-app">
    <todo-list>
      <li v-for="todo in todos" v-bind:key="todo.task" v-bind:class="{'todo-completed': todo.completed}">
    <input type="checkbox" @click="changeStatus()"/>
    {{todo.task}} <i class="far fa-check-circle" v-bind:class="{completed: todo.completed}"></i>
    </li>
    </todo-list>
  </div>
</template>

<script>
import TodoList from './components/TodoList';

export default {
  name: 'app',
  components: {
    TodoList
  }
  
}

methods: {
    changeStatus() {
      <li v-for="todo in todos" v-bind:key="todo.id" v-bind:class="{'todo-completed': todo.completed}">
    <input type="checkbox" v-on:click="changeStatus(todo.id)"/>
    {{todo.task}} <i class="far fa-check-circle" :class="{completed: todo.completed}"></i>
</li>
        
    }
}

</script>

<style>
body {
background: rgb(74,162,244);
background: radial-gradient(circle, rgba(74,162,244,1) 0%, rgba(54,131,240,1) 100%);}
</style>
