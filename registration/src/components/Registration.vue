<template>
  <div class="RegistrationBlock">
    <div class="inputBlock">
      <div>
        <input type="email" placeholder="Email" readonly class="regEmail">
      </div>
      <div>
        <input type="password" placeholder="password">
      </div>
      <div>
        <input type="password" placeholder="password">
      </div>
      <div>
        <input type="text" placeholder="Login">
      </div>
    </div>
    <div>
      <button v-on:click="EndReg">Далее</button>
    </div>
  </div>
</template>

<script lang='ts'>
export default {
  methods: {
    EndReg() {
      const emailBlock :HTMLDivElement = document.querySelector('.EmailBlock');
      const successfullyBlock :HTMLDivElement = document.querySelector('.SuccessfullyBlock');
      const registrationBlock :HTMLDivElement = document.querySelector('.RegistrationBlock');
      emailBlock.style.display = 'none';
      registrationBlock.style.display = 'none';
      successfullyBlock.style.display = 'block';
    },
  },
};
</script>
<style scroped>
  .RegistrationBlock{
    margin: 0 auto;
    margin-top: 10%;
    text-align: center;
    display: none;
  }
  .inputBlock{
    flex-direction: column;
  }
  .RegistrationBlock button{
    padding: 8px;
    background-color:rgb(39, 151, 29);
    border: none;
    border-radius: 5px;
    cursor: pointer;
  }
  .RegistrationBlock button:active{
    color: white;
    background-color:rgb(29, 57, 151);
  }
  .RegistrationBlock input{
    margin-bottom: 1%;
  }
</style>
