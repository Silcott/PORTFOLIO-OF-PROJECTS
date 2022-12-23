# import pyttsx3, PyPDF2


# pdfreader = PyPDF2.PdfFileReader(open('book.pdf',  'rb'))
# speaker = pyttsx3.init()

# for page_num in range(pdfreader.numPages):
    # text = pdfreader.getPage(page_num).extractText()
    # clean_text = text.strip().replace('\n', ' ')
    # print(clean_text)

# speaker.save_to_file(clean_text, 'story.mp3')
# speaker.runAndWait()

# speaker.stop()

###############################################################

#How to add more voices to microsoft win11
#1. Win + Ctrl + N : this takes you to the Narrator settings page
#2. Select "Add voices" to be taken to the Speech Settings page
#3. Select "Add voices" under the Manage Voices 
#4. Choose any languages you want to add - ex I choose all English, then click Add
#5. Goto your registry : Windows Key + R, type in regedit and press enter
#6. Goto Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech_OneCore\Voices\Tokens\
#7. You should see all the voices you added
#8. Goto Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech\Voices\Tokens
#9. These are all the ones available that your computer can access, so if the voices from the other dir aren't loaded, you'll need to continue
#10. Go back to the Speech_OneCore voices and right-click a voice you want to add
#11. Select export, rename addVoice.reg to your desktop
#12. Goto desktop and open the file with notepad
#13. CTRL + F to find and replace the words Speech_OneCore to be Speech
#14. Save file and close notepad
#15. Double click the addVoice.reg file to open.  Allow any changes and the new voice is added.

###############################################################

#This will find all the voices and their index numbers
#import pyttsx3
#engine = pyttsx3.init()
#voices = engine.getProperty('voices')
#index = 0
#for voice in voices:
#   print(f'index-> {index} -- {voice.name}')
#   index +=1
#engine.runAndWait()

###############################################################

#-List of speech voices-

#index-> 0 -- Microsoft David Desktop - English (United States)
#index-> 1 -- Microsoft James - English (Australia)
#index-> 2 -- Microsoft Linda - English (Canada)
#index-> 3 -- Microsoft Richard - English (Canada)
#index-> 4 -- Microsoft George - English (United Kingdom)
#index-> 5 -- Microsoft Hazel - English (United Kingdom)
#index-> 6 -- Microsoft Susan - English (United Kingdom)
#index-> 7 -- Microsoft Sean - English (Ireland)
#index-> 8 -- Microsoft Heera - English (India)
#index-> 9 -- Microsoft Ravi - English (India)
#index-> 10 -- Microsoft Mark - English (United States)
#index-> 11 -- Microsoft Hazel Desktop - English (Great Britain)
#index-> 12 -- Microsoft Catherine - English (Australia)
#index-> 13 -- Microsoft Zira Desktop - English (United States)

###############################################################

#-Test and listen to each voice say its index number and name plus origin-

#import pyttsx3

#engine = pyttsx3.init()
#voices = engine.getProperty('voices')
#index = 0
#for voice in voices:
#   currentVoiceName = f'index-> {index} -- {voice.name}'
#   print(currentVoiceName)
#   engine.setProperty('voice', voices[index].id)

#   indexRemovedChar = currentVoiceName.replace("->", " ").replace("-- Microsoft", " ")
#   engine.say("hello I am" + str(indexRemovedChar) + "the voice from your PC")
#   engine.runAndWait()
#   index +=1

###############################################################

import pyttsx3, PyPDF2

engine = pyttsx3.init()
voices = engine.getProperty('voices')
#Choose the index number of the voice you want and insert it below
engine.setProperty('voice', voices[12].id)

pdfreader = PyPDF2.PdfFileReader(open('book.pdf',  'rb'))
speaker = pyttsx3.init()

for page_num in range(pdfreader.numPages):
    text = pdfreader.getPage(page_num).extractText()
    clean_text = text.strip().replace('\n', ' ')
    print(clean_text)

speaker.save_to_file(clean_text, 'story.mp3')
speaker.runAndWait()

speaker.stop()

###############################################################