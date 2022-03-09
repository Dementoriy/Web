<template>
  <div class="EmailBlock">
    <input type="email" class="EmailInput" placeholder="Email">
    <div>
      <button v-on:click="NextReg">Далее</button>
    </div>
  </div>
</template>

<script lang='ts'>
export default {
  methods: {
    NextReg() {
      const emailBlock :HTMLDivElement = document.querySelector('.EmailBlock');
      const registrationBlock :HTMLDivElement = document.querySelector('.RegistrationBlock');
      emailBlock.style.display = 'none';
      registrationBlock.style.display = 'block';
      const enterEmail = (document.querySelector('.EmailInput') as HTMLInputElement).value;
      const regEmail :HTMLInputElement = document.querySelector('.regEmail');
      regEmail.value = enterEmail;
    },
  },
};
</script>
<style scroped>
  .EmailBlock{
    margin: 0 auto;
    margin-top: 10%;
    text-align: center;
  }
  .EmailBlock button{
    padding: 8px;
    background-color:rgb(39, 151, 29);
    border: none;
    border-radius: 5px;
    cursor: pointer;
  }
  .EmailBlock button:active{
    color: white;
    background-color:rgb(29, 57, 151);
  }
  .EmailBlock input{
    margin-bottom: 1%;
  }
</style>
