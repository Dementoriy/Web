<template>
  <div>
    <Label>!</Label>
    <div class="calculateFactorial">
      <input type="text" id="FactorialValue">
      <button type="button" id="FactorialButton" v-on:click="calculate">Рассчитать</button>
      <span id="result"></span>
    </div>
  </div>
</template>

<script lang="ts">
const FactorialValue : HTMLInputElement = document.getElementById('FactorialValue') as HTMLInputElement;
const FactorialButton : HTMLButtonElement = document.getElementById('FactorialButton') as HTMLButtonElement;
const resultText : HTMLSpanElement = document.getElementById('result') as HTMLSpanElement;
export default {
  components: {
  },
  props: {
    results: [],
  },
  methods: {
    Calculate() {
      if ('WebAssembly' in window) {
        console.log('+');
        //WebAssembly.instantiateStreaming(fetch('functions.wasm')) 
        fetch("functions.wasm")
        .then(Response)
          .then((bytes) => {
            WebAssembly.instantiate(bytes, importObject)
          })
          .then(result => {
              const number = FactorialValue.value;
              const results = result.instance.exports.factorial(number);
              resultText.innerHTML = results;
          })
          .catch(console.error);
      }
    },
  },
};
</script>
<style scoped>
  .calculateFactorial{
    margin: 0 auto;
    display: flex;
  }
</style>
