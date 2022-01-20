import { defineStore } from "pinia";

export const useDemoStore = defineStore("demo", {
  state: () => {
    return {
      demoStr: "this is demo string",
      counter: 0,
    };
  },
});
