-- TIPOS RAMOS
INSERT INTO EXERCITO.tipo_ramo (design) VALUES ('Força Terrestre');
INSERT INTO EXERCITO.tipo_ramo (design) VALUES ('Força Aérea');
INSERT INTO EXERCITO.tipo_ramo (design) VALUES ('Força Marítima');

SELECT * FROM EXERCITO.tipo_ramo

-- RAMOS
INSERT INTO EXERCITO.ramo (sigla,tipo, mote, contacto, simbolo, morada, dia, fax, data_inicio, data_fim, nCC) 
VALUES ('FT',1, 'Um Pedaço de Terra Defendida', '214988901', '', 'Rua da Infantaria 16 1269-091 Lisboa', '1961-04-23', '214988908', NULL, NULL, NULL)

INSERT INTO EXERCITO.ramo (sigla,tipo, mote, contacto, simbolo, morada, dia, fax, data_inicio, data_fim, nCC) 
VALUES ('FA',2, 'Ex Mero Motu', '214726120', '', 'Av Martins Monsanto 1500-589 Lisboa', '1952-07-01', '217716023', NULL, NULL, NULL)

INSERT INTO EXERCITO.ramo (sigla,tipo, mote, contacto, simbolo, morada, dia, fax, data_inicio, data_fim, nCC) 
VALUES ('FM',3, 'Talant de Bien Faire', '214401919', '', 'Rua do Arsenal 1149-001 Lisboa', '1317-12-12', '213945469', NULL, NULL, NULL)

SELECT * FROM EXERCITO.ramo

-- ESPECIALIDADES MEDICAS
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Cardiologia');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Cirugia Geral');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Estomatologia');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Hematologia');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Neurologia');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Ortopedia');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Psiquiatria');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Pneumologia');
INSERT INTO EXERCITO.especialidade (especialidade) VALUES ('Radiologia');

SELECT * FROM EXERCITO.especialidade

-- CARGOS MILITAR
INSERT INTO EXERCITO.cargo (cargo) VALUES ('CEME');
INSERT INTO EXERCITO.cargo (cargo) VALUES ('Vice CEME');
INSERT INTO EXERCITO.cargo (cargo) VALUES ('General');
INSERT INTO EXERCITO.cargo (cargo) VALUES ('Capitão');
INSERT INTO EXERCITO.cargo (cargo) VALUES ('Recruta');

SELECT * FROM EXERCITO.cargo

-- TIPO SOLDADOS
--FT
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Paraquedista');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Artilheiro');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Fuzileiro');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Atirador Furtivo');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Sapador');

SELECT * FROM EXERCITO.tipo_soldado
SELECT * FROM EXERCITO.tipo_ramo
--FA
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Bombardeiro');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Co-piloto');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Comunicação');

--FM
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Mergulhador');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Piloto Naútico');
INSERT INTO EXERCITO.tipo_soldado(tipo) VALUES ('Fuzileiro Naval');

SELECT * FROM EXERCITO.tipo_soldado


-- BASES MILITARES 

/*
INSERT INTO EXERCITO.base_militar (id,morada,contacto,maxMilitares,nMilitares,data_inicio,data_fim) VALUES (362,'Ap #169-1715 Sed St.','405722470',1593,0,NULL,NULL),(481,'8430 Sapien Rd.','464607757',3038,0,NULL,NULL),(376,'Ap #231-8155 Rutrum Ave','225671705',2711,0,NULL,NULL),(156,'P.O. Box 588, 5856 Eget St.','144215570',2304,0,NULL,NULL),(495,'Ap #566-8575 Imperdiet Street','219885039',2007,0,NULL,NULL),(488,'8190 Lacinia Av.','084831992',4084,0,NULL,NULL),(91,'Ap #185-9211 Suspendisse Avenue','081981671',4078,0,NULL,NULL),(590,'4388 Fames St.','974125243',4110,0,NULL,NULL),(795,'P.O. Box 652, 6615 In Avenue','162007788',3540,0,NULL,NULL),(1000,'Ap #387-5719 Tortor. Ave','398288330',1925,0,NULL,NULL);
INSERT INTO EXERCITO.base_militar (id,morada,contacto,maxMilitares,nMilitares,data_inicio,data_fim) VALUES (175,'3041 Enim. St.','414474228',2941,0,NULL,NULL),(794,'Ap #282-2423 Neque Av.','450000984',4862,0,NULL,NULL),(24,'Ap #249-7703 Primis Street','000028168',3034,0,NULL,NULL),(131,'9012 Cursus Av.','834090867',4992,0,NULL,NULL),(96,'P.O. Box 528, 1651 Libero. Ave','019935962',3957,0,NULL,NULL),(660,'8925 Lectus Street','177855718',4807,0,NULL,NULL),(886,'Ap #645-1411 Ultrices St.','627260152',4584,0,NULL,NULL),(41,'2888 Cum Avenue','401933006',4779,0,NULL,NULL),(298,'P.O. Box 846, 4259 Urna. Avenue','652600314',4574,0,NULL,NULL),(606,'P.O. Box 909, 4090 Eu Rd.','577793041',2926,0,NULL,NULL);
INSERT INTO EXERCITO.base_militar (id,morada,contacto,maxMilitares,nMilitares,data_inicio,data_fim) VALUES (897,'1646 Purus. Rd.','856824715',4656,0,NULL,NULL),(916,'Ap #835-8646 Nulla Av.','581426071',1744,0,NULL,NULL),(498,'Ap #346-5386 Et, Rd.','963710538',3472,0,NULL,NULL),(688,'P.O. Box 241, 1631 Odio Rd.','028879443',2594,0,NULL,NULL),(552,'P.O. Box 774, 1862 Aliquam Rd.','666079604',1106,0,NULL,NULL),(588,'601-6276 Semper Rd.','361117176',1011,0,NULL,NULL),(659,'Ap #730-184 Aliquet, Avenue','879554354',3170,0,NULL,NULL),(28,'P.O. Box 517, 2314 Nulla St.','510158255',3217,0,NULL,NULL),(46,'879-105 Curabitur Av.','134639475',1213,0,NULL,NULL),(810,'P.O. Box 360, 9121 Sed Rd.','910606776',1062,0,NULL,NULL);
INSERT INTO EXERCITO.base_militar (id,morada,contacto,maxMilitares,nMilitares,data_inicio,data_fim) VALUES (471,'P.O. Box 142, 397 Est Rd.','443972704',3890,0,NULL,NULL),(661,'P.O. Box 154, 6169 Sed Avenue','176127423',1418,0,NULL,NULL),(548,'103-1010 Elit, Street','582123432',4203,0,NULL,NULL),(313,'Ap #191-5165 Egestas. Av.','587858021',1487,0,NULL,NULL),(995,'Ap #306-6300 Mauris Avenue','103339517',2609,0,NULL,NULL),(13,'677 Facilisis Rd.','678250247',4194,0,NULL,NULL),(410,'Ap #245-6909 Nullam Rd.','432376674',1002,0,NULL,NULL),(159,'Ap #310-9238 Duis St.','108879713',2754,0,NULL,NULL),(812,'979-4163 Nisi Avenue','757560626',4709,0,NULL,NULL),(843,'1355 Magna. Street','316620397',4374,0,NULL,NULL);
INSERT INTO EXERCITO.base_militar (id,morada,contacto,maxMilitares,nMilitares,data_inicio,data_fim) VALUES (374,'P.O. Box 982, 533 Augue. Rd.','944473384',2705,0,NULL,NULL),(786,'3834 Erat Av.','868589018',2822,0,NULL,NULL),(670,'P.O. Box 869, 9719 Vestibulum. Rd.','053762690',1246,0,NULL,NULL),(798,'581-546 Non, Av.','497323735',2045,0,NULL,NULL),(197,'P.O. Box 644, 921 Turpis. Rd.','721135126',1151,0,NULL,NULL),(495,'Ap #374-9114 Justo Rd.','755963516',3519,0,NULL,NULL),(961,'P.O. Box 729, 4938 Suscipit, Rd.','209592034',2297,0,NULL,NULL),(729,'4272 Egestas Rd.','757152400',2531,0,NULL,NULL),(174,'P.O. Box 338, 2977 Aenean Ave','900809706',3947,0,NULL,NULL),(460,'Ap #989-9152 Erat Av.','196275673',1382,0,NULL,NULL);
INSERT INTO EXERCITO.base_militar (id,morada,contacto,maxMilitares,nMilitares,data_inicio,data_fim) VALUES (558,'8936 Laoreet, Av.','047735081',1922,0,NULL,NULL),(809,'3424 Feugiat Road','967366177',1537,0,NULL,NULL),(314,'8641 Ligula. Av.','651982225',1009,0,NULL,NULL),(434,'Ap #871-7789 Placerat, Av.','591670923',1661,0,NULL,NULL),(97,'P.O. Box 200, 4893 Facilisis. St.','385413708',3428,0,NULL,NULL),(999,'P.O. Box 949, 4099 Rutrum St.','475172962',2845,0,NULL,NULL),(229,'Ap #488-1966 Mollis. Ave','035367444',4056,0,NULL,NULL),(689,'P.O. Box 752, 7282 Nunc Rd.','127344328',3888,0,NULL,NULL),(527,'1926 Sagittis St.','598822460',4550,0,NULL,NULL),(896,'828-3144 Eget, Rd.','154557674',3005,0,NULL,NULL);
*/

INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('P.O. Box 443, 4622 Enim, Avenue','621861963',2560,NULL,NULL),('Ap #536-7207 Rutrum. Street','354766104',3905,NULL,NULL),('991-5570 Ultrices Rd.','220479034',2245,NULL,NULL),('Ap #768-1523 Consectetuer, Street','231152854',1514,NULL,NULL),('483-2299 Pellentesque Rd.','933388402',2181,NULL,NULL),('3259 Purus St.','979280660',2381,NULL,NULL),('P.O. Box 533, 7240 Mauris Rd.','041481579',4138,NULL,NULL),('P.O. Box 656, 7898 Justo. Road','429826312',2329,NULL,NULL),('P.O. Box 723, 6783 Erat, Rd.','748820102',4510,NULL,NULL),('764-3544 Amet St.','081883746',4646,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('Ap #286-1542 Nam Avenue','053660929',3048,NULL,NULL),('P.O. Box 301, 1990 Mattis Rd.','548642044',4339,NULL,NULL),('Ap #928-6270 Turpis. St.','010128657',2499,NULL,NULL),('Ap #573-9015 A, Ave','624228574',2812,NULL,NULL),('798-7515 Fusce Avenue','566168828',2871,NULL,NULL),('716-3868 Erat Rd.','597318534',1667,NULL,NULL),('Ap #968-6518 Semper Rd.','538816680',2961,NULL,NULL),('P.O. Box 639, 5660 Ultrices Av.','073877344',3751,NULL,NULL),('Ap #396-5176 Ipsum Av.','904121809',2519,NULL,NULL),('Ap #772-3050 Vitae Road','845090208',3130,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('1342 Nec, Ave','396687564',1678,NULL,NULL),('325-4624 Nunc. Road','425271300',3748,NULL,NULL),('Ap #149-3784 Penatibus Avenue','966455293',2885,NULL,NULL),('Ap #320-735 Sed, St.','934424839',4836,NULL,NULL),('563-4421 Cursus. Avenue','088244544',1912,NULL,NULL),('322-4259 Morbi Avenue','517771340',1296,NULL,NULL),('Ap #209-1613 Ultrices. Avenue','438365204',3851,NULL,NULL),('1331 Felis. Street','673186117',2546,NULL,NULL),('1611 Magna, Av.','051109992',2977,NULL,NULL),('P.O. Box 899, 4598 Enim Road','553195354',3283,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('928-4170 Quis Rd.','939018065',4759,NULL,NULL),('Ap #765-2952 Ac Road','435526133',2985,NULL,NULL),('Ap #451-1974 Malesuada. St.','424364219',1234,NULL,NULL),('Ap #149-1276 Ipsum Av.','825893382',4654,NULL,NULL),('Ap #916-9604 Auctor, Av.','587739755',3707,NULL,NULL),('P.O. Box 841, 7056 At Road','572733021',4361,NULL,NULL),('525-9100 Magna. Avenue','195036153',1357,NULL,NULL),('6321 Phasellus Rd.','794998332',1515,NULL,NULL),('Ap #991-2358 Pellentesque Av.','027524538',3260,NULL,NULL),('5411 Vitae, Road','128701976',4948,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('455-6583 Curabitur Street','500470962',3211,NULL,NULL),('P.O. Box 657, 352 Facilisis. Road','564774826',2612,NULL,NULL),('Ap #864-4128 Erat Av.','949663923',2291,NULL,NULL),('P.O. Box 640, 2491 Non, Street','248277829',1836,NULL,NULL),('572-7742 Vehicula Rd.','113910220',3680,NULL,NULL),('339-1711 Donec Avenue','398070410',1994,NULL,NULL),('Ap #527-2103 Malesuada Rd.','500617211',4266,NULL,NULL),('Ap #238-2489 Consequat Rd.','189884590',3156,NULL,NULL),('716-9893 Mi, Ave','401139812',1508,NULL,NULL),('154-4044 Parturient St.','696467904',2617,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('Ap #725-1811 Eu Street','432969328',4507,NULL,NULL),('558-4344 Faucibus St.','492962565',2219,NULL,NULL),('128-9275 Ante Rd.','968752825',3387,NULL,NULL),('4749 Mauris Road','533864416',1695,NULL,NULL),('102-8674 Nec Av.','218409120',2840,NULL,NULL),('5039 Hendrerit Ave','564945750',2169,NULL,NULL),('P.O. Box 172, 1454 Ut, Ave','687622251',3022,NULL,NULL),('831-9661 Nonummy Street','908029031',4225,NULL,NULL),('Ap #639-2484 Leo, Ave','059765338',2664,NULL,NULL),('706-927 Felis. Street','210674607',1770,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('491-2355 Tincidunt Ave','559974135',1373,NULL,NULL),('859-8719 Ipsum St.','523483213',1556,NULL,NULL),('7189 Donec Rd.','898309541',1454,NULL,NULL),('225-5191 Cum Av.','382167301',3344,NULL,NULL),('276-9281 Ultricies Road','252127349',4696,NULL,NULL),('P.O. Box 989, 8389 Elit, St.','667946753',1297,NULL,NULL),('646-7214 Curabitur Avenue','057454337',1063,NULL,NULL),('P.O. Box 110, 3421 Non St.','592438100',4595,NULL,NULL),('6524 Etiam Ave','578301972',1373,NULL,NULL),('P.O. Box 447, 5320 Nec Ave','404521390',4205,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('8296 Quam Road','382417985',2429,NULL,NULL),('5994 Nunc Av.','011812917',4945,NULL,NULL),('318-4045 Mauris St.','110736612',2489,NULL,NULL),('391-1337 Hendrerit Road','733937605',1846,NULL,NULL),('593-3349 Conubia Rd.','401732922',3616,NULL,NULL),('8110 Vitae Ave','935358740',4055,NULL,NULL),('Ap #365-7459 Aliquet St.','221452339',4663,NULL,NULL),('658-8943 Diam. St.','621238161',2750,NULL,NULL),('Ap #830-7847 Ac St.','840586049',3492,NULL,NULL),('657-434 Interdum Rd.','839207777',4306,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('Ap #182-9780 Cum Avenue','476501450',1886,NULL,NULL),('710-7012 Dui Rd.','290926968',3628,NULL,NULL),('P.O. Box 641, 3436 Cum Road','183337268',4227,NULL,NULL),('3831 Quis, Av.','905968964',1579,NULL,NULL),('119-3009 Etiam St.','489054392',2529,NULL,NULL),('Ap #726-8038 Ultrices. St.','478751240',1729,NULL,NULL),('Ap #880-5253 Eleifend St.','663673231',2891,NULL,NULL),('496-1177 Semper Rd.','624841041',4123,NULL,NULL),('5752 Imperdiet St.','298597681',2995,NULL,NULL),('438-5618 Nonummy Street','704547824',1104,NULL,NULL);
INSERT INTO EXERCITO.base_militar([morada],[contacto],[maxMilitares],[data_inicio],[data_fim]) VALUES('6962 Nonummy Avenue','250269855',3582,NULL,NULL),('9660 Et, Street','593642376',2358,NULL,NULL),('972-6343 Molestie Street','836612999',1382,NULL,NULL),('1775 Aliquam Rd.','373176832',3067,NULL,NULL),('375-2948 Ultrices Road','254601457',2495,NULL,NULL),('6498 Et, Av.','874915727',2488,NULL,NULL),('Ap #717-7837 Donec Rd.','683659130',3935,NULL,NULL),('628-8550 Ligula. St.','693451064',2682,NULL,NULL),('Ap #675-7109 Bibendum Av.','534905550',2969,NULL,NULL),('5825 Feugiat Av.','488861084',1205,NULL,NULL);

-- BASE RAMO
	--python


-- tipo_missao
INSERT INTO EXERCITO.tipo_missao(tipo) VALUES ('Territorial')
INSERT INTO EXERCITO.tipo_missao(tipo) VALUES ('Conflito')
INSERT INTO EXERCITO.tipo_missao(tipo) VALUES ('Diplomática')
INSERT INTO EXERCITO.tipo_missao(tipo) VALUES ('Civil-Militar')
INSERT INTO EXERCITO.tipo_missao(tipo) VALUES ('Evacuação')
INSERT INTO EXERCITO.tipo_missao(tipo) VALUES ('Assalto')

insert into EXERCITO.militar (nCC, Pnome, Unome, morada, email, dNasc, tel, nacionalidade, nMissoes, ramo, base, cargo) values (936125839, 'Willabella', ' Slatcher', '651 Amoth Hill', 'wslatcher0@yelp.com', '2/26/1988', '944116603', 'Portugal', 6, 1, 12, 1);

SELECT * FROM EXERCITO.militar
INSERT INTO EXERCITO.pelotao (nome) VALUES ('lllaoq')





