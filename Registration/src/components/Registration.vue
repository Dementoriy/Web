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
      <div class="input_desctop">
        <div class="input-block">
          <p>Логин</p>
          <input type="text" id="login">
        </div>
        <div class="input-block">
          <p>Пароль</p>
          <input type="password" id="password">
        </div>
      </div>
      <div class="input-mobil">
        <input type="text" placeholder="Логин">
        <input type="password" placeholder="Пароль">
      </div>
      <div class="save">
        <input type="checkbox">
        <h3 class="save-text">Сохранить</h3>
      </div>
      <div>
        <button type="button" class="Enter-btn" v-on:click="login">Авторизоваться</button>
      </div>
    </div>
    <div class="registrationtion_block">
      <h1 class="title">Регистрация</h1>
      <div class="input_desctop">
        <div class="input-block">
          <p>Почта</p>
          <input type="email">
        </div>
        <div class="input-block">
          <p>Логин</p>
          <input type="text">
        </div>
        <div class="input-block">
          <p>Пароль</p>
          <input type="password">
        </div>
        <div class="input-block">
          <p>Повторите пароль</p>
          <input type="password">
        </div>
      </div>
      <div class="input-mobil">
        <input type="email" placeholder="Почта">
        <input type="text" placeholder="Логин">
        <input type="password" placeholder="Пароль">
        <input type="password" placeholder="Повторите пароль">
      </div>
      <div>
        <button type="button" class="Enter-btn mt-20">Зарегистрироваться</button>
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
    login() {
      const login :HTMLInputElement = document.querySelector('.login');
      const password :HTMLInputElement = document.querySelector('.password');
      const data = {
        'login': login.value,
        'password': password.value,
      };
      const url = 'https://f1d4f9b7-8963-4873-a367-454f6d86e622.mock.pstmn.io/auth/check';
      axios.post(url, data, { headers: { 'Content-Type': 'appcation/json' } })
        .then(
          (res: any) => {
            console.log(res.data);
          },
        ).catch(
          (err: any) => {
            console.log(err);
          },
        );
    },
  },
};
</script>
<style scoped>
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
  .input-mobil{
    display: none;
    flex-direction: column;
  }
  .input-block p{
      margin-bottom: 0px;
  }
  .input-block input{
    font-size: 20px;
    text-decoration: none;
    padding: 2px 1px;
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
    .input_desctop{
      display: none;
    }
    .input-mobil{
      display: flex;
    }
    .input-mobil input{
      margin-top: 10px;
    }
    .input-mobil input{
    font-size: 20px;
    text-decoration: none;
    padding: 2px 1px;
    }
  }
    @media (max-width:260px){
      .input-mobil input{
        width: 180px;
    }
    }
</style>
