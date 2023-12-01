using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace PrefinalGarateAdolfina.Entidades
 { class Repositorio
  {
    private string archivo;

    public Repositorio(string nombreArchivo)
    {
        archivo = nombreArchivo;
    }

    public void AgregarTriangulo(Triangulo triangulo)
    {
        using (StreamWriter writer = File.AppendText(archivo))
        {
            writer.WriteLine($"{triangulo.LadoA},{triangulo.LadoB},{triangulo.LadoC},{(int)triangulo.ColorRelleno}");
        }
    }
  }  
 }

