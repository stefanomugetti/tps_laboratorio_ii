using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FormTPFinal
{
    public partial class Frm_Informes : Form
    {
        public Frm_Informes()
        {
            InitializeComponent();
        }



        #region InformeJdrs

        private void btn_Pie_Click(object sender, EventArgs e)
        {
            List<Jugador> jugadores = Equipo.ObtenerTodosLosJugadores();
            StringBuilder informe = new StringBuilder();
            int contadorDer = 0;
            int contadorIzq = 0;
            try
            {
                if (jugadores != null)
                {
                    foreach (Jugador item in jugadores)
                    {
                        if (item.PieHabil.ToLower() == "izquierdo")
                            contadorIzq++;
                        else
                            contadorDer++;
                    }
                    int cantidad = jugadores.Count;
                    informe.AppendLine($"De un total de {jugadores.Count} jugadores");
                    informe.AppendLine($"Pie Habil:\nDerechos:{contadorDer} ");
                    informe.AppendLine($"Izquierdos:{contadorIzq}");
                    informe.AppendLine();
                    informe.AppendFormat("Promedio Izquierdos:{0:N2}%",(double)(contadorIzq * 100 )/ cantidad);
                    informe.AppendLine();
                    informe.AppendFormat("Promedio Derechos:{0:N2}%", (double)(contadorDer * 100) / cantidad);
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "Pie_Habil");
                    

                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if(frm.ShowDialog() == DialogResult.OK)                   
                        frm.Close();
                    
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }

        private void btn_Peso_Click(object sender, EventArgs e)
        {
            List<Jugador> totalJugadores = Equipo.ObtenerTodosLosJugadores();
            StringBuilder informe = new StringBuilder();
            double minimo = 0;
            double maximo = 0;
            double promedio = 0;
            double peso = 0;
            double acumulador = 0;
            try
            {
                if (totalJugadores != null)
                {
                    foreach (Jugador item in totalJugadores)
                    {
                        peso = item.Peso;
                        acumulador += peso;
                        if (minimo == 0)
                            minimo = peso;

                        if (peso > maximo)
                            maximo = peso;
                        else if (peso < minimo)
                            minimo = peso;
                    }
                    promedio = acumulador / totalJugadores.Count;

                    promedio = acumulador / totalJugadores.Count;
                    informe.AppendLine($"De un total de {totalJugadores.Count} jugadores");
                    informe.AppendLine($"Peso:\nMaximo:{maximo}");
                    informe.AppendLine($"Minimo:{minimo}");
                    informe.AppendLine();
                    informe.AppendLine($"Promedio:{promedio}");
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "Peso");
                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }

        private void Btn_Valor_Click(object sender, EventArgs e)
        {
            List<Jugador> totalJugadores = Equipo.ObtenerTodosLosJugadores();
            StringBuilder informe = new StringBuilder();
            double minimo = 0;
            double maximo = 0;
            double promedio = 0;
            double valor = 0;
            double acumulador = 0;
            try
            {
                if (totalJugadores != null)
                {
                    foreach (Jugador item in totalJugadores)
                    {
                        valor = item.Valor;
                        acumulador += valor;
                        if (minimo == 0)
                            minimo = valor;

                        if (valor > maximo)
                            maximo = valor;
                        else if (valor < minimo)
                            minimo = valor;
                    }
                    promedio = acumulador / totalJugadores.Count;
                    informe.AppendLine($"De un total de {totalJugadores.Count} jugadores");
                    informe.AppendLine($"Valor:\nMaximo:{maximo}");
                    informe.AppendLine($"Minimo:{minimo}");
                    informe.AppendLine();
                    informe.AppendLine($"Promedio:{promedio}");
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "ValorJdr");
                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }

        private void Btn_Posicion_Click(object sender, EventArgs e)
        {
            StringBuilder informe = new StringBuilder();
            List<Jugador> jugadores = Equipo.ObtenerTodosLosJugadores();
            int contadorDef = 0;
            int contadorDel = 0;
            int contadorArq = 0;
            int contadorMed = 0;
            string posicion;
            try
            {
                if (jugadores != null)
                {
                    foreach (Jugador item in jugadores)
                    {
                        posicion = item.Posicion.ToLower();
                        if (posicion == "defensa")
                            contadorDef++;
                        else if (posicion == "arquero")
                            contadorArq++;
                        else if (posicion == "mediocampista")
                            contadorMed++;
                        else
                            contadorDel++;
                    }
                    int cantidad = jugadores.Count;
                    informe.AppendLine($"De un total de {jugadores.Count} jugadores");
                    informe.AppendLine($"Posicion:\nArqueros:{contadorArq}");
                    informe.AppendLine($"Defensas:{contadorDef}");
                    informe.AppendLine($"Mediocampistas:{contadorMed}");
                    informe.AppendLine($"Delanteros:{contadorDel}");
                    informe.AppendLine();
                    informe.AppendFormat("Promedio Arquero:{0:N2}%", (double)(contadorArq * 100) / cantidad);
                    informe.AppendLine();
                    informe.AppendFormat("Promedio Defensa:{0:N2}%", (double)(contadorDef * 100) / cantidad);
                    informe.AppendLine();
                    informe.AppendFormat("Promedio Mediocampistas:{0:N2}%", (double)(contadorMed * 100) / cantidad);
                    informe.AppendLine();
                    informe.AppendFormat("Promedio Delanteros:{0:N2}%",(double)(contadorDel * 100)/ cantidad);
                    informe.AppendLine();
                    informe.AppendLine();
                    informe.AppendLine();

                    Archivos<string>.Informes(informe.ToString(), "Posicion");
                    Frm_Informe frm = new Frm_Informe(informe.ToString() + DateTime.Now.ToString("f"));
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }

        private void Btn_ValorEquipo_Click(object sender, EventArgs e)
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            StringBuilder informe = new StringBuilder();
            double minimo = 0;
            double maximo = 0;
            double promedio = 0;
            double valor = 0;
            double acumulador = 0;
            try
            {
                if (equipos != null)
                {
                    foreach (Equipo item in equipos)
                    {
                        valor = item.Valor;
                        acumulador += valor;
                        if (minimo == 0)
                            minimo = valor;

                        if (valor > maximo)
                            maximo = valor;
                        else if (valor < minimo)
                            minimo = valor;
                    }
                    promedio = acumulador / equipos.Count;

                    informe.AppendLine($"De un total de {equipos.Count} equipos");
                    informe.AppendLine($"Valor:\nMaximo:{maximo}");
                    informe.AppendLine($"Minimo:{minimo}");
                    informe.AppendLine();
                    informe.AppendLine($"Promedio:{promedio}");
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "Valor");
                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }

        }

        private void Btn_AñoCreacion_Click(object sender, EventArgs e)
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            StringBuilder informe = new StringBuilder();
            double minimo = 0;
            double maximo = 0;
            double fecha = 0;
            try
            {

                if (equipos != null)
                {
                    foreach (Equipo item in equipos)
                    {
                        fecha = item.AñoCreacion;
                        if (minimo == 0)
                            minimo = fecha;

                        if (fecha > maximo)
                            maximo = fecha;
                        else if (fecha < minimo)
                            minimo = fecha;
                    }
                    informe.AppendLine($"De un total de {equipos.Count} equipos");
                    informe.AppendLine($"Año de fundacion:\nMaximo:{maximo}");
                    informe.AppendLine($"Minimo:{minimo}");
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "AñoFund");
                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }

        private void Btn_CantJdr_Click(object sender, EventArgs e)
        {
            List<Equipo> equipos = Liga.ObtenerLista();
            StringBuilder informe = new StringBuilder();
            double minimo = 0;
            double maximo = 0;
            double promedio = 0;
            double jdrs = 0;
            double acumulador = 0;
            try
            {

                if (equipos != null)
                {
                    foreach (Equipo item in equipos)
                    {
                        jdrs = item.ObtenerCantJrs();
                        acumulador += jdrs;
                        if (minimo == 0)
                            minimo = jdrs;

                        if (jdrs > maximo)
                            maximo = jdrs;
                        else if (jdrs < minimo)
                            minimo = jdrs;
                    }
                    promedio = acumulador / equipos.Count;
                    informe.AppendLine($"De un total de {equipos.Count} equipos");
                    informe.AppendLine($"Cantidad de jugadores:\nMaximo:{maximo}");
                    informe.AppendLine($"Minimo:{minimo}");
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "Cant_Jdrs");
                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }

        private void Btn_Edad_Click(object sender, EventArgs e)
        {
            List<Jugador> totalJugadores = Equipo.ObtenerTodosLosJugadores();
            StringBuilder informe = new StringBuilder();
            double minimo = 0;
            double maximo = 0;
            double promedio = 0;
            double edad = 0;
            double acumulador = 0;
            try
            {

                if (totalJugadores != null)
                {
                    foreach (Jugador item in totalJugadores)
                    {
                        edad = item.Edad;
                        acumulador += edad;
                        if (minimo == 0)
                            minimo = edad;

                        if (edad > maximo)
                            maximo = edad;
                        else if (edad < minimo)
                            minimo = edad;
                    }
                    promedio = acumulador / totalJugadores.Count;
                    promedio = acumulador / totalJugadores.Count;
                    informe.AppendLine($"De un total de {totalJugadores.Count} jugadores");
                    informe.AppendLine($"Edad:\nMaximo:{maximo}");
                    informe.AppendLine($"Minimo:{minimo}");
                    informe.AppendLine();
                    informe.AppendLine($"Promedio:{promedio}");
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "Edad");
                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }

        private void Btn_Altura_Click(object sender, EventArgs e)
        {
            List<Jugador> totalJugadores = Equipo.ObtenerTodosLosJugadores();
            StringBuilder informe = new StringBuilder();
            double minimo = 0;
            double maximo = 0;
            double promedio = 0;
            double altura = 0;
            double acumulador = 0;
            try
            {

                if (totalJugadores != null)
                {
                    foreach (Jugador item in totalJugadores)
                    {
                        altura = item.Altura;
                        acumulador += altura;
                        if (minimo == 0)
                            minimo = altura;

                        if (altura > maximo)
                            maximo = altura;
                        else if (altura < minimo)
                            minimo = altura;
                    }
                    promedio = acumulador / totalJugadores.Count;
                    informe.AppendLine($"De un total de {totalJugadores.Count} jugadores");
                    informe.AppendLine($"Altura:\nMaximo:{maximo}");
                    informe.AppendLine($"Minimo:{minimo}");
                    informe.AppendLine();
                    informe.AppendLine($"Promedio:{promedio}");
                    informe.AppendLine();
                    informe.AppendLine($"{DateTime.Now.ToString()}");
                    Archivos<string>.Informes(informe.ToString(), "Altura");
                    Frm_Informe frm = new Frm_Informe(informe.ToString());
                    if (frm.ShowDialog() == DialogResult.OK)
                        frm.Close();
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Informes("Error al cargar datos", "Error");
                Archivos<bool>.InformarError(ex.Message);
            }
        }
        #endregion
    }
}
