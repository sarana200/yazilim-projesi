﻿// <auto-generated />
using ImuSeyahat.DbHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImuSeyahat.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211215145601_AddNewRecords")]
    partial class AddNewRecords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImuSeyahat.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EntranceFee")
                        .HasColumnType("float");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PlaceAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PlaceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("PlaceEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("PlaceId");

                    b.ToTable("places");

                    b.HasData(
                        new
                        {
                            PlaceId = 1,
                            CityName = "Istanbul",
                            ClosingTime = "23:59",
                            EntranceFee = 100.0,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Galata_Tower_after_the_2020_restoration.jpg/270px-Galata_Tower_after_the_2020_restoration.jpg",
                            OpeningTime = "08:00",
                            PhoneNumber = "5555555555",
                            PlaceAdress = "Bereketzade 34421 Beyoğlu Istanbul",
                            PlaceDescription = "Eski Galata Kulesi, 528 yılında Bizans İmparatoru Anastasius tarafından fener kulesi olarak inşa edilmiştir. Ancak bu kule 1202-1204 yılları arasındaki Dördüncü Haçlı Seferleri sırasında İstanbul’u ele geçiren ve yağmalayan Latinler tarafından büyük oranda zarar görmüş ve yıkılmıştır. Bugün Galata Kulesi’nin bulunduğu yere yakın bir bölgeye inşa edilmiş olan kule bazı kaynaklarda bugünkü kule olarak gösterilse de bu yanlıştır.",
                            PlaceEmail = "galatakulesi@gmail.com",
                            PlaceName = "Galata Kulesi"
                        },
                        new
                        {
                            PlaceId = 2,
                            CityName = "Istanbul",
                            ClosingTime = "23:59",
                            EntranceFee = 0.0,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Exterior_of_Sultan_Ahmed_I_Mosque_in_Istanbul%2C_Turkey_002.jpg/1280px-Exterior_of_Sultan_Ahmed_I_Mosque_in_Istanbul%2C_Turkey_002.jpg",
                            OpeningTime = "09:00",
                            PhoneNumber = "6666666666",
                            PlaceAdress = "Atmeydaný Cd. No:7 34122 Fatih/Istanbul",
                            PlaceDescription = "Sultanahmet Camii, Osmanlı Sultanı I. Ahmet tarafından 1609 – 1616 tarihleri arasında yaptırılmıştır. Klâsik Türk sanatının en tipik örneği olan eser, orijinal olarak 6 minare ile inşa edilen ilk camidir. Mimar Sinan'ın eserlerinden biri olmadığı halde bu yapı Sinan'dan izler taşımaktadır. Sinan’ın öğrencisi Mimar Sedefkâr Mehmet Ağa, söylenene göre, camiyi inşa ederken, üstadının daha önce denediği bir planı daha büyük bir ölçüde uygulamıştır.",
                            PlaceEmail = "sultanahmetcami@gmail.com",
                            PlaceName = "Sultanahmet Camii"
                        },
                        new
                        {
                            PlaceId = 3,
                            CityName = "Bursa",
                            ClosingTime = "11:59",
                            EntranceFee = 0.0,
                            ImageURL = "https://somuncubabaturbesi.com/wp-content/uploads/2018/03/bursa-ulu-camii-fotograf-somuncu-baba.jpg",
                            OpeningTime = "09:00",
                            PhoneNumber = "11111111",
                            PlaceAdress = "Nalbantoğlu Ulucami Osmangazi/Bursa",
                            PlaceDescription = "Bursa Ulu Cami, Orhan Gazi Parkı'nın bulunduğu geniş bir alana, Yıldırım Bayezid zamanında, 1396-1400 yılları arasında yapılmıştır. Osmanlı camileri arasında çok kubbeli anıtsal yapıların ilkidir. Ulu Cami’nin on iki büyük dört köşeli paye üzerine oturan 20 kubbesi bulunmaktadır. Yıldırım Bayezid’in 1396 Niğbolu zaferinden sonra Ulu Cami inşaatına başlanmıştır. Caminin inşaatı bittikten sonra ilk namazı  aralarında Yıldırım Bayezid, Molla Fenari, Emir Sultan’ın  da olduğu cemaate Somuncu Baba kıldırmıştır. Ulu Cami’nin ilk imamı, Mevlid’in yazarı Süleyman Çelebidir.",
                            PlaceEmail = "ulucammi@gmail.com",
                            PlaceName = "Ulu Camiil"
                        },
                        new
                        {
                            PlaceId = 4,
                            CityName = "Ankara",
                            ClosingTime = "19:00",
                            EntranceFee = 0.0,
                            ImageURL = "https://somuncubabaturbesi.com/wp-content/uploads/2018/03/bursa-ulu-camii-fotograf-somuncu-baba.jpg",
                            OpeningTime = "09:00",
                            PhoneNumber = "222222222",
                            PlaceAdress = "Kale, 06240 Altındağ/Ankara",
                            PlaceDescription = "Ankara Kalesi[1], Ankara'nın Altındağ ilçesinde bulunan tarihi bir kale. Ne zaman yapıldığı kesin olarak bilinmemekle birlikte MÖ 2. yüzyıl başında Galatların Ankara'ya yerleşmeleri sırasında kalenin var olduğu bilinmektedir. Romalılar, Bizanslılar, Selçuklular ve Osmanlılar dönemlerinde birçok kez onarımdan geçmiştir. Ankara Kalesi dışarıdan görümüne göre daha büyüktür. Her yıl çeşitli festivallere[2] de ev sahipliği yapmaktadır.",
                            PlaceEmail = "ankarakalesi@gmail.com",
                            PlaceName = "Ankara Kalesi"
                        },
                        new
                        {
                            PlaceId = 5,
                            CityName = "Mersin",
                            ClosingTime = "19:59",
                            EntranceFee = 220.0,
                            ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/kiz-kalesi-34371.webp",
                            OpeningTime = "03:00",
                            PhoneNumber = "44444444",
                            PlaceAdress = "Mersin Erdemli ilçesine",
                            PlaceDescription = "Kız Kulesi hakkında çeşitli rivayetler anlatılan, efsanelere konu olan, İstanbul Boğazı'nın Marmara Denizi'ne yakın kısmında, Salacak açıklarında yer alan küçük adacık üzerinde inşa edilmiş yapı.Tarih içinde gözetleme kulesi, deniz feneri olarak kullanılmış, Boğaz girişini belirten bir mihenk noktasıdır. ",
                            PlaceEmail = "kizkalisi@gmail.com",
                            PlaceName = "KızKalesi"
                        },
                        new
                        {
                            PlaceId = 6,
                            CityName = "Antalya",
                            ClosingTime = "19:59",
                            EntranceFee = 220.0,
                            ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/aspendos-tiyatrosu-34372.webp",
                            OpeningTime = "03:00",
                            PhoneNumber = "555555555",
                            PlaceAdress = "Aspendos Antik Kenti antalya",
                            PlaceDescription = "Aspendos tiyatrosu, döneminin belirgin tiyatro binası yapım özelliklerini içermektedir. 2. yüzyıl sonlarında yapılmıştır. inanılmaz derece mükemmel akustiği ile çağdaşlarının arasında haklı bir üne sahiptir. Kayıtlardan tiyatronun mimarı Aspendos’lu Theodorus’un oğlu Zenon olduğu anlaşılmaktadır.",
                            PlaceEmail = "aspends@gmail.com",
                            PlaceName = "Aspendos Tiyatrosu"
                        },
                        new
                        {
                            PlaceId = 7,
                            CityName = "Sinop",
                            ClosingTime = "11:00",
                            EntranceFee = 110.0,
                            ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/sinop-tarihi-cezaevi-34380.webp",
                            OpeningTime = "07:00",
                            PhoneNumber = "66666666",
                            PlaceAdress = "Kaleyazýsý Cumhuriyet Cd. Osmaniye Köyü/Sinop",
                            PlaceDescription = "Üç yanı deniz olan ve tarihî Sinop Kalesi duvarlarının içerisinde yer alan cezaevine ev sahipliği yapan kale yaklaşık 4000 yıl önce Gaskalılar tarafından yapılmıştır. Yunanlar, Pontus, Roma, Bizans, Selçuklu ve Osmanlılar kendi dönemlerinde kaleyi korumuş ve güçlendirmişlerdir. Kalenin cezaevi olarak kullanımına ait en eski belgeler ise 1568 yılına dayanmaktadır.",
                            PlaceEmail = "sinopcezaev@gmail.com",
                            PlaceName = "Sinop Tarihi Cezaevi"
                        },
                        new
                        {
                            PlaceId = 8,
                            CityName = "Karabük",
                            ClosingTime = "11:00",
                            EntranceFee = 0.0,
                            ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/safranbolu-evleri-34381.webp",
                            OpeningTime = "07:00",
                            PhoneNumber = "77777777",
                            PlaceAdress = "Atatürk, 78600 Safranbolu/Karabük",
                            PlaceDescription = "Safranbolu evleri, Karabük iline bağlı Safranbolu ilçesinde, 18. ve 19. yüzyıl Osmanlı kent yaşamının ve tarihi dokunun günümüze kadar kaldığı korunduğu bir ilçemizdir. UNESCO tarafından 17.12.1998’de Dünya Kültür Mirası listesine alınmıştır. Safranbolu evlerinin Osmanlı döneminde yumurta akından yapıldığı ve çok uzun süre depreme dayandığı söylenilmektedir .Safranbolu evleri Türk kültürünü aile yaşantısını aktara mükemmel yapıtlardan.Evler konak tarzında hali vakti yerinde ailelerin kaldığı evlerdir. Safranbolu evleri birbirinin önünü kapatmaz. Sokaklar taşlarla örülüdür.Alt yapı hala daha çalışmaktadır.",
                            PlaceEmail = "safranbolu@gmail.com",
                            PlaceName = "Safranbolu Evleri"
                        },
                        new
                        {
                            PlaceId = 9,
                            CityName = "Rize",
                            ClosingTime = "11:00",
                            EntranceFee = 0.0,
                            ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/zilkale-34379.webp",
                            OpeningTime = "07:00",
                            PhoneNumber = "88888888",
                            PlaceAdress = "Zilkale/Çamlýhemþin/Rize",
                            PlaceDescription = "Zil Kale, bölgenin en önemli eserlerinden birisidir. I. derece Arkeolojik sit alanı içerisinde bulunan kale, Çamlıhemşin’e 12 km uzaklıkta bulunan Fırtına Deresi’nin yamaçları üzerine kuruludur. Kesin yapım tarihi bilinmeyen kale, 8 burç ve 1 gözetleme kulesinden oluşmaktadır.",
                            PlaceEmail = "zilkale@gmail.com",
                            PlaceName = "Zilkale"
                        },
                        new
                        {
                            PlaceId = 10,
                            CityName = "Erzurum",
                            ClosingTime = "16:00",
                            EntranceFee = 0.0,
                            ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/cifte-minareli-medrese-549.webp",
                            OpeningTime = "01:00",
                            PhoneNumber = "71234568",
                            PlaceAdress = "Merkez,Cumhuriyet Yakutiye/Erzurum",
                            PlaceDescription = "Çifte Minareli Medrese (Hatuniye Medresesi) Anadolu Selçuklu dönemi medreselerindendir. Avlulu, 2 katlı, 4 eyvanlı medrese tipinin anıtsal bir örneğidir. Bütünüyle 38x48 m2’lik bir alanı kaplar. Kuzey cephesine hâkim taçkapısı başlı başına bir sanat şaheseridir. Taç kapıdan avluya geçilir.",
                            PlaceEmail = "cifteminarelimedrese@gmail.com",
                            PlaceName = "Çifte Minareli Medrese"
                        },
                        new
                        {
                            PlaceId = 11,
                            CityName = "Amasya",
                            ClosingTime = "16:00",
                            EntranceFee = 0.0,
                            ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/yaliboyu-evleri-34383.webp",
                            OpeningTime = "01:00",
                            PhoneNumber = "99999999",
                            PlaceAdress = "Bahçeleriçi Amasya Merkez/Amasya",
                            PlaceDescription = "Yeşilırmak kenarında tarihi sur duvarları üzerine, ahşap çatkı arası, kerpiç dolgulu olarak inşaa edilmişlerdir. Kırma ya da beşik çatı üzeri, oluklu kiremitle örtülü bir biçimde düzenlenmiş olan ve geleneksel Osmanlı evinin bütün özelliklerini bünyesinde taşıyan bu evler, Amasya’nın tarihsel kimliğiyle uyumlu bir görünüm arz etmektedir. Evler bitişik nizamda, bodrum üzeri tek kat ya da iki katlı olarak düzenlenmişlerdir. Bazı uygulamalarda birinci kat üzerinde bazı uygulamalarda ise ikinci kat üzerinde köşk olarak bilinen şahniş yer almaktadır. Evler genellikle avlulu ve bahçelidir. Avluda su kuyusu ve ocak ilk göze çarpan nesnelerdir.",
                            PlaceEmail = "yaliboyuevleri@gmail.com",
                            PlaceName = "Yalıboyu Evleri"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
