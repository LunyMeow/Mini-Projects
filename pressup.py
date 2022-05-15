import os
try:
	import keyboard
except ImportError :
	os.system("pip install keyboard")
	import keyboard
import time

while True:
	if keyboard.read_key() == ".":
        
		time.sleep(0.2)
		if keyboard.is_pressed('.'):  
			keyboard.press("Backspace")
			keyboard.release('Backspace')
			keyboard.press("Up")
			keyboard.release('Up')
			time.sleep(0.2)
		else:
			print("31")
