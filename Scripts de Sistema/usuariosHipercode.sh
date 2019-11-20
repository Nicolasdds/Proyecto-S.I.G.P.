#! /bin/bash
clear
groupadd ndiaz
groupadd gmachado
groupadd ebettinelli
groupadd nschol
groupadd hipercode_administrador
groupadd hipercode_tecnico
groupadd hipercode_asistente
groupadd hipercode_guest
useradd -g ndiaz -d /home/ndiaz -m -s /bin/bash ndiaz
useradd -g gmachado -d /home/gmachado -m -s /bin/bash gmachado
useradd -g ebettinelli -d /home/ebettinelli -m -s /bin/bash ebettinelli
useradd -g nschol -d /home/nschol -m -s /bin/bash nschol
useradd -g hipercode_administrador -d /home/hipercode_administrador -m -s /bin/bash hipercode_administrador
useradd -g hipercode_tecnico -d /home/hipercode_tecnico -m -s /bin/bash hipercode_tecnico
useradd -g hipercode_asistente -d /home/hipercode_asistente -m -s /bin/bash hipercode_asistente
useradd -g hipercode_guest -d /home/hipercode_guest -m -s /bin/bash hipercode_guest
echo 'Ingrese una contraseña para ndiaz:'
passwd ndiaz
echo 'Ingrese una contraseña para gmachado:'
passwd gmachado
echo 'Ingrese una contraseña para ebettinelli:'
passwd ebettinelli
echo 'Ingrese una contraseña para nschol:'
passwd nschol
echo 'Ingrese una contraseña para hipercode_administrador:'
passwd hipercode_administrador
echo 'Ingrese una contraseña para hipercode_tecnico:'
passwd hipercode_tecnico
echo 'Ingrese una contraseña para hipercode_asistente:'
passwd hipercode_asistente
echo 'Ingrese una contraseña para hipercode_guest:'
passwd hipercode_guest
clear
echo 'Usuarios creados exitosamente!'
tail -8 /etc/passwd
read -p "Presione una tecla para continuar..." op
clear
dbaccess - esquemaHipercodeConsola.sql
read -p "Presione una tecla para salir..." op
