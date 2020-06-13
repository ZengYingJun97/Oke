<template>
    <div class="w-100 h-100">
        <nav class="navbar navbar-expand-lg navbar-light border-bottom text-right justify-content-end bg-white shadow">
        </nav>
        <div class="h-100 abs-bottom ">
            <div class="container padding-top" >
                <div class="row ">
                    <div class="col-sm-12 margin-bottom2" data-spy="scroll" data-offset="0" v-for="(mail, index) in mailList" :key="index">
                        <div class="card w-100">
                            <div class="card-body">
                                <h5 class="card-title">主题: {{mail.mailTitle}}</h5>
                                <p class="card-text">发件人: {{mail.mailFromUser.username}}</p>
                                <p class="card-text">正文:</p>  
                                <p class="card-text">{{mail.mailDescribe}}</p>  
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'OkeMailList',
    data() {
        return {
            mailList: []
        }
    },
    created() {
        let sessionData = {};
        sessionData.sessionId = this.$store.state.sessionId;
        sessionData.data = this.$store.state.student.user;
        this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.maillToListUrl, JSON.stringify(sessionData), {emulateJSON: true}).then((response) => {
            if (response.data.success == true) {
                this.mailList = response.data.data.data;
            } else {
                alert(response.data.error);
            }
        });
    }
}
</script>

<style>

</style>