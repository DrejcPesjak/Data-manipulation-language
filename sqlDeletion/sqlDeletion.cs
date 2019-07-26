using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlDeletion
{
    class sqlDeletion
    {
        static void Main(string[] args)
        {
            string s = @"INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1706983501815','Marsden','Phillips','891-5114 Vel, Street','083-644-527','8343');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0610985501811','Brady','Riggs','P.O. Box 401, 3899 Risus. Rd.','078-822-544','1225');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0301976501814','Samantha','Walters','2816 Tellus St.','006-625-895','2232');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1204975501819','Jameson','Shepherd','358-2410 Sed St.','017-993-090','1301');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2208997501811','Simone','Case','865-7894 Cras Avenue','031-364-833','8341');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0405982501818','Phillip','Strickland','Ap #222-2279 Lacus. St.','014-208-393','3221');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2007993501811','Emma','Hodges','P.O. Box 161, 108 Nec, Rd.','038-366-372','2233');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0301976501814','Edward','Sexton','9398 Non, Rd.','023-886-309','2316');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0610979501818','Jermaine','Hogan','P.O. Box 123, 5163 Nunc Road','046-604-898','8273');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2810992501815','September','Mcbride','4183 Ligula. Rd.','033-944-887','1315');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1208987501811','Eliana','Moss','2201 Eu, St.','073-748-705','2277');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2810998501817','Odysseus','Cruz','2333 Et, Avenue','023-822-638','8294');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0606998501813','Benjamin','Wise','Ap #741-741 Lacinia Rd.','004-308-978','2370');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0301988501811','Malachi','Salas','P.O. Box 817, 5751 Nam Rd.','012-241-757','1217');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2501995501813','Cairo','Bird','711-6759 A, St.','088-310-340','2288');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0305988501815','Murphy','Ruiz','919-3583 Nunc Rd.','017-293-645','2390');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1208987501811','Randall','Holt','P.O. Box 714, 422 Ante Road','007-540-550','3333');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2702980501812','Lamar','Molina','569-5727 Fermentum Street','029-350-241','8231');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2409988501812','Zenia','Fowler','782-1575 Et Av.','027-736-950','3341');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2304991501819','Laurel','Richard','8266 Rhoncus. St.','087-790-215','6225');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0610985501811','David','Carey','645-9661 In Ave','020-474-369','1351');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2208984501812','Malik','Mccarthy','Ap #585-4723 Ac Ave','016-963-752','1319');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1309985501813','Hasad','Marquez','8568 Mi. Avenue','059-665-336','6274');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0402986501813','Lee','Butler','988-9952 Eleifend Avenue','046-689-837','1354');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1204981501812','Chaney','Hood','5436 Vitae, Street','026-750-266','2321');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1502977501817','Hall','Vinson','P.O. Box 616, 4672 Malesuada Road','050-195-055','6001');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0104978501811','Nash','Santos','P.O. Box 917, 1416 Etiam St.','061-500-594','2242');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1710976501815','Victor','Carr','570-1183 Lorem, Rd.','012-315-257','2255');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1112993501816','Mohammad','Osborn','5588 Magnis Road','041-219-080','2211');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1409991501811','Shelly','Oliver','601-4919 Risus Street','067-964-502','3224');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2806986501814','Timon','Ortiz','231 Nonummy Avenue','019-168-502','5223');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0510998501816','Colleen','Hanson','Ap #706-7911 Aliquet, St.','021-673-840','3203');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2810998501817','Silas','Phillips','Ap #260-4981 Ut, Ave','044-560-301','3303');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2208984501812','Alexis','Mullen','Ap #475-7607 Hymenaeos. Rd.','076-885-550','8350');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2212984501811','Isaac','Swanson','380-8335 Purus, St.','097-619-649','1294');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1309985501813','Ivy','Guerra','P.O. Box 319, 3534 Risus. Ave','098-790-701','6272');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2304991501819','Lysandra','Peterson','593-8034 Sem St.','019-401-600','8257');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2806980501812','Armand','Dillard','282 Ultricies Road','017-838-220','1433');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0104978501811','Vincent','York','5414 Libero. St.','053-172-707','4245');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1104994501817','Sonya','Fox','P.O. Box 944, 3572 A Rd.','068-281-730','3255');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0405994501813','Ann','Weber','3006 Nec Rd.','050-615-168','3262');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0706979501815','Jennifer','Stout','P.O. Box 947, 3869 Lorem Ave','064-916-122','2390');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1502977501817','Thomas','James','P.O. Box 145, 7258 Fusce Road','001-904-313','8222');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1401985501817','Magee','Chen','Ap #437-7175 Ornare, Ave','093-137-245','2370');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0903990501819','Barclay','Walters','P.O. Box 115, 1917 Quam. St.','053-672-889','5224');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0506992501817','Brady','Poole','Ap #801-8860 Convallis Street','084-712-231','2230');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1505985501817','Brock','Ware','Ap #406-4871 Massa. Rd.','078-492-024','8342');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0301976501814','Heidi','Bradford','298-5429 Ultrices St.','050-551-329','1296');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1911999501818','Camilla','Lancaster','P.O. Box 509, 2002 Senectus St.','001-604-772','1413');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('3011996501813','Quemby','Carney','207-6763 Lectus. Road','070-827-346','2214');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2308978501813','Yasir','Moon','P.O. Box 398, 3857 Ornare St.','056-731-408','3241');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1401985501817','Kessie','Sullivan','707-1410 Mollis Rd.','061-496-135','2373');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1003977501810','Callie','Kennedy','Ap #299-2214 Sagittis Road','009-594-705','2371');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2810992501815','Nola','Haley','819-180 Purus St.','008-919-515','8256');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2810992501815','Angelica','Pierce','731-8390 Donec Rd.','042-468-552','9201');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2212984501811','Kessie','Klein','544-1947 Tempus St.','001-386-091','5292');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0405982501818','Rina','Houston','6070 Maecenas Av.','077-921-403','4276');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('3107984501815','Randall','Newman','2673 Per Ave','034-413-076','9244');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0610979501818','Robert','Valenzuela','947-1712 Et St.','066-454-715','9000');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2602993501817','Alisa','Fulton','Ap #977-554 Accumsan Rd.','060-850-554','4275');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('3103984501811','Maris','Mcgee','4000 Sagittis St.','012-105-352','1313');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0807996501811','Linus','Ware','Ap #643-2147 Non St.','012-938-962','3322');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1602989501817','Vladimir','Gallegos','Ap #139-4099 Consectetuer St.','090-902-989','1332');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2011986501811','Zahir','Hickman','297 Egestas. Rd.','030-418-261','4225');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0201982501813','Wylie','Barton','P.O. Box 481, 1948 Elit Avenue','028-422-975','1310');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2702986501814','Gail','Banks','Ap #317-5935 Donec Rd.','014-586-084','8272');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1806995501815','Emily','Boyer','Ap #771-4388 Dui Street','091-410-869','1316');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('3011977501810','Garrison','Bradshaw','P.O. Box 919, 5010 Posuere Rd.','056-742-638','3212');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('3103984501811','Erasmus','Frazier','4382 Suspendisse Rd.','019-742-673','9253');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1409991501811','Zeus','Moran','497-5918 Enim. Ave','070-335-626','2231');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1409991501811','Blake','Lambert','4341 Mauris Ave','015-596-936','6254');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0811989501811','Anastasia','Mathews','P.O. Box 715, 1799 Non, St.','077-515-329','8333');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0309975501811','Dexter','Zamora','1200 Sollicitudin Ave','084-146-556','9261');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0610979501818','Sheila','Oneil','161-9483 Vitae, Av.','021-532-498','8276');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0911995501811','Unity','Todd','9712 Nonummy Rd.','015-429-714','1275');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('3011996501813','Mara','Sanchez','3737 A Rd.','076-416-480','2211');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1204981501812','Carissa','Mccall','Ap #262-7504 Cum Rd.','059-204-158','9265');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1112987501812','Burke','Myers','3787 Mauris Rd.','043-615-760','8340');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2509994501810','Chancellor','Bowman','3379 A, St.','024-932-236','1431');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0301976501814','Kamal','Barrett','162-9655 Vel, Ave','077-669-197','6333');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1505985501817','Jayme','Kramer','P.O. Box 174, 381 Pede Street','011-613-990','1262');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1401979501813','Louis','Valencia','P.O. Box 683, 7637 Et Av.','015-862-646','1380');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2501976501810','Gemma','Hoffman','P.O. Box 394, 1691 Duis Road','027-497-260','2287');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0606998501813','Galvin','Morin','539-5352 Varius Road','059-377-068','8281');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2702999501813','Scarlet','Hewitt','Ap #955-3747 Mauris Av.','047-942-524','2341');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0706979501815','John','Pugh','P.O. Box 796, 7126 Consequat Road','065-981-638','1352');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2312990501818','Patricia','Mendoza','Ap #230-6681 Suscipit Avenue','074-481-429','6230');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0402986501813','Holmes','Mays','P.O. Box 780, 2011 Rutrum. St.','079-102-798','2256');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2409988501812','Luke','Blake','Ap #511-132 Non, Avenue','083-374-742','2365');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1409997501813','Flynn','Cobb','7297 Risus. Rd.','043-429-569','6276');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('0610985501811','Hiram','Riggs','3324 Diam Rd.','063-719-878','3230');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1810982501813','Ashely','Kent','P.O. Box 957, 990 Sem Av.','032-882-361','3253');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2312990501818','Hu','Perry','849-4436 Lacus St.','094-152-361','1001');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2810986501811','Sylvester','Morris','391-2945 Sem Avenue','077-887-900','8000');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2208984501812','Shoshana','Kim','8158 Ante Street','073-323-530','1352');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2304978501818','Kuame','Zimmerman','P.O. Box 934, 739 Integer St.','006-473-821','9252');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2702986501814','Brian','Weaver','139-731 Odio. Avenue','069-531-942','9253');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('3103984501811','Gloria','Burgess','7560 Arcu. Rd.','085-909-027','8262');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('1204975501819','Ginger','Briggs','1551 Magnis Av.','081-357-504','1217');
            INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES('2003981501810','Idola','Pate','Ap #536-4456 Ante Street','017-973-907','2394');";

            string[] emsi = "2602993501817|2003981501810|1104994501817|0405982501818|2605995501813|1706983501815|0807996501811|3107984501815|2208997501811|1309985501813|0510998501816|2810986501811|1911999501818|1112987501812|0301976501814|2401989501815|1502977501817|0903990501819|0104978501811|2304991501819|1505979501813|0506992501817|2806980501812|2007993501811|1108981501813|0209994501811|2509982501815|1710995501818|0811983501811|3011996501813|2212984501811|1301998501811|0402986501813|2702999501813|2103987501817|1204975501819|0305988501815|2605976501810|1706989501817|0907977501813|3107990501819|2308978501813|1409991501811|0610979501818|2810992501815|1911980501817|1112993501816|0201982501813|2501995501813|1602983501815|0903996501810|3103984501811|2304997501810|1505985501817|0606998501813|2806986501814|2107999501818|1208987501811|0309975501811|2409988501812|1710976501815|0811989501811|3011977501810|2312990501818|1401979501813|0502992501811|2702980501812|2103993501810|1204981501812|0405994501813|2605982501814|1806995501815|1007983501811|3107996501810|2208984501812|1409997501813|0610985501811|2810998501817|2011986501811|1212999501812|0301988501811|2501976501810|1602989501817|1003977501810|0104990501819|2304978501818|1605991501815|0706979501815|2806992501818|2007980501812|1208993501813|0309981501815|2509994501810|1810982501813|0911995501811|0112983501814|2212996501815|1401985501817|0502998501813|2702986501814".Split('|');
            /*
            for (int i = 0, indeks=0; i < emsi.Length; i++ )
            {
                indeks = s.IndexOf("VALUES(", indeks)+8;
                s = s.Remove(indeks, 13);
                s = s.Insert(indeks, emsi[i]);
            }*/
            /*Console.Write("INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES" +
                s.Replace("INSERT INTO projekti([emso],[ime],[priimek],[naslov],[telefon],[postna_st]) VALUES", "           ").Replace(';', ','));*/
        
            //Console.Write("2602993504451|2003981504453|1104994504451|0405982504450|2605995504456|1706983504458|0807996504454|3107984504458|2208997504454|1309985504456|0510998504459|2810986504454|1911999504450|1112987504455|0301976504457|2401989504458|1502977504451|0903990504451|0104978504454|2304991504451|1505979504456|0506992504451|2806980504455|2007993504454|1108981504456|0209994504452|2509982504458|1710995504450|0811983504452|3011996504456|2212984504452|1301998504454|0402986504456|2702999504456|2103987504451|1204975504451|0305988504458|2605976504453|1706989504451|0907977504456|3107990504451|2308978504456|1409991504454|0610979504450|2810992504458|1911980504451|1112993504459|0201982504456|2501995504456|1602983504458|0903996504453|3103984504452|2304997504453|1505985504451|0606998504456|2806986504457|2107999504450|1208987504452|0309975504454|2409988504455|1710976504458|0811989504454|3011977504453|2312990504450|1401979504456|0502992504454|2702980504455|2103993504453|1204981504455|0405994504456|2605982504457|1806995504458|1007983504452|3107996504453|2208984504455|1409997504456|0610985504454|2810998504451|2011986504454|1212999504455|0301988504452|2501976504453|1602989504451|1003977504453|0104990504451|2304978504450|1605991504458|0706979504458|2806992504450|2007980504455|1208993504456|0309981504458|2509994504453|1810982504456|0911995504452|0112983504457|2212996504458|1401985504451|0502998504456|2702986504457".Replace('|', '\n'));

            string query = @"(1,60,'15/06/2017',275840,'','1401985501817'),(2,78,'28/10/2018',246421,'','1605991501815'),(3,44,'08/12/2018',821288,'','1710976501815'),(4,39,'24/11/2018',993482,'','1204981501812'),(5,67,'24/11/2018',344580,'','1710995501818'),(6,66,'10/11/2017',9611,'','0309981501815'),(7,84,'28/11/2018',355100,'','0903996501810'),(8,24,'15/01/2019',174987,'','1602983501815'),(9,92,'15/12/2018',342104,'','0510998501816'),(10,85,'17/02/2018',540160,'','0104978501811'),(11,39,'07/08/2018',773551,'','1409991501811'),(12,38,'16/11/2017',987985,'','2208984501812'),(13,92,'06/02/2018',198130,'','2103993501810'),(14,87,'26/07/2017',239945,'','1112987501812'),(15,18,'02/09/2017',169248,'','2011986501811'),(16,68,'01/01/2018',492855,'','0606998501813'),(17,68,'08/03/2019',178372,'','2810986501811'),(18,40,'14/07/2018',774354,'','0502998501813'),(19,20,'15/01/2019',867509,'','2007980501812'),(20,72,'02/01/2018',772873,'','2007980501812'),(21,93,'18/05/2017',51482,'','2810998501817'),(22,92,'30/07/2017',919518,'','2304997501810'),(23,63,'21/01/2018',850125,'','0502998501813'),(24,35,'29/06/2018',31227,'','2304997501810'),(25,92,'06/12/2017',636874,'','2107999501818'),(26,98,'03/05/2018',35031,'','2304997501810'),(27,25,'17/10/2017',696629,'','1401985501817'),(28,77,'14/06/2017',568050,'','2208997501811'),(29,71,'10/01/2019',678372,'','0112983501814'),(30,76,'10/02/2018',630709,'','2208984501812'),(31,24,'15/06/2018',881771,'','0405982501818'),(32,67,'08/08/2018',28476,'','2605982501814'),(33,21,'23/07/2018',740667,'','1212999501812'),(34,46,'22/04/2017',338362,'','2806992501818'),(35,71,'27/12/2017',304729,'','0610979501818'),(36,45,'22/02/2018',59764,'','0405994501813'),(37,45,'26/01/2019',617183,'','1301998501811'),(38,17,'12/10/2018',545277,'','0405982501818'),(39,15,'20/05/2017',91617,'','1605991501815'),(40,17,'21/11/2017',469830,'','0405982501818'),(41,49,'18/09/2017',26494,'','2312990501818'),(42,13,'29/07/2017',224241,'','0405982501818'),(43,21,'08/09/2018',739399,'','2810986501811'),(44,98,'30/01/2019',289648,'','0104978501811'),(45,20,'18/10/2018',546529,'','2702986501814'),(46,90,'12/10/2017',130292,'','2208997501811'),(47,65,'28/04/2018',717298,'','0911995501811'),(48,69,'14/09/2017',807342,'','0104990501819'),(49,79,'04/07/2017',626885,'','2312990501818'),(50,40,'25/10/2017',258335,'','2806980501812')";
            for (int i = 0, indeks = 0; i < query.Length; i=indeks+60)
            {
                indeks = query.IndexOf("),(", indeks);
                if (indeks != -1) query = query.Insert(indeks + 2, "\n           ");
            }
            Console.Write(query);

            Console.ReadKey();
        }
    }
}
