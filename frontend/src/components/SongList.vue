<template>
  <table>
    <tr>
      <th>interpret</th>
      <th>title</th>
      <th>subtitle</th>
      <th>mapper</th>
      <th>easy</th>
      <th>normal</th>
      <th>hard</th>
      <th>expert</th>
      <th>custom</th>
    </tr>
    <tr v-for="song in songList" :key="song.id">
      <td>{{ song.id }}</td>
      <td>{{ song.interpret }}</td>
      <td>{{ song.title }}</td>
      <td>{{ song.subtitle }}</td>
      <td>{{ song.mapper }}</td>
      <td>{{ song.difficulty.easy ? 'easy' : '' }}</td>
      <td>{{ song.difficulty.normal ? 'normal' : '' }}</td>
      <td>{{ song.difficulty.hard ? 'hard' : '' }}</td>
      <td>{{ song.difficulty.expert ? 'expert' : '' }}</td>
      <td>{{ song.difficulty.custom ? song.difficulty.custom.join(',') : '' }}</td>
    </tr>
  </table>
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component';
  import { Song } from '../models/Song';
  @Options({
    props: {
      songList: []
    }
  })
  export default class SongList extends Vue {
    songList!: Song[]
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
