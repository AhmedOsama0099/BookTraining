/*==============================================================*/
/* DBMS name:      Sybase SQL Anywhere 12                       */
/* Created on:     5/5/2019 1:21:19 AM                          */
/*==============================================================*/

create database _Train_Booking_
use _Train_Booking_
/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN 
(
   USERNAME             varchar(50)                    not null,
   ADMIN_PW             varchar(50)                    not null,
   AGE                  numeric(3)                     not null,
   GENDER               varchar(1)                     not null,
   PHONE                varchar(20)                    not null,
   STREET_NUM           numeric(5)                     not null,
   CITY                 varchar(50)                    not null,
   constraint PK_ADMIN primary key (USERNAME)
);

/*==============================================================*/
/* Index: ADMIN_PK                                              */
/*==============================================================*/
create unique index ADMIN_PK on ADMIN (
USERNAME ASC
);

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK 
(
   TRIP_NUM             numeric(8)                     not null,
   C_USERNAME           varchar(50)                    not null,
   TICKET_ID_			numeric(8)                     not null,
   constraint PK_BOOK primary key (TRIP_NUM, C_USERNAME)
);

/*==============================================================*/
/* Index: BOOK_PK                                               */
/*==============================================================*/
create unique index BOOK_PK on BOOK (
TRIP_NUM ASC,
C_USERNAME ASC
);

/*==============================================================*/
/* Index: BOOK2_FK                                              */
/*==============================================================*/
create index BOOK2_FK on BOOK (
C_USERNAME ASC
);

/*==============================================================*/
/* Index: BOOK_FK                                               */
/*==============================================================*/
create index BOOK_FK on BOOK (
TRIP_NUM ASC
);

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER 
(
   C_USERNAME           varchar(50)                    not null,
   C_PW                 varchar(50)                    not null,
   AGE                  numeric(3)                     not null,
   PHONE                varchar(20)                    not null,
   GENDER               varchar(1)                     not null,
   constraint PK_CUSTOMER primary key (C_USERNAME)
);

/*==============================================================*/
/* Index: CUSTOMER_PK                                           */
/*==============================================================*/
create unique index CUSTOMER_PK on CUSTOMER (
C_USERNAME ASC
);

/*==============================================================*/
/* Table: HISTORY                                               */
/*==============================================================*/
create table HISTORY 
(
   C_USERNAME           varchar(50)                    not null,
   REGDATE              datetime                      not null,
   BOOKFORTRIP          integer                       not null,
   TOTALPRICESPEND      float                        not  null
   
);

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on HISTORY (
C_USERNAME ASC
);

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET 
(
   PRICE                numeric(8)                     not null,
   TICKET_ID            numeric(8)                     not null,
   T_ID                 numeric(8)                     not null,
   TRIP_NUM             numeric(8)                     not null,
   constraint PK_TICKET primary key (TICKET_ID)
);

/*==============================================================*/
/* Index: TICKET_PK                                             */
/*==============================================================*/
create unique index TICKET_PK on TICKET (
TICKET_ID ASC
);

/*==============================================================*/
/* Index: HAVE_FK                                               */
/*==============================================================*/
create index HAVE_FK on TICKET (
T_ID ASC
);

/*==============================================================*/
/* Index: BOOK_TO_FK                                            */
/*==============================================================*/
create index BOOK_TO_FK on TICKET (
TRIP_NUM ASC
);

/*==============================================================*/
/* Table: TRAIN                                                 */
/*==============================================================*/
create table TRAIN 
(
   T_ID                 numeric(8)                     not null,
   USERNAME             varchar(50)                    not null,
   NUMOFSEATS           integer                        not null,
   MODEL                varchar(50)                    not null,
   AVILABLESEATS        integer                        not null,
   "TO"                 varchar(50)                    not null,
   "FROM"               varchar(50)                    not null,
   [DATE&TIME]            datetime                      not null,
   constraint PK_TRAIN primary key (T_ID)
);

/*==============================================================*/
/* Index: TRAIN_PK                                              */
/*==============================================================*/
create unique index TRAIN_PK on TRAIN (
T_ID ASC
);

/*==============================================================*/
/* Index: CONTROL_FK                                            */
/*==============================================================*/
create index CONTROL_FK on TRAIN (
USERNAME ASC
);

/*==============================================================*/
/* Table: TRIP                                                  */
/*==============================================================*/
create table TRIP 
(
   TRIP_NUM             numeric(8)                     not null,
   "FROM"               varchar(50)                    not null,
   "TO"                 varchar(50)                    not null,
   [DATE&TIME]          datetime                      not null,
   constraint PK_TRIP primary key (TRIP_NUM)
);

/*==============================================================*/
/* Index: TRIP_PK                                               */
/*==============================================================*/
create unique index TRIP_PK on TRIP (
TRIP_NUM ASC
);

alter table BOOK
   add constraint FK_BOOK_BOOK_TRIP foreign key (TRIP_NUM)
      references TRIP (TRIP_NUM)
      on update CASCADE
      on delete CASCADE;

alter table BOOK
   add constraint FK_BOOK_BOOK2_CUSTOMER foreign key (C_USERNAME)
      references CUSTOMER (C_USERNAME)
      on update CASCADE
      on delete CASCADE;

alter table HISTORY
   add constraint FK_HISTORY_HAS_CUSTOMER foreign key (C_USERNAME)
      references CUSTOMER (C_USERNAME)
      on update CASCADE
      on delete CASCADE;

alter table TICKET
   add constraint FK_TICKET_BOOK_TO_TRIP foreign key (TRIP_NUM)
      references TRIP (TRIP_NUM)
      on update CASCADE
      on delete CASCADE;

alter table TICKET
   add constraint FK_TICKET_HAVE_TRAIN foreign key (T_ID)
      references TRAIN (T_ID)
      on update CASCADE
      on delete CASCADE;

alter table TRAIN
   add constraint FK_TRAIN_CONTROL_ADMIN foreign key (USERNAME)
      references ADMIN (USERNAME)
      on update CASCADE
      on delete CASCADE;

