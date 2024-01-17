using System;
using System.Collections.Generic;
using Avalonia.Media.Imaging;

namespace Videoclub;

[Serializable]

public class Pelicula
{
    
        // Atributos
        private string titulo;
        private string director;
        private char genero;
        private float precio;
        private byte[] imagen;
    

        public Pelicula(string titulo, string director, char genero, float precio, byte[] imagen)
        {
            // Inicializar los atributos con los valores proporcionados al constructor
            this.titulo = titulo;
            this.director = director;
            this.genero = genero;
            this.precio = precio;
            this.imagen = imagen;


        }
        
        public Pelicula(string titulo, string director, char genero, float precio)
        {
            // Inicializar los atributos con los valores proporcionados al constructor
            this.titulo = titulo;
            this.director = director;
            this.genero = genero;
            this.precio = precio;
            


        }
        
        
    
        // Propiedades con get y set
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public char Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public float Precio
        {
            get { return precio; }
            set
            {
                // Validación para asegurarse de que el precio no sea negativo
                if (value >= 0)
                {
                    precio = value;
                }
                else
                {
                    Console.WriteLine("El precio no puede ser negativo. Se establecerá en 0.");
                    precio = 0;
                }
            }
        }
    }
    
