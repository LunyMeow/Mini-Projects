import keyboard  # using module keyboard
import pyautogui
import time

from win10toast import ToastNotifier

toaster = ToastNotifier()

print("Hold \" to open autoclick")
print("Hold again \" to close autoclick")

aaa=False
while True:  # making a loop
    try:  # used try so that if user pressed other than the given key error will not be shown
        if keyboard.is_pressed('"'):  # if key pressed 
            if aaa==True:
                aaa=False
                toaster.show_toast("False")
                time.sleep(1)
            else:
                aaa=True
                toaster.show_toast("True")
                time.sleep(1)
        if aaa==True:
            pyautogui.click()
    except:
        pass
