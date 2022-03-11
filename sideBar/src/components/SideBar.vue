<template>
  <div>
    <button class="menu-btn" v-on:click="openNavbarPanel">
      <svg width="50" height="32" viewBox="0 0 50 32" fill="none" xmlns="http://www.w3.org/2000/svg">
        <g clip-path="url(#clip0_101_2)">
        <rect width="40" height="32" fill="#F5F5F5"/>
        <rect y="1" width="40" height="6" rx="3" fill="#67748E"/>
        <rect y="13" width="40" height="6" rx="3" fill="#67748E"/>
        <rect y="25" width="30" height="6" rx="3" fill="#67748E"/>
        </g>
        <defs>
        <clipPath id="clip0_101_2">
        <rect width="50" height="32" fill="white"/>
        </clipPath>
        </defs>
      </svg>
    </button>
    <div class="navbar-panel">
      <header>
        <img src="../assets/logo.jpg" alt="logo">
        <h3 class="m0">Soft UI Dashboard</h3>
        <button class="ExitBtn" v-on:click="exitNavbarPanel">
          <svg width="22" height="22" viewBox="0 0 22 22" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M1 1L21 21M21 1L1 21" stroke="#FF0000"/>
          </svg>
        </button>
      </header>
      <main>
        <ul>
          <li class="BGW-li">
            <button type="button" class="btnCheck" id="Dashboard"
              v-on:click="clickSideBar" href="#">
              <img src="../assets/shop.svg" alt="shop" class="bgp mr20">
              <h4 class="m0">Dashboard</h4>
            </button>
          </li>
          <li class="BGG-li">
            <button type="button" class="btnUncheck" id="Tables" v-on:click="clickSideBar">
              <img src="../assets/office.svg" alt="office" class="bgw mr20">
              <h4 class="m0">Tables</h4>
            </button>
          </li>
          <li class="BGG-li">
            <button type="button" class="btnUncheck" id="Billing" v-on:click="clickSideBar">
              <img src="../assets/credit-card.svg" alt="credit" class="bgw mr20">
              <h4 class="m0">Billing</h4>
            </button>
          </li>
          <li class="BGG-li">
            <button type="button" class="btnUncheck" id="RTL" v-on:click="clickSideBar">
              <img src="../assets/settings.svg" alt="settings" class="bgw mr20">
              <h4 class="m0">RTL</h4>
            </button>
          </li>
          <li>
            <h4>ACCOUNT PAGES</h4>
          </li>
          <li class="BGG-li">
            <button type="button" class="btnUncheck">
              <img src="../assets/customer-support.svg" alt="Profile" class="bgw mr20">
              <h4 class="m0">Profile</h4>
            </button>
          </li>
          <li class="BGG-li">
            <button type="button" class="btnUncheck">
              <img src="../assets/document.svg" alt="document" class="bgw mr20">
              <h4 class="m0">Sign In</h4>
            </button>
          </li>
          <li class="BGG-li">
            <button type="button" class="btnUncheck">
              <img src="../assets/spaceship.svg" alt="spaceship" class="bgw mr20">
              <h4 class="m0">Sign Up</h4>
            </button>
          </li>
        </ul>
      </main>
    </div>
  </div>
</template>

<script lang='ts'>
import Vue from 'vue';
import Header from '../../../header/src/components/Header.vue';

const Dashboard = document.getElementById('Dashboard');
const Tables = document.getElementById('Tables');
const Billing = document.getElementById('Billing');
const RTL = document.getElementById('RTL');
const CurrentCheck = Dashboard;
export default {
  methods: {
    clickSideBar(e) {
      console.log(e.target.class);
    },
    openNavbarPanel() {
      const NavbarPanel :HTMLDivElement = document.querySelector('.navbar-panel');
      NavbarPanel.style.transform = 'translateX(0%)';
      NavbarPanel.style.opacity = '1';
    },
    exitNavbarPanel() {
      const NavbarPanel :HTMLDivElement = document.querySelector('.navbar-panel');
      NavbarPanel.style.transform = 'translateX(-100%)';
      NavbarPanel.style.opacity = '0';
    },
  },
};
</script>

<style scroped>
  .navbar-panel
  {
    margin-top: 10px;
  }
  header{
    display: flex;
    margin-left: 40px;
  }
  header img{
    height: 30px;
    width: 30px;
  }
  .m0{
    margin: 0;
  }
  main ul{
    list-style-type: none;
  }
  main li{
    width: 80%;
    display: flex;
    align-items: center;
    padding: 10px 20px 10px 10px;
    border-radius: 8px;
  }
  main li button{
    width: 34px;
  }
  main li h4{
      white-space: nowrap;
    }
  .BGW-li{
    background-color: #ffff;
  }
  .BGG-li{
    background-color: #F5F5F5;
  }
  .bgp{
    background-color: #CB0C9F;
    padding: 9px;
    border-radius: 8px;
  }
  .bgw{
    background-color: #fff;
    padding: 9px;
    border-radius: 8px;
  }
  .mr20{
    margin-right: 20px;
  }
  .btnCheck{
    background-color:#ffff;
    border: none;
    cursor: pointer;
    display: flex;
    align-items: center;
    font-size: 14px;
    color: #252F40;
  }
  .btnUncheck{
    background-color: #F5F5F5;
    border: none;
    cursor: pointer;
    display: flex;
    align-items: center;
    font-size: 14px;
    color: #67748E;
  }
  .menu-btn{
    display: none;
    margin-top: 10px;
    margin-left: 10px;
    cursor: pointer;
    background-color: #F5F5F5;
    border: none;
  }
  .ExitBtn{
    display: none;
    border: none;
    background-color: #F5F5F5;
    margin-left: 20%;
  }
  @media (max-width: 420px)
  {
    header{
      margin-left: 2%;
      margin-top: 14px;
    }
    header{
      padding-left: 5%;
    }
    main ul{
      padding-left: 5%;
    }
    main li{
    padding: 5px;
  }
  .mr{
    margin: 0;
  }
  .BGW-li{
    background-color: #F5F5F5;
  }
  .menu-btn{
    display: block;
  }
  .navbar-panel{
    position: fixed;
    right: 0;
    top: 0;
    width: 100%;
    height: 100%;
    background-color: #F5F5F5;
    z-index: 9;
    transition: transform 0.2s, opacity 0.2s;
    transform: translateX(-100%); /*убираем меню в сторону */
    opacity: 0;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
  .ExitBtn{
    display: block;
  }
  }
</style>
