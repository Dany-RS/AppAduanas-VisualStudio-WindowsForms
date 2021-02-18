using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Validaciones
    {
        public string numRegistros;
        public string letrasLote;
        public string numerosLote;
        public string ciudad;

        public Validaciones(string ciudad, string numRegistros, string letrasLote, string numerosLote)
        {
            this.ciudad = ciudad;
            this.numRegistros = numRegistros;
            this.letrasLote = letrasLote;
            this.numerosLote = numerosLote;
        }

        public List<string> ValidaDatos()
        {
            string mensaje;
            string titulo;
            List<string> datos = new List<string>();
            int reg_Ciudad;
            int num_lote_Ciudad;

            if (numRegistros == "")
            {
                //MessageBox.Show("Indicar registros para Turquía.", "Falta info Turquía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mensaje = "Indicar registros para " + ciudad;
                titulo = "Falta info " + ciudad;
                datos.Add("KO");
                datos.Add(mensaje);
                datos.Add(titulo);

                return datos;
            }
            else 
            {
                if (letrasLote == "" || numerosLote == "")
                {
                    //MessageBox.Show("Revisar info Lote Turquía.", "Falta info lote Turquía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mensaje = "Revisar info Lote " + ciudad;
                    titulo = "Falta info lote " + ciudad;
                    datos.Add("KO");
                    datos.Add(mensaje);
                    datos.Add(titulo);

                    return datos;
                }
                else
                {
                    if (numRegistros != "" && letrasLote != "" && numerosLote != "")
                    {
                        try
                        {
                            reg_Ciudad = int.Parse(numRegistros);
                            num_lote_Ciudad = int.Parse(numerosLote);
                            //datos = lista de ["OK", numRegistros, ciudad, letrasLote, numerosLote]
                            datos.Add("OK");
                            datos.Add(numRegistros);
                            datos.Add(ciudad);
                            datos.Add(letrasLote);
                            datos.Add(numerosLote);
                            return datos;

                            //lista_datos = reg_Ciudad + "," + "TURQUIA" + "," + letrasLote + "," + numerosLote;
                            //datos.Add(lista_datos);
                            //destino = true;

                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("Revisar nº registros y nº lote, que sean números.", "Error Turquía", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                            mensaje = "Revisar nº registros y nº lote, que sean números.";
                            titulo = "Falta info " + ciudad;
                            datos.Add("KO");
                            datos.Add(mensaje);
                            datos.Add(titulo);
                            return datos;
                        }
                    }
                    else
                    {
                        datos.Add("KO");
                        datos.Add("OOPPSS!! esto sí es embarazoso! No puedo generar el listado, hay algo chungo roto!!.");
                        datos.Add("ERROR GORDO!!");
                        return datos;
                    }
                }
            }
        }
    }
}
