# Problema 29

## Enunciado
El torniquete de la sede recibe dos datos: el rol de la persona (“admin”,
“instructor”, “aprendiz”) y la hora de llegada (0 a 23). Las reglas son:
“admin” puede entrar a cualquier hora.
“instructor” puede entrar de 6 a 21 horas.
“aprendiz” puede entrar de 6 a 18 horas.
Cualquier otro caso: acceso denegado.
Ejemplos: (“admin”, 2) → Acceso permitido · (“aprendiz”, 19) → Acceso denegado ·
(“instructor”, 20) → Acceso permitido

## Estructura condicional elegida
if-else if-else con condiciones compuestas.

## Justificación
 Se utilizan condiciones compuestas porque el acceso depende de
combinar el rol de la persona con el intervalo horario autorizado para ese rol.

## Evidencia
![Salida](evidencias/image.png)
