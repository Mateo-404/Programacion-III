# Manejar errores de rango al ingresar valores en un

Escenario: Un programa que calcula el área de un
rectángulo. El usuario ingresa la longitud y el ancho
del rectángulo.

## 1. Crear la clase de excepción personalizada:
- Crear una clase llamada
AreaRectanguloException que herede de la
clase Exception.
- Agregar un constructor que reciba un mensaje
de error como parámetro.
## 2. Validar la entrada del usuario:
- En el código que solicita la longitud y el ancho
al usuario, verificar si los valores ingresados
son negativos.
- Si un valor es negativo, crear una instancia
de la excepción AreaRectanguloException
con un mensaje adecuado y lanzarla
utilizando la instrucción throw.
## 3. Calcular y mostrar el área:
- Si la entrada del usuario es válida, calcular
el área del rectángulo y mostrarla en la
consola.
## 4. Captura de la excepción:
- Envolver el código que calcula el área en
un bloque try-catch para capturar la
excepción AreaRectanguloException.
- En el bloque catch, mostrar un mensaje de
error personalizado al usuario.
