<template>
  <div class="container common-bg">
    <div class="row justify-content-center">
      <div class="col-4">
        <div class="card w-100 shadow">
          <div class="card-header login-logo-bg d-flex justify-content-between align-items-end p-0">
			<a class="boardtop-left w-25  h-25" href="/">
				<div>首 页</div>
			</a>
            <img src="../../static/Oke_loginBg.png" class="logo-size" />
			<a href="#" class="boardtop-right w-25 h-25"  data-toggle="modal" data-target="#registerModal">
				<div>注 册</div>
			</a>
			<div class="modal fade" id="registerModal" tabindex="-1" role="dialog" aria-hidden="true">
				<div class="modal-dialog" role="document">
					<div class="modal-content">
					<div class="modal-header">
						<h5 class="modal-title" id="exampleModalLabel">学生注册</h5>
						<button type="button" class="close" data-dismiss="modal" aria-label="Close">
						<span aria-hidden="true">&times;</span>
						</button>
					</div>
					<div class="modal-body">
					<form>
						<div class="form-group">
							<label for="username">用户名</label>
							<input type="text" class="form-control" id="username" v-model="registerData.user.username" />
						</div>
						<div class="form-group">
							<label for="password">密码</label>
							<input type="password" class="form-control" id="password" v-model="registerData.user.password" />
						</div>
						<div class="form-group">
							<label for="passwordConfirm">确认密码</label>
							<input type="password" class="form-control" id="passwordConfirm" v-model="passwordConfirm" />
						</div>
						<div class="form-group">
							<label for="studentNumber">学号</label>
							<input type="text" class="form-control" id="studentNumber" v-model="registerData.studentNumber" />
						</div>
						<div class="form-group">
							<label for="studentName">姓名</label>
							<input type="text" class="form-control" id="studentName" v-model="registerData.studentName" />
						</div>
						<div class="form-group">
							<label for="studentClass">班级</label>
							<input type="text" class="form-control" id="studentClass" v-model="registerData.studentClass" />
						</div>
					</form>
					</div>
					<div class="modal-footer" id="alter-register">
						<span class="badge badge-success">{{registerSuccess}}</span>
						<span class="badge badge-danger">{{tip}}</span>
						<button type="button" class="btn btn-secondary" @click="initTip" data-dismiss="modal">关闭</button>
						<button type="button" class="btn btn-primary" @click="register" v-if="isClick == true">注册</button>
					</div>
					</div>
				</div>
			</div>
          </div>
          <div class="card-body">
            <form>
              <div class="form-group">
                <label for="okeUsername">用户名</label>
                <input type="text" class="form-control" id="okeUsername" v-model="username" />
              </div>
              <div class="form-group">
                <label for="okePassword">密码</label>
                <input type="password" class="form-control" id="okePassword" v-model="password" />
              </div>
              <div class="form-group form-check">
                <input type="checkbox" class="form-check-input" id="remenberCheck" v-model="remenberCheck">
                <label class="form-check-label" for="remenberCheck">记住用户名和密码</label>
              </div>
              <div class="form-group">
                <button type="submit" class="btn btn-primary w-100" @click="login" v-if="isClick == true">登陆</button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import '../util/util.js'
import { getCookie, setCookie } from '../util/util.js'
export default {
	name: 'OkeLogin',
	data() {
		return {
			username: "",
			password: "",
			isClick: true,
			registerSuccess: "",
			tip: "",
			passwordConfirm: "",
			remenberCheck: false,
			registerData: {
				studentNumber: "",
				studentName: "",
				studentClass: "",
				user: {
					username: "",
					password: ""
				}
			}
		}
	},
	created() {
		if (getCookie("remenberCheck") == null) {
			setCookie("remenberCheck", false, 7);
		}
		
		this.remenberCheck = false;
		if (getCookie("remenberCheck") == "true") {
			this.remenberCheck = true;
			this.username = getCookie("username");
			this.password = getCookie("password");
		}
	},
	methods: {
		login() {
			this.isClick = false;
			setCookie("remenberCheck", this.remenberCheck, 7);
			if (this.remenberCheck) {
				setCookie("username", this.username, 7);
				setCookie("password", this.password, 7);
			}
			let data = {};
			data['username'] = this.username;
			data['password'] = this.password;
			this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.loginUrl, JSON.stringify(data), {emulateJSON: true}).then((response) => {
				if (response.data.success == true) {
					this.$store.commit('login', response.data.data);
					this.$router.push({name: 'courseList'})
				} else {
					alert(response.data.error);
				}
      		});
			this.isClick = true;
		},
		register() {
			this.isClick = false;
			if (this.registerData.user.username.length >= 8 && this.registerData.user.username.length <= 20
			&& this.registerData.user.password.length >= 8 && this.registerData.user.password.length <= 20) {
				if (this.registerData.user.password == this.passwordConfirm) {
					if (this.registerData.studentNumber == "" || this.registerData.studentName == "" || this.registerData.studentClass == "") {
						this.tip = "主要信息不能为空";
					} else {
						this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.registerUrl, JSON.stringify(this.registerData), {emulateJSON: true}).then((response) => {
							if (response.data.success == true) {
								this.registerSuccess = response.data.error;
								this.tip = "";
								setTimeout(function() {
									this.tip = "";
									this.registerSuccess = "";
									$('#registerModal').modal('hide');
								}, 1000);
							} else {
								this.tip = response.data.error;
							}
						});
					}
				} else {
					this.tip = "两次密码不一致";
				}
			} else {
				this.tip = "用户名密码长度应在8-20";
			}
			this.isClick = true;
		},
		initTip() {
			this.tip = "";
			this.registerSuccess = "";
			this.registerData.studentNumber = "";
			this.registerData.studentName = "";
			this.registerData.studentClass = "";
			this.registerData.user.username = "";
			this.registerData.user.password = "";
		}
	}
}
</script>

<style>
  @import "../style/common.css";
</style>
