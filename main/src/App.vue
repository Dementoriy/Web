<template>
  <div class="conteiner">
    <Email class="Email"/>
    <Registration class="Registration"/>
    <Successfully class="Successfully"/>
  </div>
</template>
<style scroped>
</style>
<script lang="ts">
import Vue from 'vue';
import axios from 'axios';
import Email from '../../email/src/components/Email.vue';
import Registration from '../../registration/src/components/Registration.vue';
import Successfully from '../../successfully/src/components/Successfully.vue';

const url = 'http://localhost:8080/admission/';

export default {
  name: 'App',
  props: {
    results: [],
  },
  components: {
    Email,
    Registration,
    Successfully,
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
