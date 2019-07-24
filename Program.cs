
using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListaDeArquivos = new GetFiles();

            var ListaMeusDocumentos = ListaDeArquivos.RetornaArquivosDoMeuDocumentos();
            imprimir(ListaMeusDocumentos);

            
            var ListaGit = ListaDeArquivos.RetornaArquivosGit();
            if(ListaGit == null)
            {
                Console.WriteLine("Diretório inexis");
            }
            else
            {
                imprimir(ListaGit);
            }

            var listaImg = ListaDeArquivos.RetornaArquivosImagesFiles();
             imprimir(listaImg);
           // imprimir(ListaDeArquivos.RetornaArquivosImagesFiles());

        }

        public static void imprimir(string[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
        }
    }
   

}

    
       
			

			

