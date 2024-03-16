import random
import sys
import os
import time

#to use this program as module do this:
#first take user user choice or take whatever : user_choice="[rock,paper,sci]"
#and add the choice to list a.append(user_choice) (the ai taking information from here)
#than play(guessuser(),user_choice)

#if you dont wanna play just wanna guess the user do this:
#guessuser(listofuserschoices)
#if you wanna know how many time user play rock:
#findlocations(list,"rock")
choices = ['rock', 'paper', 'sci']  
userp=0
ai=0
if __name__=='__main__':
    debug=False
    osis = "windows" if os.name == "nt" else "notwindows"
    sindex=int(input("Select weird number \"The less the smarter\" (3-100)..:"))
    if len(sys.argv)>1:
        debug=True if sys.argv[1] == "-d" else False
else:
        sindex=5
        debug=False


def play(a,user): #a is for winning
	global userp,ai
	computer_choice=a if a!=None else  random.choice(choices)
	print("Computer is ",computer_choice)
	print("You are ",user)
	if computer_choice == user_choice:
		print('Tie')
	elif user_choice == 'rock' and computer_choice == 'sci':
		print('User Win')
		userp+=1
	elif user_choice == 'paper' and computer_choice == 'rock':
		print('User Win')
		userp+=1
	elif user_choice == 'sci' and computer_choice == 'paper':
		print('User Win')
		userp+=1
	else:
		print('Ai smarter than you :)')
		ai+=1
	print(f"User :{userp}")
	print(f"AI   :{ai}")

a=[] # i guess this list is users moves

def findlocations(list,item):
	t=0
	lista=[]
	for i in list:
		if i==item:
			lista.append(t)
		t+=1
	return lista
def guessuser(userlist=[]): 
    global a
    if len(userlist)!=0:
        a=userlist
    rockp=0
    paperp=0
    scip=0
	
    rockafterpaper=0
    rockaftersci=0
    rockafterrock=0

    paperafterrock=0
    paperafterpaper=0
    paperaftersci=0

    sciafterpaper=0
    sciafterrock=0
    sciaftersci=0
	
    timer=1 
    templist=findlocations(a,"rock")
    templist = templist[-sindex:]
    while timer<len(templist):
        if a[templist[timer]-1]=="paper":
            rockafterpaper+=1
        elif a[templist[timer]-1]=="rock":
            rockafterrock+=1
        elif a[templist[timer]-1]=="sci":
            rockaftersci+=1
        timer+=1
		
	
    timer=1 
    templist=findlocations(a,"paper")
    templist = templist[-sindex:]
    while timer<len(templist):
        if a[templist[timer]-1]=="paper":
            paperafterpaper+=1
        elif a[templist[timer]-1]=="rock":
            paperafterrock+=1
        elif a[templist[timer]-1]=="sci":
            paperaftersci+=1
        timer+=1
    timer=1 
    templist=findlocations(a,"sci")
    templist = templist[-sindex:]
    while timer<len(templist):
        if a[templist[timer]-1]=="paper":
            sciafterpaper+=1
        elif a[templist[timer]-1]=="rock":
            sciafterrock+=1
        elif a[templist[timer]-1]=="sci":
            sciaftersci+=1
        timer+=1
    if paperafterrock>paperafterpaper and paperafterrock>paperaftersci:
        rockp=paperafterrock
    elif paperafterpaper>paperaftersci and paperafterpaper>paperafterrock:
        paperp=paperafterpaper
    elif paperaftersci>paperafterrock and paperaftersci>paperafterpaper:
        scip=paperaftersci

    if rockafterrock>rockafterpaper and rockafterrock>rockaftersci:
        rockp=rockafterrock
    elif rockafterpaper>rockaftersci and rockafterpaper>rockafterrock:
        paperp=rockafterpaper
    elif rockaftersci>rockafterrock and rockaftersci>rockafterpaper:
        scip=rockaftersci

    if sciafterrock>sciafterpaper and sciafterrock>sciafterrock:
        rockp=sciafterrock
    elif sciafterpaper>sciafterrock and sciafterpaper>sciaftersci:
        paperp=sciafterpaper
    elif sciaftersci>sciafterrock and sciaftersci>sciafterpaper:
        scip=sciaftersci

    if debug:
        #print(f"Paper {round(paperp,3)}: Rock {round(rockp,3)}: Sci {round(scip,3)}")
        print(f"{rockp} {paperp} {scip}")
        print(f"""
        "After Rock"     "After Sci"     "After Paper"
Paper :      {paperafterrock}           {paperaftersci}        {paperafterpaper}
Rock  :      {rockafterrock}           {rockaftersci}        {rockafterpaper}
Sci   :      {sciafterrock}           {sciaftersci}        {sciafterpaper}

""")
  
  
    if rockp>paperp and rockp > scip:
        return "paper"
    elif paperp > rockp and paperp > scip:
        return "sci"
    elif scip > rockp and scip > paperp:
        return "rock"
    else:
        print("random")
        return random.choice(choices)#i added this because i dont know but without this, game cant decide 
	
	
def guessuserv2(userlist=[]):
    import tensorflow as tf
    import numpy as np

    oyuncu_hamleleri=["rock","paper","sci"]
    sonraki_hamleler=["paper","sci","rock"]
    
    def ozellik_hedef_ayırma(hamleler):
        ozellikler=[]
        hedef=[]

        for i in range(len(hamleler)-5):
             ozellikler.append(hamleler[i:i+5])
             hedef.append(hamleler[i+5])
             return np.array(ozellikler), np.array(hedef)
    ozellikler,hedef = ozellik_hedef_ayırma(userlist)

    model=tf.keras.Sequential([
         tf.keras.layers.Embedding(input_dim=3,output_dim=10),
         tf.keras.layers.GlobalAveragePooling1D(),
         tf.keras.layers.Dense(3,activation='softmax')
    ])

    model.compile(optimizer='adam',loss='sparse_categorical_crossentropy',metrics=['accuary'])
    model.fit(ozellikler,hedef,epochs=10,batch_size=32,validation_split=0.2)

    yeni_oyuncu_hamleleri = np.array([userlist])
    tahmin=model.predict(yeni_oyuncu_hamleleri)
    return tahmin
    
	





while __name__== '__main__':
	#user_choice=random.choice(choices)
	#time.sleep(0.05)
        user_choice = input("Enter rock, paper, or sci:\n")
        if osis == "windows":
            os.system("cls")
        else:
            os.system("clear")
        
        play(guessuser(),user_choice)
        a.append(user_choice)


