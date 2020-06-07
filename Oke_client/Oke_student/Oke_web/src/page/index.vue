<template>
    <div class="h-100 w-100">
        <div class="left-menu float-left">
            <ul class="margin-0" style="padding: 0;">
                <li class="text-center margin-bottom">
                    <img src="../../static/Oke_loginBg.png" class="logo-size2" />
                </li>
                <router-link :to="{name: 'personalInfo'}" class=" w-100 a-block">
                    <li class="text-center white margin-bottom">
                        个人中心
                    </li>
                </router-link>
                <router-link :to="{name: 'courseList'}" class=" w-100 a-block">
                    <li class="text-center white margin-bottom">
                        课程列表
                    </li>
                </router-link>
            </ul>
        </div>
        <div class="right-menu" style="overflow-y: hidden;">
            <router-view/>
        </div>
    </div>
</template>

<script>
export default {
}
</script>

<style>
    @import "../style/common.css";
</style>