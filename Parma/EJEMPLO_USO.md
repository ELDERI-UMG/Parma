# Ejemplo de Uso de la Aplicación Parma

## Paso 1: Iniciar la aplicación
Al ejecutar `dotnet run` desde el directorio Parma, se abrirá el formulario principal.

## Paso 2: Seleccionar productos
1. Seleccionar un producto del ComboBox (ej: "Cuaderno")
2. Ingresar la cantidad deseada (ej: 2)
3. Hacer clic en "Agregar"

## Paso 3: Visualizar en DataGridView
El producto se agrega al DataGridView mostrando:
- Producto: Cuaderno
- Cantidad: 2
- Precio Unitario: $5.50
- Precio Total: $11.00

## Paso 4: Agregar más productos
Repetir el proceso para agregar más productos (ej: 5 lápices, 1 libro)

## Paso 5: Ver el total
El total se actualiza automáticamente y se muestra en la parte inferior:
TOTAL: $29.75 (ejemplo)

## Catálogo de Productos

| Producto    | Precio Unitario |
|-------------|-----------------|
| Cuaderno    | $5.50          |
| Lápiz       | $0.75          |
| Borrador    | $1.25          |
| Regla       | $2.00          |
| Libro       | $15.00         |
| Mochila     | $25.00         |
| Calculadora | $12.50         |
| Pegamento   | $3.00          |

## Validaciones Implementadas

1. **Selección de producto**: Si no hay producto seleccionado, muestra mensaje de advertencia
2. **Producto válido**: Verifica que el producto exista en el catálogo
3. **Cantidad mínima**: La cantidad mínima es 1
4. **Cantidad máxima**: La cantidad máxima es 999
5. **Reseteo automático**: Después de agregar, la cantidad vuelve a 1

## Características de Formato

- Precios mostrados con formato de moneda (C2)
- Columna de cantidad centrada
- Columnas de precio alineadas a la derecha
- Total mostrado en negrita y color verde oscuro
- DataGridView de solo lectura (no se pueden editar valores directamente)
