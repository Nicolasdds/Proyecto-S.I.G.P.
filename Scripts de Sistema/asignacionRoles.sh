#! /bin/bash
salir="n"
while true; do
clear
echo ".................................."
echo ". Asignacion de Roles a Usuarios ."
echo ".................................."
read -p "Ingrese el usuario: " user
echo "select * from usuario_rol where usuario='$user'" | dbaccess hipercode > msg.txt 2> error.txt
if grep -wq No error.txt; then
 echo "Ingrese el rol:"
 echo "1. Admin."
 echo "2. Tecnico."
 echo "3. Asistente."
 echo "4. Guest." 
 read rol
 case $rol in
 1)while true; do
   echo "insert into usuario_rol values('$user',1)" | dbaccess hipercode
   echo "select u.usuario, r.rol from usuario_rol as u, roles as r where u.rol=r.id and u.usuario='$user'" | dbaccess hipercode > query.txt
   clear
   echo "Rol asignado correctamente: "  
   echo ""
   cat query.txt | tail -3 | head -2
   echo ""  
   read -p "Desea asignar otro rol? y/n: " rep
   if [[ $rep = $salir ]]; then 
    clear
    exit
   else
    break
   fi
   done;;
 2)while true; do
   echo "insert into usuario_rol values('$user',2)" | dbaccess hipercode
   echo "select u.usuario, r.rol from usuario_rol as u, roles as r where u.rol=r.id and u.usuario='$user'" | dbaccess hipercode > query.txt
   clear
   echo "Rol asignado correctamente: "  
   echo ""
   cat query.txt | tail -3 | head -2
   echo ""  
   read -p "Desea asignar otro rol? y/n: " rep
   if [[ $rep = $salir ]]; then 
    clear
    exit
   else
    break
   fi
   done;;
 3)while true; do
   echo "insert into usuario_rol values('$user',3)" | dbaccess hipercode
   echo "select u.usuario, r.rol from usuario_rol as u, roles as r where u.rol=r.id and u.usuario='$user'" | dbaccess hipercode > query.txt
   clear
   echo "Rol asignado correctamente: "  
   echo ""
   cat query.txt | tail -3 | head -2
   echo ""  
   read -p "Desea asignar otro rol? y/n: " rep
   if [[ $rep = $salir ]]; then 
    clear
    exit
   else
    break
   fi
   done;;
 4)while true; do
   echo "insert into usuario_rol values('$user',4)" | dbaccess hipercode
   echo "select u.usuario, r.rol from usuario_rol as u, roles as r where u.rol=r.id and u.usuario='$user'" | dbaccess hipercode > query.txt
   clear
   echo "Rol asignado correctamente: "  
   echo ""
   cat query.txt | tail -3 | head -2
   echo ""  
   read -p "Desea asignar otro rol? y/n: " rep
   if [[ $rep = $salir ]]; then 
    clear
    exit
   else
    break
   fi
   done;;
 *)echo "Hubo un error, verifique."
   sleep 2;;
  esac
 else
  echo "El usuario ya tiene un rol asignado, reintente."
  sleep 2
fi
done
