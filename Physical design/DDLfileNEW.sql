/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/15/2025 1:11:48 AM                         */
/*==============================================================*/

-- Disable all constraints temporarily
EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"
GO

-- Drop tables in reverse order of dependencies
IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'TEACHES')
   DROP TABLE TEACHES
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'LEARNINGOBJECT')
   DROP TABLE LEARNINGOBJECT
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'EXAMRESULT')
   DROP TABLE EXAMRESULT
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'EXAM')
   DROP TABLE EXAM
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'ENROLL_IN')
   DROP TABLE ENROLL_IN
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'COURSE')
   DROP TABLE COURSE
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'INSTRUCTOR')
   DROP TABLE INSTRUCTOR
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'STUDENT')
   DROP TABLE STUDENT
GO

-- Re-enable constraints
EXEC sp_MSforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"
GO

/*==============================================================*/
/* Table: STUDENT                                               */
/*==============================================================*/
CREATE TABLE STUDENT (
   SID                  INT                  NOT NULL IDENTITY(1,1),
   SNAME                VARCHAR(30)          NOT NULL,
   SEMAIL               VARCHAR(30)          NOT NULL,
   SPASSWORD            VARCHAR(64)          NOT NULL,
   CONSTRAINT PK_STUDENT PRIMARY KEY NONCLUSTERED (SID)
)
GO

/*==============================================================*/
/* Table: INSTRUCTOR                                            */
/*==============================================================*/
CREATE TABLE INSTRUCTOR (
   IID                  INT                  NOT NULL IDENTITY(1,1),
   INAME                VARCHAR(30)          NOT NULL,
   IEMAIL               VARCHAR(30)          NOT NULL,
   IPASSWORD            VARCHAR(64)          NOT NULL,
   CONSTRAINT PK_INSTRUCTOR PRIMARY KEY NONCLUSTERED (IID)
)
GO

/*==============================================================*/
/* Table: COURSE                                                */
/*==============================================================*/
CREATE TABLE COURSE (
   CID                  INT                  NOT NULL IDENTITY(1,1),
   CRSNAME              VARCHAR(30)          NOT NULL,
   CATEGORY             VARCHAR(30)          NOT NULL,
   ISHIDDEN             BIT                  NOT NULL,
   CONSTRAINT PK_COURSE PRIMARY KEY NONCLUSTERED (CID)
)
GO

/*==============================================================*/
/* Table: EXAM                                                  */
/*==============================================================*/
CREATE TABLE EXAM (
   EXAMID               INT                  NOT NULL IDENTITY(1,1),
   EXAMNAME             VARCHAR(30)          NOT NULL,
   CID                  INT                  NOT NULL,
   DATE                 VARCHAR(30)          NOT NULL,
   TYPE                 VARCHAR(20)          NOT NULL,
   CONSTRAINT PK_EXAM PRIMARY KEY (EXAMID)
)
GO

CREATE INDEX REQUIRE2_FK ON EXAM (CID ASC)
GO

/*==============================================================*/
/* Table: EXAMRESULT                                            */
/*==============================================================*/
CREATE TABLE EXAMRESULT (
   EXAMNAME             varchar(30)                  NOT NULL,
   SID                  INT                  NOT NULL,
   CID                  INT                  NOT NULL,
   GRADE                FLOAT                NULL,
   CONSTRAINT PK_EXAMRESULT PRIMARY KEY (SID,CID,EXAMNAME)
)
GO

CREATE INDEX EXAMRESULT_FK ON EXAMRESULT (CID ASC)
GO

CREATE INDEX EXAMRESULT_EXAM_FK ON EXAMRESULT (SID ASC)
GO
CREATE INDEX EXAMRESULT_EXAM2_FK ON EXAMRESULT (EXAMNAME ASC)
GO


/*==============================================================*/
/* Table: ENROLL_IN                                             */
/*==============================================================*/
CREATE TABLE ENROLL_IN (
   SID                  INT                  NOT NULL,
   CID                  INT                  NOT NULL,
   SEMESTER             VARCHAR(20)          NOT NULL,
   YEAR                 INT                  NOT NULL,
   GRADE                FLOAT                NULL,
   CONSTRAINT PK_ENROLL_IN PRIMARY KEY (SID, CID)
)
GO

CREATE INDEX ENROLL_IN_FK ON ENROLL_IN (SID ASC)
GO

CREATE INDEX ENROLL_IN2_FK ON ENROLL_IN (CID ASC)
GO

/*==============================================================*/
/* Table: LEARNINGOBJECT                                        */
/*==============================================================*/
CREATE TABLE LEARNINGOBJECT (
   OBJECTID             INT                  NOT NULL IDENTITY(1,1),
   CID                  INT                  NOT NULL,
   CONTENTURL           VARCHAR(50)          NOT NULL,
   TITLE                VARCHAR(30)          NOT NULL,
   TYPE                 VARCHAR(20)          NOT NULL,
   CONSTRAINT PK_LEARNINGOBJECT PRIMARY KEY (OBJECTID)
)
GO

CREATE INDEX INCLUDE_FK ON LEARNINGOBJECT (CID ASC)
GO

/*==============================================================*/
/* Table: TEACHES                                               */
/*==============================================================*/
CREATE TABLE TEACHES (
   CID                  INT                  NOT NULL,
   IID                  INT                  NOT NULL,
   SEMSTER              VARCHAR(20)          NOT NULL,
   YEAR                 INT                  NOT NULL,
   CONSTRAINT PK_TEACHES PRIMARY KEY (CID, IID)
)
GO

CREATE INDEX TEACHES_FK ON TEACHES (CID ASC)
GO

CREATE INDEX TEACHES2_FK ON TEACHES (IID ASC)
GO

-- Add foreign key constraints
ALTER TABLE EXAM
   ADD CONSTRAINT FK_EXAM_REQUIRE2_COURSE FOREIGN KEY (CID)
      REFERENCES COURSE (CID)
GO

ALTER TABLE EXAMRESULT
   ADD CONSTRAINT FK_EXAMRESULT_STUDENT FOREIGN KEY (SID)
      REFERENCES STUDENT (SID)
GO



ALTER TABLE ENROLL_IN
   ADD CONSTRAINT FK_ENROLL_I_ENROLL_IN_STUDENT FOREIGN KEY (SID)
      REFERENCES STUDENT (SID)
GO

ALTER TABLE ENROLL_IN
   ADD CONSTRAINT FK_ENROLL_I_ENROLL_IN_COURSE FOREIGN KEY (CID)
      REFERENCES COURSE (CID)
GO

ALTER TABLE LEARNINGOBJECT
   ADD CONSTRAINT FK_LEARNING_INCLUDE_COURSE FOREIGN KEY (CID)
      REFERENCES COURSE (CID)
GO

ALTER TABLE TEACHES
   ADD CONSTRAINT FK_TEACHES_TEACHES_COURSE FOREIGN KEY (CID)
      REFERENCES COURSE (CID)
GO

ALTER TABLE TEACHES
   ADD CONSTRAINT FK_TEACHES_TEACHES2_INSTRUCT FOREIGN KEY (IID)
      REFERENCES INSTRUCTOR (IID)
GO
