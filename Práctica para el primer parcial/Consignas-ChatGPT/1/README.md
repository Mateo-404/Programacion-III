# Sistema de Control de Acceso

## Descripción
Desarrolla un programa en C# que simule un sistema de control de acceso para un edificio de oficinas. El sistema debe permitir la entrada a diferentes tipos de personal, como empleados, visitantes y personal de mantenimiento, cada uno con distintos niveles de acceso.

## Requisitos Funcionales
1. **Interfaces:**
   - Define una interfaz `IAccesible` con un método abstracto `Acceder`.
   - Implementa la interfaz en clases como `Empleado`, `Visitante` y `PersonalMantenimiento`.

2. **Métodos Abstractos:**
   - Crea una clase abstracta `Persona` que implemente la interfaz `IAccesible` y declare un método abstracto `Identificarse`.

3. **Clases Selladas:**
   - Implementa una clase sellada `RegistroAcceso` que no pueda ser heredada y que contenga un método para registrar la entrada y salida de personas.

4. **Control de Acceso:**
   - El sistema debe validar el nivel de acceso antes de permitir la entrada.
   - Debe registrar la hora de entrada y salida de cada persona.

## Requisitos No Funcionales
- Aplica el principio de sustitución de Liskov para garantizar que las subclases sean intercambiables con su clase base.
- Utiliza clases selladas para proteger partes críticas del sistema.
- Implementa una interfaz de consola para interactuar con el sistema.

## Entregables
- Código fuente en C#.
- Documentación del código.
- Instrucciones para ejecutar el programa.

## Evaluación
El ejercicio será evaluado en base a la correcta implementación de los requisitos funcionales y no funcionales, la calidad del código, el uso de interfaces, métodos abstractos y clases selladas.

---

**Nota:** Este ejercicio está diseñado para desafiar tus habilidades en el uso de conceptos avanzados de POO en C#. Asegúrate de entender cómo aplicar estos conceptos y ¡buena suerte en tu preparación!
