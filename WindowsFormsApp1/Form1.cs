using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FormularioAduanas : Form
    {
        public bool Genera_Cabecera()
        {
            string listadoCabecera;
            string fecha;
            GenerarListado cabecera = new GenerarListado();
            fecha = cabecera.CreaFecha();
            listadoCabecera = cabecera.CreaCabecera(fecha);
            if (listadoCabecera != "EXISTE")
                { cabecera.GeneraFichero(fecha, listadoCabecera); return true; }
            else { return false; }
            
        }
        public FormularioAduanas()
        {
            InitializeComponent();
            regTurquia.Enabled = false;
            regSuiza.Enabled = false;
            regJapon.Enabled = false;
            regUK.Enabled = false;
            textLote_Letras_Turquia.Enabled = false;
            textLote_Num_Turquia.Enabled = false;
            textLote_Letras_Suiza.Enabled = false;
            textLote_Num_Suiza.Enabled = false;
            textLote_Letras_Japon.Enabled = false;
            textLote_Num_Japon.Enabled = false;
            textLote_Letras_UK.Enabled = false;
            textLote_Num_UK.Enabled = false;
            groupTren.Visible = false;
        }

        private void GenerarListado_Click(object sender, EventArgs e)
        {
            //*************************** variables *****************************************
            string transporte;
            string puerto_descarga = "";
            string tren = "";
            //Boolean turquia = false, suiza = false, japon = false, UK = false;
            //declaro una lista donde se van a meter destinos y registros
            List<string> lista_destinos = new List<string>();
            List<string> datos_turquia = new List<string>();
            List<string> datos_suiza = new List<string>();
            List<string> datos_japon = new List<string>();
            List<string> datos_uk = new List<string>();
            Boolean tpte = false;
            Boolean puerto = false;
            Boolean validar = false;
            Boolean destino_turquia = false;
            Boolean destino_suiza = false;
            Boolean destino_japon = false;
            Boolean destino_uk = false;
            string lista_datos;
            string listadoFinal;
            


            //********************** VALIDACIONES *********************************************

            //validar transporte
            if (radioCarretera.Checked == true)
            {
                transporte = "CARRETERA";
                tpte = true;
            }
            else 
            { 
                transporte = "FERROCARRIL";
                //valido el tren informado
                if (textTren.Text == "")
                {
                    MessageBox.Show("Falta Tren", "Error en campo Tren", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    tpte = true;
                    tren = textTren.Text;
                }
            }

            //valido combo Puertos Descarga
            if (comboPuertos.Text == "")
            {
                MessageBox.Show("Revisar puerto de Descarga.", "Falta puerto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                puerto = true;
                puerto_descarga = comboPuertos.Text;
            }

            //Valida los datos para cada ciudad
            //si ningún destino check, entonces error
            if (checkTurquia.Checked == false && checkSuiza.Checked == false && checkJapon.Checked == false && checkUK.Checked == false)
            {
                MessageBox.Show("Indicar destino.", "Falta destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (checkTurquia.Checked == true)
            {
                Validaciones valida_Turquia = new Validaciones("TURQUIA", regTurquia.Text, textLote_Letras_Turquia.Text, textLote_Num_Turquia.Text);
                datos_turquia = valida_Turquia.ValidaDatos();
                if (datos_turquia[0] == "KO") 
                {
                    MessageBox.Show(datos_turquia[1], datos_turquia[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    lista_datos = "";
                    destino_turquia = true;
                    foreach (string elemento in datos_turquia)
                    {
                        lista_datos += elemento + ",";
                    }

                    lista_destinos.Add(lista_datos);
                }

            }

            if (checkSuiza.Checked == true)
            {
                Validaciones valida_Suiza = new Validaciones("SUIZA", regSuiza.Text, textLote_Letras_Suiza.Text, textLote_Num_Suiza.Text);
                datos_suiza = valida_Suiza.ValidaDatos();
                if (datos_suiza[0] == "KO")
                {
                    MessageBox.Show(datos_suiza[1], datos_suiza[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    destino_suiza = true;
                    lista_datos = "";
                    foreach (string elemento in datos_suiza)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_suiza = true;
                    lista_destinos.Add(lista_datos);
                }

            }

            if (checkJapon.Checked == true)
            {
                Validaciones valida_Japon = new Validaciones("JAPON", regJapon.Text, textLote_Letras_Japon.Text, textLote_Num_Japon.Text);
                datos_japon = valida_Japon.ValidaDatos();
                if (datos_japon[0] == "KO")
                {
                    MessageBox.Show(datos_japon[1], datos_japon[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    destino_japon = true;
                    lista_datos = "";
                    foreach (string elemento in datos_japon)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_suiza = true;
                    lista_destinos.Add(lista_datos);
                }

            }

            if (checkUK.Checked == true)
            {
                Validaciones valida_UK = new Validaciones("INGLATERRA", regUK.Text, textLote_Letras_UK.Text, textLote_Num_UK.Text);
                datos_uk = valida_UK.ValidaDatos();
                if (datos_uk[0] == "KO")
                {
                    MessageBox.Show(datos_uk[1], datos_uk[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    destino_uk = true;
                    lista_datos = "";
                    foreach (string elemento in datos_uk)
                    {
                        lista_datos += elemento + ","; 
                    }
                    destino_suiza = true;
                    lista_destinos.Add(lista_datos);
                }

            }


            //destino OK, puerto descarga OK y algún destino está OK
            if (tpte == true && puerto == true && (destino_turquia == true || destino_suiza == true || destino_japon == true || destino_uk == true))
            {
                validar = true;
            }



            //////************************* SI TODO OK ENTONCES GENERA LISTADO ******************
            if (validar == true)
            {
                string fecha;
                Boolean escrito;
                if (transporte == "CARRETERA") 
                    {

                    //genera listado de carretera y lo escribe
                    GenerarListado listado_carretera = new GenerarListado(transporte, puerto_descarga, lista_destinos);
                    listadoFinal = listado_carretera.Generador();
                    fecha = listado_carretera.CreaFecha();

                    //Verifico si existe el fichero para indicar que se va a seguir escribiendo en él o por el contrario escribir la cabecera y la primera tanda de registros
                    if (listado_carretera.VerificaFichero(fecha) == true )
                    {
                        var resultado = MessageBox.Show("El fichero existe, se va a seguir escribiendo en él. Si no quieres seguir escribiéndolo, renómbralo antes!!.", "Fichero existente.", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            escrito = listado_carretera.GeneraFichero(fecha, listadoFinal);
                            if (escrito == true)
                            {
                                MessageBox.Show("Listado CARRETERA generado OK", "Fichero generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }else
                            {
                                MessageBox.Show("Opps!! algo raro ha pasado, listado no generado", "Fichero no generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Listado no generado", "Fichero no generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else 
                    {
                        //en Genera_Cabecera, se controla si existe el fichero escribe cabecera, si no existe, no hace nada
                        Genera_Cabecera();
                        escrito = listado_carretera.GeneraFichero(fecha, listadoFinal);
                        if (escrito == true)
                        {
                            MessageBox.Show("Listado CARRETERA generado OK", "Fichero generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Opps!! algo raro ha pasado, listado no generado", "Fichero no generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    //genera listado de tren y lo escribe
                    GenerarListado listado_tren = new GenerarListado(transporte, puerto_descarga, lista_destinos, tren);
                    listadoFinal = listado_tren.Generador_Tren();
                    fecha = listado_tren.CreaFecha();
                    //Verifico si existe el fichero para indicar que se va a seguir escribiendo en él.
                    if (listado_tren.VerificaFichero(fecha) == true)
                    {
                        var resultado = MessageBox.Show("El fichero existe, se va a seguir escribiendo en él. Si no quieres seguir escribiéndolo, renómbralo antes!!.", "Fichero existente.", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            escrito = listado_tren.GeneraFichero(fecha, listadoFinal);
                            if (escrito == true)
                            {
                                MessageBox.Show("Listado TREN generado OK", "Fichero generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Opps!! algo raro ha pasado, listado no generado", "Fichero no generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Listado no generado", "Fichero no generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        //en Genera_Cabecera, se controla si existe el fichero escribe cabecera, si no existe, no hace nada
                        Genera_Cabecera();
                        escrito = listado_tren.GeneraFichero(fecha, listadoFinal);
                        if (escrito == true)
                        {
                            MessageBox.Show("Listado TREN generado OK", "Fichero generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Opps!! algo raro ha pasado, listado no generado", "Fichero no generado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                //pinta la caja texto
                richTextBox1.Text = listadoFinal;
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            checkTurquia.Checked = false;
            regTurquia.Text = "";
            textLote_Letras_Turquia.Text = "";
            textLote_Num_Turquia.Text = "";

            checkSuiza.Checked = false;
            regSuiza.Text = "";
            textLote_Letras_Suiza.Text = "";
            textLote_Num_Suiza.Text = "";

            checkJapon.Checked = false;
            regJapon.Text = "";
            textLote_Letras_Japon.Text = "";
            textLote_Num_Japon.Text = "";

            checkUK.Checked = false;
            regUK.Text = "";
            textLote_Letras_UK.Text = "";
            textLote_Num_UK.Text = "";

            comboPuertos.Text = "";
            textTren.Text = "";
        }

        private void checkTurquia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTurquia.Checked == false)
            {
                regTurquia.Text = "";
                textLote_Letras_Turquia.Text = "";
                textLote_Num_Turquia.Text = "";
                regTurquia.Enabled = false;
                textLote_Letras_Turquia.Enabled = false;
                textLote_Num_Turquia.Enabled = false;
            }
            else 
            { 
                regTurquia.Enabled = true;
                textLote_Letras_Turquia.Enabled = true;
                textLote_Num_Turquia.Enabled = true;
            }
        }

        private void checkSuiza_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSuiza.Checked == false)
            {
                regSuiza.Text = "";
                textLote_Letras_Suiza.Text = "";
                textLote_Num_Suiza.Text = "";
                regSuiza.Enabled = false;
                textLote_Letras_Suiza.Enabled = false;
                textLote_Num_Suiza.Enabled = false;
            }
            else 
            { 
                regSuiza.Enabled = true;
                textLote_Letras_Suiza.Enabled = true;
                textLote_Num_Suiza.Enabled = true;
            }
        }

        private void checkJapon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJapon.Checked == false)
            {
                regJapon.Text = "";
                textLote_Letras_Japon.Text = "";
                textLote_Num_Japon.Text = "";
                regJapon.Enabled = false;
                textLote_Letras_Japon.Enabled = false;
                textLote_Num_Japon.Enabled = false;
            }
            else 
            { 
                regJapon.Enabled = true;
                textLote_Letras_Japon.Enabled = true;
                textLote_Num_Japon.Enabled = true;
            }
        }

        private void checkUK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUK.Checked == false)
            {
                regUK.Text = "";
                textLote_Letras_UK.Text = "";
                textLote_Num_UK.Text = "";
                regUK.Enabled = false;
                textLote_Letras_UK.Enabled = false;
                textLote_Num_UK.Enabled = false;
            }
            else 
            { 
                regUK.Enabled = true;
                textLote_Letras_UK.Enabled = true;
                textLote_Num_UK.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioTren_CheckedChanged(object sender, EventArgs e)
        {
            groupTren.Visible = true;
        }

        private void radioCarretera_CheckedChanged(object sender, EventArgs e)
        {
            groupTren.Visible = false;
        }


    }
}


