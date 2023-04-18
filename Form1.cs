using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valentin.Torassa.Colombero_CajaDeAhorro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Se declara un array de objetos CajaDeAhorro, el contador de indice del array y un contador para los numeros de cuenta
        CajaDeAhorro[] arrayObjetos = new CajaDeAhorro[10];
        int indice = 0;
        int numeroCuenta = 1;

        //BOTON AGREGAR
        private void agregarbtn_Click(object sender, EventArgs e)
        {
            //variable que servira de out para TryParse
            int saldo;

            // Se obtienen los valores ingresados por el usuario, comprobandose que los campos tengan datos válidos y no nulos
            if (nombretxt.Text != "" && saldotxt.Text != "" && monedacmb.Text != "" && int.TryParse(saldotxt.Text, out saldo))
            {
                errorlbl.Text = "";

                // Se crea un nuevo objeto CajaDeAhorro y se agrega al array
                arrayObjetos[indice] = new CajaDeAhorro(numeroCuenta, nombretxt.Text, saldo, monedacmb.Text);

                // Se agregan los datos del objeto creado a la tabla
                datosdgtv.Rows.Add(arrayObjetos[indice].NumeroCuenta, arrayObjetos[indice].Nombre, arrayObjetos[indice].Saldo, arrayObjetos[indice].TipoMoneda);

                //Se incrementa tanto el cotandor de objetos en el array y el numero de cuenta
                indice++;
                numeroCuenta++;
            }
        }

        // BOTON EXTRAER
        private void extraerbtn_Click(object sender, EventArgs e)
        {
            //variable que servira de out para TryParse
            int extrac;

            // Se comprueba que se haya seleccionado una fila y que el valor sea un entero válido
            if (datosdgtv.SelectedRows.Count == 1 && int.TryParse(extracDepositxt.Text, out extrac))
            {
                //se obtiene el indice de la fila seleccionada por el usuario
                int filaSeleccionada = datosdgtv.SelectedRows[0].Index;

                // Se obtiene el objeto CajaDeAhorro correspondiente a la fila seleccionada
                CajaDeAhorro Cajaseleccionada = arrayObjetos[filaSeleccionada];

                // if para comprobar si la extraccion puede realizarse(saldo > extraccion) y si el input no es negativo
                //el metodo extraer devuelve un bool asi que lo podemos utilizar como condicional
                if (Cajaseleccionada.Extraer(extrac))
                {
                    //anunciamos que el saldo ha sido actualizado en un label
                    extraclbl.Text = "Su saldo se ha actualizado";
                    //actualizo el saldo en la datagridview
                    datosdgtv.Rows[filaSeleccionada].Cells[2].Value = Cajaseleccionada.Saldo;
                    extracDepositxt.Text = "";
                }
                else
                {
                    extraclbl.Text = "Su saldo es insuficiente o negativo";
                }

            }
            else
            {
                extraclbl.Text = "Debes seleccionar una fila y poner un valor numerico";
            }
        }

        //BOTON DEPOSITAR
        private void depositarbtn_Click(object sender, EventArgs e)
        {
            //variable que servira de out para TryParse
            int deposit;

            // Se comprueba que se haya seleccionado una fila y que el valor sea un entero válido
            if (datosdgtv.SelectedRows.Count == 1 && int.TryParse(extracDepositxt.Text, out deposit))
            {
                //se obtiene el indice de la fila seleccionada por el usuario
                int filaSeleccionada = datosdgtv.SelectedRows[0].Index;

                // Se obtiene el objeto CajaDeAhorro correspondiente a la fila seleccionada
                CajaDeAhorro Cajaseleccionada = arrayObjetos[filaSeleccionada];

                // if para comprobar si el input es negativo
                if (deposit > 0)
                {
                    //utilizamos el metodo depositar para sumar el deposito del usuario a su saldo
                    Cajaseleccionada.Depositar(deposit);
                    extraclbl.Text = "Su saldo se ha actualizado";
                    //actualizo el saldo en la datagridview
                    datosdgtv.Rows[filaSeleccionada].Cells[2].Value = Cajaseleccionada.Saldo;
                    extracDepositxt.Text = "";
                }
                else
                {
                    extraclbl.Text = "El deposito no puede ser negativo";
                }

            }
            else
            {
                extraclbl.Text = "Debes seleccionar una fila y poner un valor numerico";
            }
        }

        //BOTON ELIMINAR
        private void eliminarbtn_Click(object sender, EventArgs e)
        {

            // Comprobamos si se ha seleccionado una sola fila
            if (datosdgtv.SelectedRows.Count == 1)
            {
                eliminarlbl.Text = "";

                // Obtenemos el indice de la fila
                int filaSeleccionada = datosdgtv.SelectedRows[0].Index;

                //removemos esa fila
                datosdgtv.Rows.RemoveAt(filaSeleccionada);

            }
            else
            {
                eliminarlbl.Text = "No ha seleccionado ningun campo";
            }
        }


        public class CajaDeAhorro
        {
            // Propiedades públicas para leer y escribir los atributos
            public int Saldo { get { return _saldo; } set { _saldo = value; } }
            public int NumeroCuenta { get { return _numeroCuenta; } }
            public string Nombre { get { return _nombre; } set { _nombre = value; } }
            public string TipoMoneda { get { return _tipoMoneda; } set { _tipoMoneda = value; } }


            // Constructor que inicializa los atributos con los valores de los parametros
            public CajaDeAhorro(int numerocuenta, string nombre, int saldo, string tipoMoneda)
            {
                _numeroCuenta = numerocuenta;
                _nombre = nombre;
                _saldo = saldo;
                _tipoMoneda = tipoMoneda;
            }

            // Metodo que muestra un mensaje con los datos de la caja de ahorro
            public void mostrarDatos()
            {
                MessageBox.Show($"El numero de cuenta {NumeroCuenta} del titular {_nombre} de saldo {_saldo} en {_tipoMoneda}");
            }

            //Metodo para hacer una extraccion comprobando que el parametro no sea negativo
            //y que el saldo sea mayor o igual que el monto a extraer
            public bool Extraer(int saldo)
            {
                if(saldo > 0)
                {
                    if (saldo <= Saldo)
                    {
                        Saldo -= saldo;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }

            //Metodo para realizar un deposito sumando el parametro al saldo
            public void Depositar(int saldo)
            {
                    Saldo += saldo;

            }

            //Atributos privados de la clase
            private int _saldo;
            private int _numeroCuenta;
            private string _nombre;
            private string _tipoMoneda;
        }

    }
}

