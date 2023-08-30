using JohanGutierrezPractico1.Controladores;
using JohanGutierrezPractico1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace JohanGutierrezPractico1
{
    public partial class Form1 : Form
    {
        private DataTable tabla;
        ClienteController clienteController = new ClienteController();
        int filaSeleccionada;
        string accion = "guardar";

        private readonly string fecha = DateTime.Now.ToString("dd-MM-yyyy"); //Formato de fecha

        public Form1()
        {
            InitializeComponent();

            // Establece el estado del formulario como maximizado
            this.WindowState = FormWindowState.Maximized;

            // Establece el estilo de borde para que no se pueda cambiar el tamaño
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Opcional: Oculta el botón de maximizar
            this.MaximizeBox = false;

            // Configura el DateTimePicker para no permitir seleccionar fechas futuras
            datePickerFechaRegistro.MaxDate = DateTime.Now;

            try
            {
                MostrarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Llama al método para obtener y mostrar los indicadores al iniciar el formulario
            ObtenerYMostrarIndicadores();
        }

        //asigna nombres de columna a cada row del datagrid y ubica dichos nombres como cabecera
        private void InicializarTablaClientes()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Rut");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Es Empresa");
            tabla.Columns.Add("Teléfono");
            tabla.Columns.Add("Dirección");
            tabla.Columns.Add("Fecha Registro");
            tabla.Columns.Add("Cantidad Facturas");
            tabla.Columns.Add("Número Última Factura");
            tabla.Columns.Add("Monto Última Factura");

            dgClientes.DataSource = tabla; //dgClientes = datagrid clientes
        }

        //pobla el datagrid con los datos de la lista de clientes
        private void MostrarListaClientes()
        {
            InicializarTablaClientes();

            List<Cliente> clientes = clienteController.ObtenerClientes();

            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    DataRow row = tabla.NewRow();
                    row["Rut"] = cliente.Rut;
                    row["Nombre"] = cliente.Nombre;
                    row["Es Empresa"] = cliente.EsEmpresa;
                    row["Teléfono"] = cliente.Telefono;
                    row["Dirección"] = cliente.Direccion;
                    row["Fecha Registro"] = cliente.FechaRegistro;
                    row["Cantidad Facturas"] = cliente.CantidadFacturas;
                    row["Número Última Factura"] = cliente.NumeroUltimaFactura;
                    row["Monto Última Factura"] = cliente.MontoUltimaFactura;

                    tabla.Rows.Add(row);
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0 && filaSeleccionada < dgClientes.Rows.Count)
            {
                DataGridViewRow fila = dgClientes.Rows[filaSeleccionada];

                txtRut.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();

                // Obtiene el valor de "Es Empresa" en el cliente seleccionado
                string valorCelda = fila.Cells[2].Value.ToString();
                bool esEmpresa = (valorCelda == "Si");

                // Actualiza la selección en cbEsEmpresa
                cbEsEmpresa.SelectedIndex = esEmpresa ? 1 : 0;
                txtTelefono.Text = fila.Cells[3].Value.ToString();
                txtDireccion.Text = fila.Cells[4].Value.ToString();

                // Habilita la edición de los campos deseados
                txtNombre.Enabled = true;
                cbEsEmpresa.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                datePickerFechaRegistro.Enabled = true;

                // Deshabilita la edición de los campos que no deben actualizarse
                txtCantidadFacturas.Enabled = false;
                txtNumeroUltimaFactura.Enabled = false;
                txtMontoUltimaFactura.Enabled = false;

                accion = "editar";

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecciona una fila válida para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbEsEmpresa.SelectedIndex == -1)
                    throw new Exception("Selecciona si es una empresa o no.");

                // Validar que Rut no esté vacío
                if (string.IsNullOrWhiteSpace(txtRut.Text))
                    throw new Exception("El campo Rut es requerido.");

                // Validar que Nombre no esté vacío
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("El campo Nombre es requerido.");

                // Validar que Teléfono sea un número válido
                if (!int.TryParse(txtTelefono.Text, out _))
                    throw new Exception("El campo Teléfono debe ser un número válido.");

                // Validar que Dirección no esté vacía
                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                    throw new Exception("El campo Dirección es requerido.");

                // Validar que estás en modo de guardado
                if (accion == "guardar")
                {
                    // Validar que Cantidad Facturas sea un número válido
                    if (!int.TryParse(txtCantidadFacturas.Text, out _))
                        throw new Exception("El campo Cantidad Facturas debe ser un número válido.");

                    // Validar que Numero Última Factura sea un número válido
                    if (!int.TryParse(txtNumeroUltimaFactura.Text, out _))
                        throw new Exception("El campo Número Última Factura debe ser un número válido.");

                    // Validar que Monto Última Factura sea un número decimal válido
                    if (!decimal.TryParse(txtMontoUltimaFactura.Text, out _))
                        throw new Exception("El campo Monto Última Factura debe ser un número decimal válido.");
                }

                Cliente cliente = new Cliente()
                {
                    Rut = txtRut.Text,
                    Nombre = txtNombre.Text,
                    EsEmpresa = (cbEsEmpresa.SelectedIndex == 1), // Toma el valor seleccionado en el ComboBox
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    FechaRegistro = datePickerFechaRegistro.Value,
                };

                if (accion == "guardar")
                {
                    if (clienteController.ExisteRutDuplicado(cliente.Rut))
                    {
                        throw new Exception("Ya existe un cliente con el mismo RUT.");
                    }

                    cliente.CantidadFacturas = int.Parse(txtCantidadFacturas.Text);
                    cliente.NumeroUltimaFactura = int.Parse(txtNumeroUltimaFactura.Text);
                    cliente.MontoUltimaFactura = decimal.Parse(txtMontoUltimaFactura.Text);

                    clienteController.AgregarCliente(cliente);
                }
                else if (accion == "editar")
                {
                    // Obtenemos la lista de clientes y verificamos si el nuevo RUT ya existe en otro cliente
                    var clientes = clienteController.ObtenerClientes();
                    foreach (var otroCliente in clientes)
                    {
                        if (otroCliente.Rut == cliente.Rut && otroCliente.Rut != txtRut.Text)
                        {
                            throw new Exception("Ya existe un cliente con el mismo RUT.");
                        }
                    }

                    // Actualiza los campos que deben actualizarse solo en modo de edición
                    clienteController.EditarCliente(filaSeleccionada, cliente);
                    accion = "guardar";
                }

                MostrarListaClientes();
                LimpiarFormularioClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormularioClientes()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            cbEsEmpresa.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCantidadFacturas.Text = "";
            txtNumeroUltimaFactura.Text = "";
            txtMontoUltimaFactura.Text = "";
        }

        private void DgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            clienteController.EliminarCliente(filaSeleccionada);
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            MostrarListaClientes();
        }

        private void ObtenerYMostrarIndicadores()
        {
            string apiUrl = "https://www.mindicador.cl/api";
            string jsonString = "{}";
            WebClient http = new WebClient();
            JavaScriptSerializer jss = new JavaScriptSerializer();

            try
            {
                http.Headers.Add(HttpRequestHeader.Accept, "application/json");
                jsonString = http.DownloadString(apiUrl);
                var indicatorsObject = jss.Deserialize<Dictionary<string, object>>(jsonString);

                Dictionary<string, Dictionary<string, string>> dailyIndicators = new Dictionary<string, Dictionary<string, string>>();

                foreach (var key in indicatorsObject.Keys)
                {
                    var item = indicatorsObject[key];

                    if (item is Dictionary<string, object> itemObject)
                    {
                        Dictionary<string, string> indicatorProp = new Dictionary<string, string>();

                        foreach (var key2 in itemObject.Keys)
                        {
                            indicatorProp.Add(key2, itemObject[key2].ToString());
                        }

                        dailyIndicators.Add(key, indicatorProp);
                    }
                }

                // Mostrar el valor de la UF en un Label
                if (dailyIndicators.ContainsKey("uf") && dailyIndicators["uf"].ContainsKey("valor"))
                {
                    string valorUF = dailyIndicators["uf"]["valor"];
                    lblValorUF.Text = "El valor actual de la UF es $" + valorUF;
                }
                else
                {
                    lblValorUF.Text = "No se pudo obtener el valor de la UF.";
                }

                // Mostrar el valor del dólar en un Label
                if (dailyIndicators.ContainsKey("dolar") && dailyIndicators["dolar"].ContainsKey("valor"))
                {
                    string valorDolar = dailyIndicators["dolar"]["valor"];
                    lblValorDolar.Text = "El valor actual del Dólar es $" + valorDolar;
                }
                else
                {
                    lblValorDolar.Text = "No se pudo obtener el valor del Dólar.";
                }
                lblFecha.Text = "Fecha: " + fecha;
            }
            catch (Exception ex)
            {
                lblValorUF.Text = "Error al obtener los indicadores: " + ex.Message;
                lblValorDolar.Text = "Error al obtener los indicadores: " + ex.Message;
                lblFecha.Text = "Error al obtener la fecha: " + ex.Message;
            }
        }

    }
}