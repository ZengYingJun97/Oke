<template>
    <div class="w-100 h-100">
        <nav class="navbar navbar-expand-lg navbar-light border-bottom text-right justify-content-end bg-white shadow">
            <form class="form-inline my-2 my-lg-0">
                <input class="form-control mr-sm-2" type="text" placeholder="课程码" aria-label="课程码" v-model="courseRandom" />
                <button class="btn btn-outline-dark my-2 my-sm-0" type="submit" @click="entryCourse">进入课堂</button>
            </form>
        </nav>
        <div class="h-100 abs-bottom">
            <div class="container padding-top" >
                <div class="row ">
                    <div class="col-sm-4 margin-bottom2" data-spy="scroll" data-offset="0" v-for="item in courseRecordList" :key="item.courseNumber">
                        <router-link :to="{name: 'course', params: {course: item}}" class="card-link text-dark">
                            <div class="card">
                                <div class="card-body">
                                    <h5 class="card-title">{{item.courseName}}</h5>
                                    <p class="card-text">{{item.teacher.teacherName}}  <span class="badge badge-primary">{{item.teacher.teacherTitle}}</span></p>
                                    <p class="card-text">{{new Date(item.courseCreateTime) | formatDate}}</p>
                                </div>
                            </div>
                        </router-link>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
var padDate = function (value) {
    return value < 10 ? '0' + value : value;
}
var padWeek = function (value) {
    var string = '日一二三四五六'
    return '星期' + string[value];
}
var isCourseRandom = function(value) {
    if (value.length != 6) {
        return false;
    }
    for (let i = 0; i < value.length; i++) {
        if (!((value[i] >= 'A' && value[i] <= 'Z') || (value[i] >= '0' && value[i] <= '9'))) {
            return false;
        }
    }
    return true;
}


export default {
    name: 'OkeCourseList',
	data() {
		return {
            courseRecordList: [],
            courseRandom: ""
		}
	},
	created() {
        if (this.$store.state.sessionId == null) {
            this.$router.push({name: 'OkeLogin'});
            return;
        }
        let sessionData = {};
        sessionData.sessionId = this.$store.state.sessionId;
        sessionData.data = this.$store.state.student;
        this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.courseListUrl, JSON.stringify(sessionData), {emulateJSON: true}).then((response) => {
            if (response.data.success == true) {
                for (let i = 0 ; i < response.data.data.data.length; i++) {
                    this.courseRecordList.push(response.data.data.data[i].course);
                }
            } else {
                alert(response.data.error);
                this.$router.push({name:"OkeLogin"});
            }
        });
    },
    filters: {
        formatDate: function (value) {
            var date = new Date(value);
            var year = date.getFullYear();
            var month = padDate(date.getMonth() + 1);
            var day = padDate(date.getDate());
            var hours = padDate(date.getHours());
            var minutes = padDate(date.getMinutes());
            var seconds = padDate(date.getSeconds());
            var weekday = date.getDay();
            //返回数据
            return year + '年' + month + '月' + day + '日(' + padWeek(weekday) + ') ' + hours + ':' + minutes + ':' + seconds;
        }
    },
    methods: {
        entryCourse() {
            if (isCourseRandom(this.courseRandom.toUpperCase())) {
                let data = {};
                data.sessionId = this.$store.state.sessionId;
                data.data = this.courseRandom.toUpperCase();
                this.$http.post(this.$store.state.url.serverUrl + this.$store.state.url.entryCourseUrl, JSON.stringify(data), {emulateJSON: true}).then((response) => {
                    if (response.data.success == true) {
                        this.courseRecordList.unshift(response.data.data.data);
                        this.$router.push({name:"course", params: {course: response.data.data.data}});
                    } else {
                        alert(response.data.error);
                    }
                });
            } else {
                alert('课程码格式错误!')
            }
        }
    }
}
</script>

<style>

</style>