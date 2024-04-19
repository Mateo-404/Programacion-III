# Guía de ejercicios prácticos Nº 1
## Conceptos básicos de C# 
Array.Resize(ref myArr, myArr.Length + 5);
1. Escribir un método que imprima “Hola <nombre>!”, donde <nombre> se corresponde 
con el primer argumento recibido desde la línea de comandos.

2. Escribir un programa que calcule el factorial de un número entero recibido como 
argumento. Utilizar estructuras iterativas (for o while) y recursividad.

3. Escribir un programa que determine si el argumento recibido como parámetro es un 
número par.

4. Escribir un programa que tome un entero largo (tipo primitivo long) recibido como 
parámetro e imprima la suma de todos sus dígitos. (Por ejemplo: 317  11)

5. Escribir un programa que calcule el promedio de todos los números recibidos como 
argumentos hasta que ingrese la letra C.

6. Escribir un programa que reciba varios números enteros como argumentos, los introduzca 
en un arreglo (de enteros) y se lo pase a otro método que los ordene. 
Finalmente, imprimir el arreglo ordenado.
El algoritmo de ordenación a utilizar será el siguiente:
Mientras el arreglo no esté completamente ordenado hacer:
Sea i una variable entera; sea n el tamaño del arreglo.
Desde i = 0 hasta n - 1 hacer:
Comparar ei con ei+1
Si ei > ei+1 entonces intercambiarlos
Fin Desde
Fin Mientras

7. Escribir un método que tome un arreglo de caracteres y devuelva otro arreglo que 
contenga todos los caracteres del original en MAYÚSCULAS, minúsculas y Capital 
respectivamente:
 char[] convertirAMayusculas(char[] arreglo)
 char[] convertirAMinusculas(char[] arreglo)
 char[] convertirACapital(char[] arreglo)

8. Escribir un programa que tome una cadena recibida como argumento y la imprima de 
manera invertida (por ejemplo: “Tecnicatura”  “arutacinceT”).

9. Escribir un método que devuelva una subcadena de un String recibido como argumento. 
Los parámetros que recibe son: la posición del primer carácter donde comienza la 
subcadena, el tamaño de la subcadena y el String original

10. Escribir un método que, dada una cadena de texto recibida como parámetro, devuelva el 
número total de palabras que la componen. Tener en cuenta los espacios y demás 
caracteres separadores (comas, puntos, etc)