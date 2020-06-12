import pyqrcode
import MySQLdb
import datetime
import time
now = datetime.datetime.now()

def generate_qr(string):
    print(string)
    link_to_post = string
    url = pyqrcode.create(link_to_post)
    url.png('{}.png'.format(link_to_post), scale=8)
    print("Printing QR code")
    print(url.terminal())

def test(string):
    print(string)
if __name__ == '__main__':
    
    db = MySQLdb.connect(host="localhost",          
                         user="root",               
                         passwd="usbw",            
                         db="gip")        
    cur = db.cursor()
    cur.execute("SELECT email FROM aanwezig")
    z = now.strftime("%Y-%m-%d %H:%M:%S")
    for i in cur:
        
        probeer = str(i[0])
        t = probeer +"&"+ z.replace(":","#")
        generate_qr(str(t))
             

