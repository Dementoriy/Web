<template>
<div class="container">
  <div class="logo">
    <img src="../assets/big_logo.jpg" alt="logo" class="biglogo-img">
    <img src="../assets/logo.jpg" alt="logo" class="logo-img">
  </div>
  <div class="registration_block">
    <h1 class="title">Авторизация</h1>
    <div class="input_desctop">
      <div class="input-block">
        <p>Логин</p>
        <input type="text">
      </div>
      <div class="input-block">
        <p>Пароль</p>
        <input type="password">
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
      <button type="button" class="Enter-btn">Авторизоваться</button>
    </div>
  </div>
</div>
</template>

<script lang="ts">
export default {

};
</script>
<style scoped>
  .container{
    width: 100%;
    margin: 0 auto;
    display: flex;
    justify-content: center;
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
  .registration_block{
    display: flex;
    align-items: center;
    flex-direction: column;
  }
  .title{
    margin-top: 0;
    margin-bottom: 10px;
  }
  .Enter-btn{
    background-color: green;
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
