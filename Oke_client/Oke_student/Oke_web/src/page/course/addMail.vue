<template>
    <div class="w-100 h-100">
        <nav class="navbar navbar-expand-lg navbar-light border-bottom text-right justify-content-end bg-white shadow">
            <form class="form-inline my-2 my-lg-0">
                <button class="btn btn-outline-dark my-2 my-sm-0" @click="goback">返回</button>
            </form>
        </nav>
        <div class="h-100 abs-bottom">
            <div class="container w-75 padding-top" style="margin-top: 20px" >
                <form>
                    <div class="form-group row">
                        <label for="mailTitle" class="col-sm-2 col-form-label">主题</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="mailTitle" v-model="mailTitle">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="mailToUsername" class="col-sm-2 col-form-label">收件人</label>
                        <div class="col-sm-10">
                            <input type="text" readonly class="form-control-plaintext" id="mailToUsername" v-model="course.teacher.user.username">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="mailDescribe" class="col-sm-2 col-form-label">正文</label>
                        <div class="col-sm-10">
                            <textarea class="form-control" style="resize:none" id="mailDescribe" rows="5"  v-model="mailDescribe"></textarea>
                        </div>
                    </div>
                    <div class="form-group row">
                        <button type="button" class="btn btn-outline-primary" @click="sendMail">发送</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'OkeAddMail',
    data() {
        return {
            course: {},
            mailTitle: "",
            mailDescribe: ""
        }
    },
    created() {
        this.course = this.$route.params.course;
    },
    methods: {
        goback() {
            this.$router.push({name:"course", params: {course: this.course}});
        },
        sendMail() {
            let sessionData = {};
            sessionData.sessionId = this.$store.state.sessionId;
            let mail = {};
            mail.mailTitle = this.mailTitle;
            mail.mailDescribe = this.mailDescribe;
            mail.mailFromUser = this.$store.state.student.user;
            mail.mailToUser = this.course.teacher.user;
            sessionData.data = mail;
            this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.addMailUrl, JSON.stringify(sessionData), {emulateJSON: true}).then((response) => {
                if (response.data.success == true) {
                    alert(response.data.error);
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