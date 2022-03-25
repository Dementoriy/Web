<template>
  <div>
    <Fio lastName="Ведерников" firstName="Дмитрий" middleName="Михайлович"/>
    <Vyatsu hidden :results="results"/>
    <Registration/>
    <Button class="btnStart"/>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Fio from '../../fio/src/components/Fio.vue';
import Vyatsu from '../../vyatsu/src/components/Vyatsu.vue';
import Registration from '../../Registration/src/components/Registration.vue';
import Button from '../../button/src/components/Button.vue';

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
    Button,
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
<style scoped>
  .btnStart
  {
    position: fixed;
    z-index: 100;
  }
</style>
