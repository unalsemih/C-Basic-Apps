# 4 Basic-Apps with C# Programming Language

- Hangman Game
- Maths Game
- Number Finding Game
- Memory Game


## 1) Hangman Game
✓ Bilinemeyen her harf için adamı asılmaya bir adım daha yaklaştıran kelime oyununudur.

✓ Kelime veritabanı olarak kullanılmak üzere bir metin dosyası oluşturuldu. Bu metin
dosyasına yeni kelime ekleme ve dosyadan kelime silme işlemleri yapılabilmektedir.

✓ Skor listesi yapılmalıdır ve bu bilgiler bir dosyada tutularak oyun yediden başladığında
görüntülenebilmelidir.
![](https://github.com/unalsemih/repo-images/blob/master/hangman-home.png?raw=true)

✓ Kullanıcını oyuna başladığında opsiyonel olarak belirlediği harf sayısı kadar veya
rasgele boyutlarda bir kelime, veritabanındaki uygun kelimelerden seçilmedir.

✓ Sorulan kelimeye uzunluğunun 2 fazlası kadar bir hak tanıyarak kullanıcının kelimeyi
bulması istenmelidir.

✓ Sorulan kelimenin her harfi için farklı metin kutuları kullanılmalıdır.

✓ Yanlış tahmin edilen harfler form üzerinde görülmelidir.

✓ Tahminlerde harf tekrarına izin verilmemeli ve kullanıcının hak sayısından
düşürülmemelidir.

![](https://github.com/unalsemih/repo-images/blob/master/hangman-game.png?raw=true)


## 2) Maths Game
✓ İlkokul öğrencilerine yönelik bir 4 işlem alıştırma oyunudur.

✓ Oyun 5 seviden oluşmaktadır ve her seviye 4 blok soru içermelidir.

✓ Kullanıcı cevaplarını verip devam edebilmekte veya PAS diyebilmektedir. Pas geçtiği sorular bulunduğu seviyedeki son
sorudan sonra tekrar görüntülenmektedir. 

✓ Öğrenci sonraki seviyeye geçebilmek için toplam 20 sorudan en az 11 tanesini doğru
cevaplamalıdır. Verilen doğru cevap sayılarına göre seviyeden geçişlere yıldız
verilmektedir. [11-15] – [16-18] ve [19-20] . Ayrıca soruların zorluk
derecesine göre puan verilmektedir.

✓ Her seviye için belirli bir süre verilmekte ve skor listesi tutulmaktadır ve bilgiler bir
dosyada saklanmaktadır. Oyun kapatılıp yediden başlandığında kalınan seviden devam
edilebilmektedir.

✓ Seviye atlandıkça işlemlerin basamak sayısı ve süre makul derecede artmaktadır. 
![](https://github.com/unalsemih/repo-images/blob/master/mathgame.png?raw=true)

✓ Programın kontrolünü kolaylaştırmak amacıyla, bir hile eklenmesi istenmiştir. Oyun komut satırından “Matematikoyunu.exe open x” şeklinde çalıştırıldığında istenilen seviyenin kilidi açık olarak başlamalıdır. x, değişkeni 2-3-4-5 veya “all”
değerlerini alabilir. Girilen değere göre seviye atlanmaktadır.

## 3) Number Finding Game
✓ Kullanıcıların uygulamada istenilen sayıyı, verilen hak ve süre içerisinde bulması istenilen bir oyundur.

✓ Kullanıcı sayıyı bulmasına yardımcı olmak için yerinde olanlara mavi renk; yerinde
olmayıp içinde geçen sayılara kırmızı renk ile işaretlenmektedir.
![](https://github.com/unalsemih/repo-images/blob/master/numbergame.png?raw=true)

✓ Skor listesi ve gerekli bilgiler bir dosyada tutulmaktadır.
![](https://github.com/unalsemih/repo-images/blob/master/numbergameGiris.png?raw=true)



## 4) Memory Game
✓ Oyuna hafızaya dayanmakta ve 2 oyuncu ile oynanmaktadır. Ekrana matris şeklinde
rasgele dağılmış şekilde 20 çift resim gelecek ve 5 saniye bekledikten sonra kapanarak;
birinci oyuncu oyuna başlayacaktır.

✓ Mouse ile seçilen birinci resim 5 saniyeliğine açılır ve bu süre içinde oyuncunun 2.resmi
seçmesi beklenir.

![](https://github.com/unalsemih/repo-images/blob/master/memorygame.png?raw=true)

✓ Süre içinde 2.resmi seçemez veya 1.resmin çiftini bulamaz ise sıra ikinci oyuncuya
geçer. Aksi halde; birinci oyuncu puan alarak devam eder.

✓ Tüm resim çiftleri bulunduğunda veya oyunculardan biri 11 çift resme ulaştığında oyun
bitmiş olur.
