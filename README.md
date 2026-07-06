# Sistema de Gestión de Eventos y Facturación 

## Descripción del Sistema
Este es un software de escritorio robusto desarrollado en **C# (.NET 9.0 Windows Forms)** diseñado para administrar eficientemente la logística de alquiler de equipos e insumos de eventos, control de inventario y facturación de servicios comerciales. El sistema ofrece un entorno multiusuario con controles de acceso por roles, permitiendo una operatividad fluida tanto para administradores como para representantes de ventas.

## Objetivo
El objetivo principal del sistema es proveer una plataforma integral y centralizada que permita automatizar el ciclo de vida de los eventos corporativos y sociales, abarcando desde el registro inicial del cliente, la gestión de la disponibilidad de artículos de inventario, el cronograma del evento y la emisión final del cobro mediante facturas comerciales estilizadas en formato PDF y exportaciones ordenadas en Excel.

---

## Tecnologías Utilizadas
El proyecto está construido bajo una pila de desarrollo moderna en el entorno .NET:

* **Framework Base:** .NET 9.0 (Windows Forms para entorno de escritorio).
* **Base de Datos:** Microsoft SQL Server / LocalDB mediante `System.Data.SqlClient` para un acceso y almacenamiento relacional de alta velocidad.
* **Generación de Reportes PDF:** [PDFsharp](http://www.pdfsharp.com/) (versión `6.2.4`) para el renderizado nativo y con diseño premium de las facturas (diseño con paneles institucionales, colores balanceados y tipografía Arial controlada).
* **Exportación de Datos:** [ClosedXML](https://github.com/ClosedXML/ClosedXML) (versión `0.102.2`) para la creación nativa de hojas de cálculo de Microsoft Excel (`.xlsx`) sin dependencia de MS Office instalado.

---

## Características Principales
1. **Control de Usuarios y Roles (Login/Registro):** Validación local en login y redirección inteligente dependiendo de los privilegios del usuario (Admin / Representante).
2. **Administración de Clientes:** Altas, bajas, modificaciones y consultas de datos de contacto de clientes.
3. **Gestión de Eventos:** Planificación y programación de eventos asignando cliente, lugar, fecha de entrega y estado de la solicitud.
4. **Control de Inventario:** Catálogo de artículos disponibles en alquiler, con control de cantidades, precios individuales y descripciones de stock.
5. **Facturación Contextual:** 
   - Tabla de facturación que se carga automáticamente con los artículos solo después de haber elegido el evento asociado.
   - Concatenación de código, nombre y descripción del artículo en todo el flujo del sistema.
6. **Emisión de Documentos y Exportación:**
   - Botón **Facturar:** Genera de forma inmediata el reporte en PDF, lo registra en la base de datos y lo abre de forma automática.
   - Botón **Excel:** Exporta los artículos listados a un archivo nativo `.xlsx`, autoajustando las columnas para su lectura inmediata.
7. **Diseño Visual:** Integración de iconos representativos en todos los botones del sistema para optimizar la experiencia de usuario.

---

## Instrucciones de Instalación y Ejecución

### Prerrequisitos
* Tener instalado el SDK de [.NET 9.0](https://dotnet.microsoft.com/download/dotnet/9.0) en el equipo.
* Instancia local de **Microsoft SQL Server** (ej. LocalDB o SQL Express).
* Base de datos configurada con el nombre de `GestionEventos`.

### Configuración del Proyecto
1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/100090365-hue/proyecto-programacion-iii.git
   ```
2. **Configurar la cadena de conexión:**
   Abre el archivo [Class2.cs](file:///d:/Desarrollo_AntiGravity/SOL/Diseño Trabajo final/Class2.cs) y edita el campo `cadena` con el nombre de tu servidor o instancia de SQL Server:
   ```csharp
   private static readonly string cadena =
       "Server=TU_SERVIDOR\\SQLEXPRESS;Database=GestionEventos;Trusted_Connection=True;TrustServerCertificate=True;";
   ```

### Restaurar y Compilar
1. Abre tu terminal en el directorio del proyecto y ejecuta el siguiente comando para restaurar los paquetes NuGet (PDFsharp y ClosedXML) y compilar la solución:
   ```bash
   dotnet build
   ```

### Ejecutar la Aplicación
1. Lanza el proyecto directamente con el comando de ejecución de .NET CLI:
   ```bash
   dotnet run
   ```
