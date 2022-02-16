<template>
  <div>
    <Fio lastName="Ведерников" firstName="Дмитрий" middleName="Михайлович"></Fio>
    <Vyatsu :results="results"></Vyatsu>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Fio from '../../fio/src/components/Fio.vue';
import Vyatsu from '../../vyatsu/src/components/Vyatsu.vue';

const url = 'https://new.vyatsu.ru/';
// const url = 'http://127.0.0.1:5500/main/src/components/8.Html';

export default {
  name: 'App',
  components: {
    Fio,
    Vyatsu,
  },
  data() {
    return { Fio, results: [] };
  },
  mounted() {
    axios
      .get(url)
      .then((response: any) => {
        console.log(response);
        this.results = response.data;
      })
      .catch((error: any) => console.log(error));
  },
};
</script>
