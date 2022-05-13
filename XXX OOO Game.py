from tkinter import *
import random


root = Tk()
frm = Frame(root)
frm.grid()


p1skor=0
p2skor=0

playerturn="p1"


    

plyr1=None
plyr2=None
player1chc=None
player2chc=None
def setPlayers():
    global plyr1,plyr2,player1chc,player2chc
    plyr1=Label(frm,text=f"Oyuncu 1..:{p1skor}",bg="green")
    plyr1.grid(column=1,row=0)
    player1chc=Label(frm,text="X")
    player1chc.grid(column=1,row=1)
    plyr2=Label(frm,text=f"Oyuncu 2..:{p2skor}",bg="red")
    plyr2.grid(column=3,row=0)
    player2chc=Label(frm,text="O")
    player2chc.grid(column=3,row=1)



setPlayers()


btnsnmr=[]
btnscoordinates=[[1,2],[1,3],[1,4],[2,2],[2,3],[2,4],[3,2],[3,3],[3,4]]
btns=[]

wintxt=None

def changeButtonOnOff(arg):
    for i in btns:
        if arg:
            i.config(state = NORMAL)
        else:
            i.config(state=DISABLED)

def resetgame():
    global p1skor,p2skor
    print("Sıfırlandı")
    for i in range(len(btns)):
        btns[i].config(text='')

def startgame():
    global wintxt
    print("Yeni Oyun Başladı")
    if wintxt:
        wintxt.destroy()
    changeButtonOnOff(True)
    player1chc.config(text="X")
    player2chc.config(text="O")
    resetgame()


def updatePoint():
    global plyr1,plyr2,p1skor,p2skor
    plyr1.config(text=f"Oyuncu 1..:{p1skor}")
    plyr2.config(text=f"Oyuncu 2..:{p2skor}")

def winnerMessage(who,text="!!Kazanan Oyuncu {}!!"):
    global wintxt
    wintxt=Label(frm,text=text.format(1 if who=="X" else 2),bg="lime",width=20,height=3, font = ("Rockwell", 13))
    wintxt.place(x=146,y=110)
    

def kazanan(a):
    global p1skor,p2skor
    
    if a=="X":
        p1skor+=1
        winnerMessage("X")
        changeButtonOnOff(False)
    elif a=="O":
        p2skor+=1
        winnerMessage("O")
        changeButtonOnOff(False)
    updatePoint()

def draws():
    winnerMessage("XY",text="Berabere")

def kontrol():
    if btns[0].cget('text')=="X" and btns[1].cget('text')=="X" and btns[2].cget('text')=="X":
            return "X"
    if btns[3].cget('text')=="X" and btns[4].cget('text')=="X" and btns[5].cget('text')=="X":
            return "X"
    if btns[6].cget('text')=="X" and btns[7].cget('text')=="X" and btns[8].cget('text')=="X":
            return "X"

    if btns[0].cget('text')=="O" and btns[1].cget('text')=="O" and btns[2].cget('text')=="O":
            return "O"
    if btns[3].cget('text')=="O" and btns[4].cget('text')=="O" and btns[5].cget('text')=="O":
            return "O"
    if btns[6].cget('text')=="O" and btns[7].cget('text')=="O" and btns[8].cget('text')=="O":
            return "O"
    #
    
    if btns[0].cget('text')=="X" and btns[3].cget('text')=="X" and btns[6].cget('text')=="X":
            return "X"
    if btns[1].cget('text')=="X" and btns[4].cget('text')=="X" and btns[7].cget('text')=="X":
            return "X"
    if btns[2].cget('text')=="X" and btns[5].cget('text')=="X" and btns[8].cget('text')=="X":
            return "X"

    if btns[0].cget('text')=="O" and btns[3].cget('text')=="O" and btns[6].cget('text')=="O":
            return "O"
    if btns[1].cget('text')=="O" and btns[4].cget('text')=="O" and btns[7].cget('text')=="O":
            return "O"
    if btns[2].cget('text')=="O" and btns[5].cget('text')=="O" and btns[8].cget('text')=="O":
            return "O"
    
    #
    
        
    if (btns[0].cget('text')=="X" and btns[4].cget('text')=="X" and btns[8].cget('text')=="X"):
        return "X"
    if (btns[0].cget('text')=="O" and btns[4].cget('text')=="O" and btns[8].cget('text')=="O"):
        return "O"
    
    if (btns[6].cget('text')=="X" and btns[4].cget('text')=="X" and btns[2].cget('text')=="X"):
        return "X"
    if (btns[6].cget('text')=="O" and btns[4].cget('text')=="O" and btns[2].cget('text')=="O"):
        return "O"
    
    s=0
    for i in btns:
        if i.cget('text')!='':
            s+=1
            if s==9:
                draws()
            
            
    
    

def OnClick(button):
    global plyr1,plyr2,playerturn
    
    if button.cget('text') == '':
        if playerturn=="p1":
            button.config(text="X")
            plyr1.config(bg="red")
            plyr2.config(bg="green")
            playerturn="p2"
        else:
            button.config(text="O")
            plyr1.config(bg="green")
            plyr2.config(bg="red")
            playerturn="p1"
    
    kazanan(kontrol())
    


for i in range(9):
    btnsnmr.append(i)


s=0

def create_Buttons():
    global s
    for i in range(len(btnsnmr)):
        btns.append(Button(frm,width=10,height=3,command=lambda c=i: OnClick(btns[c])))
        btns[s].grid(column=btnscoordinates[i][0],row=btnscoordinates[i][1])
        s+=1

def resetpoint():
    global p1skor, p2skor
    p1skor=0
    p2skor=0
    global plyr1,plyr2
    plyr1.config(text=f"Oyuncu 1..:{p1skor}")
    plyr2.config(text=f"Oyuncu 2..:{p2skor}")    

strt=Button(frm, text="Yeni Oyun", command=startgame).grid(column=0, row=2)
reset=Button(frm,text="Skorları  \nSıfırla",command=resetpoint).grid(column=0,row=3)
create_Buttons()
root.mainloop()
