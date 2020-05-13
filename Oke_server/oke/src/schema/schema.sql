##创建db_oke数据库
create database db_oke;

##使用db_oke
use db_oke;

##创建user表
create table user (
    username varchar(255) not null comment '账号',
    password varchar(255) not null comment '密码',
    primary key (username)
) engine = innodb charset = utf8 comment = '用户表';

##创建teacher表
create table teacher (
    teacher_id int(11) not null comment '教师id',
    teacher_name varchar(255) comment '姓名',
    teacher_title varchar(255) comment '职称',
    username varchar(255) not null comment '账号',
    primary key (teacher_id),
    foreign key (username) references user(username)

) engine = innodb charset = utf8 comment = '教师表';

##创建student表
create table student (
    student_id int(11) not null comment '学生id',
    student_number varchar(255) comment '学生学号',
    student_name varchar(255) comment '学生姓名',
    student_class varchar(255) comment '学生行政班',
    username varchar(255) not null comment '账号',
    primary key (student_id),
    foreign key (username) references user(username)
) engine = innodb charset = utf8 comment = '学生表';

##创建course表
create table course (
    course_number varchar(255) not null comment '课程号',
    course_name varchar(255) comment '课程名',
    course_create_time timestamp comment '课程创建时间',
    course_end_time timestamp comment '课程结束时间',
    teacher_id int(11) not null comment '教师id',
    primary key (course_number),
    foreign key (teacher_id) references teacher(teacher_id)
) engine = innodb charset = utf8 comment = '课程表';

##创建course表
create table course (
    course_number varchar(255) not null comment '课程号',
    course_name varchar(255) comment '课程名',
    course_create_time timestamp comment '课程创建时间',
    course_end_time timestamp comment '课程结束时间',
    teacher_id int(11) not null comment '教师id',
    primary key (course_number),
    foreign key (teacher_id) references teacher(teacher_id)
) engine = innodb charset = utf8 comment = '课程表';