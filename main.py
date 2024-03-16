import game
import random
import matplotlib.pyplot as plt
data=[]

data =['rock', 'paper', 'sci', 'rock', 'sci', 'rock', 'paper', 'rock', 'paper', 'rock', 'paper', 'sci', 'paper', 'rock', 'rock', 'paper', 'rock', 'paper', 'sci', 'sci', 'paper', 'rock', 'paper', 'rock', 'paper', 'rock', 'sci', 'paper', 'sci', 'paper', 'rock', 'rock', 'paper', 'rock', 'sci', 'paper']

"""
for i in range(100):
  data.append(random.choice(["rock","paper","sci"]))
"""

"""
aidata=[] #the ais guesses
for i in data:
  next=game.guessuser(i)
  aidata.append(next)

"""

for i in range(10):
    a=game.guessuser(data)
    print(a)
    data.append(a)

exit()



x=range(1,len(data)+1)
y=[1 if move == "rock" else 2 if move == "paper" else 3 for move in data]
aidata=[1 if move == "rock" else 2 if move == "paper" else 3 for move in aidata]

def calculatebrain():
  _=0
  for i in range(len(data)):
    
    if y[i]==aidata[i]:
      _+=1
  print(_)
  print(len(data))
  return (_*100/len(data))

print(calculatebrain())


plt.figure(figsize=(10,3))

for i in range(len(data)):
  plt.scatter(x[i],y[i],color='blue')
  plt.axvline(x=36,color="black")
  plt.scatter(x[i],aidata[i],color="red",edgecolor="white") #for ais input
  if i<len(data)-1:
    plt.plot([x[i],x[i+1]],[y[i],y[i+1]],color="green")
plt.xticks(x)
plt.yticks([1,2,3],["Taş","Kağıt","Makas"])
plt.plot(x,y,'m.')
plt.show()

