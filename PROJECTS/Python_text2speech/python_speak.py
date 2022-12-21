#Comment: must install Text to Speech library for python first.  https://pypi.org/project/pyttsx3/ or type in console pip install pyttsx3

import pyttsx3

engine = pyttsx3.init()
engine.say('hello world')
print('hello world')
engine.runAndWait()