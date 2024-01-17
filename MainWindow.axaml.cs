using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;


namespace Videoclub;

public partial class MainWindow : Window
{

    List<Pelicula> Listapeliculas = new List<Pelicula>();
    static int contador = 0;
    private String InitialDirectory; 
    
    String ruta = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\VIDEOCLUB";
    
    public MainWindow()
    {
        InitializeComponent();
        //CargarPeliculas();
        
        VaciarTextView();
        ocultarTxtFieldMod();
        ocultarBotonesMod();
        ocultarBotones();

       
        
    }

    public void Button_Click(object sender, RoutedEventArgs args)
    {

    }

    private void btnClickListaPelicula(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnclickNuevaPelicula(object? sender, RoutedEventArgs e)
    {
        // Create a new window (or UserControl) for the "Nueva Película" functionality
        var nuevaPeliculaWindow = new MainWindow(); // Assuming NuevaPeliculaWindow is your new window class

        // Show the new window
        nuevaPeliculaWindow.Show();
        throw new System.NotImplementedException();
    }

    private void btnClickProximosEstrenos(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnclickSalir(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void ClickHandler(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
    

    private void Modificar(object? sender, RoutedEventArgs e)
    {
        VaciarTextView();
        mostrarTxtFieldMod();
        mostrarBotonesMod();
        
    }
    
    
    public void VaciarTextView()
    {


        TxtViewTitulo.IsVisible = false;
        TxtViewDirector.IsVisible = false;
        TxtViewGenero.IsVisible = false;
        TxtViewPrecio.IsVisible = false;

    }

    public void ocultarBotones()
    {

        btnModificar.IsVisible = false;
        btnSiguiente.IsVisible = false;
        btnAnterior.IsVisible = false;
    }

    public void mostrarBotones()
    {
        btnModificar.IsVisible = true;
        btnSiguiente.IsVisible = true;
        btnAnterior.IsVisible = true;
        
    }

    public void mostrarTextView()
    {
        TxtViewTitulo.IsVisible = true;
        TxtViewDirector.IsVisible = true;
        TxtViewGenero.IsVisible = true;
        TxtViewPrecio.IsVisible = true;
        
    }

    public void ocultarTxtFieldMod()
    {
        
        txtFieldDirectorMod.IsVisible = false;
        txtFieldTituloMod.IsVisible = false;
        txtFieldGeneroMod.IsVisible = false;
        txtFieldPrecioMod.IsVisible = false;
    }

    public void mostrarTxtFieldMod()
    {
        txtFieldDirectorMod.IsVisible = true;
        txtFieldTituloMod.IsVisible = true;
        txtFieldGeneroMod.IsVisible = true;
        txtFieldPrecioMod.IsVisible = true;

    }

    public void ocultarBotonesMod()
    {

        btnAceptar.IsVisible = false;
        btnCancelar.IsVisible = false;

    }

    public void mostrarBotonesMod()
    {
        btnAceptar.IsVisible = true;
        btnCancelar.IsVisible = true;
        
    }
    
// EN ESTA FUNCION LO QUE HAGO ES CREAR VARIAS RUTAS DE TIPO STRING DONDE GUARDO LAS IMAGENES DE LAS PORTADAS, LUEGO ESAS VARIABLES LAS PASO A UN ARRAY DE BYTES 
//PARA PODER PASARLO COMO PARAMETRO LUEGO EN EL CONSTRUCTOR DE PELICULAS, ADEMÁS CREO VARIOS OBJETOS DE TIPO PELICULA PASANDOLE LOS DATOS A MANO.
// AL FINAL AÑADO AL ARRAYLIST DE PELICULAS ESAS INSTANCIAS Y YA TENGO PRECARGADAS UNA SERIE DE PELICULAS PARA MOSTRAR.
    public void CargarPeliculas()
    {
        //agrego al hashmap la relacion entre el char elegido y el string 
        // generosPelicula.Add('A', "Aventuras");
        // generosPelicula.Add('C', "Ciencia Ficción");
        // generosPelicula.Add('D', "Drama");

        string rutaTerminator = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\terminator2.jpg";
        string rutaTitanic = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\titanic.jpg";
        string rutaArmaggedon = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\armaggedon.jpg";
        string rutaBraveheart = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\braveheart.jpg";
        string rutaSalvarSoldado = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\saving.jpg";
        string rutaInterstellar = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\interstellaportada.jpg";
        string rutaElPadrino = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\elpadrino.jpg";
        string rutaForrestGump = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\forrest.jpg";
        string rutaRegresoFuturo = "C:\\Users\\Rodri\\Documents\\GRADO-SUPERIOR-2024\\DEINT\\RIDER\\Imagenes\\backtothefuture.jpg";

        byte[] iTerminator = File.ReadAllBytes(rutaTerminator);
        byte[] iTitanic = File.ReadAllBytes(rutaTitanic);
        byte[] iArmaggedon = File.ReadAllBytes(rutaArmaggedon);
        byte[] iBraveheart = File.ReadAllBytes(rutaBraveheart);
        byte[] iSalvar = File.ReadAllBytes(rutaSalvarSoldado);
        byte[] iInterstellar = File.ReadAllBytes(rutaInterstellar);
        byte[] Iforrest = File.ReadAllBytes(rutaForrestGump);
        byte[] iPadrino = File.ReadAllBytes(rutaElPadrino);
        byte[] iRegreso = File.ReadAllBytes(rutaRegresoFuturo);
        
        Pelicula pelicula1 = new Pelicula("Titanic", "James Cameron", 'A', 3.5f, iTitanic);
        Pelicula pelicula2 = new Pelicula("BraveHeart", "Mel Gibson", 'A', 4.5f, iBraveheart);
        Pelicula pelicula3 = new Pelicula("Terminator 2", "James Cameron", 'C', 5.5f, iTerminator);
        Pelicula pelicula4 = new Pelicula("Armageddon", "Michael Bay", 'C', 3, iArmaggedon);
        Pelicula pelicula5 = new Pelicula("Salvar al soldado Ryan", "Steven Spielberg", 'C', 3, iSalvar);
        Pelicula pelicula6 = new Pelicula("Interstellar", "Christopher Nolan", 'C', 5, iInterstellar);
        Pelicula pelicula7 = new Pelicula("El Padrino", "F. Ford Coppola", 'D', 7, iPadrino);
        Pelicula pelicula8 = new Pelicula("Forrest Gump", "Robert Zemeckis", 'D', 5, Iforrest);
        Pelicula pelicula9 = new Pelicula("Regreso al futuro", "Robert Zemeckis", 'A', 5, iRegreso);
        
        Listapeliculas.Add(pelicula1);
        Listapeliculas.Add(pelicula2);
        Listapeliculas.Add(pelicula3);
        Listapeliculas.Add(pelicula4);
        Listapeliculas.Add(pelicula5);
        Listapeliculas.Add(pelicula6);
        Listapeliculas.Add(pelicula7);
        Listapeliculas.Add(pelicula8);
        Listapeliculas.Add(pelicula9);
    }
    
    // AQUI MUESTRO LOS DATOS DE LAS PELICULAS CARGADAS EN EL ARRAYLIST ListaPeliculas, LO QUE HAGO ES PASARLE A LOS TEXTVIEW LAS VARIABLES TITULO, DIRECTOR, GENERO, PRECIO E IMAGEN
    // DE CADA OBJETO Y GRACIAS A LA VARIABLE CONTADOR INICIALIZADA EN 0 VOY SUMANDOLE +1 CADA VEZ QUE PULSO SIGUIENTE Y RESTANDO -1 CADA VEZ QUE PULSO ANTERIOR, ASÍ PUEDO LLEVAR EL CONTROL
    // DE A QUE POSICION DEL ARRAYLIST ESTOY APUNTANDO.
    public void MostrarDatos()
    {
        
        try
        {

            TxtViewTitulo.Text = Listapeliculas[contador].Titulo.ToString();
            TxtViewDirector.Text = Listapeliculas[contador].Director.ToString();
            TxtViewGenero.Text = "Categoria " + Listapeliculas[contador].Genero.ToString();
            TxtViewPrecio.Text = Listapeliculas[contador].Precio.ToString() + " Euros";
            MostrarImagen(Listapeliculas[contador].Imagen);
            
            ContadorPeliculas.Text = contador.ToString();
            
            

        }catch (Exception ex)
       
        {


        }
    }
    
    // en esta función lo que hacemos es pararle por parametro el array de bytes de cada portada de una pelicula, luego abrimos un memoryStream y creamos una variable 
    // de tipo bitmap para luego igualarlo al id de la imagen.
    private void MostrarImagen(byte[] byteArray) //muestro la imagen del array de bytes
    {
        try
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                Bitmap bitmap = new Bitmap(memoryStream);

                // asigno el Bitmap directamente al control Image
                PictureBox.Source = bitmap;
            }
        }
        catch (Exception ex)
        {
            //MessageBox.Show("Error al mostrar la imagen: " + ex.Message);
        }
    }

    // BOTON ANTERIOR
    private void BtnAnterior_OnClick(object? sender, RoutedEventArgs e)
    {
        contador--;

        btnSiguiente.IsEnabled = true;  

        if (contador == 0)
        {
            btnAnterior.IsEnabled = false;

        }
        
        MostrarDatos();
    }
    
    // BOTON SIGUIENTE
    private void BtnSiguiente_OnClick(object? sender, RoutedEventArgs e)
    {
        contador++;

        btnAnterior.IsEnabled = true;

        if (contador == Listapeliculas.Count - 1)
        {
            btnSiguiente.IsEnabled = false;

        }
        
        MostrarDatos();
    }

    
    // BOTON BORRAR
    private void BtnBorrar_OnClick(object? sender, RoutedEventArgs e)
    {
        eliminar();
    }
    
    
    // EN ESTA FUNCION ELIMINO EL OBJETO DEL ARRAYLIST QUE ESTOY VISUALIZANDO EN ESE MOMENTO.
    private void eliminar()
    {

        if (contador >= 0 && contador < Listapeliculas.Count)
        {

            if (contador == Listapeliculas.Count - 1)
            {
                Listapeliculas.RemoveAt(contador);
                contador--;


            }
            else
            {

                Listapeliculas.RemoveAt(contador);
            }
            
        }

       MostrarDatos();
    }
    
    
    // EN ESTA FUNCION AÑADO UNA PELÍCULA NUEVA, LO HAGO CREANDO VARIABLES LOCALES, LUEGO PASANDOLE A ESAS VARIABLES EL CONTENIDO DE LOS TEXTFIELD Y POR ULTIMO PASANDO ESAS VARIABLES
    // YA CON DATOS EN EL CONSTRUCTOR DE PELICULA, PARA ASÍ AÑADIR ESA PELICULA AL ARRAYLIST.
    public void AñadirPeli()
    {

        byte[] iRuta;
        
        if (!ruta.Equals(""))
            iRuta = File.ReadAllBytes(ruta);
        else
            iRuta = null;
        
        String titulo;
        String director;
        char genero;
        float precio;

        
        titulo = TextFieldTitulo.Text;
        director = TextFieldDirector.Text;
        genero = char.Parse(TextFieldGenero.Text);
        precio = float.Parse(TextFieldPrecio.Text);
        

        Pelicula peli = new Pelicula(titulo, director, genero, precio, iRuta);
        

        Listapeliculas.Add(peli);
       // MessageBox.Show("Película añadida correctamente");


    }
    
    //agregar portada
    
    private async void BtnAgregarPortada_OnClick(object? sender, RoutedEventArgs routedEventArgs) //metodo para agregar imagenes con OpenFileDialog
    {
       
        var ofd = new OpenFileDialog();
        
        ofd.Filters.Add(new FileDialogFilter { Name = "Imagenes PNG", Extensions = { "png" } });
    
        var result = await ofd.ShowAsync(this);
        if (result != null && result.Length > 0)
        {
            try
            {
                ruta = result[0]; // Obtiene la ruta del archivo seleccionado
                Console.WriteLine(ruta);
                PictureBox.IsVisible = true; // Hace visible el control de la imagen
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    
    // cargar registros
    private void CargarRegistros()
    {
        try
        {
            if (File.Exists("databank.data"))
            {
                using (FileStream stream = new FileStream("databank.data", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Listapeliculas = (List<Pelicula>)formatter.Deserialize(stream);
                }
            }
            else
            {
                Listapeliculas = new List<Pelicula>();
            }
        }
        catch (Exception ex)
        {
           
            Console.WriteLine($"Error al cargar registros: {ex.Message}");
        }
    }
    
    
    // aqui guardo el registro de peliculas
    private void GuardarRegistros()
    {
        try
        {
            using (FileStream stream = new FileStream("databank.data", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Listapeliculas);
                
            }
        }
        catch (Exception ex)
        {
            // Manejar excepciones según tus necesidades
            Console.WriteLine($"Error al guardar registros: {ex.Message}");
        }
    }

   
    private void BtnAñadirPelicula_OnClick(object? sender, RoutedEventArgs e)
    {
        AñadirPeli();
    }

    private void BtnAceptar_OnClick(object? sender, RoutedEventArgs e)
    {

        
        Listapeliculas[contador].Titulo = txtFieldTituloMod.Text;
        Listapeliculas[contador].Director = txtFieldDirectorMod.Text;
        //Listapeliculas[contador].Genero = char.Parse(TextFieldGenero.Text);
        //Listapeliculas[contador].Precio = float.Parse(TextFieldPrecio.Text);*/

        ocultarBotonesMod();
        ocultarTxtFieldMod();
        mostrarTextView();
        MostrarDatos();


    }

    private void BtnCancelar_OnClick(object? sender, RoutedEventArgs e)
    {
        mostrarTextView();
        ocultarTxtFieldMod();
        ocultarBotonesMod();
        
        
        MostrarDatos();
    }


    private void BtnGuardarLista_OnClick(object? sender, RoutedEventArgs e)
    {
        GuardarRegistros();
    }

    private void BtnCargarLista_OnClick(object? sender, RoutedEventArgs e)
    {
       CargarRegistros();
       mostrarTextView();
       MostrarDatos();
       mostrarBotones();
    }
}