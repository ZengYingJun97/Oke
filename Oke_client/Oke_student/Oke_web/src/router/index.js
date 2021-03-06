import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import login from '@/page/login'      
import studentIndex from '@/page/index'
import courseList from '@/page/course/courseList'
import course from '@/page/course/course'
import personalInfo from '@/page/personalInfo/personalInfo'
import addMail from '@/page/course/addMail'
import mailList from '@/page/mailList'

Vue.use(Router)

export default new Router({
  base: '/okeweb/',
  routes: [
    {
      path: '/login',
      name: 'OkeLogin',
      meta: {
        requireAuth:true,
      },
      component: login
    },
    {
      path: '/student/',
      name: 'OkeIndex',
      meta: {
        requireAuth:true,
      },
      component: studentIndex,
      children: [
        {path: 'course/list', name: 'courseList', component: courseList,meta:{requireAuth: false}},
        {path: 'course', name: 'course', component: course,meta:{requireAuth: false}},
        {path: 'info', name: 'personalInfo', component: personalInfo,meta:{requireAuth: false}},
        {path: 'mail/add', name: 'addMail', component: addMail,meta:{requireAuth: false}},
        {path: 'mail/list', name: 'mailList', component: mailList,meta:{requireAuth: false}}
      ]
    },
    {
      path:'*',
      component:login
    }
  ]
})
