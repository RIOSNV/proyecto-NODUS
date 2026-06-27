# NODUS
ADR GOF
Autor: Rodrigo Haziz Rios Novelo
Fecha: 26/06/2026
_____________________________________________________________________________________________________________________________________________________
Contexto
Estamos construyendo NODOUS, un gestor de tareas académicas en ASP.NET Core MVC. El sistema requiere una lógica dinámica para ordenar tareas por prioridad basándose en variables como dificultad, tiempo estimado y fechas de entrega. Actualmente, la lógica de negocio reside directamente en el Modelo o Controlador, lo que dificultaría cambiar la fórmula de priorización o añadir nuevos criterios sin afectar el código base existente.
___________________________________________________________________________________________________________________________________________________
Decisión
He decidido mantener la arquitectura MVC  y añadir el patrón de diseño Strategy (Estrategia) para encapsular el algoritmo de prioridad.

Patrón Strategy: Crearemos una interfaz IPriorityStrategy con un método CalcularPrioridad(Tarea tarea). Luego, implementaremos clases concretas (ej. PrioridadPorFecha, PrioridadPorDificultad) que contengan las fórmulas específicas.

¿Por qué?
Flexibilidad: Permite cambiar el algoritmo de priorización en tiempo de ejecución.
Mantenibilidad: Evita tener múltiples condicionales if/else o switch dentro de nuestros controladores o modelos, separando la lógica del algoritmo de la estructura de datos.

Escalabilidad: Si en el futuro necesitas un algoritmo de prioridad mucho más complejo para estudiantes avanzados, solo añades una nueva clase que implemente la interfaz, sin tocar el resto del sistema.
___________________________________________________________________________________________________________________________________________________
Alternativas consideradas
-Alternativa:Lógica en Controlador. Por qué la descarté?:Genera "código espagueti" y rompe la separación de responsabilidades del MVC.

-Alternativa:Hardcoding (if/else en Modelo). Por qué la descarté?: Difícil de probar y de escalar; cada nueva regla de prioridad obligaría a modificar código existente.
___________________________________________________________________________________________________________________________________________________
Consecuencias
Lo que gano:
Técnica: El código se vuelve modular; la lógica de prioridad es independiente del resto de la entidad Tarea, facilitando pruebas unitarias.
Proceso: Facilita el trabajo en equipo, ya que alguien puede trabajar en un nuevo algoritmo (nueva clase) sin riesgo de romper el controlador existente.

 Lo que sacrifico o asumo:
Limitación: Aumenta ligeramente el número de archivos en el proyecto (nuevas clases para cada estrategia).
Deuda: Debemos asegurarnos de documentar bien qué estrategia está activa para no perder la trazabilidad de los cálculos realizados.
 ___________________________________________________________________________________________________________________________________________________

 Yo Rodrigo Rios acepto que use IA para mejorar  la estructura del ADR y buscar ideas para el GOF
