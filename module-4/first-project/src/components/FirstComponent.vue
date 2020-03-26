<template>
  <div>
    <h1>{{message}}</h1>
  </div>
</template>

<style scoped>
h1 {
  color: blue;
}
</style>

<script>
export default {
    name: 'first-compnent',
    data() {
        return {
            message: 'Our message from the first component'
        }
    }
}
</script>