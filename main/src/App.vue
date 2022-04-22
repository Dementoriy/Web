<template>
  <div>
    <Table/>
    <Reg/>
    <Factorial/>
  </div>
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
import Reg from '../../reg/src/components/Reg.vue';
import Factorial from '../../Factorial/src/components/Factorial.vue';

export default {
  name: 'App',
  props: {
    results: [],
  },
  components: {
    Table,
    Reg,
    Factorial,
  },
};
</script>
