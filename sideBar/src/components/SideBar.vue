<template>
  <div>
    <header>
      <img src="../assets/logo.jpg" alt="logo">
      <h3 class="m0">Soft UI Dashboard</h3>
    </header>
    <main>
      <ul>
        <li class="BGW-li">
          <button type="button" class="btnCheck" id="Dashboard" v-on:click="clickSideBar">
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
  },
};
</script>

<style scroped>
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
  @media (max-width: 420px)
  {
    header{
      margin-left: 2%;
      margin-top: 14px;
    }
    main li h4{
      display: none;
    }
    header h3{
      display: none;
    }
    header img{
      display:block;
      margin:auto;
    }
    main ul{
      padding-left: 2%;
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
  }
</style>
