<template>
    <div class="search">
        <form v-on:submit.prevent="handleFilter">
        <input type="text" id="search" name="search" placeholder="Search Shopping List..." v-model = "searchText"/>
        </form>
    </div>
</template>

<script>
export default {
    data() {
        return {
            searchText: ''
        }

    },
    
    methods: {
   //emit something
   handleFilter() {
            this.$emit('filter',this.searchText);
        }
    }
}
</script>

<style>
#search {
    width:100%;
    font-size:24px;
    font-family: 'Roboto Condensed', sans-serif;
    padding:10px;
}
</style>