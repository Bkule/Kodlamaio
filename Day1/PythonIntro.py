# Kodlama.io sistemimizde detaylı bir gezinti yapınız.
# Sistemde şart blokları, döngüler ve fonksiyon(metot) olarak kullanıldığını düşündüğünüz kısımlar için aynen eğitimde yaptığımız gibi repl.it'de kodlar yazınız.
# Örneğin : Kurslar List formatındadır. Bunun simulasyonunu yapınız.


def giriskontrol(kullaniciadi, parola):
    kullanicilarListesi = ["Ahmet", "Mehmet", "Osman"]
    parolaListesi = ["ahmetinsifresi", "mehmetinsifresi", "osmaninsifresi"]
    kontrolAd = True
    kontrolSifre = True
    kontrolNumaraAd = 0
    kontrolNumaraSifre = 0


    for i in range(0,len(kullanicilarListesi)):
        kullanici = kullanicilarListesi[i]
        if (kullaniciadi == kullanici):
            kontrolAd = True
            kontrolNumaraAd = i
            break
        else:
            kontrolAd = False

    for i in range(0,len(parolaListesi)):
        sifre = parolaListesi[i]
        if (sifre == parola):
            kontrolSifre = True
            kontrolNumaraSifre = i
            break
        else:
            kontrolSifre = False
    
    if(kontrolAd == True and kontrolSifre == True and kontrolNumaraAd == kontrolNumaraSifre):
        print("Giriş yapıldı.")
    else:
        print("Hatalı giriş.")

def kurslarListe():
    kurslarBlok= ["Ders Programı", "Gün sonu Kayıt", "Ödev1", "Ödev2", "Değerlendirme"]
    for i in range(1,17):
        print(i, ".", "Gününcü kurslar:")
        for x in range(0,len(kurslarBlok)):
            if x == 1:
                print(i, ".", kurslarBlok[x])
            else:
                print(kurslarBlok[x])


kullaniciadi = input("Lütfen kullanıcı adınızı giriniz: ")
parola = input("Lütfen parolanızı giriniz: ")
giriskontrol(kullaniciadi, parola)

kurslarListe()