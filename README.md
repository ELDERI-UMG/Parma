# Parma
Programa de ventas para una librería

## Descripción
Aplicación de escritorio en Windows Forms (.NET 8.0) que permite gestionar ventas de productos de librería.

## Características
- Selección de productos desde una lista desplegable (ComboBox)
- Ingreso de cantidad mediante control numérico
- Visualización de productos en DataGridView con:
  - Producto
  - Cantidad
  - Precio Unitario
  - Precio Total
- Cálculo automático del total de la venta

## Productos disponibles
- Cuaderno ($5.50)
- Lápiz ($0.75)
- Borrador ($1.25)
- Regla ($2.00)
- Libro ($15.00)
- Mochila ($25.00)
- Calculadora ($12.50)
- Pegamento ($3.00)

## Requisitos
- .NET 8.0 SDK o superior
- Windows OS (para ejecutar la aplicación)

## Compilación
```bash
cd Parma
dotnet build
```

## Ejecución
```bash
cd Parma
dotnet run
```

## Estructura del proyecto
- `Program.cs`: Punto de entrada de la aplicación
- `MainForm.cs`: Formulario principal con la interfaz de usuario y lógica de negocio
- `Parma.csproj`: Archivo de proyecto .NET

