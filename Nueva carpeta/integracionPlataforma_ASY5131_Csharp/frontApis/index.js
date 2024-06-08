window.onload = function() {
    document.getElementById('finalizar').onclick = function() {
        // Obtenemos los valores del cliente y los productos
        var nombre = document.getElementById('nombre').value;
        var rut = document.getElementById('rut').value;
        var apellido = document.getElementById('apellido').value;
        var idProducto = document.getElementById('nombre-producto').value;
        var cantidadProducto = document.getElementById('cantidad-producto').value; // Corregido aquí
        var precio = document.getElementById('precio').value;
        var descripcion = document.getElementById('descripcion').value;
        
        // Calculamos el total del producto multiplicando cantidad por precio
        var total = (cantidadProducto * precio).toFixed(2);

        // Guardamos los datos en localStorage
        localStorage.setItem('nombre', nombre);
        localStorage.setItem('rut', rut);
        localStorage.setItem('apellido', apellido);
        localStorage.setItem('idProducto', idProducto);
        localStorage.setItem('cantidadProducto', cantidadProducto); // Corregido aquí
        localStorage.setItem('precio', precio);
        localStorage.setItem('descripcion', descripcion);
        localStorage.setItem('total', total);

        // Redirigimos a la página de boleta
        window.location.href = 'boleta.html';
    }
};
