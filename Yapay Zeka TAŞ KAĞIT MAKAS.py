print("Proje Adı..:         AI ile destekli taş kağıt makas")
print("Proje Açıklaması..:  Basit bir yapay zeka ile taş kağıt makas oyununu iki basit yapay zeka oyunu ile testetmek")
print("Proje başlatılıyor")
print("------------------------------------")
print("Değişkenler oluşturuluyor...")
import os
import random
import time
from getpass import getpass

ikincioyuncugirişi=None

öğrenildi=False




def Menü():
    print("Oyun türünü seçmek için aşağıdaki seçeneklerden birini giriniz.")
    print("1: Kullanıcı vs AI")
    print("2: Kullanıcı vs Kullanıcı")
    #print("3: Kendi Kendine Öğrenme")
    oyuntürü=int(input("Seçiminizi Giriniz..:"))
    if oyuntürü==1:
        KullanıcıvsAI()
    elif oyuntürü==2:
        KullanıcıvsKullanıcı()
def AIWinKontrol(a,b):
    cevap=None
    if a=="Tas":
        if b=="Makas" or b=="Makas'":
            cevap= False
        elif b=="Kagit" or b=="Kagit'":
            cevap= True
        elif b=="Tas"or b=="Tas'":
            cevap= False
    elif a=="Kagit":
        if b=="Tas"or b=="Tas'":
            cevap= False
        elif b=="Kagit"or b=="Kagit'":
            cevap= False
        elif b=="Makas"or b=="Makas'":
            cevap= True
    elif a=="Makas":
        if b=="Tas"or b=="Tas'":
            cevap= True
        elif b=="Kagit"or b=="Kagit'":
            cevap= False
        elif b=="Makas"or b=="Makas'":
            cevap= False
    return cevap
    
def KullanıcıvsAI():
    global taşçıkarsa
    global kağıtçıkarsa
    global makasçıkarsa
    global öğrenildi
    global debug
    debug=input("Oyunda debug penceresi gösterilsin mi? Varsayılan Kapalı \nAçmak için E ye basın geçmek için direk enter..:")
    
    if taşçıkarsa!=None and kağıtçıkarsa!=None and makasçıkarsa!=None:
        öğrenildi=True
    print("Kullanıcı vs AI seçildi")
    print("Gerekli bilgiler oluşturuluyor")
    
    if öğrenildi==False:
        devam =input("AI daha oyunu tam olarak öğrenemedi yinede devam etmek istiyormusunuz?..  E/H  :")
        if devam=="H":
            print("Oyun iptal edildi \nMenüye dönülüyor")
            time.sleep(3)
            os.system("cls")
            Menü()
    AIGame()        
    
    



def Denedikmi(a):
    t=False
    k=False
    m=False
    
    cevap=None
    if a=="Tas":
        if t==False:
            cevap=False
            t=True
        else:
            cevap=True
    elif a=="Kagit":
        if k==False:
            cevap=False
            k=True
        else:
            cevap=True
    elif a=="Makas":
        if m==False:
            cevap=False
            m=True
        else:
            cevap=True
     
    if a=="TasÇek":
        t=False
    if a=="KagitÇek":
        k=False
    if a=="MakasÇek":
        m=False
    
    return cevap
        
   
        


taşçıkarsa=None
makasçıkarsa=None
kağıtçıkarsa=None
debug="H"

kimkazandi=None
td=None
def AICevap(kullanıcıgirişi):
    if kullanıcıgirişi=="":
        os.system("cls")
        Menü()
    AIcevabı=None
        
    global taşçıkarsa
    global makasçıkarsa
    global kağıtçıkarsa
    
    global kimkazandi
    
    global td

    global debug
    
    
    
    while True:
        cevap=random.randint(0,3)
        
        if kullanıcıgirişi=="Tas" and taşçıkarsa!=None:
            AIcevabı=taşçıkarsa
            break
        elif kullanıcıgirişi=="Kagit" and kağıtçıkarsa!=None:
            AIcevabı=kağıtçıkarsa
            break
        elif kullanıcıgirişi=="Makas" and makasçıkarsa!=None:
            AIcevabı=makasçıkarsa
            break
        
        #Hata: Kagit yazdğımızda makas seçeneği çıkmıyor  NEDEEENNN??
        td=Denedikmi(kullanıcıgirişi)
        if cevap==0 :
            if taşçıkarsa==None or not td :
                AIcevabı="Tas"    
            else:
                AIcevabı=taşçıkarsa
            break
        if cevap==1:
            if kağıtçıkarsa==None or not td:
                AIcevabı="Kagit"    
            else:
                AIcevabı=kağıtçıkarsa
            break
        if cevap==2:
            if makasçıkarsa==None or not td:
                AIcevabı="Makas"    
            else:            
                AIcevabı=makasçıkarsa
            break
    
        
    kazandımı=None
    
    if AIWinKontrol(kullanıcıgirişi,AIcevabı):
        kazandımı=True
        if (kullanıcıgirişi=="Tas" or kullanıcıgirişi =="Tas'") and taşçıkarsa==None:
            taşçıkarsa=AIcevabı+"'"
            Denedikmi("TasÇek")
            kimkazandi="T"
        if (kullanıcıgirişi=="Kagit" or kullanıcıgirişi =="Kagit'") and kağıtçıkarsa==None:
            kağıtçıkarsa=AIcevabı+"'"
            Denedikmi("KagitÇek")
            kimkazandi="K"
        if (kullanıcıgirişi=="Makas" or kullanıcıgirişi =="Makas'") and makasçıkarsa==None:
            makasçıkarsa=AIcevabı+"'"
            Denedikmi("MakasÇek")
            kimkazandi="M"
            
    if debug=="E":        
        print("Debug Penceresi..... \nMakasÇıkarsa..:{}  \nKagitÇıkarsa..:{} \nTasÇıkarsa..:{} \nAICevap..:{}  \ncevap..:{} \nKazndımı..:{}  \nKim Kazandı..:{}  \ntd..:{}".format(makasçıkarsa,kağıtçıkarsa,taşçıkarsa,AIcevabı,cevap,kazandımı,kimkazandi,td)) 
    print()    
    return AIcevabı
    
def Exit():
    print("Oyunu yüklediğiniz için teşekkürler.\nSonra görüşürüz.")


def AIGame():
    print("Kullanıcı vs AI seçildi öğrenme başlatılıyor.")
    print("Bu kısımda oyunu kaybetmeniz tamamen normal azami öğrenme sayısı 6 oyun.")
    print("Oyun başlasın :)")
    os.system("cls")
    print("Oyun kuralları belli.")
    print("Korkar ve oyundan çıkmak istersen cevabını boş bırakabilirsin. ;)")
    print("-----------------")
    print("Tas \nKagit \nMakas \nSeçeneklerin bunlar")
    print("Başladı")
    print("***********************************")
    
    while True:
        ilkoyuncugirişi=input("Lütfen cevabını gir..:")
        if ilkoyuncugirişi==None:
            break
        else:
            print("AI Cevap..:"+AICevap(ilkoyuncugirişi))
    
def KullanıcıvsKullanıcı():
    print("Oyun kuralları basit.")
    print("Seçiminiz tamamen gizli kalacaktır.")
    print("Boş bırakarak menüye çıkabilirsiniz")
    print("Oyun başladı.")
    print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-")
    while True:
        os.system("cls")
        print("1) Taş \n2) Kağıt \n3) Makas") # Devam et
        print("********************************************")
        print("Siz yazarken yazı otomatik gizlenir!!")
        print("Sayısal değerleri giriniz")
        print("********************************************")
        print("")
        ilkkul=getpass("İlk Kullanıcı giriş yapsın..:") 
        print("")
        ikincikul=getpass("İkinci kullanıcı giriş yapsın..:")
        
        if ilkkul=="1":
            ilkkul="Tas"
        elif ilkkul=="2":
            ilkkul="Kagit"
        elif ilkkul=="3":
            ilkkul="Tas"
        
        if ikincikul=="1":
            ikincikul="Tas"
        elif ikincikul=="2":
            ikincikul="Kagit"
        elif ikincikul=="3":
            ikincikul="Tas"
        
        
        if AIWinKontrol(ilkkul,ikincikul):
            print("İkinci kullanıcı kazandı!!")
        else:
            print("Birinci kullanıcı kazandı!!")
        print("")
        print("")
        input("Devam etmek için bir tuşa basın.")
        
        
        
        
        
        
        
        
        
        
        
    
Menü()
input()