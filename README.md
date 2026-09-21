# Console Invaders 🚀

Un clon del clásico juego arcade *Space Invaders*, desarrollado íntegramente en C# para ejecutarse en la consola de comandos. Este proyecto sirve como una práctica de Programación Orientada a Objetos (POO), aplicando conceptos como herencia, polimorfismo, sobrecarga de constructores y gestión de colisiones en un entorno de texto.

## 👾 Características Principales

* **Sistema de Flotas:** Un bloque organizado de 30 enemigos distribuidos en 3 filas, cada una con un tipo de alienígena distinto (diferentes formas y colores).
* **Inteligencia de Enjambre:** Los enemigos se mueven en bloque, rebotando contra los bordes de la pantalla y descendiendo gradualmente.
* **El OVNI Escurridizo:** Aparición aleatoria de un OVNI en la parte superior de la pantalla que cruza rápidamente de lado a lado.
* **Motor de Renderizado en Consola:** Sistema de dibujado y borrado optimizado por coordenadas (sin parpadeos excesivos ni necesidad de limpiar toda la pantalla en cada fotograma).
* **Control de Jugador:** Movimiento fluido de la nave defensora utilizando la lectura asíncrona de teclas.

## 💻 Tecnologías y Conceptos

* **Lenguaje:** C# (.NET)
* **Paradigma:** Programación Orientada a Objetos (POO).
* **Conceptos clave aplicados:**
  * **Herencia:** Clases derivadas (`Nave`, `Ovni`, `Enemigo1`, `Enemigo2`) que heredan de clases base.
  * **Sobrecarga de constructores:** Flexibilidad para instanciar objetos en posiciones predeterminadas o en coordenadas específicas.
  * **Matrices (Arrays):** Gestión de la flota de enemigos utilizando arrays y matemáticas modulares para simular una cuadrícula 2D.

## 🎮 Controles del Juego

* **Flecha Izquierda (`<-`):** Mover la nave hacia la izquierda.
* **Flecha Derecha (`->`):** Mover la nave hacia la derecha.
* **Espacio:** Disparar.
* **ESC:** Salir de la partida y volver al menú principal.

## 🛠️ Requisitos Previos

Para compilar y ejecutar este proyecto, necesitarás tener instalado:

* [.NET SDK](https://dotnet.microsoft.com/download) (versión 6.0 o superior recomendada).
* Un terminal o consola compatible (se recomienda la consola nativa de Windows para un renderizado óptimo de los caracteres ASCII y los colores).

## 🚀 Instalación y Ejecución

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone [https://github.com/TU_USUARIO/TU_REPOSITORIO.git](https://github.com/TU_USUARIO/TU_REPOSITORIO.git)