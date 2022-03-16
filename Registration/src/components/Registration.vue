<template>
  <div>
  <div class="switch">
    <a type="button" class="EnterBtn" v-on:click="toggleStyleEnter">Вход</a>
    <a type="button" class="RegBtn" v-on:click="toggleStyleRegister">Регистрация</a>
  </div>
  <div class="container">
    <div class="logo">
      <img src="../assets/big_logo.jpg" alt="logo" class="biglogo-img">
      <img src="../assets/logo.jpg" alt="logo" class="logo-img">
    </div>
    <div class="autorization_block">
      <h1 class="title">Авторизация</h1>
      <div class="input-block">
        <p>Логин</p>
        <input type="text" id="log" placeholder="Логин">
      </div>
      <div class="input-block">
        <p>Пароль</p>
        <input type="password" id="password" placeholder="Пароль">
      </div>
      <div class="save">
        <input type="checkbox">
        <h3 class="save-text">Сохранить</h3>
      </div>
      <div>
        <button type="button" class="Enter-btn" v-on:click="signIn">Авторизоваться</button>
      </div>
    </div>
    <div class="registrationtion_block">
      <h1 class="title">Регистрация</h1>
      <div class="input-block">
        <p>Почта</p>
        <input type="email" placeholder="email">
      </div>
      <div class="input-block">
        <p>Логин</p>
        <input type="text" placeholder="Логин" id="regLog">
      </div>
      <div class="input-block">
        <p>Пароль</p>
        <input type="password" placeholder="Пароль" id="regPass">
      </div>
      <div class="input-block">
        <p>Повторите пароль</p>
        <input type="password" placeholder="Пароль">
      </div>
      <div>
        <button type="button" class="Enter-btn mt-20" v-on:click="signOn">Зарегистрироваться
        </button>
      </div>
    </div>
  </div>
</div>
</template>

<script lang="ts">
import axios from 'axios';

export default {
  methods: {
    toggleStyleEnter() {
      const enter :HTMLDivElement = document.querySelector('.autorization_block');
      const reg :HTMLDivElement = document.querySelector('.registrationtion_block');
      const enterBtn :HTMLDivElement = document.querySelector('.EnterBtn');
      const regBtn :HTMLDivElement = document.querySelector('.RegBtn');
      enter.style.display = 'flex';
      reg.style.display = 'none';
      enterBtn.style.color = 'green';
      regBtn.style.color = 'black';
    },
    toggleStyleRegister() {
      const enter :HTMLDivElement = document.querySelector('.autorization_block');
      const reg :HTMLDivElement = document.querySelector('.registrationtion_block');
      const enterBtn :HTMLDivElement = document.querySelector('.EnterBtn');
      const regBtn :HTMLDivElement = document.querySelector('.RegBtn');
      enter.style.display = 'none';
      reg.style.display = 'flex';
      enterBtn.style.color = 'black';
      regBtn.style.color = 'green';
    },
    signIn() {
      const log :HTMLInputElement = document.getElementById('log') as HTMLInputElement;
      const password :HTMLInputElement = document.getElementById('password') as HTMLInputElement;

      const config = {
        url: 'https://b83c67c6-f6e2-44a3-b933-0dbe68ae85c0.mock.pstmn.io/auth/login',
      };
      const data = {
        login: log.value,
        password: password.value,
      };
      axios.post(config.url, data, { headers: { 'x-mock-match-request-body': true } })
        .then((response) => {
          console.log(response.data.completed);
          if (response.data.completed) {
            alert('Успешно!');
          }
        })
        .catch((error) => {
          console.log(error);
          alert('Неверный логин или пароль!');
        });
    },
    signOn() {
      const regLog :HTMLInputElement = document.getElementById('regLog') as HTMLInputElement;
      const regPass :HTMLInputElement = document.getElementById('regPass') as HTMLInputElement;

      const config = {
        url: 'https://b83c67c6-f6e2-44a3-b933-0dbe68ae85c0.mock.pstmn.io/auth/check',
      };
      const data = {
        login: regLog.value,
        password: regPass.value,
      };
      axios.get(config.url + '?' + data.login + '&' + data.password)
        .then((response) => {
          console.log(response.data.isValid);
          if (response.data.isValid) {
            alert('Логин занят!');
          } else alert('Успешно!');
        })
        .catch((error) => {
          console.log(error);
        });
    },
  },
};
</script>
<style scoped>
  .input-block input::placeholder{
    color: white;
  }
  .container{
    width: 100%;
    margin: 0 auto;
    display: flex;
    justify-content: center;
  }
  .switch{
    text-align: center;
    margin: 30px 0px;
  }
  .switch a{
    font-size: 30px;
    padding: 5px 10px;
  }
  .EnterBtn{
    color: green;
    cursor: pointer;
  }
  .RegBtn{
    color: black;
    cursor: pointer;
  }
  .mt-20{
    margin-top: 10px;
  }
  .logo{
    margin-right: 10px;
  }
  .biglogo-img{
    height: 280px;
  }
  .logo-img{
    display: none;
  }
  .autorization_block{
    display: flex;
    align-items: center;
    flex-direction: column;
  }
  .registrationtion_block{
    display: none;
    align-items: center;
    flex-direction: column;
  }
  .title{
    margin-top: 0;
    margin-bottom: 10px;
  }
  .save{
    display: flex;
    margin: 20px 0px 10px 0px;
  }
  .save-text{
    margin: 0 auto;
    margin-left: -1px;
  }
  .save input{
    cursor: pointer;
  }
  .Enter-btn{
    background-color: green;
    padding: 14px 26px;
    border-radius: 5px;
    font-size: 16px;
    color: white;
    cursor: pointer;
  }
  .input-block p{
      margin-bottom: 0px;
  }
  .input-block input{
    font-size: 20px;
    text-decoration: none;
    padding: 2px 1px;
    margin-bottom: 10px;
    }
  @media (max-width:600px){
    .container{
      display: block;
    }
    .biglogo-img{
      display: none;
    }
    .logo-img{
      display: block;
      margin: 0 auto;
      height: 100px;
    }
    .input-block input::placeholder{
    color: gray;
    }
    .input-block p{
      display: none;
    }
  }
    @media (max-width:260px){
      .input-mobil input{
        width: 180px;
    }
    }
</style>
