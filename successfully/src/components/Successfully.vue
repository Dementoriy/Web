<template>
  <div class="SuccessfullyBlock">
    <h1>Successfully!</h1>
    <div>
      <button v-on:click="backToStartPage">Назад</button>
    </div>
  </div>
</template>

<script lang='ts'>
export default {
  methods: {
    backToStartPage() {
      const emailBlock :HTMLDivElement = document.querySelector('.EmailBlock');
      const emailBtn :HTMLDivElement = document.querySelector('.EmailBtn');
      const successfullyBlock :HTMLDivElement = document.querySelector('.SuccessfullyBlock');
      emailBlock.style.display = 'block';
      successfullyBlock.style.display = 'none';
    },
  },
};
</script>
<style scroped>
  .SuccessfullyBlock{
    margin: 0 auto;
    margin-top: 10%;
    text-align: center;
    display: none;
  }
  .SuccessfullyBlock button{
    padding: 8px;
    background-color:rgb(39, 151, 29);
    border: none;
    border-radius: 5px;
    cursor: pointer;
  }
  .SuccessfullyBlock button:active{
    color: white;
    background-color:rgb(29, 57, 151);
  }
</style>
