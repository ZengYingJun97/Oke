<template>
    <div class="w-100 h-100">
        <nav class="navbar navbar-expand-lg navbar-light border-bottom text-right justify-content-end bg-white shadow">
            <button class="btn btn-outline-dark my-2 my-sm-0" type="submit" @click="goback">返回</button>
            <form class="form-inline my-2 my-lg-0">
                <h5 class="card-title">{{course.courseName}}</h5>
            </form>
        </nav>
        <div class="h-100 abs-bottom ">
            <div class="container padding-top" >
                <div class="row ">
                    <div class="col-sm-12 margin-bottom2" data-spy="scroll" data-offset="0" v-for="(questionData, index) in questionList" :key="index">
                        <div class="card w-100" v-if="!('question' in questionData)">
                            <div class="card-body">
                                <h5 class="card-title">投票</h5>
                                <p class="card-text">{{questionData.vote.voteDescribe}}</p>   
                                <div class=" w-100" data-toggle="buttons">
                                    <label class="text-left btn btn-outline-primary active w-100" v-for="voteChoice in questionData.voteChoiceList" :key="voteChoice.voteChoiceId">
                                        <input type="radio" name="options" :id="voteChoice.voteChoiceType" autocomplete="off"> {{voteChoice.voteChoiceType}} {{voteChoice.voteChoiceDescribe}}
                                    </label>
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" v-if="questionData.vote.voteLimitTime > 0" @click="answerQuestion($event, questionData)">提交答案 <span class="badge badge-success">{{questionData.vote.voteLimitTime}}</span></button>
                                </div>
                            </div>
                        </div>
                        <div class="card w-100" v-if="'question' in questionData && questionData.question.questionType == 0">
                            <div class="card-body">
                                <h5 class="card-title">单选题 {{questionData.question.questionScore}}分</h5>
                                <p class="card-text">{{questionData.question.questionDescribe}}</p>   
                                <div class=" w-100" data-toggle="buttons">
                                    <label class="text-left btn btn-outline-primary w-100" v-for="option in questionData.optionList" :key="option.optionId">
                                        <input type="radio" name="options" :id="option.optionType" autocomplete="off"> {{option.optionType}} {{option.optionDescribe}}
                                    </label>
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" v-if="questionData.question.questionLimitTime > 0" @click="answerQuestion($event, questionData)">提交答案 <span class="badge badge-success">{{questionData.question.questionLimitTime}}</span></button>
                                </div>
                            </div>
                        </div>
                        <div class="card w-100" v-if="'question' in questionData && questionData.question.questionType == 1">
                            <div class="card-body">
                                <h5 class="card-title">多选题 {{questionData.question.questionScore}}分</h5>
                                <p class="card-text">{{questionData.question.questionDescribe}}</p>   
                                <div class=" w-100" data-toggle="buttons">
                                    <label class="text-left btn btn-outline-primary w-100" v-for="option in questionData.optionList" :key="option.optionId">
                                        <input type="checkbox" name="options" :id="option.optionType" autocomplete="off"> {{option.optionType}} {{option.optionDescribe}}
                                    </label>
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" v-if="questionData.question.questionLimitTime > 0" @click="answerQuestion($event, questionData)">提交答案 <span class="badge badge-success">{{questionData.question.questionLimitTime}}</span></button>
                                </div>
                            </div>
                        </div>
                        <div class="card w-100" v-if="'question' in questionData && questionData.question.questionType == 2">
                            <div class="card-body">
                                <h5 class="card-title">判断题 {{questionData.question.questionScore}}分</h5>
                                <p class="card-text">{{questionData.question.questionDescribe}}</p>   
                                <div class=" w-100" data-toggle="buttons">
                                    <label class="text-left btn btn-outline-primary active w-100">
                                        <input type="radio" name="options" id="True" autocomplete="off"> True
                                    </label>
                                    <label class="text-left btn btn-outline-primary w-100">
                                        <input type="radio" name="options" id="False" autocomplete="off"> False
                                    </label>
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" v-if="questionData.question.questionLimitTime > 0" @click="answerQuestion($event, questionData)">提交答案 <span class="badge badge-success">{{questionData.question.questionLimitTime}}</span></button>
                                </div>
                            </div>
                        </div>
                        <div class="card w-100" v-if="'question' in questionData && questionData.question.questionType == 3">
                            <div class="card-body">
                                <h5 class="card-title">填空题 {{questionData.question.questionScore}}分</h5>
                                <p class="card-text">{{questionData.question.questionDescribe}}</p>   
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">填空答案</span>
                                    </div>
                                    <input type="text" class="form-control" placeholder="例如: 答案1;答案2;" aria-describedby="basic-addon1">
                                </div>
                                <div class="w-100 text-right">
                                    <button type="button" class="btn btn-light" v-if="questionData.question.questionLimitTime > 0" @click="answerQuestion($event, questionData)">提交答案 <span class="badge badge-success">{{questionData.question.questionLimitTime}}</span></button>
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
            websock: {},
            questionList: [],
            timer: null
		}
    },
    created() {
        this.course = this.$route.params.course;
        if (this.course.courseEndTime != null) {
            alert('课程已结束!');
            this.$router.push({name:"courseList"});
            return;
        }
        this.initWebSocket()
    },
    destroyed() {
        this.websock.close() //离开路由之后断开websocket连接
    },
    methods: {
        initWebSocket(){ //初始化weosocket
            const wsuri = "ws://120.25.193.138:8080/imserver/" + this.$store.state.student.studentId;
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
            const redata = $.parseJSON(e.data);
            this.questionList.unshift(redata);
            this.timer = setInterval(() => {
                redata.question.questionLimitTime--;
                if (redata.question.questionLimitTime <= 0) {
                    clearInterval(this.timer);
                }
            }, 1000);
        },
        websocketclose(e){  //关闭
            this.$router.push({name:"courseList"});
        },
        answerQuestion(event, questionData) {
            if ("question" in questionData) {
                let questionType = questionData.question.questionType;
                let studentAnswer = {};
                studentAnswer.question = questionData.question;
                studentAnswer.student = this.$store.state.student;
                if (questionType < 3) {
                    let el = event.currentTarget.parentElement.parentElement;
                    let ell = $(el).find('input[name="options"]:checked');
                    let answer = "";
                    ell.each(function(){
                        answer += $(this).attr('id') + ";";
                    });
                    studentAnswer.answerContent = answer;
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
                    studentAnswer.answerContent = str;
                }
                let sessionData = {};
                sessionData.sessionId = this.$store.state.sessionId;
                sessionData.data = studentAnswer;
                this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.answerQuestionUrl, JSON.stringify(sessionData), {emulateJSON: true}).then((response) => {
                    if (response.data.success == true) {
                        questionData.question.questionLimitTime = 0;
                        alert(response.data.error);
                    } else {
                        alert(response.data.error);
                    }
                });
            } else {

            }
        },
        goback() {
            this.$router.push({name:"courseList"});
        }
    }
}
</script>

<style>

</style>