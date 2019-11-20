#! /bin/bash
while true; do
clear
echo "........................"
echo ". Creacion de Usuarios ."
echo "........................"
echo ""
read -p "Nombre de Usuario: " user
grep -wq $user /etc/passwd
if [ $? -eq 0 ]
 then
  echo 'El usuario ya existe.'
  sleep 2
 else
  groupadd $user
  useradd -g $user -d /home/$user -m -s /bin/bash $user  
  grep -wq $user /etc/passwd
  if [ $? -eq 0 ]  
   then
    passwd $user
    clear
    echo 'Usuario agregado exitosamente!.'
    echo 'passwd:'  
    tail -1 /etc/passwd
    echo 'group:'
    tail -1 /etc/group
    echo ''
    while true; do
    read -p 'Desea ingresar otro usuario? y/n: ' op
    case $op in
    y|Y) break;;
    n|N)clear 
        exit;;
    *) echo 'Hubo un error, reintente.'
       sleep 2
       clear;;
    esac
    done
  else
    echo 'Hubo un error, reintente'
  fi   
fi
done
