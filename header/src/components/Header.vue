<template>
  <div>
    <nav class="header">
      <h4>Dashboard</h4>
      <div class="navBarPanel">
        <input type="text" placeholder="Type here…" class="mr20">
        <div class="navigation">
          <img src="../assets/Shape.svg" alt="SignIn" class="mr20">
          <h4 class="mr20">Sign In</h4>
          <img src="../assets/cog.svg" alt="cog" class="mr20">
          <img src="../assets/bell.svg" alt="bell" class="mr20">
        </div>
      </div>
    </nav>
  </div>
</template>

<script lang='ts'>
import Vue from 'vue';

export default {
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
  }
  .mr20{
    margin-right: 20px;
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
  @media (max-width: 420px)
  {
    nav h4:nth-child(1)
    {
      display: none;
    }
    .navBarPanel{
    display: block;
    margin: auto;
  }
  }
</style>
