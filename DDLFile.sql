/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/15/2025 12:11:31 AM                        */
/*==============================================================*/


if exists (select 1
            from  sysindexes
           where  id    = object_id('COURSE')
            and   name  = 'REQUIRE_FK'
            and   indid > 0
            and   indid < 255)
   drop index COURSE.REQUIRE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COURSE')
            and   type = 'U')
   drop table COURSE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ENROLL_IN')
            and   name  = 'ENROLL_IN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ENROLL_IN.ENROLL_IN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ENROLL_IN')
            and   name  = 'ENROLL_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ENROLL_IN.ENROLL_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ENROLL_IN')
            and   type = 'U')
   drop table ENROLL_IN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXAM')
            and   name  = 'REQUIRE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXAM.REQUIRE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXAM')
            and   name  = 'EXAMRESULT_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXAM.EXAMRESULT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EXAM')
            and   type = 'U')
   drop table EXAM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INSTRUCTOR')
            and   type = 'U')
   drop table INSTRUCTOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LEARNINGOBJECT')
            and   name  = 'INCLUDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index LEARNINGOBJECT.INCLUDE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LEARNINGOBJECT')
            and   type = 'U')
   drop table LEARNINGOBJECT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDENT')
            and   type = 'U')
   drop table STUDENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TEACHES')
            and   name  = 'TEACHES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TEACHES.TEACHES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TEACHES')
            and   name  = 'TEACHES_FK'
            and   indid > 0
            and   indid < 255)
   drop index TEACHES.TEACHES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TEACHES')
            and   type = 'U')
   drop table TEACHES
go

/*==============================================================*/
/* Table: COURSE                                                */
/*==============================================================*/
create table COURSE (
   CID                  int                  not null,
   EXAMNAME             varchar(30)          null,
   CRSNAME              varchar(30)          not null,
   CATEGORY             varchar(30)          not null,
   ISHIDDEN             bit                  not null,
   constraint PK_COURSE primary key nonclustered (CID)
)
go

/*==============================================================*/
/* Index: REQUIRE_FK                                            */
/*==============================================================*/
create index REQUIRE_FK on COURSE (
EXAMNAME ASC
)
go

/*==============================================================*/
/* Table: ENROLL_IN                                             */
/*==============================================================*/
create table ENROLL_IN (
   SID                  int                  not null,
   CID                  int                  not null,
   SEMESTER             varchar(20)          not null,
   YEAR                 int                  not null,
   GRADE                float                null,
   constraint PK_ENROLL_IN primary key (SID, CID)
)
go

/*==============================================================*/
/* Index: ENROLL_IN_FK                                          */
/*==============================================================*/
create index ENROLL_IN_FK on ENROLL_IN (
SID ASC
)
go

/*==============================================================*/
/* Index: ENROLL_IN2_FK                                         */
/*==============================================================*/
create index ENROLL_IN2_FK on ENROLL_IN (
CID ASC
)
go

/*==============================================================*/
/* Table: EXAM                                                  */
/*==============================================================*/
create table EXAM (
   EXAMNAME             varchar(30)          not null,
   SID                  int                  null,
   CID                  int                  not null,
   DATE                 varchar(30)          not null,
   TYPE                 varchar(20)          not null,
   GRADE                float                null,
   constraint PK_EXAM primary key nonclustered (EXAMNAME)
)
go

/*==============================================================*/
/* Index: EXAMRESULT_FK                                         */
/*==============================================================*/
create index EXAMRESULT_FK on EXAM (
SID ASC
)
go

/*==============================================================*/
/* Index: REQUIRE2_FK                                           */
/*==============================================================*/
create index REQUIRE2_FK on EXAM (
CID ASC
)
go

/*==============================================================*/
/* Table: INSTRUCTOR                                            */
/*==============================================================*/
create table INSTRUCTOR (
   IID                  int                  not null,
   INAME                varchar(30)          not null,
   IEMAIL               varchar(30)          not null,
   IPASSWORD            varchar(64)          not null,
   constraint PK_INSTRUCTOR primary key nonclustered (IID)
)
go

/*==============================================================*/
/* Table: LEARNINGOBJECT                                        */
/*==============================================================*/
create table LEARNINGOBJECT (
   CONTENTURL           varchar(50)          not null,
   CID                  int                  not null,
   TITLE                varchar(30)          not null,
   TYPE                 varchar(20)          not null,
   constraint PK_LEARNINGOBJECT primary key nonclustered (CONTENTURL)
)
go

/*==============================================================*/
/* Index: INCLUDE_FK                                            */
/*==============================================================*/
create index INCLUDE_FK on LEARNINGOBJECT (
CID ASC
)
go

/*==============================================================*/
/* Table: STUDENT                                               */
/*==============================================================*/
create table STUDENT (
   SID                  int                  not null,
   SNAME                varchar(30)          not null,
   SEMAIL               varchar(30)          not null,
   SPASSWORD            varchar(64)          not null,
   constraint PK_STUDENT primary key nonclustered (SID)
)
go

/*==============================================================*/
/* Table: TEACHES                                               */
/*==============================================================*/
create table TEACHES (
   CID                  int                  not null,
   IID                  int                  not null,
   SEMSTER              varchar(20)          not null,
   YEAR                 int                  not null,
   constraint PK_TEACHES primary key (CID, IID)
)
go

/*==============================================================*/
/* Index: TEACHES_FK                                            */
/*==============================================================*/
create index TEACHES_FK on TEACHES (
CID ASC
)
go

/*==============================================================*/
/* Index: TEACHES2_FK                                           */
/*==============================================================*/
create index TEACHES2_FK on TEACHES (
IID ASC
)
go

