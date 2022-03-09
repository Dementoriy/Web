<template>
  <div>
    <nav class="header">
      <h4>Dashboard</h4>
      <div class="navBarPanel">
        <input type="text" placeholder="Type here…" class="mr20">
        <div class="navigation">
          <button class="ExitBtn2" v-on:click="exitNavigation">
            <svg width="22" height="22" viewBox="0 0 22 22" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M1 1L21 21M21 1L1 21" stroke="#FF0000"/>
            </svg>
          </button>
          <button class="NavBtn df">
            <img src="../assets/Shape.svg" alt="SignIn" class="mrNav">
            <h4 class="mr10" style="margin: 2px 0 0 0">Sign In</h4>
          </button>
          <button class="NavBtn df">
            <img src="../assets/cog.svg" alt="cog" class="mrNav">
            <h4 class="mr10" style="margin: 2px 0 0 0">Setting</h4>
          </button>
          <button class="NavBtn df">
            <img src="../assets/bell.svg" alt="bell" class="mrNav">
            <h4 class="mr10" style="margin: 2px 0 0 0">New</h4>
          </button>
        </div>
        <button class="Person" v-on:click="openNavigation">
          <img src="../assets/Person.svg" alt="Person">
        </button>
      </div>
    </nav>
  </div>
</template>

<script lang='ts'>
import Vue from 'vue';

export default {
  methods: {
    openNavigation() {
      const navigation :HTMLDivElement = document.querySelector('.navigation');
      navigation.style.transform = 'translateX(0%)';
      navigation.style.opacity = '1';
    },
    exitNavigation() {
      const navigation :HTMLDivElement = document.querySelector('.navigation');
      navigation.style.transform = 'translateX(100%)';
      navigation.style.opacity = '0';
    },
  },
};
</script>

<style scoped>
  .header{
    max-width: 96%;
    display: flex;
    margin: 0 auto;
    justify-content: space-between;
  }
  .navBarPanel{
    display: flex;
  }
  .navigation{
    display: flex;
    margin-top: 5px;
  }
  .mr20{
    margin-right: 20px;
  }
  .mrNav{
    margin: 3px 3px 0 0;
  }
  .NavBtn{
    height: 30px;
    background-color: #F5F5F5;
    margin-top: 12px;
    border: none;
    cursor: pointer;
  }
  .df{
    display: flex;
  }
  .navBarPanel input{
    width: 120px;
    height: 24px;
    margin-top: 16px;
    border-radius: 5px;
    border-width: 1px;
    background: url(../assets/Search.svg) no-repeat;
    background-size: auto 50%;
    background-position-y: 7px;
    background-position-x: 4px;
    padding-left: 30px;
  }
  .navBarPanel h4{
    font-size: 16px;
    color: #67748E;
  }
  .Person{
    width: 30px;
    height: 30px;
    cursor: pointer;
    background-color: #F5F5F5;
    border: none;
    margin-top: 10px;
    display: none;
  }
  .ExitBtn2{
    display: none;
    border: none;
    background-color: #F5F5F5;
  }
  @media (max-width: 420px)
  {
    nav h4:nth-child(1)
    {
      display: none;
    }
    .navBarPanel{
    display: flex;
    margin: auto;
    }
    .navBarPanel input{
      margin-top: 10px;
      margin-bottom: 20px;
      height: 30px;
    }
    .Person{
      display: block;
    }
    .navigation{
    position: fixed;
    right: 0;
    top: 0;
    width: 100%;
    height: 100%;
    background-color: #F5F5F5;
    z-index: 9;
    transition: transform 0.2s, opacity 0.2s;
    transform: translateX(100%); /*убираем меню в сторону */
    opacity: 0;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    }
    .ExitBtn2{
      display: block;
    }
  }
</style>
