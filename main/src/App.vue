<template>
  <div>
    <Table/>
    <Reg/>
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

export default {
  name: 'App',
  props: {
    results: [],
  },
  components: {
    Table,
    Reg,
  },
};
</script>
