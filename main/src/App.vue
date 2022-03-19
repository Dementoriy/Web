<template>
 <Table/>
</template>
<style scroped>
  .conteiner table{
    border-radius: 1px;
  }
</style>
<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Table from '../../table/src/components/table.vue';

const url = 'http://localhost:8080/admission/';

export default {
  name: 'App',
  props: {
    results: [],
  },
  components: {
    Table,
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
