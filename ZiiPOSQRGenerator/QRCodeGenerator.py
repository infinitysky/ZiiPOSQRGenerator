import tkinter as tk
import tkinter.font as tkFont
from tkinter.constants import *
from tkinter import filedialog
import qrcode
import PIL
from PIL import Image
import pathlib
from pathlib import Path
import os.path
import glob



class App:
    def __init__(self, root):
        #setting title
        root.title("QR Code Generator for General")
        #setting window size
        width=600
        height=650
        screenwidth = root.winfo_screenwidth()
        screenheight = root.winfo_screenheight()
        alignstr = '%dx%d+%d+%d' % (width, height, (screenwidth - width) / 2, (screenheight - height) / 2)
        root.geometry(alignstr)
        root.resizable(width=False, height=False)

        GLineEdit_738=tk.Text(root)
        
        GLineEdit_738["borderwidth"] = "1px"
        ft = tkFont.Font(family='Times',size=10)
        GLineEdit_738["font"] = ft
        GLineEdit_738["fg"] = "#333333"
        GLineEdit_738.place(x=50,y=40,width=510,height=500)
        GLineEdit_738.get(1.0,END)
        

        GLabel_325=tk.Label(root)
        ft = tkFont.Font(family='Times',size=10)
        GLabel_325["font"] = ft
        GLabel_325["fg"] = "#333333"
        GLabel_325["justify"] = "center"
        GLabel_325["text"] = "QR Code URL"
        GLabel_325.place(x=40,y=10,width=91,height=30)
        
        def checkOutputPath():
            currentPath = pathlib.Path(__file__).parent.resolve()
            #print(currentPath)
            
            path = str(currentPath) +'/output'
 
            # Instantiate the Path class
            obj = Path(path)
            
            # Check if path points to
            # an existing file or directory
            if obj.exists():
                files = glob.glob(path+'/*')
                for f in files:
                    os.remove(f)
            else:
                os.mkdir(path)

            
        
        #-----------------Functions---------------------------------
        def substring_after(s, delim):
            return s.partition(delim)[2]
    
        def getTextInput():
            result=GLineEdit_738.get("1.0","end").splitlines()
            return result
            
        def generateWithLogo():
            checkOutputPath()
            print("Logo")
            file_path = filedialog.askopenfilename()
            Urls=getTextInput()
            x=0
            for line in Urls:
           
                fileName=line
                #print(fileName)
                Logo_link = file_path
                logo = Image.open(Logo_link)               
                # taking base width
                basewidth = 100
                # adjust image size
                wpercent = (basewidth/float(logo.size[0]))
                hsize = int((float(logo.size[1])*float(wpercent)))
                logo = logo.resize((basewidth, hsize), Image.ANTIALIAS)
                QRcode = qrcode.QRCode(
                    error_correction=qrcode.constants.ERROR_CORRECT_H
                )
                # taking url or text
                url = line
                # adding URL or text to QRcode
                QRcode.add_data(url)
                # generating QR code
                QRcode.make()
                # taking color name from user
                QRcolor = 'Black'
                # adding color to QR code
                QRimg = QRcode.make_image(
                    fill_color=QRcolor, back_color="white").convert('RGB')
                # set size of QR code
                pos = ((QRimg.size[0] - logo.size[0]) // 2,
                    (QRimg.size[1] - logo.size[1]) // 2)
                QRimg.paste(logo, pos)
                
                # save the QR code generated
                fileName=str(x)
                QRfileName=fileName+'.png'
                
                QRimg.save('./output/'+QRfileName)
                
                print('QR code generated!')
                x=x+1
            
            
        def generateNoLogo():
            checkOutputPath()
            print("No Logo")
            Urls=getTextInput()
            
            #print(Urls)
            x=0;
            for line in Urls:
                
                fileName=line
                print(fileName)
                
                
                QRcode = qrcode.QRCode(
                    error_correction=qrcode.constants.ERROR_CORRECT_H
                )
                # taking url or text
                url = line
                # adding URL or text to QRcode
                QRcode.add_data(url)
                # generating QR code
                QRcode.make()
                # taking color name from user
                QRcolor = 'Black'
                # adding color to QR code
                QRimg = QRcode.make_image(
                    fill_color=QRcolor, back_color="white").convert('RGB')
                # set size of QR code              
                # save the QR code generated
                fileName=str(x)
                QRfileName=fileName+'.png'
                
                QRimg.save('./output/'+QRfileName)
                
                print('QR code generated!')
                x=x+1
                
        
    
        
        

        GButton_NoLogo=tk.Button(root)
        GButton_NoLogo["bg"] = "#f0f0f0"
        ft = tkFont.Font(family='Times',size=10)
        GButton_NoLogo["font"] = ft
        GButton_NoLogo["fg"] = "#000000"
        GButton_NoLogo["justify"] = "center"
        GButton_NoLogo["text"] = "Without Logo"
        GButton_NoLogo.place(x=460,y=580,width=100,height=34)
        GButton_NoLogo["command"] = generateNoLogo

        GButton_withLogo=tk.Button(root)
        GButton_withLogo["bg"] = "#f0f0f0"
        ft = tkFont.Font(family='Times',size=10)
        GButton_withLogo["font"] = ft
        GButton_withLogo["fg"] = "#000000"
        GButton_withLogo["justify"] = "center"
        GButton_withLogo["text"] = "With Logo"
        GButton_withLogo.place(x=50,y=580,width=100,height=34)
        GButton_withLogo["command"] = generateWithLogo
        
       
        
        
        
        
            
        

      

    def GButton_NoLogo_command(self):
        print("NoLogo")
        self.getTextInput()
        

    def GButton_withLogo_command(self):
        print("withLogo")
        file_path = filedialog.askopenfilename()
        
        #print(GLineEdit_738.get())

if __name__ == "__main__":
    root = tk.Tk()
    app = App(root)
    root.mainloop()
