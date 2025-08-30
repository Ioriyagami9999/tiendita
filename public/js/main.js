const API_URL = '/api/productos'; // Ajusta según tu API

async function cargarProductos() {
    const resp = await fetch(API_URL);
    const productos = await resp.json();
    const tbody = document.querySelector('#tablaProductos tbody');
    tbody.innerHTML = '';
    productos.forEach(p => {
        const tr = document.createElement('tr');
        tr.innerHTML = `
            <td>${p.id}</td>
            <td>${p.nombre}</td>
            <td>${p.precio}</td>
            <td>
                <button class="delete" onclick="eliminarProducto(${p.id})">Eliminar</button>
            </td>
        `;
        tbody.appendChild(tr);
    });
}

document.getElementById('formAgregarProducto').addEventListener('submit', async (e) => {
e.preventDefault();
const nombre = document.getElementById('nombre').value;
const precio = parseFloat(document.getElementById('precio').value);

try {
const resp = await fetch(API_URL, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ nombre, precio })
});

if (!resp.ok) {
    const errorData = await resp.json();
    mostrarModal(errorData.mensaje || "Ocurrió un error");
    return;
}

e.target.reset();
cargarProductos();
} catch (err) {
mostrarModal("Error de conexión con el servidor");
}
});

async function eliminarProducto(id) {
    await fetch(`${API_URL}/${id}`, { method: 'DELETE' });
    cargarProductos();
}

cargarProductos();




    // Mostrar modal
    function mostrarModal(mensaje) {
        document.getElementById('mensajeModal').innerText = mensaje;
        document.getElementById('modalError').style.display = 'flex';
    }
    
    // Cerrar modal
    function cerrarModal() {
        document.getElementById('modalError').style.display = 'none';
    }