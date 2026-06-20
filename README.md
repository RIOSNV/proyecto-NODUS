# NODUS
ADR API REST
Autor: Rodrigo Haziz Rios Novelo
Fecha: 12/06/2026
----------------------------------------------------------------------------------------------------
# CONTEXTO: Nodus es un proyecto dirigido a ayuadar a los estudiantes para organizar sus actividades academicas facilmente
--------------------------------------------------------------------------------------------------
# Decision de estilo:
He decidido usar el modelo vista controlador con una topologia cliente-servidor 

# Justificacion: Se ha seleccionado el patrón MVC debido a su capacidad para aislar la lógica de cálculo de prioridad del usuario (Modelo) de la capa de presentación (Vista). Esta separación garantiza que el sistema sea mantenible, permitiendo futuras mejoras en los algoritmos de priorización sin afectar la interfaz, y escalable, al proporcionar una estructura de carpetas y responsabilidades clara para el crecimiento de NODOUS
# concideraciones  concideré usar el patron hexagonal por su capacidad de adaptacion pero decidi disernir de esta decicion debido a la complejidad de adaptar el proyecto a un nuevo estilo que apenas conozco. Aunque no descarto usar este modelo en el futuro
--------------------------------------------------------------------------------------------------

# Decisión
Se han definido las siguientes vistas arquitectónicas para el proyecto:
Vista Lógica: Describe la estructura de clases del sistema bajo el patrón MVC, enfocándose en la relación entre Materia, Tarea y el TareasController.

# Vista Física: Representa la organización de archivos del proyecto en Visual Studio, garantizando la separación de responsabilidades entre los componentes del patrón.

# Vista de Despliegue: Define el entorno de ejecución, distinguiendo entre el servidor web que aloja la aplicación y el cliente (navegador web).

# Vista de Procesos: Documenta el flujo dinámico de información, específicamente cómo una solicitud de usuario desencadena la lógica de priorización y la actualización de la vista.
--------------------------------------------------------------------------------------------------

# Consecuencias
Positivas:

Facilita la incorporación de nuevas funcionalidades al tener una hoja de ruta clara de dónde reside cada componente.

Permite identificar cuellos de botella en el flujo de ejecución (Vista de Procesos).

Simplifica la revisión de código por parte de otros desarrolladores al seguir una convención estándar.

# Negativas (Compromisos):

Requiere un esfuerzo adicional de actualización en la documentación cada vez que se realice un cambio estructural significativo en el código.
--------------------------------------------------------------------------------------------------
# Descripción de Vistas Arquitectónicas
1. Vista Lógica (Capa 1)
 <img width="1125" height="687" alt="capa1" src="https://github.com/user-attachments/assets/063460c5-e53c-42f0-9d74-fd4324d610ad" />

# Descripción: Esta vista representa la estructura interna de la aplicación bajo el patrón Modelo-Vista-Controlador (MVC).

# Componentes: Define la separación de responsabilidades: los Modelos contienen las entidades de datos y la lógica de negocio (como el algoritmo de prioridad), los Controladores gestionan el flujo de las peticiones, y las Vistas definen la interfaz de usuario.

# Propósito: Garantizar que el sistema sea modular, permitiendo que la lógica de cálculo de prioridad sea independiente de la presentación visual, facilitando el mantenimiento y la escalabilidad del proyecto.
--------------------------------------------------------------------------------------------------
2. Vista Física (Capa 2)
   <img width="1279" height="670" alt="CAPA2" src="https://github.com/user-attachments/assets/d40cd4c0-9978-403d-8995-3804fc0b39d9" />

Descripción: Representa la organización de los artefactos de software dentro del sistema de archivos del proyecto.

Componentes: Muestra la jerarquía de carpetas (Models, Views, Controllers, wwwroot).

Propósito: Establecer una convención de nombres y ubicación que permita a cualquier desarrollador navegar por el código de forma intuitiva, asegurando que cada componente tenga un lugar predecible dentro de la solución de ASP.NET Core.

--------------------------------------------------------------------------------------------------

3. Vista de Procesos (Capa 3)
<img width="1245" height="780" alt="Capa3" src="https://github.com/user-attachments/assets/0472aeca-e1e0-45ca-b8a1-dd170bcb69cc" />

Descripción: Ilustra el flujo dinámico de la información ante una solicitud específica del usuario.

Componentes: Describe el ciclo de vida de una petición: Usuario → Controlador (Procesamiento) → Modelo (Cálculo de Prioridad) → Controlador (Retorno) → Vista (Renderizado).

Propósito: Documentar cómo interactúan los componentes en tiempo de ejecución. Es fundamental para entender cómo se aplica el algoritmo de prioridad cuando el sistema recibe una solicitud para listar tareas.
--------------------------------------------------------------------------------------------------
4. Vista de Despliegue (Capa 4)
<img width="1111" height="734" alt="CAPA4" src="https://github.com/user-attachments/assets/e12c84b3-3eca-46d6-9f28-f501c9dcdd96" />

Descripción: Define el entorno donde reside la aplicación y cómo interactúa con el usuario final.

Componentes: Identifica el Navegador Web (Cliente) y el Host de Servidor .NET (Servidor).

Propósito: Clarificar la infraestructura básica del sistema. En esta etapa, el despliegue es local, utilizando el entorno de desarrollo de .NET como servidor para servir la interfaz al navegador del usuario, sentando las bases para una futura implementación en un servidor en la nube.
--------------------------------------------------------------------------------------------------
# Integración de Servicios Externos (APIs REST)
Para enriquecer la experiencia del usuario y automatizar la gestión académica, NODOUS incorpora la integración de servicios externos mediante APIs REST, manteniendo el desacoplamiento lógico:

- API de Calendario (Ej. Google Calendar): Se integrará para sincronizar automáticamente las fechas de vencimiento de las tareas registradas en NODOUS con el calendario personal del estudiante, evitando la duplicidad de registros y mejorando la gestión del tiempo.
- API de Clima (Ej. OpenWeatherMap): Se utilizará para proporcionar contexto ambiental. Esta integración servirá como una funcionalidad estética y práctica que ayuda al estudiante a planificar sus traslados a la universidad basándose en las condiciones meteorológicas locales.

Estas integraciones se tratarán como servicios externos dentro de la capa de Modelo (Services/Integrations), asegurando que, si un servicio cambia o deja de estar disponible, el núcleo del sistema (la lógica de priorización) permanezca intacto.
--------------------------------------------------------------------------------------------------

Yo Rodrigo Rios acepto el uso de ia con motivos de mejorar la redaccion y aseguracion del contenido 


