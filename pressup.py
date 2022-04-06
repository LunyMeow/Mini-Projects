import keyboard
import time

while True:
    if keyboard.read_key() == ".":
        
        time.sleep(0.1)
        if keyboard.is_pressed('.'):  
            
            keyboard.press("backspace")
            keyboard.press("up")
            time.sleep(0.2)
        else:
            print("31")
        
        
