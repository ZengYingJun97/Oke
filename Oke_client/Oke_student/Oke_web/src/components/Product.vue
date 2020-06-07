<template>
  <!-- 创建要控制的区域 -->
  <div id="app">
    <div class="panel panel-primary">
      <div class="panel-heading">
        <h3 class="panel-title">Add Product</h3>
      </div>
      <div class="panel-body form-inline">
        <label>
          Id:
          <input type="text" class="form-control" v-model="id">
        </label>
        
        <label>
          Name:
          <input type="text" class="form-control" v-model="name" @keyup.enter="add">
        </label>
        
        <label>Keywords Search:
          <!-- 注意 ：Vue中所有指令，在调用的时候，都以v- 开头-->
          <input type="text" class="form-control" v-model="keywords">
        </label>
        
        <input type="button" value="Add" class="btn btn-primary" @click="add">
      </div>
    </div>

    <table class="table table-hover table-bordered table-striped">
      <thead>
        <tr>
          <th>Id</th>
          <th>Name</th>
          <th>Time</th>
          <th>Operation</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in search(keywords)" :key="item.id">
          <td>{{item.id}}</td>
          <td>{{item.name }}</td>
          <td>{{item.ctime}}</td>
          <td>
            <a href="#" @click.prevent="del(item.id)">Delete</a>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>


<script>
export default {
  name: "Product",
  data() {
    return {
      list: [
        { id: 1, name: "奔驰", ctime: new Date() },
        { id: 2, name: "宝马", ctime: new Date() }
      ],
      id: "",
      name: "",
      keywords: ""
    };
  },
  methods: {
    add() {
      // vue中已经实现了数据的双向绑定，每当我们修改了data中的数据，Vue会默认监听到
      // 数据的改动，自动把最新的数据，应用到页面上
      this.list.push({ id: this.id, name: this.name, ctime: new Date() });
    },

    del(id) {
      // 根据Id删除数据
      // this.list.some((item, i) => {
      //     if (item.id == id) {
      //         this.list.splice(i, 1)
      //         // 在数组的 some 方法中，如果return true ，就会立即终止这个数组的后续循环
      //         return true
      //     }
      // })

      let index = this.list.findIndex(item => {
        if (item.id == id) {
          return true;
        }
      });

      this.list.splice(index, 1);
    },

    search(keywords) {
      var newList = [];
      // this.list.forEach(item => {
      //     if (item.name.indexOf(keywords) != -1) {
      //         newList.push(item)
      //     }
      // });
      // return newList;

      // forEach some fliter findIndex 这些都属于数组的新方法，
      // 都会对数组的每一项，进行遍历，执行相关的操作
      return this.list.filter(item => {
        //注意:在ES6中，为字符串提供了一个新方法，叫做 String.prototype.includes("要包含的字符串")
        // 如果包含，返回true，反之false
        if (item.name.includes(keywords)) {
          return item;
        }
      });
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1,
h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>