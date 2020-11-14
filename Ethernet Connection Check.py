import time 
import winsound
try:
    import httplib
except:
    import http.client as httplib
    print("Import hatası \nİkinci seçenek denendi Başarılı")
hata=int(0)
denemesayısı=0
while 1:
    def checkInternetHttplib(url="www.google.com", timeout=3):
        try:
            print("Bağlantı sağlanıyor")
            conn = httplib.HTTPConnection(url, timeout=timeout)
        except Exception as a:
            print("Kritik Hata :",a)
        try:
            print("Bilgiler alınıyor")
            conn.request("HEAD", "/")
            conn.close()
            print("Bağlantı başarılı")            
            
        except Exception as e:
            try:
                global hata
                hata+=1               
            except:
                print("Hata değeri arttırılamadı")
            try:
                
                print("Bağlantı hatası \nNedeni : " + str(e) + "\nToplam hata sayısı :" + str(hata) +"")
            except Exception as b:
                print("Hata yazdırılamadı : ",b)
            try:
                winsound.PlaySound("SystemError", winsound.SND_ALIAS)
            except:
                print("Ses çalınamadı")
            
    print()
    denemesayısı+=1
    print("Deneme :" , denemesayısı)
    checkInternetHttplib()
    time.sleep(5)
input()