/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     27/12/2012 23:06:33                          */
/*==============================================================*/


alter table DIPINJAM
   drop constraint FK_DIPINJAM_NOTADANDI_NOTA;

alter table DIPINJAM
   drop constraint FK_DIPINJAM_STOKDIPIN_STOKKOLE;

alter table KOLEKSI
   drop constraint FK_KOLEKSI_GENREKOLE_GENRE;

alter table NOTA
   drop constraint FK_NOTA_ADMINDANN_PENGGUNA;

alter table NOTA
   drop constraint FK_NOTA_MEMBERDAN_MEMBER;

alter table NOTA
   drop constraint FK_NOTA_NOTADANPE_PENAWARA;

alter table PENGGUNA
   drop constraint FK_PENGGUNA_PENGGUNAD_KEWENANG;

alter table STOKKOLEKSI
   drop constraint FK_STOKKOLE_KOLEKSIDA_KOLEKSI;

drop index STOKDIPINJAM_FK;

drop index NOTADANDIPINJAM_FK;

drop table DIPINJAM cascade constraints;

drop table GENRE cascade constraints;

drop table KEWENANGAN cascade constraints;

drop index GENREKOLEKSI_FK;

drop table KOLEKSI cascade constraints;

drop table MEMBER cascade constraints;

drop index NOTADANPENAWARANSPESIAL_FK;

drop index ADMINDANNOTA_FK;

drop index MEMBERDANNOTA_FK;

drop table NOTA cascade constraints;

drop table PENAWARANSPESIAL cascade constraints;

drop table PENGATURAN cascade constraints;

drop index PENGGUNADANKEWENANGAN_FK;

drop table PENGGUNA cascade constraints;

drop index KOLEKSIDANSTOK_FK;

drop table STOKKOLEKSI cascade constraints;

/*==============================================================*/
/* Table: DIPINJAM                                              */
/*==============================================================*/
create table DIPINJAM 
(
   KODEDIPINJAM         CHAR(12)             not null,
   KODESTOK             CHAR(12),
   NONOTA               CHAR(12),
   HARGASEWA            FLOAT,
   HARGADENDA           FLOAT,
   constraint PK_DIPINJAM primary key (KODEDIPINJAM)
);

/*==============================================================*/
/* Index: NOTADANDIPINJAM_FK                                    */
/*==============================================================*/
create index NOTADANDIPINJAM_FK on DIPINJAM (
   NONOTA ASC
);

/*==============================================================*/
/* Index: STOKDIPINJAM_FK                                       */
/*==============================================================*/
create index STOKDIPINJAM_FK on DIPINJAM (
   KODESTOK ASC
);

/*==============================================================*/
/* Table: GENRE                                                 */
/*==============================================================*/
create table GENRE 
(
   KODEKATEGORI         CHAR(4)              not null,
   NAMAKATEGORI         VARCHAR2(50),
   HARGASEWAKATEGORI    FLOAT,
   HARGADENDAKATEGORI   FLOAT,
   constraint PK_GENRE primary key (KODEKATEGORI)
);

/*==============================================================*/
/* Table: KEWENANGAN                                            */
/*==============================================================*/
create table KEWENANGAN 
(
   KODEKEWENANGAN       INTEGER              not null,
   NAMAKEWENANGAN       VARCHAR2(50)         not null,
   MASTERPELANGGAN      SMALLINT             not null,
   MASTERKOLEKSI        SMALLINT             not null,
   MASTERSTOK           SMALLINT             not null,
   TRANSAKSI            SMALLINT             not null,
   LAPORANPERTRANSAKSI  SMALLINT             not null,
   LAPORANTRANSAKSI     SMALLINT             not null,
   LAPORANKEUANGAN      SMALLINT             not null,
   HALLOFFAME           SMALLINT,
   PENGATURANSISTEM     SMALLINT             not null,
   PENGATURANKEWENANGAN SMALLINT             not null,
   PENGATURANPENGGUNA   SMALLINT             not null,
   PENGATURANPENAWARANMENARIK SMALLINT             not null,
   JENDELAPERTAMA       SMALLINT             not null,
   constraint PK_KEWENANGAN primary key (KODEKEWENANGAN)
);

/*==============================================================*/
/* Table: KOLEKSI                                               */
/*==============================================================*/
create table KOLEKSI 
(
   KODEKOLEKSI          CHAR(12)             not null,
   KODEKATEGORI         CHAR(4)              not null,
   NAMAITEM             VARCHAR2(255)        not null,
   DEKRIPSIITEM         CLOB                 not null,
   JENIS                INTEGER              not null,
   BIAYASEWAFILM        FLOAT,
   BIAYADENDAFILM       FLOAT,
   COVERART             BLOB,
   constraint PK_KOLEKSI primary key (KODEKOLEKSI)
);

/*==============================================================*/
/* Index: GENREKOLEKSI_FK                                       */
/*==============================================================*/
create index GENREKOLEKSI_FK on KOLEKSI (
   KODEKATEGORI ASC
);

/*==============================================================*/
/* Table: MEMBER                                                */
/*==============================================================*/
create table MEMBER 
(
   KODEMEMBER           CHAR(10)             not null,
   NAMAMEMBER           VARCHAR2(255),
   JENISIDENTITAS       INTEGER,
   NOMORIDENTITAS       VARCHAR2(255),
   constraint PK_MEMBER primary key (KODEMEMBER)
);

/*==============================================================*/
/* Table: NOTA                                                  */
/*==============================================================*/
create table NOTA 
(
   NONOTA               CHAR(12)             not null,
   KODEOPERATOR         CHAR(5)              not null,
   KODEPENAWARANSPESIAL INTEGER,
   KODEMEMBER           CHAR(10)             not null,
   TGLTRANSAKSI         DATE                 not null,
   TGLKEMBALI           DATE,
   TGLREALISASIKEMBALI  DATE,
   constraint PK_NOTA primary key (NONOTA)
);

/*==============================================================*/
/* Index: MEMBERDANNOTA_FK                                      */
/*==============================================================*/
create index MEMBERDANNOTA_FK on NOTA (
   KODEMEMBER ASC
);

/*==============================================================*/
/* Index: ADMINDANNOTA_FK                                       */
/*==============================================================*/
create index ADMINDANNOTA_FK on NOTA (
   KODEOPERATOR ASC
);

/*==============================================================*/
/* Index: NOTADANPENAWARANSPESIAL_FK                            */
/*==============================================================*/
create index NOTADANPENAWARANSPESIAL_FK on NOTA (
   KODEPENAWARANSPESIAL ASC
);

/*==============================================================*/
/* Table: PENAWARANSPESIAL                                      */
/*==============================================================*/
create table PENAWARANSPESIAL 
(
   KODEPENAWARANSPESIAL INTEGER              not null,
   NAMAPENAWARANSPESIAL VARCHAR2(255)        not null,
   DISKON               FLOAT                not null,
   MULAI                DATE                 not null,
   AKHIR                DATE                 not null,
   constraint PK_PENAWARANSPESIAL primary key (KODEPENAWARANSPESIAL)
);

/*==============================================================*/
/* Table: PENGATURAN                                            */
/*==============================================================*/
create table PENGATURAN 
(
   ID                   INTEGER              not null,
   ATRIBUT              VARCHAR2(50),
   DATA                 VARCHAR2(255),
   constraint PK_PENGATURAN primary key (ID)
);

/*==============================================================*/
/* Table: PENGGUNA                                              */
/*==============================================================*/
create table PENGGUNA 
(
   KODEOPERATOR         CHAR(5)              not null,
   KODEKEWENANGAN       INTEGER              not null,
   USERNAME             VARCHAR2(20)         not null,
   PASSWORD             VARCHAR2(255),
   ISLOGIN              SMALLINT,
   NAMALENGKAP          VARCHAR2(50),
   constraint PK_PENGGUNA primary key (KODEOPERATOR)
);

/*==============================================================*/
/* Index: PENGGUNADANKEWENANGAN_FK                              */
/*==============================================================*/
create index PENGGUNADANKEWENANGAN_FK on PENGGUNA (
   KODEKEWENANGAN ASC
);

/*==============================================================*/
/* Table: STOKKOLEKSI                                           */
/*==============================================================*/
create table STOKKOLEKSI 
(
   KODESTOK             CHAR(12)             not null,
   KODEKOLEKSI          CHAR(12)             not null,
   KONDISI              INTEGER              not null,
   STATUS               SMALLINT             not null,
   HARGA                FLOAT,
   TGLBELI              DATE,
   constraint PK_STOKKOLEKSI primary key (KODESTOK)
);

/*==============================================================*/
/* Index: KOLEKSIDANSTOK_FK                                     */
/*==============================================================*/
create index KOLEKSIDANSTOK_FK on STOKKOLEKSI (
   KODEKOLEKSI ASC
);

alter table DIPINJAM
   add constraint FK_DIPINJAM_NOTADANDI_NOTA foreign key (NONOTA)
      references NOTA (NONOTA);

alter table DIPINJAM
   add constraint FK_DIPINJAM_STOKDIPIN_STOKKOLE foreign key (KODESTOK)
      references STOKKOLEKSI (KODESTOK);

alter table KOLEKSI
   add constraint FK_KOLEKSI_GENREKOLE_GENRE foreign key (KODEKATEGORI)
      references GENRE (KODEKATEGORI);

alter table NOTA
   add constraint FK_NOTA_ADMINDANN_PENGGUNA foreign key (KODEOPERATOR)
      references PENGGUNA (KODEOPERATOR);

alter table NOTA
   add constraint FK_NOTA_MEMBERDAN_MEMBER foreign key (KODEMEMBER)
      references MEMBER (KODEMEMBER);

alter table NOTA
   add constraint FK_NOTA_NOTADANPE_PENAWARA foreign key (KODEPENAWARANSPESIAL)
      references PENAWARANSPESIAL (KODEPENAWARANSPESIAL);

alter table PENGGUNA
   add constraint FK_PENGGUNA_PENGGUNAD_KEWENANG foreign key (KODEKEWENANGAN)
      references KEWENANGAN (KODEKEWENANGAN);

alter table STOKKOLEKSI
   add constraint FK_STOKKOLE_KOLEKSIDA_KOLEKSI foreign key (KODEKOLEKSI)
      references KOLEKSI (KODEKOLEKSI);

