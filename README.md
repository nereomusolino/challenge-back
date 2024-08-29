Challenge Backend
Este proyecto es un backend desarrollado en ASP.NET Core para gestionar la API del challenge frontend. Provee servicios REST para manejar pedidos y productos.

Tecnologías
ASP.NET Core

Estructura del proyecto
Controllers: Manejan las solicitudes HTTP.
Service: la lógica del backend.
Models: Define las entidades de la base de datos.

Endpoints principales
/api/getProductos: Obtiene la lista de productos disponibles.
/api/postPedidos: Guarda un nuevo pedido.

Instalación
Clona el repositorio:
git clone https://github.com/tuusuario/challenge-backend.git

Inicia el servidor:
dotnet run
El backend estará disponible en http://localhost:5000.

Uso
Los datos son gestionados a través de endpoints REST que pueden ser consumidos por el frontend.
Puedes realizar consultas de productos y vendedores, así como guardar pedidos.
