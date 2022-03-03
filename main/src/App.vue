<template>
  <div>
    <Fio lastName="Ведерников" firstName="Дмитрий" middleName="Михайлович"/>
    <Vyatsu hidden :results="results"/>
    <Registration/>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Fio from '../../fio/src/components/Fio.vue';
import Vyatsu from '../../vyatsu/src/components/Vyatsu.vue';
import Registration from '../../Registration/src/components/Registration.vue';

const url = 'http://localhost:8080/admission/';

export default {
  name: 'App',
  props: {
    results: [],
  },
  components: {
    Fio,
    Vyatsu,
    Registration,
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
