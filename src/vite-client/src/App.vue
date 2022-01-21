<template>
  <img alt="Vue logo" src="./assets/logo.png" />
  <HelloWorld msg="Hello Vue 3 + TypeScript + Vite" />
  <h1>{{ txt }}</h1>
  <h1>{{ counter }}</h1>
  <button @click="addHandler">add</button>
  <button @click="clickHandler">click me</button>
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

const clickHandler = () => {
  fetch('https://localhost:5001/api/todoitems', {
    method: 'get'
  })
    .then(res => res.json().then(data => console.log(data)))
}

const addHandler = () => {
  fetch('https://localhost:5001/api/todoitems', {
    method: 'post',
    body: JSON.stringify({
      "name": "walk dog",
      "isComplete": true
    }),
    headers: new Headers({
      'Content-Type': 'application/json'
    })
  })
}

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
