<template>
  <div v-on:click="btnStartClick" class="btnStart">
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
  methods: {
    btnStartClick() {
      const btnStart :HTMLDivElement = document.querySelector('.btnStart');
      const bgdiv :HTMLDivElement = document.querySelector('#mainContainer');
      btnStart.style.display = 'none';
      bgdiv.style.pointerEvents = 'auto';
      bgdiv.style.userSelect = 'auto';
    },
  },
};
</script>

<style scoped>
div {
  display: block;
  margin: 0 auto;
  text-align: center;
  width: 48%;
  height: 96%;
  background-color: red;
  border-radius: 100%;
  border: 3px solid;
  cursor: pointer;
  overflow-y: auto;
  overflow-x: hidden;
  backdrop-filter: blur(4rem);
}
div:hover {
  background-color: rgb(53, 96, 189);
}
div:active {
  background-color: rgb(53, 189, 64);
}
div h1 {
  font-size: 100px;
  font-family: arial;
  margin-top: 35%;
  user-select: none;
}
</style>
