<template>
  <div id="app">
    <HelloWorld v-bind:title="message" v-on:result-event="appAction"/>
    <hr>
    <p>{{result}}</p>
    <!--<button v-on:click="doAction">change title</button>-->
  </div>  
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'app',
  components: {
    HelloWorld
  },

  data: function(){
    return {
      message:'HELLO2',
      result:'no event'
    }
  },

  methods:{
    appAction: function(message){
      this.result = '(*** you send:"' + message + '".***)'
    }
  }

  /*methods:{
    doAction:function(){
      var input = prompt("new title:"); // 小さい画面を表示して情報を受け取る
      this.message = input;
    }
  }*/

}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
