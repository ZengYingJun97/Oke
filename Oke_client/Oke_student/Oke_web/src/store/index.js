import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex);

const store = new Vuex.Store({
  state: {
      sessionId: null,
      student: {
          studentId: 0,
          studentNumber: null,
          studentName: null,
          studentClass: null,
          user: {
              username: null,
              password: null
          }
      },
      url: {
          serverUrl: "http://localhost:8080/oke",
          loginUrl: "/student/login",
          registerUrl: "/student/register",
          courseListUrl: "/student/course/list",
          entryCourseUrl: "/course/entry"
      }
  },
  mutations: {
      login(state, data) {
          state.sessionId = data.sessionId;
          state.student.studentId = data.data.studentId;
          state.student.studentNumber = data.data.studentNumber;
          state.student.studentName = data.data.studentName;
          state.student.studentClass = data.data.studentClass;
          state.student.user.username = data.data.user.username;
      }
  }
});

export default store;