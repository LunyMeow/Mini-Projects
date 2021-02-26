import tkinter
from tkinter import *
import tkinter.font as font
from tkinter import font as tkFont
from tkinter import ttk
from tkinter import messagebox
import tkinter as tk
import speech_recognition as sr
import time
import datetime
import pyautogui


import __future__
#from __future__ import logyazdır_function
from pycaw.pycaw import AudioUtilities, ISimpleAudioVolume
import threading            #arkaplan işlevi


def logyazdır(text,kayıt=True):
    an = datetime.datetime.now()
    saat="Saat..:"+str(an.hour)+"."+str(an.minute)+"."+str(an.second)
    
    print(str(text))
    if kayıt:        
        print(saat)




çıktı=""
def callback(recognizer, audio):                         
    try:        
        çıktı = recognizer.recognize_google(
            audio, 
            language="tr-TR"
        )
        var.set("Komut..:" + çıktı)  
        kelimeler=çıktı.split(" ")
        logyazdır("Kelimeler..:"+kelimeler,False)
        cevapver(çıktı)
    except Exception as e:            
        print("Hata"+str(e))
    except sr.UnknownValueError:
        car.set("Anlayamadım :(")
    
r = sr.Recognizer()
mic=sr.Microphone()


def listen():
    
    if var1.get()==0:
        logyazdır("Komut yazı olarak alındı...")
        var.set("Komut yazı olarak alındı...")
        logyazdır(E1.get(),False)
        if cevapver(E1.get())==False:
            logyazdır("Anlaşılmadı",False)
            var.set("Anlaşılmadı")  #
    else:
        var.set("Dinliyor...")
        r.listen_in_background(sr.Microphone(), callback)
    
      

def cevapver(kod):
    if kod.find("ses")!=-1 or kod.find("Ses")!=-1:
        print("ses menüsü")
        var2.set("Ses Menüsü Seçildi")
        var2.set(sesmenüsü(kod))
        
    


    

    

#index = sesler.index(aaaaa)            #Liste içinde arama
#print(index)



kelimeler=[]

#Komutlar






        
        
        

def sesmenüsü(kod):
    if kod.find("yükselt")!=-1 or kod.find("arttır")!=-1:   
        w1.set(0)
        logyazdır("ses +",True)
        return ""
    elif kod.find("azalt")!=-1 or kod.find("alçalt")!=-1:
        w1.set(0.6)
        logyazdır("ses -",True)
        return ""
    elif kod.find("kıs")!=-1 or kod.find("Kıs")!=-1:
        w1.set(0.6)
        logyazdır("ses -",True)
        return ""
    elif kod.find("aç")!=-1 or kod.find("Aç")!=-1:
        w1.set(0)
        logyazdır("ses +",True)
        return ""
    elif kod.find("kapat")!=-1 or kod.find("Kapat")!=-1:
        w1.set(1)
        logyazdır("ses 0",True)
        return ""
    elif kod.find("kapa")!=-1 or kod.find("Kapa")!=-1:
        w1.set(1)
        logyazdır("ses 0",True)
        return ""
    
    return "Ses konusunda yapacağım şeyi anlamadım"                     #Bu sürekli yazılıyor













#Komutlar sonu

def sesayarla(ses,app):                                                         
    sessions = AudioUtilities.GetAllSessions()
    for session in sessions:
        volume = session._ctl.QueryInterface(ISimpleAudioVolume)                                
        if session.Process and app=="Hepsi":                                              
            print("volume.GetMasterVolume(): %s" % volume.GetMasterVolume(),False)
            volume.SetMasterVolume(1-float(ses), None)
        elif app!="Hepsi":
            print("Değiştirildi..:"+app)
            if session.Process and session.Process.name() == app:
                volume.SetMasterVolume(1-float(ses), None)
sesler=[]

def seslistele():
    sesler.clear()
    sessions = AudioUtilities.GetAllSessions()
    for i in sessions:                                                              #ses çıkaran uygulamaları listeliyor
        try:            
            sesler.append(i.Process.name())
        except:
            pass
    print(sesler)

   
    

    
    


def sel(aa):
    logyazdır("Seçili..:"+my_listbox.get(ACTIVE),False)                                                
    sesayarla(ses=aa,app=my_listbox.get(ACTIVE))
    
    

def method(sanane):
    sessions = AudioUtilities.GetAllSessions()
    for abc in sessions:
        volume = abc._ctl.QueryInterface(ISimpleAudioVolume)        
        if my_listbox.get(ACTIVE)!="Hepsi" and type(abc.Process)!=type(None):        
            if  abc.Process.name() == my_listbox.get(ACTIVE):
                w1.set(float(1-volume.GetMasterVolume()))
                logyazdır("Orjinal ses seviyesi..:"+str(volume.GetMasterVolume()),False)
    
    seslistele()
    
    
seslistele()










def update():
    my_listbox.delete(1,END)
    seslistele()
    for item in sesler:
        my_listbox.insert(END, item)
    


window = Tk()

window.title("Test")
window.geometry("400x200")
window.configure(background='black')



my_listbox=Listbox(window,width=10,font=("",37),height=4,relief=RAISED)
my_listbox.bind("<<ListboxSelect>>", method)
my_listbox.place(x=150,y=400)
my_listbox.insert(1, "Hepsi") 


updatebtn = Button(window, text="Update", width=20, height=1, command=update,bg='#13bc07', fg='#ffffff',font=("",15)).place(x=150, y=350)

def logyazdır_selection():
    logyazdır("CheckBox Değeri..:"+str(var1.get()),False)
    

var1 = tkinter.IntVar()
var1.set(1)
c1 = tkinter.Checkbutton(window, text='Mic Açık',variable=var1, onvalue=1, offvalue=0, command=logyazdır_selection)
c1.place(x=620,y=285)









def ButtonFunc():
    tkinter.messagebox.showinfo(title="Message", message="Hello World")
 
myFont = font.Font(size=30)

actionBtn = Button(window, text="Enter", width=20, height=5, command=ButtonFunc,bg='#13bc07', fg='#ffffff',font=myFont).place(x=140, y=20)

actionBtn = Button(window, text="Mark'a selam ver", width=18, height=5, command=listen,bg='#000000', fg='#ffffff',font=myFont).place(x=620, y=20)




    
    



w1 = Scale(window, from_=0, to=1,command=sel,background='gray',showvalue=0,resolution=0.01,sliderrelief=RAISED,borderwidth=15,width=50,sliderlength=80)
w1.place(bordermode=INSIDE , height=600, width=100 ,x=30,y=30)

var = StringVar()
label = Label( window, textvariable=var, relief=RAISED )
label.config(font=("Courier", 22))

var.set("Komut..:")
label.place(x=500,y=560)

E1 = Entry(window, bd =5)
E1.place(x=500,y=640)


var2 = StringVar()
label2 = Label( window, textvariable=var2, relief=RAISED )

var2.set("")
label2.place(x=500,y=605)
label2.config(font=("Arial", 22))
label2.config(bg="black")
label2.config(fg="#ffffff")




window.mainloop()

