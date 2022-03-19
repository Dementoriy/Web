<template>
 <div class="conteiner">
   <button type="button" v-on:click="GetList">Сформировать список</button>
   <button type="button" v-on:click="FindById">Найти по id</button>
    <table>
      <tr><th>id</th><th>ФИО</th><th>Возраст</th><th>Почта</th></tr>
      <tr v-on:click="ClickRow" v-for="item in rowData" :key="item.id">
        <td>{{ item.id }}</td>
        <td>{{ item.fio }}</td>
        <td>{{ item.age }}</td>
        <td>{{ item.email }}</td>
      </tr>
    </table>
  </div>
</template>

<script lang='ts'>
import axios from 'axios';
import Vue from 'vue';

const app = new Vue({
  el: '#app',
  data: {
    mail: '',
    date: '',
    adress: '',
    company: '',
    fliers: '',
    rowData: [],
  },
  methods: {
    ClickRow() {
      alert('Ти далбаеб поешь говна пожалуйста');
    },
    addItem(id, fio, age, email) {
      const myObject = {
        mail: this.id,
        date: this.fio,
        adress: this.age,
        company: this.email,
      };
      this.rowData.push(myObject);
      this.id = id;
      this.fio = fio;
      this.age = age;
      this.email = email;
    },
    GetList() {
      // const log :HTMLInputElement = document.getElementById('log') as HTMLInputElement;
      // const password :HTMLInputElement = document.getElementById('password') as HTMLInputElement;
      const config = {
        url: 'https://9eb3cae0-9260-4214-a5d9-07dc6c847c58.mock.pstmn.io',
      };
      axios.get(config.url)
        .then((response) => {
          console.log(response.data);
        })
        .catch((error) => {
          console.log(error);
        });
    },
    FindById() {
      const config = {
        url: 'https://9eb3cae0-9260-4214-a5d9-07dc6c847c58.mock.pstmn.io/1',
      };
      axios.get(config.url)
        .then((response) => {
          console.log(response.data);
        })
        .catch((error) => {
          console.log(error);
        });
    },
  },
});

</script>
<style scroped>
  .conteiner{
    margin: 0 auto;
    text-align: center;
  }
  button{
    padding: 8px;
    background-color:#e8edff;
    border-radius: 4px;
    cursor: pointer;
    margin: 0 10px;
    color: #039;
    border-color: #039;
    font-size: 14px;
    font-weight: 600;
  }
  button:active{
    color: black;
    background-color:#039;
    border-color: black;
  }
  table {
    font-family: "Lucida Sans Unicode", "Lucida Grande", Sans-Serif;
    font-size: 14px;
    background: white;
    max-width: 70%;
    width: 70%;
    border-collapse: collapse;
    text-align: left;
    margin: 0 auto;
  }
  th {
    font-weight: normal;
    color: #039;
    border-bottom: 2px solid #6678b1;
    padding: 10px 8px;
  }
  td {
    color: #669;
    padding: 9px 8px;
    transition: .3s linear;
    border-bottom: 1px solid #ccc;
  }
  tr:hover td {
    background: #e8edff;
    cursor: pointer;
  }
</style>
