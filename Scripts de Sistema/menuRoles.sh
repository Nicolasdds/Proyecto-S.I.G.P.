#! /bin/bash
clear
while true
do
echo "......................................"
echo ". Administracion de Usuarios & Roles ."
echo "......................................"
echo ""
echo "Seleccione una opcion:"
echo "1. Crear Usuarios."
echo "2. Asignar Roles."
echo "Q|q. Salir."
read op
case $op in
1)bash crearUsuarios.sh;;
2)bash asignacionRoles.sh;;
q|Q) break;;
*)echo "Hubo un error, reintente."
  sleep 2
  clear;;
esac
done
