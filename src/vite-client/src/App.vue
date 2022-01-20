<template>
  <img alt="Vue logo" src="./assets/logo.png" />
  <HelloWorld msg="Hello Vue 3 + TypeScript + Vite" />
  <h1>{{ txt }}</h1>
  <h1>{{ counter }}</h1>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue'
import HelloWorld from './components/HelloWorld.vue'
import { useDemoStore } from './Stores/demo'

const demoStore = useDemoStore()
const txt = ref('empty')
const counter = ref(-1)

onMounted(() => {
  txt.value = demoStore.demoStr
  counter.value = demoStore.counter
})

</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
