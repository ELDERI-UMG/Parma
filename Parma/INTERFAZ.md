# Documentación de la Interfaz de Usuario

## Diseño del Formulario Principal

### Controles de Entrada (Parte Superior)
```
┌─────────────────────────────────────────────────────────────┐
│  Producto: [ComboBox ▼]  Cantidad: [1 ▲▼]  [Agregar]      │
└─────────────────────────────────────────────────────────────┘
```

### DataGridView (Área Central)
```
┌───────────────────────────────────────────────────────────────┐
│ Producto    │ Cantidad │ Precio Unitario │ Precio Total      │
├─────────────┼──────────┼─────────────────┼──────────────────┤
│ Cuaderno    │    2     │     $5.50       │    $11.00        │
│ Lápiz       │    5     │     $0.75       │     $3.75        │
│ Libro       │    1     │    $15.00       │    $15.00        │
└─────────────┴──────────┴─────────────────┴──────────────────┘
```

### Total (Parte Inferior)
```
                                        TOTAL:    $29.75
```

## Funcionalidad

1. **Selección de Producto**: El usuario selecciona un producto del ComboBox
2. **Ingreso de Cantidad**: El usuario ingresa la cantidad deseada (mínimo 1, máximo 999)
3. **Agregar Producto**: Al hacer clic en "Agregar", se agrega una fila al DataGridView con:
   - Nombre del producto
   - Cantidad ingresada
   - Precio unitario del producto
   - Precio total (cantidad × precio unitario)
4. **Actualización del Total**: El total se actualiza automáticamente sumando todos los precios totales

## Validaciones

- Se valida que haya un producto seleccionado antes de agregar
- La cantidad mínima es 1
- Después de agregar, la cantidad se resetea a 1

## Características Visuales

- Ventana centrada en pantalla de 800x500 píxeles
- Título: "Parma - Sistema de Ventas para Librería"
- Columnas de precio formateadas como moneda (C2)
- Alineación de columnas: cantidad centrada, precios a la derecha
- Total mostrado en negrita y color verde oscuro
- DataGridView de solo lectura
