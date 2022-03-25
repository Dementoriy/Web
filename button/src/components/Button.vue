<template>
  <div v-on:click="tap">
    <h1>Старт</h1>
  </div>
</template>

<script lang='ts'>
import Vue from 'vue';

export default {
  name: 'Fio',
  props: {
    lastName: String,
    firstName: String,
    middleName: String,
  },
};
</script>

<style scoped>
div {
  display: block;
  margin: 0 auto;
  text-align: center;
}
div::before{
  width: 100%;
  height: 100%;
  background-color: red;
  border-radius: 100%;
}
</style>
