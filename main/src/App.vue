<template>
  <div class="conteiner">
    <SideBar class="SideBar"/>
    <div class="block">
      <Header class="Header"/>
      <Dashboard class="Dashboard"/>
    </div>
  </div>
</template>
<style scroped>
  .conteiner{
    display: flex;
    width: 100%;
    background-color: #F5F5F5;
    font-family: 'Lato', sans-serif;
  }
  .SideBar{
    width: 20%;
  }
  .block{
    width: 80%;
  }
  .Header{
    width: 100%;
  }
</style>
<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Header from '../../header/src/components/Header.vue';
import SideBar from '../../sideBar/src/components/SideBar.vue';
import Dashboard from '../../dashboard/src/components/Dashboard.vue';

const url = 'http://localhost:8080/admission/';

export default {
  name: 'App',
  props: {
    results: [],
  },
  components: {
    Header,
    SideBar,
    Dashboard,
  },
  mounted() {
    axios
      .get(url)
      .then((response) => {
        console.log(response);
        this.results = response.data;
      })
      .catch((error: any) => console.log(error));
  },
};
</script>
