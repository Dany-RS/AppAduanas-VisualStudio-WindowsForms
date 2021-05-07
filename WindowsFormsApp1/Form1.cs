using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FormularioAduanas : Form
    {
        //cambio a private estas funciones porque solo las usa este formulario
        private bool Genera_Cabecera()
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

        private void Deshabilita_Registros()
        {
            regArgelia.Enabled = false;
            regAustralia.Enabled = false;
            regCaledonia.Enabled = false;
            regChile.Enabled = false;
            regCorea.Enabled = false;
            regEmiratos.Enabled = false;
            regGuadalupe.Enabled = false;
            regGuyana.Enabled = false;
            regIslandia.Enabled = false;
            regJapon.Enabled = false;
            regMarruecos.Enabled = false;
            regMartinica.Enabled = false;
            regMayotte.Enabled = false;
            regNoruega.Enabled = false;
            regOmar.Enabled = false;
            regQatar.Enabled = false;
            regReunion.Enabled = false;
            regSingapur.Enabled = false;
            regSudafrica.Enabled = false;
            regSuiza.Enabled = false;
            regTurquia.Enabled = false;
            regUK.Enabled = false;
            regIsrael.Enabled = false;
            regUcrania.Enabled = false;
        }

        private void Deshabilita_Lotes()
        {
            //texto - lote
            textLote_Letras_Argelia.Enabled = false;
            textLote_Letras_Australia.Enabled = false;
            textLote_Letras_Caledonia.Enabled = false;
            textLote_Letras_Chile.Enabled = false;
            textLote_Letras_Corea.Enabled = false;
            textLote_Letras_Emiratos.Enabled = false;
            textLote_Letras_Guadalupe.Enabled = false;
            textLote_Letras_Guyana.Enabled = false;
            textLote_Letras_Islandia.Enabled = false;
            textLote_Letras_Japon.Enabled = false;
            textLote_Letras_Marruecos.Enabled = false;
            textLote_Letras_Martinica.Enabled = false;
            textLote_Letras_Mayotte.Enabled = false;
            textLote_Letras_Noruega.Enabled = false;
            textLote_Letras_Omar.Enabled = false;
            textLote_Letras_Qatar.Enabled = false;
            textLote_Letras_Reunion.Enabled = false;
            textLote_Letras_Singapur.Enabled = false;
            textLote_Letras_Sudafrica.Enabled = false;
            textLote_Letras_Suiza.Enabled = false;
            textLote_Letras_Turquia.Enabled = false;
            textLote_Letras_UK.Enabled = false;
            textLote_Letras_Israel.Enabled = false;
            textLote_Letras_Ucrania.Enabled = false;

            //numero - lote
            textLote_Num_Argelia.Enabled = false;
            textLote_Num_Australia.Enabled = false;
            textLote_Num_Caledonia.Enabled = false;
            textLote_Num_Chile.Enabled = false;
            textLote_Num_Corea.Enabled = false;
            textLote_Num_Emiratos.Enabled = false;
            textLote_Num_Guadalupe.Enabled = false;
            textLote_Num_Guyana.Enabled = false;
            textLote_Num_Islandia.Enabled = false;
            textLote_Num_Japon.Enabled = false;
            textLote_Num_Marruecos.Enabled = false;
            textLote_Num_Martinica.Enabled = false;
            textLote_Num_Mayotte.Enabled = false;
            textLote_Num_Noruega.Enabled = false;
            textLote_Num_Omar.Enabled = false;
            textLote_Num_Qatar.Enabled = false;
            textLote_Num_Reunion.Enabled = false;
            textLote_Num_Singapur.Enabled = false;
            textLote_Num_Sudafrica.Enabled = false;
            textLote_Num_Suiza.Enabled = false;
            textLote_Num_Turquia.Enabled = false;
            textLote_Num_UK.Enabled = false;
            textLote_Num_Israel.Enabled = false;
            textLote_Num_Ucrania.Enabled = false;
        }

        private void Deshabilita_Grupos()
        {
            groupTren.Enabled = false;
            groupvalencia.Enabled = false;
            groupzeebrugge.Enabled = false;
            groupaarau.Enabled = false;
            grouprotterdam.Enabled = false;
            groupsantander.Enabled = false;
            groupbarcelona.Enabled = false;
            groupvigo.Enabled = false;
        }

        private void Inicializa_Checks()
        {
            //checks
            checkArgelia.Checked = false;
            checkAustralia.Checked = false;
            checkCaledonia.Checked = false;
            checkChile.Checked = false;
            checkCorea.Checked = false;
            checkEmiratos.Checked = false;
            checkGuadalupe.Checked = false;
            checkGuyana.Checked = false;
            checkIslandia.Checked = false;
            checkJapon.Checked = false;
            checkMarruecos.Checked = false;
            checkMartinica.Checked = false;
            checkMayotte.Checked = false;
            checkNoruega.Checked = false;
            checkOmar.Checked = false;
            checkQatar.Checked = false;
            checkReunion.Checked = false;
            checkSingapur.Checked = false;
            checkSudafrica.Checked = false;
            checkSuiza.Checked = false;
            checkTurquia.Checked = false;
            checkUK.Checked = false;
            checkIsrael.Checked = false;
            checkUcrania.Checked = false;
        }

        private void Inicializa_campos_texto()
        {
            //registros
            regArgelia.Text = "";
            regAustralia.Text = "";
            regCaledonia.Text = "";
            regChile.Text = "";
            regCorea.Text = "";
            regEmiratos.Text = "";
            regGuadalupe.Text = "";
            regGuyana.Text = "";
            regIslandia.Text = "";
            regJapon.Text = "";
            regMarruecos.Text = "";
            regMartinica.Text = "";
            regMayotte.Text = "";
            regNoruega.Text = "";
            regOmar.Text = "";
            regQatar.Text = "";
            regReunion.Text = "";
            regSingapur.Text = "";
            regSudafrica.Text = "";
            regSuiza.Text = "";
            regTurquia.Text = "";
            regUK.Text = "";
            regIsrael.Text = "";
            regUcrania.Text = "";

            //texto - lote
            textLote_Letras_Argelia.Text = "";
            textLote_Letras_Australia.Text = "";
            textLote_Letras_Caledonia.Text = "";
            textLote_Letras_Chile.Text = "";
            textLote_Letras_Corea.Text = "";
            textLote_Letras_Emiratos.Text = "";
            textLote_Letras_Guadalupe.Text = "";
            textLote_Letras_Guyana.Text = "";
            textLote_Letras_Islandia.Text = "";
            textLote_Letras_Japon.Text = "";
            textLote_Letras_Marruecos.Text = "";
            textLote_Letras_Martinica.Text = "";
            textLote_Letras_Mayotte.Text = "";
            textLote_Letras_Noruega.Text = "";
            textLote_Letras_Omar.Text = "";
            textLote_Letras_Qatar.Text = "";
            textLote_Letras_Reunion.Text = "";
            textLote_Letras_Singapur.Text = "";
            textLote_Letras_Sudafrica.Text = "";
            textLote_Letras_Suiza.Text = "";
            textLote_Letras_Turquia.Text = "";
            textLote_Letras_UK.Text = "";
            textLote_Letras_Israel.Text = "";
            textLote_Letras_Ucrania.Text = "";

            //numero - lote
            textLote_Num_Argelia.Text = "";
            textLote_Num_Australia.Text = "";
            textLote_Num_Caledonia.Text = "";
            textLote_Num_Chile.Text = "";
            textLote_Num_Corea.Text = "";
            textLote_Num_Emiratos.Text = "";
            textLote_Num_Guadalupe.Text = "";
            textLote_Num_Guyana.Text = "";
            textLote_Num_Islandia.Text = "";
            textLote_Num_Japon.Text = "";
            textLote_Num_Marruecos.Text = "";
            textLote_Num_Martinica.Text = "";
            textLote_Num_Mayotte.Text = "";
            textLote_Num_Noruega.Text = "";
            textLote_Num_Omar.Text = "";
            textLote_Num_Qatar.Text = "";
            textLote_Num_Reunion.Text = "";
            textLote_Num_Singapur.Text = "";
            textLote_Num_Sudafrica.Text = "";
            textLote_Num_Suiza.Text = "";
            textLote_Num_Turquia.Text = "";
            textLote_Num_UK.Text = "";
            textLote_Num_Israel.Text = "";
            textLote_Num_Ucrania.Text = "";
        }

        public FormularioAduanas()
        {
            InitializeComponent();
            //casilla tren
            groupTren.Enabled = false;
            //Inicializa registros
            Deshabilita_Registros();
            //Inicializa lotes
            Deshabilita_Lotes();
            //Inicializa grupos
            Deshabilita_Grupos();
        }

        private void GenerarListado_Click(object sender, EventArgs e)
        {
            //*************************** variables *****************************************
            string transporte;
            string puerto_descarga = "";
            string tren = "";
            //declaro una lista donde se van a meter destinos y registros
            List<string> lista_destinos   = new List<string>();
            List<string> datos_Turquia   = new List<string>();
            List<string> datos_Suiza     = new List<string>();
            List<string> datos_Japon     = new List<string>();
            List<string> datos_Uk        = new List<string>();
            List<string> datos_Corea     = new List<string>();
            List<string> datos_Reunion   = new List<string>();
            List<string> datos_Noruega   = new List<string>();
            List<string> datos_Mayotte   = new List<string>();
            List<string> datos_Sudafrica = new List<string>();
            List<string> datos_Caledonia = new List<string>();
            List<string> datos_Australia = new List<string>();
            List<string> datos_Marruecos = new List<string>();
            List<string> datos_Omar      = new List<string>();
            List<string> datos_Argelia   = new List<string>();
            List<string> datos_Singapur  = new List<string>();
            List<string> datos_Qatar     = new List<string>();
            List<string> datos_Emiratos  = new List<string>();
            List<string> datos_Guadalupe = new List<string>();
            List<string> datos_Guyana    = new List<string>();
            List<string> datos_Martinica = new List<string>();
            List<string> datos_Chile     = new List<string>();
            List<string> datos_Islandia  = new List<string>();
            List<string> datos_Israel    = new List<string>();
            List<string> datos_Ucrania   = new List<string>();

            //Booleanos para el control de cada cosa
            Boolean tpte              = false;
            Boolean puerto            = false;
            Boolean validar           = false;
            Boolean destino_Turquia   = false;
            Boolean destino_Suiza     = false;
            Boolean destino_Japon     = false;
            Boolean destino_Uk        = false;
            Boolean destino_Corea     = false;
            Boolean destino_Reunion   = false;
            Boolean destino_Noruega   = false;
            Boolean destino_Mayotte   = false;
            Boolean destino_Sudafrica = false;
            Boolean destino_Caledonia = false;
            Boolean destino_Australia = false;
            Boolean destino_Marruecos = false;
            Boolean destino_Omar      = false;
            Boolean destino_Argelia   = false;
            Boolean destino_Singapur  = false;
            Boolean destino_Qatar     = false;
            Boolean destino_Emiratos  = false;
            Boolean destino_Guadalupe = false;
            Boolean destino_Guyana    = false;
            Boolean destino_Martinica = false;
            Boolean destino_Chile     = false;
            Boolean destino_Islandia  = false;
            Boolean destino_Israel    = false;
            Boolean destino_Ucrania   = false;

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
            /*
             *             
            checkArgelia.Checked = false;
            checkAustralia.Checked = false;
            checkCaledonia.Checked = false;
            checkChile.Checked = false;
            checkCorea.Checked = false;
            checkEmiratos.Checked = false;
            checkGuadalupe.Checked = false;
            checkGuyana.Checked = false;
            checkIslandia.Checked = false;
            checkJapon.Checked = false;
            checkMarruecos.Checked = false;
            checkMartinica.Checked = false;
            checkMayotte.Checked = false;
            checkNoruega.Checked = false;
            checkOmar.Checked = false;
            checkQatar.Checked = false;
            checkReunion.Checked = false;
            checkSingapur.Checked = false;
            checkSudafrica.Checked = false;
            checkSuiza.Checked = false;
            checkTurquia.Checked = false;
            checkUK.Checked = false;
            checkIsrael.Checked = false;
            checkUcrania.Checked = false;
             */
            //Valida los datos para cada ciudad
            //si ningún destino check, entonces error
            if (checkArgelia.Checked == false && checkAustralia.Checked == false && checkCaledonia.Checked == false && checkChile.Checked == false &&
                checkCorea.Checked == false && checkEmiratos.Checked == false && checkGuadalupe.Checked == false && checkGuyana.Checked == false &&
                checkIslandia.Checked == false && checkJapon.Checked == false && checkMarruecos.Checked == false && checkMartinica.Checked == false &&
                checkMayotte.Checked == false && checkNoruega.Checked == false && checkOmar.Checked == false && checkQatar.Checked == false &&
                checkReunion.Checked == false && checkSingapur.Checked == false && checkSudafrica.Checked == false && checkSuiza.Checked == false &&
                checkTurquia.Checked == false && checkUK.Checked == false && checkIsrael.Checked == false && checkUcrania.Checked == false)
            {
                MessageBox.Show("Indicar destino.", "Falta destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Todas estas validaciones para cada país hay que hacerlas en una clase

            if (checkTurquia.Checked == true)
            {
                Validaciones valida_Turquia = new Validaciones("TURQUIA", regTurquia.Text, textLote_Letras_Turquia.Text, textLote_Num_Turquia.Text);
                datos_Turquia = valida_Turquia.ValidaDatos();
                if (datos_Turquia[0] == "KO") 
                {
                    MessageBox.Show(datos_Turquia[1], datos_Turquia[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    lista_datos = "";
                    destino_Turquia = true;
                    foreach (string elemento in datos_Turquia)
                    {
                        lista_datos += elemento + ",";
                    }

                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkSuiza.Checked == true)
            {
                Validaciones valida_Suiza = new Validaciones("SUIZA", regSuiza.Text, textLote_Letras_Suiza.Text, textLote_Num_Suiza.Text);
                datos_Suiza = valida_Suiza.ValidaDatos();
                if (datos_Suiza[0] == "KO")
                {
                    MessageBox.Show(datos_Suiza[1], datos_Suiza[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    destino_Suiza = true;
                    lista_datos = "";
                    foreach (string elemento in datos_Suiza)
                    {
                        lista_datos += elemento + ",";
                    }
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkJapon.Checked == true)
            {
                Validaciones valida_Japon = new Validaciones("JAPON", regJapon.Text, textLote_Letras_Japon.Text, textLote_Num_Japon.Text);
                datos_Japon = valida_Japon.ValidaDatos();
                if (datos_Japon[0] == "KO")
                {
                    MessageBox.Show(datos_Japon[1], datos_Japon[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    lista_datos = "";
                    foreach (string elemento in datos_Japon)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Japon = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkUK.Checked == true)
            {
                Validaciones valida_UK = new Validaciones("INGLATERRA", regUK.Text, textLote_Letras_UK.Text, textLote_Num_UK.Text);
                datos_Uk = valida_UK.ValidaDatos();
                if (datos_Uk[0] == "KO")
                {
                    MessageBox.Show(datos_Uk[1], datos_Uk[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    lista_datos = "";
                    foreach (string elemento in datos_Uk)
                    {
                        lista_datos += elemento + ","; 
                    }
                    destino_Uk = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkCorea.Checked == true)
            {
                Validaciones valida_Corea = new Validaciones("COREA", regCorea.Text, textLote_Letras_Corea.Text, textLote_Num_Corea.Text);
                datos_Corea = valida_Corea.ValidaDatos();
                if (datos_Corea[0] == "KO")
                {
                    MessageBox.Show(datos_Corea[1], datos_Corea[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Corea)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Corea = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkReunion.Checked == true)
            {
                Validaciones valida_Reunion = new Validaciones("REUNION", regReunion.Text, textLote_Letras_Reunion.Text, textLote_Num_Reunion.Text);
                datos_Reunion = valida_Reunion.ValidaDatos();
                if (datos_Reunion[0] == "KO")
                {
                    MessageBox.Show(datos_Reunion[1], datos_Reunion[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Reunion)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Reunion = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkNoruega.Checked == true)
            {
                Validaciones valida_Noruega = new Validaciones("NORUEGA", regNoruega.Text, textLote_Letras_Noruega.Text, textLote_Num_Noruega.Text);
                datos_Noruega = valida_Noruega.ValidaDatos();
                if (datos_Noruega[0] == "KO")
                {
                    MessageBox.Show(datos_Noruega[1], datos_Noruega[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Noruega)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Noruega = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkMayotte.Checked == true)
            {
                Validaciones valida_Mayotte = new Validaciones("MAYOTTE", regMayotte.Text, textLote_Letras_Mayotte.Text, textLote_Num_Mayotte.Text);
                datos_Mayotte = valida_Mayotte.ValidaDatos();
                if (datos_Mayotte[0] == "KO")
                {
                    MessageBox.Show(datos_Mayotte[1], datos_Mayotte[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Mayotte)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Mayotte = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkSudafrica.Checked == true)
            {
                Validaciones valida_Sudafrica = new Validaciones("SUDAFRICA", regSudafrica.Text, textLote_Letras_Sudafrica.Text, textLote_Num_Sudafrica.Text);
                datos_Sudafrica = valida_Sudafrica.ValidaDatos();
                if (datos_Sudafrica[0] == "KO")
                {
                    MessageBox.Show(datos_Sudafrica[1], datos_Sudafrica[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Sudafrica)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Sudafrica = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkCaledonia.Checked == true)
            {
                Validaciones valida_Caledonia = new Validaciones("NUEVA CALEDONIA", regCaledonia.Text, textLote_Letras_Caledonia.Text, textLote_Num_Caledonia.Text);
                datos_Caledonia = valida_Caledonia.ValidaDatos();
                if (datos_Caledonia[0] == "KO")
                {
                    MessageBox.Show(datos_Caledonia[1], datos_Caledonia[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Caledonia)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Caledonia = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkAustralia.Checked == true)
            {
                Validaciones valida_Australia = new Validaciones("AUSTRALIA", regAustralia.Text, textLote_Letras_Australia.Text, textLote_Num_Australia.Text);
                datos_Australia = valida_Australia.ValidaDatos();
                if (datos_Australia[0] == "KO")
                {
                    MessageBox.Show(datos_Australia[1], datos_Australia[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Australia)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Australia = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkMarruecos.Checked == true)
            {
                Validaciones valida_Marruecos = new Validaciones("MARRUECOS", regMarruecos.Text, textLote_Letras_Marruecos.Text, textLote_Num_Marruecos.Text);
                datos_Marruecos = valida_Marruecos.ValidaDatos();
                if (datos_Marruecos[0] == "KO")
                {
                    MessageBox.Show(datos_Marruecos[1], datos_Marruecos[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Marruecos)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Marruecos = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkOmar.Checked == true)
            {
                Validaciones valida_Omar = new Validaciones("OMAR", regOmar.Text, textLote_Letras_Omar.Text, textLote_Num_Omar.Text);
                datos_Omar = valida_Omar.ValidaDatos();
                if (datos_Omar[0] == "KO")
                {
                    MessageBox.Show(datos_Omar[1], datos_Omar[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Omar)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Omar = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkArgelia.Checked == true)
            {
                Validaciones valida_Argelia = new Validaciones("ARGELIA", regArgelia.Text, textLote_Letras_Argelia.Text, textLote_Num_Argelia.Text);
                datos_Argelia = valida_Argelia.ValidaDatos();
                if (datos_Argelia[0] == "KO")
                {
                    MessageBox.Show(datos_Argelia[1], datos_Argelia[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Argelia)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Argelia = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkSingapur.Checked == true)
            {
                Validaciones valida_Singapur = new Validaciones("SINGAPUR", regSingapur.Text, textLote_Letras_Singapur.Text, textLote_Num_Singapur.Text);
                datos_Singapur = valida_Singapur.ValidaDatos();
                if (datos_Singapur[0] == "KO")
                {
                    MessageBox.Show(datos_Singapur[1], datos_Singapur[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Singapur)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Singapur = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkQatar.Checked == true)
            {
                Validaciones valida_Qatar = new Validaciones("QATAR", regQatar.Text, textLote_Letras_Qatar.Text, textLote_Num_Qatar.Text);
                datos_Qatar = valida_Qatar.ValidaDatos();
                if (datos_Qatar[0] == "KO")
                {
                    MessageBox.Show(datos_Qatar[1], datos_Qatar[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Qatar)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Qatar = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkEmiratos.Checked == true)
            {
                Validaciones valida_Emiratos = new Validaciones("EMIRATOS", regEmiratos.Text, textLote_Letras_Emiratos.Text, textLote_Num_Emiratos.Text);
                datos_Emiratos = valida_Emiratos.ValidaDatos();
                if (datos_Emiratos[0] == "KO")
                {
                    MessageBox.Show(datos_Emiratos[1], datos_Emiratos[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Emiratos)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Emiratos = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkGuadalupe.Checked == true)
            {
                Validaciones valida_Guadalupe = new Validaciones("GUADALUPE", regGuadalupe.Text, textLote_Letras_Guadalupe.Text, textLote_Num_Guadalupe.Text);
                datos_Guadalupe = valida_Guadalupe.ValidaDatos();
                if (datos_Guadalupe[0] == "KO")
                {
                    MessageBox.Show(datos_Guadalupe[1], datos_Guadalupe[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Guadalupe)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Guadalupe = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkGuyana.Checked == true)
            {
                Validaciones valida_Guyana = new Validaciones("GUYANA", regGuyana.Text, textLote_Letras_Guyana.Text, textLote_Num_Guyana.Text);
                datos_Guyana = valida_Guyana.ValidaDatos();
                if (datos_Guyana[0] == "KO")
                {
                    MessageBox.Show(datos_Guyana[1], datos_Guyana[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Guyana)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Guyana = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkMartinica.Checked == true)
            {
                Validaciones valida_Martinica = new Validaciones("MARTINICA", regMartinica.Text, textLote_Letras_Martinica.Text, textLote_Num_Martinica.Text);
                datos_Martinica = valida_Martinica.ValidaDatos();
                if (datos_Martinica[0] == "KO")
                {
                    MessageBox.Show(datos_Martinica[1], datos_Martinica[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Martinica)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Martinica = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkChile.Checked == true)
            {
                Validaciones valida_Chile = new Validaciones("CHILE", regChile.Text, textLote_Letras_Chile.Text, textLote_Num_Chile.Text);
                datos_Chile = valida_Chile.ValidaDatos();
                if (datos_Chile[0] == "KO")
                {
                    MessageBox.Show(datos_Chile[1], datos_Chile[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Chile)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Chile = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkIslandia.Checked == true)
            {
                Validaciones valida_Islandia = new Validaciones("ISLANDIA", regIslandia.Text, textLote_Letras_Islandia.Text, textLote_Num_Islandia.Text);
                datos_Islandia = valida_Islandia.ValidaDatos();
                if (datos_Islandia[0] == "KO")
                {
                    MessageBox.Show(datos_Islandia[1], datos_Islandia[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Islandia)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Islandia = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkIsrael.Checked == true)
            {
                Validaciones valida_Israel = new Validaciones("ISRAEL", regIsrael.Text, textLote_Letras_Israel.Text, textLote_Num_Israel.Text);
                datos_Israel = valida_Israel.ValidaDatos();
                if (datos_Israel[0] == "KO")
                {
                    MessageBox.Show(datos_Israel[1], datos_Israel[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Israel)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Israel = true;
                    lista_destinos.Add(lista_datos);
                }
            }

            if (checkUcrania.Checked == true)
            {
                Validaciones valida_Ucrania = new Validaciones("UCRANIA", regUcrania.Text, textLote_Letras_Ucrania.Text, textLote_Num_Ucrania.Text);
                datos_Ucrania = valida_Ucrania.ValidaDatos();
                if (datos_Ucrania[0] == "KO")
                {
                    MessageBox.Show(datos_Ucrania[1], datos_Ucrania[2], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lista_datos = "";
                    foreach (string elemento in datos_Ucrania)
                    {
                        lista_datos += elemento + ",";
                    }
                    destino_Ucrania = true;
                    lista_destinos.Add(lista_datos);
                }
            }
            //destino OK, puerto descarga OK y algún destino está OK
            if (tpte == true && puerto == true && (destino_Turquia == true || destino_Suiza == true || destino_Japon == true || destino_Uk == true ||
                destino_Corea == true || destino_Reunion == true || destino_Noruega == true ||destino_Mayotte == true || destino_Sudafrica == true ||
                destino_Caledonia == true || destino_Australia == true || destino_Marruecos == true || destino_Omar == true ||destino_Argelia == true ||
                destino_Singapur == true || destino_Qatar == true || destino_Emiratos == true || destino_Guadalupe == true || destino_Guyana == true ||
                destino_Martinica == true || destino_Chile == true || destino_Islandia == true || destino_Israel == true || destino_Ucrania == true))
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
            //Inicializa Checks
            Inicializa_Checks();
            //Inicializa textos
            Inicializa_campos_texto();
            //grupos
            Deshabilita_Grupos();
            //ComboBox y Tren            
            comboPuertos.Text = "";
            textTren.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioTren_CheckedChanged(object sender, EventArgs e)
        {
            groupTren.Enabled = true;
        }

        private void radioCarretera_CheckedChanged(object sender, EventArgs e)
        {
            groupTren.Enabled = false;
        }

        private void comboPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPuertos.Text == "PTO VALENCIA")
            {
                groupvalencia.Enabled = true;
            }
            else { groupvalencia.Enabled = false; Inicializa_campos_texto(); Inicializa_Checks(); }

            if (comboPuertos.Text == "PTO ZEEBRUGGE")
            {
                groupzeebrugge.Enabled = true;
            }
            else { groupzeebrugge.Enabled = false; Inicializa_campos_texto(); Inicializa_Checks(); }

            if (comboPuertos.Text == "PTO. ROTTERDAM")
            {
                grouprotterdam.Enabled = true;
            }
            else { grouprotterdam.Enabled = false; Inicializa_campos_texto(); Inicializa_Checks(); }

            if (comboPuertos.Text == "AARAU")
            {
                groupaarau.Enabled = true;
            }
            else { groupaarau.Enabled = false; Inicializa_campos_texto(); Inicializa_Checks(); }

            if (comboPuertos.Text == "PTO SANTANDER")
            {
                groupsantander.Enabled = true;
            }
            else { groupsantander.Enabled = false; Inicializa_campos_texto(); Inicializa_Checks(); }

            if (comboPuertos.Text == "PTO BARCELONA")
            {
                groupbarcelona.Enabled = true;
            }
            else { groupbarcelona.Enabled = false; Inicializa_campos_texto(); Inicializa_Checks(); }

            if (comboPuertos.Text == "PTO VIGO")
            {
                groupvigo.Enabled = true;
            }
            else { groupvigo.Enabled = false; Inicializa_campos_texto(); Inicializa_Checks(); }

        }

        // CONTROLES DE LOS CHECK
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
        private void checkIslandia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIslandia.Checked == false)
            {
                regIslandia.Text = "";
                textLote_Letras_Islandia.Text = "";
                textLote_Num_Islandia.Text = "";
                regIslandia.Enabled = false;
                textLote_Letras_Islandia.Enabled = false;
                textLote_Num_Islandia.Enabled = false;
            }
            else
            {
                regIslandia.Enabled = true;
                textLote_Letras_Islandia.Enabled = true;
                textLote_Num_Islandia.Enabled = true;
            }
        }

        private void checkCorea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCorea.Checked == false)
            {
                regCorea.Text = "";
                textLote_Letras_Corea.Text = "";
                textLote_Num_Corea.Text = "";
                regCorea.Enabled = false;
                textLote_Letras_Corea.Enabled = false;
                textLote_Num_Corea.Enabled = false;
            }
            else
            {
                regCorea.Enabled = true;
                textLote_Letras_Corea.Enabled = true;
                textLote_Num_Corea.Enabled = true;
            }
        }

        private void checkReunion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReunion.Checked == false)
            {
                regReunion.Text = "";
                textLote_Letras_Reunion.Text = "";
                textLote_Num_Reunion.Text = "";
                regReunion.Enabled = false;
                textLote_Letras_Reunion.Enabled = false;
                textLote_Num_Reunion.Enabled = false;
            }
            else
            {
                regReunion.Enabled = true;
                textLote_Letras_Reunion.Enabled = true;
                textLote_Num_Reunion.Enabled = true;
            }
        }

        private void checkNoruega_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNoruega.Checked == false)
            {
                regNoruega.Text = "";
                textLote_Letras_Noruega.Text = "";
                textLote_Num_Noruega.Text = "";
                regNoruega.Enabled = false;
                textLote_Letras_Noruega.Enabled = false;
                textLote_Num_Noruega.Enabled = false;
            }
            else
            {
                regNoruega.Enabled = true;
                textLote_Letras_Noruega.Enabled = true;
                textLote_Num_Noruega.Enabled = true;
            }
        }

        private void checkMayotte_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMayotte.Checked == false)
            {
                regMayotte.Text = "";
                textLote_Letras_Mayotte.Text = "";
                textLote_Num_Mayotte.Text = "";
                regMayotte.Enabled = false;
                textLote_Letras_Mayotte.Enabled = false;
                textLote_Num_Mayotte.Enabled = false;
            }
            else
            {
                regMayotte.Enabled = true;
                textLote_Letras_Mayotte.Enabled = true;
                textLote_Num_Mayotte.Enabled = true;
            }
        }

        private void checkSudafrica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSudafrica.Checked == false)
            {
                regSudafrica.Text = "";
                textLote_Letras_Sudafrica.Text = "";
                textLote_Num_Sudafrica.Text = "";
                regSudafrica.Enabled = false;
                textLote_Letras_Sudafrica.Enabled = false;
                textLote_Num_Sudafrica.Enabled = false;
            }
            else
            {
                regSudafrica.Enabled = true;
                textLote_Letras_Sudafrica.Enabled = true;
                textLote_Num_Sudafrica.Enabled = true;
            }
        }

        private void checkCaledonia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCaledonia.Checked == false)
            {
                regCaledonia.Text = "";
                textLote_Letras_Caledonia.Text = "";
                textLote_Num_Caledonia.Text = "";
                regCaledonia.Enabled = false;
                textLote_Letras_Caledonia.Enabled = false;
                textLote_Num_Caledonia.Enabled = false;
            }
            else
            {
                regCaledonia.Enabled = true;
                textLote_Letras_Caledonia.Enabled = true;
                textLote_Num_Caledonia.Enabled = true;
            }
        }

        private void checkAustralia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAustralia.Checked == false)
            {
                regAustralia.Text = "";
                textLote_Letras_Australia.Text = "";
                textLote_Num_Australia.Text = "";
                regAustralia.Enabled = false;
                textLote_Letras_Australia.Enabled = false;
                textLote_Num_Australia.Enabled = false;
            }
            else
            {
                regAustralia.Enabled = true;
                textLote_Letras_Australia.Enabled = true;
                textLote_Num_Australia.Enabled = true;
            }
        }

        private void checkMarruecos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMarruecos.Checked == false)
            {
                regMarruecos.Text = "";
                textLote_Letras_Marruecos.Text = "";
                textLote_Num_Marruecos.Text = "";
                regMarruecos.Enabled = false;
                textLote_Letras_Marruecos.Enabled = false;
                textLote_Num_Marruecos.Enabled = false;
            }
            else
            {
                regMarruecos.Enabled = true;
                textLote_Letras_Marruecos.Enabled = true;
                textLote_Num_Marruecos.Enabled = true;
            }
        }

        private void checkOmar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOmar.Checked == false)
            {
                regOmar.Text = "";
                textLote_Letras_Omar.Text = "";
                textLote_Num_Omar.Text = "";
                regOmar.Enabled = false;
                textLote_Letras_Omar.Enabled = false;
                textLote_Num_Omar.Enabled = false;
            }
            else
            {
                regOmar.Enabled = true;
                textLote_Letras_Omar.Enabled = true;
                textLote_Num_Omar.Enabled = true;
            }
        }

        private void checkArgelia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkArgelia.Checked == false)
            {
                regArgelia.Text = "";
                textLote_Letras_Argelia.Text = "";
                textLote_Num_Argelia.Text = "";
                regArgelia.Enabled = false;
                textLote_Letras_Argelia.Enabled = false;
                textLote_Num_Argelia.Enabled = false;
            }
            else
            {
                regArgelia.Enabled = true;
                textLote_Letras_Argelia.Enabled = true;
                textLote_Num_Argelia.Enabled = true;
            }
        }

        private void checkSingapur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSingapur.Checked == false)
            {
                regSingapur.Text = "";
                textLote_Letras_Singapur.Text = "";
                textLote_Num_Singapur.Text = "";
                regSingapur.Enabled = false;
                textLote_Letras_Singapur.Enabled = false;
                textLote_Num_Singapur.Enabled = false;
            }
            else
            {
                regSingapur.Enabled = true;
                textLote_Letras_Singapur.Enabled = true;
                textLote_Num_Singapur.Enabled = true;
            }
        }

        private void checkQatar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkQatar.Checked == false)
            {
                regQatar.Text = "";
                textLote_Letras_Qatar.Text = "";
                textLote_Num_Qatar.Text = "";
                regQatar.Enabled = false;
                textLote_Letras_Qatar.Enabled = false;
                textLote_Num_Qatar.Enabled = false;
            }
            else
            {
                regQatar.Enabled = true;
                textLote_Letras_Qatar.Enabled = true;
                textLote_Num_Qatar.Enabled = true;
            }
        }

        private void checkEmiratos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmiratos.Checked == false)
            {
                regEmiratos.Text = "";
                textLote_Letras_Emiratos.Text = "";
                textLote_Num_Emiratos.Text = "";
                regEmiratos.Enabled = false;
                textLote_Letras_Emiratos.Enabled = false;
                textLote_Num_Emiratos.Enabled = false;
            }
            else
            {
                regEmiratos.Enabled = true;
                textLote_Letras_Emiratos.Enabled = true;
                textLote_Num_Emiratos.Enabled = true;
            }
        }

        private void checkGuadalupe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGuadalupe.Checked == false)
            {
                regGuadalupe.Text = "";
                textLote_Letras_Guadalupe.Text = "";
                textLote_Num_Guadalupe.Text = "";
                regGuadalupe.Enabled = false;
                textLote_Letras_Guadalupe.Enabled = false;
                textLote_Num_Guadalupe.Enabled = false;
            }
            else
            {
                regGuadalupe.Enabled = true;
                textLote_Letras_Guadalupe.Enabled = true;
                textLote_Num_Guadalupe.Enabled = true;
            }
        }

        private void checkGuyana_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGuyana.Checked == false)
            {
                regGuyana.Text = "";
                textLote_Letras_Guyana.Text = "";
                textLote_Num_Guyana.Text = "";
                regGuyana.Enabled = false;
                textLote_Letras_Guyana.Enabled = false;
                textLote_Num_Guyana.Enabled = false;
            }
            else
            {
                regGuyana.Enabled = true;
                textLote_Letras_Guyana.Enabled = true;
                textLote_Num_Guyana.Enabled = true;
            }
        }

        private void checkMartinica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMartinica.Checked == false)
            {
                regMartinica.Text = "";
                textLote_Letras_Martinica.Text = "";
                textLote_Num_Martinica.Text = "";
                regMartinica.Enabled = false;
                textLote_Letras_Martinica.Enabled = false;
                textLote_Num_Martinica.Enabled = false;
            }
            else
            {
                regMartinica.Enabled = true;
                textLote_Letras_Martinica.Enabled = true;
                textLote_Num_Martinica.Enabled = true;
            }
        }

        private void checkChile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChile.Checked == false)
            {
                regChile.Text = "";
                textLote_Letras_Chile.Text = "";
                textLote_Num_Chile.Text = "";
                regChile.Enabled = false;
                textLote_Letras_Chile.Enabled = false;
                textLote_Num_Chile.Enabled = false;
            }
            else
            {
                regChile.Enabled = true;
                textLote_Letras_Chile.Enabled = true;
                textLote_Num_Chile.Enabled = true;
            }
        }

        private void checkIsrael_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsrael.Checked == false)
            {
                regIsrael.Text = "";
                textLote_Letras_Israel.Text = "";
                textLote_Num_Israel.Text = "";
                regIsrael.Enabled = false;
                textLote_Letras_Israel.Enabled = false;
                textLote_Num_Israel.Enabled = false;
            }
            else
            {
                regIsrael.Enabled = true;
                textLote_Letras_Israel.Enabled = true;
                textLote_Num_Israel.Enabled = true;
            }
        }

        private void checkUcrania_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkUcrania.Checked == false)
            {
                regUcrania.Text = "";
                textLote_Letras_Ucrania.Text = "";
                textLote_Num_Ucrania.Text = "";
                regUcrania.Enabled = false;
                textLote_Letras_Ucrania.Enabled = false;
                textLote_Num_Ucrania.Enabled = false;
            }
            else
            {
                regUcrania.Enabled = true;
                textLote_Letras_Ucrania.Enabled = true;
                textLote_Num_Ucrania.Enabled = true;
            }
        }
    }
}