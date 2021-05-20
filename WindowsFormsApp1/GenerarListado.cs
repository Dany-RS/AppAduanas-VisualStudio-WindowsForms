using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace WindowsFormsApp1
{
    class GenerarListado
    {
        public string transporte;
        public List<string> lista_destinos;
        public string puerto;
        public string tren;

        //constructor para cabecera
        public GenerarListado() { }
        //dos constructores, uno para carretera y otro para tren
        public GenerarListado(string transporte, string puerto, List<string> lista_destino)
        {
            this.transporte = transporte;
            this.puerto = puerto;
            this.lista_destinos = lista_destino;
        }

        public GenerarListado(string transporte, string puerto, List<string> lista_destino, string tren)
        {
            this.transporte = transporte;
            this.puerto = puerto;
            this.lista_destinos = lista_destino;
            this.tren = tren;
        }

        private string Genera_Matriculas()
        {
            string camion;
            GeneraMatriculas solonumeros = new GeneraMatriculas(0, 9999);
            string randomNumber = solonumeros.RandomNumeros();
            GeneraMatriculas sololetras = new GeneraMatriculas(2);
            string randomLetras = sololetras.RandomLetters();
            camion = "R" + randomNumber + "B" + randomLetras;
            return camion;
        }

        //método para generar el listado
        public string Generador()
        {
            //******* inicialización variables del método ************
            string fila = "";
            DateTime fechaHora = DateTime.Now; //fecha y hora
            int year = fechaHora.Year;
            //para controlar matrículas al cambio de ciudad y de matrículas de remolques
            string ciudadAnterior = "";
            //para separar valores de la lista de registros
            string[] elemento_lista = new string[5];//como pasamos 5 elementos con comas, los vamos a separar luego para coger el que corresponda
            Boolean remolques8 = true;
            Boolean primeraVez = true;
            int numRem7 = 0;
            int numRem8 = 0;
            int numRem9 = 0;
            string remolque = "";
            string remolque2 = "";
            string remolque3 = "";


            //crea filas del documento según los criterios indicados
            //Count nos indica los elementos de la lista
            for (int i = 0; i < lista_destinos.Count; i++)
            {
                //string lista = lista_destinos[i];
                //datos en la lista = lista de ["OK", numRegistros, ciudad, letrasLote, numerosLote] * cada ciudad
                elemento_lista = lista_destinos[i].Split(',');
                int longitud = int.Parse(elemento_lista[1]);
                int lotes = int.Parse(elemento_lista[4]);
                string year_string = Convert.ToString(year);
                string anio = year_string.Substring(2, 2);
                //hay que controlar el cambio de ciudad para el cambio de matrícula
                string ciudad = elemento_lista[2].ToUpper(); 
                //se puede controlar que si vienen 9 se haga un registro solo de 9 y no uno de 8 y el que sobra se mete en el de 9
                if (longitud == 9) { remolques8 = false; }
                
                for (int k = 0; k < longitud; k++)
                {
                    if (elemento_lista[2].ToUpper() != "SUIZA") {
                        
                        if (remolques8 == true)
                        {
                            //Si hay cambio de ciudad se activa la primera vez para que cambie la matrícula
                            if (ciudad != ciudadAnterior) { primeraVez = true; }
                            //Generación de matriculas
                            if (primeraVez == true)
                            {
                                //hay que hacer el 'DO' hasta que cambie el valor de la matrícula. Random depende del valor del tiempo del sistema, si no cambia un milisegundo, devolverá la misma matrícula y el tiempo en ejecutar un bloque de 8 y de 9 es muy muy pequeño
                                do { remolque = Genera_Matriculas(); }
                                while (remolque == remolque2 || remolque == remolque3);
                                primeraVez = false;
                                ciudadAnterior = ciudad; //una vez generada la matrícula para esa ciudad, la guardamos
                                lotes += 1;
                            }
                            //Se escribe el registro, según sea JAPON va sin matriculas de remolque y los demás sí la llevan
                            if (elemento_lista[2].ToUpper() != "JAPON") { fila += "VALLADOLID" + "," + anio + "," + "," + transporte + "," + puerto + "," + elemento_lista[2].ToUpper() + "," + elemento_lista[3].ToUpper() + lotes + "," + remolque + "\n"; }
                            else { fila += "VALLADOLID" + "," + anio + "," + "," + transporte + "," + puerto + "," + elemento_lista[2].ToUpper() + "," + elemento_lista[3].ToUpper() + lotes + "\n"; }
                            numRem8++;
                            //se inicializan valores y cambian booleanos para que ejecute el bloque de 9 y aquí quede inicializado los contadores
                            if (numRem8 == 8 || (k == longitud-1)) { remolques8 = false; primeraVez = true; numRem8 = 0; numRem7 = 0; numRem9 = 0; }
                        }
                        else
                        {
                            //Si hay cambio de ciudad se activa la primera vez para que cambie la matrícula
                            if (ciudad != ciudadAnterior) { primeraVez = true; }
                            //Generación de matriculas
                            if (primeraVez == true)
                            {
                                //hay que hacer el 'DO' hasta que cambie el valor de la matrícula. Random depende del valor del tiempo del sistema, si no cambia un milisegundo, devolverá la misma matrícula y el tiempo en ejecutar un bloque de 8 y de 9 es muy muy pequeño
                                do { remolque2 = Genera_Matriculas(); }
                                while (remolque2 == remolque || remolque2 == remolque3);
                                primeraVez = false;
                                ciudadAnterior = ciudad;
                                lotes += 1;
                            }
                            //Se escribe el registro, según sea JAPON va sin matriculas de remolque y los demás sí la llevan
                            if (elemento_lista[2].ToUpper() != "JAPON") { fila += "VALLADOLID" + "," + anio + "," + "," + transporte + "," + puerto + "," + elemento_lista[2].ToUpper() + "," + elemento_lista[3].ToUpper() + lotes + "," + remolque2 + "\n"; }
                            else { fila += "VALLADOLID" + "," + anio + "," + "," + transporte + "," + puerto + "," + elemento_lista[2].ToUpper() + "," + elemento_lista[3].ToUpper() + lotes + "\n"; }
                            numRem9++;
                            //se inicializan valores y cambian booleanos para que ejecute el bloque de 8 y aquí quede inicializado los contadores
                            if (numRem9 == 9 || (k == longitud - 1)) { remolques8 = true; primeraVez = true; numRem9 = 0; numRem7 = 0; numRem8 = 0; }
                        }
                    }
                    else {
                        //Si hay cambio de ciudad se activa la primera vez para que cambie la matrícula
                        if (ciudad != ciudadAnterior) { primeraVez = true; }

                        //Generación de matriculas
                        if (primeraVez == true)
                        {
                            do { remolque3 = Genera_Matriculas(); }
                            while (remolque3 == remolque || remolque2 == remolque3);
                            primeraVez = false;
                            ciudadAnterior = ciudad;
                            lotes += 1;
                        }
                        //escribe el registro
                        fila += "VALLADOLID" + "," + anio + "," + "," + transporte + "," + puerto + "," + elemento_lista[2].ToUpper() + "," + elemento_lista[3].ToUpper() + lotes + "\n";
                        numRem7++;
                        //se inicializan valores y cambian booleanos para que ejecute el bloque de 8 y aquí quede inicializado los contadores
                        if (numRem7 == 7 || (k == longitud - 1)) { primeraVez = true; numRem7 = 0; numRem8 = 0; numRem9 = 0; remolques8 = true; }
                    }
                }

            }
            return fila;
        }

        public string CreaCabecera(string fecha)
        {
            string fila;
            string listado = "Listado_" + fecha;
            //string path = Path.GetFullPath("..\\..\\..\\..\\" + listado + ".txt");
            string path = Path.GetFullPath(".\\" + listado + ".txt");
            string c176 = Encoding.Default.GetString(new byte[] { 176 });
            string c209 = Encoding.Default.GetString(new byte[] { 209 });

            if (!File.Exists(path))
            {
                fila = "CENTRO" + "," + "A"+ c209 + "O" + "," + "FACTURA" + "," + "MEDIO" + "," + "PTO DESCARGA" + "," + "DESTINO" + "," + "N"+ c176+ " LOTE" + "," + "N" + c176 + " REMOLQUE" + "," + "CHASIS" + "\n";
                return fila;
            }
            else { return "EXISTE"; }
        }


        public string Generador_Tren()
        {
            string fila = "";
            DateTime fechaHora = DateTime.Now; //fecha y hora
            int year = fechaHora.Year;
            //para separar valores de la lista de registros
            string[] elemento_lista = new string[5];//como pasamos 5 elementos con comas, los vamos a separar luego para coger el que corresponda

            //Count nos indica los elementos de la lista
            for (int i = 0; i < lista_destinos.Count; i++)
            {
                //datos = lista de ["OK", numRegistros, ciudad, letrasLote, numerosLote]
                elemento_lista = lista_destinos[i].Split(',');
                int longitud = int.Parse(elemento_lista[1]);
                int lotes = int.Parse(elemento_lista[4]);
                string year_string = Convert.ToString(year);
                string anio = year_string.Substring(2, 2);

                for (int k = 0; k < longitud; k++)
                {
                    fila += "VALLADOLID" + "," + anio + "," + "," + transporte + "," + puerto + "," + elemento_lista[2].ToUpper() + "," + elemento_lista[3].ToUpper() + lotes + "," + tren.ToUpper() + "\n";
                }

            }
            return fila;
        }
        // construye la fecha del dia para el fichero
        public string CreaFecha()
        {
            DateTime fechaHora = DateTime.Now; //fecha y hora
            int year = fechaHora.Year;
            int month = fechaHora.Month;
            int day = fechaHora.Day;
            string fecha = day + "-" + month + "-" + year;
            return fecha;
        }
        //Verifica si existe el fichero de salida con la fecha del día
        public bool VerificaFichero(string fecha)
        {
            string listado = "Listado_" + fecha;
            //generar una carpeta para meter el repo para que genere los listados en la carpeta
            //este es correcto para ejecutarlo instalando o el archivo Debug directamente
            //string path = Path.GetFullPath("..\\..\\..\\..\\" + listado + ".txt");
            string path = Path.GetFullPath(".\\" + listado + ".txt");
            //pruebas con el archivo BAT como acceso directo, así lo genera en la carpeta donde la deje C, D o donde sea y no pide permisos de administrador porque lo escriba en C:\
            //string path = Path.GetFullPath(listado + ".txt");
            if (File.Exists(path))
            {
                return true;
                //se va a seguir escribiendo el listado
            }
            else
            {
                return false;
                //se va a crear nuevo
            }

        }

        public Boolean GeneraFichero(string fecha, string listadoFinal)
        {
            string listado = "Listado_" + fecha;
            //generar una carpeta para meter el repo para que genere los listados en la carpeta
            //este es correcto para ejecutarlo instalando o el archivo Debug directamente
            string path = Path.GetFullPath(".\\" + listado + ".txt");
            //pruebas con el archivo BAT como acceso directo, así lo genera en la carpeta donde la deje C, D o donde sea y no pide permisos de administrador porque lo escriba en C:\
            //string path = Path.GetFullPath(listado + ".txt");
            //Boolean file = File.Exists(path);

            if (File.Exists(path))
            {
                // Open the file to read from.
                using (StreamWriter fs = File.AppendText(path))
                {
                    fs.Write(listadoFinal, 0, Encoding.Default);
                    return true;
                }
                
            }
            else {
                // Create a file to write to.
                using (StreamWriter fs = File.CreateText(path))
                {
                    fs.Write(listadoFinal, 0, Encoding.Default);
                    return true;
                }
            }


        }

    }
}
