using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Word_Finder_1._0
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            EntradaPalabra.Text = ""; //al cargarse el texto del entry no sera nada
            Texto carga = new Texto();
            carga.CrearArchivo("");
        }

        private void EnlaceWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.lexico.com/es?locale=es");
        }

        private void BtnDefinir_Click(object sender, EventArgs e)
        {
            PalabraFinal.Text = "";
            Texto palabra1 = new Texto();
            if (EntradaPalabra.Text != "")
            {
                PalabraFinal.Text = palabra1.Definir(EntradaPalabra.Text);
            }
            else
            {
                PalabraFinal.Text = "Escriba algo para definir.";
            }
        }

        private void BtnTraducir_Click(object sender, EventArgs e)
        {
            PalabraFinal.Text = "";
            Texto palabra1 = new Texto();
            if (EntradaPalabra.Text != "")
            {
                PalabraFinal.Text = palabra1.TraducirEsEn(EntradaPalabra.Text);
            }
            else
            {
                PalabraFinal.Text = "Escriba algo para traducir.";
            }
        }

        private void BtnGuardado_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            int eleccionRuta = EleccionRuta.SelectedIndex; //asignamos a una variable el valor de la opcion escogidaç
            string eleccion, eleccionNotificacion;

            switch (eleccionRuta)
            {
                case -1:
                    eleccion = "nada";
                    eleccionNotificacion = "";
                    break;
                case 0:
                    eleccion = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/texto.txt";
                    eleccionNotificacion = "Escritorio";
                    break;
                case 1:
                    eleccion = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/texto.txt";
                    eleccionNotificacion = "Documentos";
                    break;
                case 2:
                    eleccion = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "/texto.txt";
                    eleccionNotificacion = "Fotos";
                    break;
                default:
                    eleccion = "nada";
                    eleccionNotificacion = "";
                    break;
            }

            if (eleccion == "nada")
            {
                MessageBox.Show("Elija una ruta de destino válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Texto palabra2 = new Texto();
                    palabra2.setRutaGuardado(eleccion);
                    palabra2.CrearArchivoGuardado(PalabraFinal.Text, EntradaPalabra.Text);
                    NotifGuardado.BalloonTipText = "Archivo guardado con éxito en " + eleccionNotificacion;
                    NotifGuardado.ShowBalloonTip(1000);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error durante el proceso.\nVuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SobreWordFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventanaAcercaDe = new ventanaAcercaDe(); //creamos un nuevo objeto de tipo form para poder abrir la ventana de acerca de...
            ventanaAcercaDe.Show();
        }

        private void CreditosYAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventanaCreditos = new ventanacreditos();
            ventanaCreditos.Show();
        }

        private void ComprobarActualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Actualizador.pdb") && File.Exists("Actualizador.exe") && File.Exists("Actualizador.exe.config"))
            {
                Actualizacion comprobar = new Actualizacion();
                comprobar.ComprobarActualizaciones();
            }
            else
            {
                Form DescargaActualizador = new ventanaDescargaactualizador();
                DescargaActualizador.Show();
            }
        }

        private void Ventana_Activated(object sender, EventArgs e)
        {

        }
    }

    class Texto
    {
        private string ruta = @"C:\Users\" + Environment.UserName + @"\Documents\WordFinder\codigo.txt";

        public string getRuta() => ruta;

        private string setRuta(string nueva_ruta)
        {
            ruta = nueva_ruta;
            return ruta;
        }

        private string rutaGuardado = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/texto.txt";

        public string getRutaGuardado() => rutaGuardado;

        public string setRutaGuardado(string nueva_ruta)
        {
            rutaGuardado = nueva_ruta;
            return rutaGuardado;
        }

        public void CrearArchivoGuardado(string texto_a_escribir, string busqueda)
        {
            TextWriter archivoGuardado = new StreamWriter(getRutaGuardado());
            archivoGuardado.WriteLine(busqueda + ": " + texto_a_escribir);
            archivoGuardado.Close();
        }

        private string codigo;

        public string getCodigo() => codigo;

        private string setCodigo(string nuevo_codigo)
        {
            codigo = nuevo_codigo;
            return codigo;
        }

        private string urlDef = "https://www.lexico.com/es/definicion/";

        public string getUrlDef() => urlDef;

        private string setUrlDef(string nueva_url)
        {
            urlDef = nueva_url;
            return urlDef;
        }

        private string definicion;

        public string getDefinicion() => definicion;

        private string setDefinicion(string nueva_definicion)
        {
            definicion = nueva_definicion;
            return definicion;
        }

        public void CrearArchivo(string texto_a_escribir)
        {
            //buscamos si existe la ruta para guaradr el fichero de texto con el codigo, para crearla en caso de que no
            if (Directory.Exists(getRuta()))
            {
                TextWriter archivo = new StreamWriter(getRuta());//de esta manera borramos lo que ya hay en el archivo y sobreescribimos
                archivo.WriteLine(texto_a_escribir); //                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                archivo.Close();
            }
            else
            {
                Directory.CreateDirectory(getRuta().Replace(@"\codigo.txt",""));
                Directory.CreateDirectory(getRuta().Replace("codigo.txt", "NewVersions")); //aprovechamos para crear la carpeta donde se descragaran los archivos de nueva version
                TextWriter archivo = new StreamWriter(getRuta());
                archivo.WriteLine(texto_a_escribir);
                archivo.Close();
            }
        }



        public string Definir(string texto_a_definir)
        {

            texto_a_definir = texto_a_definir.Replace(" ", "_");
            //asi cuando hay espacios se reemplazan por "_" que es la manera de acceder a ellas en la web.
            texto_a_definir = texto_a_definir.Replace("ñ", "n");

            setUrlDef(urlDef + texto_a_definir);

            try
            /*
             * lo que conseguimos con esta serie de try y except es que si por cualquier motivo no consigue descragar el codigo, saltara un messagebox
             * y te pedira que compruebes la conexion. Te dara la opcion de retry y cancel. Siempre que elijas retry volvera a intentarlo, hasta que consiga
             * conectarse o le des a cancel.
             */
            {
                var pagina = new WebClient();
                pagina.Encoding = Encoding.UTF8; //lo descargamos en utf-8 ya que puede da error a la hora de descargar caracteres con acentos y especiales.
                setCodigo(pagina.DownloadString(urlDef));
            }

            catch (Exception)
            {
                var eleccion = MessageBox.Show("Hubo un problema al conectarse con el servidor.\nPor favor compruebe su conexion a internet.", "Error de conexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                while (eleccion == DialogResult.Retry)
                {
                    try
                    {
                        var pagina = new WebClient();
                        pagina.Encoding = Encoding.UTF8; //lo descargamos en utf-8 ya que puede da error a la hora de descargar caracteres con acentos y especiales.
                        setCodigo(pagina.DownloadString(urlDef));
                        eleccion = DialogResult.No;
                    }
                    catch (Exception)
                    {
                        eleccion = MessageBox.Show("Hubo un problema al conectarse con el servidor.\nPor favor compruebe su conexion a internet.", "Error de conexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

                }
            }

            CrearArchivo(getCodigo());

            StreamReader leer_texto = new StreamReader(getRuta());

            bool romperBucle = false;
            while (!leer_texto.EndOfStream && romperBucle == false) //endofstream es un metodo que detecta automaticamente el final del archivo y rompera el while cuando llegue al final del archivo
            {
                string linea = leer_texto.ReadLine();

                if (linea.Contains("<span class=\"ind\">"))
                {
                    int posicion_inicial = linea.IndexOf("<span class=\"ind\">") + 18; //18 mas que son los que ocupa <sapn class...
                    linea = linea.Substring(posicion_inicial);
                    int posicion_final = linea.IndexOf("<"); //este es el siguiente caracter que no nos interesa
                    setDefinicion(linea.Substring(0, posicion_final)); //obetenemos solo la parte de la definicion, con substring se corta desde la posicion de un caracter hasta la posicion de otro siguiente. (posicion-inicial/final
                    romperBucle = true;
                }

                else
                {
                    setDefinicion("La busqueda no obtuvo resultados.");
                }
            }
            leer_texto.Close();
            return definicion;
        }



        private string texto_traducido;

        public string getTexto_traducido() => texto_traducido;

        private string setTexto_traducido(string nuevo_texto_traducido)
        {
            texto_traducido = nuevo_texto_traducido;
            return texto_traducido;
        }

        private string urlTradc = "https://www.lexico.com/es-en/traducir/";

        public string getUrlTradc() => urlTradc;

        private string setUrlTradc(string nueva_url)
        {
            urlTradc = nueva_url;
            return urlTradc;
        }



        public string TraducirEsEn(string texto_a_traducir)
        {
            texto_a_traducir = texto_a_traducir.Replace(" ", "_");

            setUrlTradc(urlTradc + texto_a_traducir);

            try
            {
                var pagina = new WebClient();
                pagina.Encoding = Encoding.UTF8;
                setCodigo(pagina.DownloadString(urlTradc));
            }

            catch (Exception)
            {
                var eleccion = MessageBox.Show("Hubo un problema al conectarse con el servidor.\nPor favor compruebe su conexion a internet.", "Error de conexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                while (eleccion == DialogResult.Retry)
                {
                    try
                    {
                        var pagina = new WebClient();
                        pagina.Encoding = Encoding.UTF8;
                        setCodigo(pagina.DownloadString(urlTradc));
                        eleccion = DialogResult.No;
                    }
                    catch (Exception)
                    {
                        eleccion = MessageBox.Show("Hubo un problema al conectarse con el servidor.\nPor favor compruebe su conexion a internet.", "Error de conexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

                }
            }

            CrearArchivo(getCodigo());

            StreamReader leer_texto = new StreamReader(getRuta());

            bool romperBucle = false;
            while (!leer_texto.EndOfStream && romperBucle == false)
            {
                string linea = leer_texto.ReadLine();

                if (linea.Contains("<span class=\"hw head-translation\">"))
                {
                    int posicion_inicial = linea.IndexOf("<span class=\"hw head-translation\">") + 34;
                    linea = linea.Substring(posicion_inicial);
                    int posicion_final = linea.IndexOf(",");
                    setTexto_traducido(linea.Substring(0, posicion_final));
                    romperBucle = true;
                }
                else
                {
                    setTexto_traducido("La busqueda no obtuvo resultados.");
                }
            }
            leer_texto.Close();
            return texto_traducido;
        }
    }

    class Actualizacion : Texto
    {
        private int version = 145; //1.4.5 escrito asi para poder compararlo con otras versiones.
        //private string versionTexto = "145";

        public void ComprobarActualizaciones()
        {
            CrearArchivo(version.ToString());

            bool ArchivoDescargado = false;

            try
            {
                var comprobador_version = new WebClient();
                comprobador_version.DownloadFile("https://sourceforge.net/projects/actualizaciones-word-finder/files/Actualizaciones/Actualizacion/actualizacion.txt/download", "actualizacion.txt");
                ArchivoDescargado = true;
            }

            catch (Exception)
            {
                var eleccion = MessageBox.Show("Hubo un problema al conectarse con el servidor.\nPor favor compruebe su conexion a internet.", "Error de conexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                while (eleccion == DialogResult.Retry)
                {
                    try
                    {
                        var comprobador_version = new WebClient();
                        comprobador_version.DownloadFile("https://sourceforge.net/projects/actualizaciones-word-finder/files/Actualizaciones/Actualizacion/actualizacion.txt/download", "actualizacion.txt");
                        ArchivoDescargado = true;
                        eleccion = DialogResult.No;
                    }
                    catch (Exception)
                    {
                        eleccion = MessageBox.Show("Hubo un problema al conectarse con el servidor.\nPor favor compruebe su conexion a internet.", "Error de conexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

                }
            }
            if (ArchivoDescargado)
            {
                StreamReader archivo_version = new StreamReader("actualizacion.txt");
                int lineaVersion = int.Parse(archivo_version.ReadLine());
                archivo_version.Close();

                if (lineaVersion <= version)
                {
                    Form noActualizacion = new ventanaNoActualizacion();
                    noActualizacion.Show();
                }

                else if (lineaVersion > version)
                {
                    Form Actualizacion = new ventanaActualizacion();
                    Actualizacion.Show();
                }
            }
        }
    }

}
