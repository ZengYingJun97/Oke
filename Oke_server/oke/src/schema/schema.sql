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
    teacher_id int(11) auto_increment not null comment '教师id',
    teacher_name varchar(255) not null comment '姓名',
    teacher_title varchar(255) not null comment '职称',
    username varchar(255) not null comment '账号',
    primary key (teacher_id),
    foreign key (username) references user(username)

) engine = innodb charset = utf8 comment = '教师表';

##创建student表
create table student (
    student_id int(11) auto_increment not null comment '学生id',
    student_number varchar(255) not null comment '学生学号',
    student_name varchar(255) not null comment '学生姓名',
    student_class varchar(255) not null comment '学生行政班',
    username varchar(255) not null comment '账号',
    primary key (student_id),
    foreign key (username) references user(username)
) engine = innodb charset = utf8 comment = '学生表';

##创建course表
create table course (
    course_number varchar(255) not null comment '课程号',
    course_name varchar(255) not null comment '课程名',
    course_create_time timestamp not null comment '课程创建时间',
    course_end_time timestamp comment '课程结束时间',
    teacher_id int(11) not null comment '教师id',
    primary key (course_number),
    foreign key (teacher_id) references teacher(teacher_id)
) engine = innodb charset = utf8 comment = '课程表';

##创建course_record表
create table course_record (
    course_number varchar(255) not null comment '课程号',
    online_time timestamp not null comment '学生上线时间',
    offline_time timestamp comment '学生下线时间',
    student_id int(11) not null comment '学生id',
    primary key (course_number, student_id),
    foreign key (course_number) references course(course_number),
    foreign key (student_id) references student(student_id)
) engine = innodb charset = utf8 comment = '上课记录表';

##创建question表
create table question (
    question_id int(11) auto_increment not null comment '问题id',
    course_number varchar(255) not null comment '课程号',
    question_type int not null comment '题目类型(0:单选题 1:多选题 2:判断题 3:填空题 4:简答题)',
    question_describe varchar(255) not null comment '题目描述',
    question_answer varchar(255) not null comment '答案选项',
    question_score int not null comment '题目分值',
    question_limit_time int not null comment '题目限时',
    primary key (question_id),
    foreign key (course_number) references course(course_number)
) engine = innodb charset = utf8 comment = '问题表';

##创建option表
create table question_option (
    option_id int(11) auto_increment not null comment '选项id',
    question_id int(11) not null comment '题目id',
    option_type varchar(255) not null comment '选项符号',
    option_describe varchar(255) not null comment '选项描述',
    primary key (option_id),
    foreign key (question_id) references question(question_id)
) engine = innodb charset = utf8 comment = '题目选项表';

##创建student_answer表
create table student_answer (
    student_id int(11) not null comment '学生id',
    question_id int(11) not null comment '题目id',
    answer_content varchar(255) not null comment '学生答案',
    answer_correct int(1) not null comment '是否正确',
    answer_value float not null comment '获得分值占比',
    primary key (student_id, question_id),
    foreign key (student_id) references student(student_id),
    foreign key (question_id) references question(question_id)
) engine = innodb charset = utf8 comment = '学生答案表';

##创建scratcher表
create table scratcher (
    scratcher_id int(11) auto_increment not null comment '抽奖id',
    course_number varchar(255) not null comment '课程号',
    primary key (scratcher_id),
    foreign key (course_number) references course(course_number)
) engine = innodb charset = utf8 comment = '抽奖表';

##创建prize表
create table prize (
    prize_id int(11) auto_increment not null comment '奖品id',
    scratcher_id int(11) not null comment '抽奖id',
    prize_describe varchar(255) not null comment '奖品描述',
    prize_count int not null comment '奖品数量',
    primary key (prize_id),
    foreign key (scratcher_id) references scratcher(scratcher_id)
) engine = innodb charset = utf8 comment = '奖品表';