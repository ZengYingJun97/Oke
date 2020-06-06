<template>
    <div class="w-100 h-100">
        <nav class="navbar navbar-expand-lg navbar-light border-bottom text-right justify-content-end bg-white shadow">
            <form class="form-inline my-2 my-lg-0">
                <h5 class="card-title">{{course.courseName}}</h5>
            </form>
        </nav>
        <div class="h-100 abs-bottom ">
            <div class="container padding-top" >
                <div class="row ">
                    <div class="col-sm-12 margin-bottom2" data-spy="scroll" data-offset="0">
                        <div class="card w-100">
                            <div class="card-body">
                                <h5 class="card-title">单选题</h5>
                                <p class="card-text">根据我国现行《宪法》的规定，下列有关公民基本权利宪法保护的表述，正确的是()</p>   
                                <div class=" w-100" data-toggle="buttons">
                                    <label class="text-left btn btn-outline-primary active w-100">
                                        <input type="radio" name="options" id="A" autocomplete="off" checked> A 所有公民都有选举权和被选举权
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="radio" name="options" id="B" autocomplete="off"> B 宪法没有规定对归侨权益的保护
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="radio" name="options" id="C" autocomplete="off"> C 宪法对建立劳动者休息和休养的设施未加以规定
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="radio" name="options" id="D" autocomplete="off"> D 宪法规定公民的住宅不受侵犯
                                    </label>
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" @click="answerQuestion($event, 0)">提交答案 <span class="badge badge-success">4</span></button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-12 margin-bottom2" data-spy="scroll" data-offset="0">
                        <div class="card w-100">
                            <div class="card-body">
                                <h5 class="card-title">多选题</h5>
                                <p class="card-text">根据我国现行《宪法》的规定，下列有关公民基本权利宪法保护的表述，正确的是()</p>   
                                <div class=" w-100" data-toggle="buttons">
                                    <label class="text-left btn btn-outline-primary active w-100">
                                        <input type="checkbox" name="options" id="A" autocomplete="off" checked> A 所有公民都有选举权和被选举权
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="checkbox" name="options" id="B" autocomplete="off"> B 宪法没有规定对归侨权益的保护
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="checkbox" name="options" id="C" autocomplete="off"> C 宪法对建立劳动者休息和休养的设施未加以规定
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="checkbox" name="options" id="D" autocomplete="off"> D 宪法规定公民的住宅不受侵犯
                                    </label>
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" @click="answerQuestion($event, 1)">提交答案 <span class="badge badge-success">4</span></button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-12 margin-bottom2" data-spy="scroll" data-offset="0">
                        <div class="card w-100">
                            <div class="card-body">
                                <h5 class="card-title">判断题</h5>
                                <p class="card-text">根据我国现行《宪法》的规定，下列有关公民基本权利宪法保护的表述，正确的是()</p>   
                                <div class=" w-100" data-toggle="buttons">
                                    <label class="text-left btn btn-outline-primary active w-100">
                                        <input type="radio" name="options" id="True" autocomplete="off" checked> True
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="radio" name="options" id="False" autocomplete="off"> False
                                    </label>
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" @click="answerQuestion($event, 2)">提交答案 <span class="badge badge-success">4</span></button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-12 margin-bottom2" data-spy="scroll" data-offset="0">
                        <div class="card w-100">
                            <div class="card-body">
                                <h5 class="card-title">填空题</h5>
                                <p class="card-text">阿虎地方啥服你[       ]</p>   
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">填空答案</span>
                                    </div>
                                    <input type="text" class="form-control" placeholder="例如: 答案1;答案2;" aria-describedby="basic-addon1">
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" @click="answerQuestion($event, 3)">提交答案 <span class="badge badge-success">4</span></button>
                                </div>
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
    name: 'OkeCourse',
	data() {
		return {
            course: {},
            websock: null,
            questionList: []
		}
    },
    created() {
        this.course = this.$route.params.course;
        if (this.course.courseEndTime != null) {
            alert('课程已结束!');
            this.$router.push({name:"courseList"});
            return;
        }
        //this.initWebSocket()
    },
    destroyed() {
        this.websock.close() //离开路由之后断开websocket连接
    },
    methods: {
        initWebSocket(){ //初始化weosocket
            const wsuri = "ws://127.0.0.1:8080/imserver/" + this.$store.state.student.studentId;
            this.websock = new WebSocket(wsuri);
            this.websock.onmessage = this.websocketonmessage;
            this.websock.onopen = this.websocketonopen;
            this.websock.onerror = this.websocketonerror;
            this.websock.onclose = this.websocketclose;
        },
        websocketonopen(){ //连接建立之后执行send方法发送数据
        },
        websocketonerror(){//连接建立失败重连
            this.initWebSocket();
        },
        websocketonmessage(e){ //数据接收
            const redata = JSON.parse(e.data);
            this.questionList.unshift(redata);
        },
        websocketclose(e){  //关闭
            this.$router.push({name:"courseList"});
        },
        answerQuestion(event, questionId) {
            if (questionId < 3) {
                let el = event.currentTarget.parentElement.parentElement;
                let ell = $(el).find('input[name="options"]:checked');
                ell.each(function(){
                    alert($(this).attr('id'));
                });
            } else {
                let el = event.currentTarget.parentElement.parentElement;
                let ell = $(el).find('input[type="text"]').val().trim();
                let str = "";
                for (let i = 0; i < ell.length; i++) {
                    if (ell[i] == '；') {
                        str += ";";
                    } else {
                        str += ell[i];
                    }
                }
                if (str[str.length - 1] != ';') {
                    str += ";";
                }
                alert(str);
            }
        }
    }
}
</script>

<style>

</style>