<template>
    <div class="w-100 h-100">
        <nav class="navbar navbar-expand-lg navbar-light border-bottom text-right justify-content-end bg-white shadow">
            <form class="form-inline my-2 my-lg-0">
                <button class="btn btn-outline-dark my-2 my-sm-0" type="submit" @click="updateInfo">保存修改</button>
            </form>
        </nav>
        <div class="h-100 abs-bottom">
            <div class="container w-75 padding-top" style="margin-top: 20px" >
                <form>
                    <div class="form-group row">
                        <label for="username" class="col-sm-2 col-form-label">用户名</label>
                        <div class="col-sm-10">
                            <input type="text" readonly class="form-control-plaintext" id="username" v-model="student.user.username">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="studentNumber" class="col-sm-2 col-form-label">学号</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="studentNumber" placeholder="学号" v-model="student.studentNumber">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="studentName" class="col-sm-2 col-form-label">姓名</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="studentName" placeholder="姓名" v-model="student.studentName">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="studentClass" class="col-sm-2 col-form-label">班级</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="studentClass" placeholder="班级" v-model="student.studentClass">
                        </div>
                    </div>
                </form>
                <hr>
                <form>
                    <div class="form-group row">
                        <label for="oldPassword" class="col-sm-2 col-form-label">旧密码</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="oldPassword" placeholder="旧密码" v-model="oldPassword">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="newPassword" class="col-sm-2 col-form-label">新密码</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="newPassword" placeholder="新密码" v-model="newPassword">
                        </div>
                    </div>
                    <div class="form-group row">
                        <button type="button" class="btn btn-outline-primary" @click="updatePassword">修改密码</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'OkeStudentInfo',
	data() {
		return {
            student: {},
            oldPassword: "",
            newPassword: ""
		}
    },
    created() {
        if (this.$store.state.sessionId == null) {
            this.$router.push({name: 'OkeLogin'});
            return;
        }
        this.student = this.$store.state.student;
    },
    methods: {
        updateInfo() {
            let sessionData = {};
            sessionData.sessionId = this.$store.state.sessionId;
            sessionData.data = this.student;
            this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.updateInfoUrl, JSON.stringify(sessionData), {emulateJSON: true}).then((response) => {
                if (response.data.success == true) {
                    this.$store.state.student.studentNumber = response.data.data.data.studentNumber;
                    this.$store.state.student.studentName = response.data.data.data.studentName;
                    this.$store.state.student.studentClass = response.data.data.data.studentClass;
                    alert("修改成功");
                    this.$router.push({name: 'courseList'});
                } else {
                    alert(response.data.error);
                }
            });
        },
        updatePassword() {
            let sessionData = {};
            sessionData.sessionId = this.$store.state.sessionId;
            let updateUserData = {};
            let user = {};
            user.username = this.student.user.username;
            user.password = this.oldPassword;
            updateUserData.user = user;
            updateUserData.newPassword = this.newPassword;
            sessionData.data = updateUserData;
            this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.updatePasswordUrl, JSON.stringify(sessionData), {emulateJSON: true}).then((response) => {
                if (response.data.success == true) {
                    alert("修改成功");
                } else {
                    alert(response.data.error);
                }
            });
        }
    }
}
</script>

<style>

</style>