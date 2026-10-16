using System.Text;

namespace ProyectoParcial
{
    internal class Program
    {
        class Colas
        {
            int[] _cola;
            int _tope;
            int _cantidad;
            int _primero;

            public Colas(int elementos)
            {
                _cola = new int[elementos];
                _primero = 0;
                _tope = 0;
                _cantidad = 0;
            }

            public void Agregar(int dato)
            {
                if (_cantidad == _cola.Length) throw new Exception("La Cola se llenó");
                _cola[_tope] = dato;
                _tope++;
                if (_tope == _cola.Length) _tope = 0;
                _cantidad++;
            }

            public void Eliminar()
            {
                if (_cantidad == 0) throw new Exception("La cola está vacía");
                _cola[_primero] = 0;
                _primero++;
                if (_primero == _cola.Length) _primero = 0;
                _cantidad--;
            }

            public string Obtenerdatos()
            {
                if (_cantidad == 0) return "La cola está vacía.";
                StringBuilder datos = new StringBuilder();
                int indice = _primero;
                for (int i = 0; i < _cantidad; i++)
                {
                    datos.AppendLine($"Dato: {_cola[indice]}");
                    indice++;
                    if (indice == _cola.Length) indice = 0;
                }
                return datos.ToString();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Colas miCola = new Colas(3);

                miCola.Agregar(10);
                miCola.Agregar(20);
                miCola.Agregar(30);

                Console.WriteLine(" Estado actual ");
                Console.WriteLine(miCola.Obtenerdatos());

                miCola.Eliminar();

                Console.WriteLine(" Después de eliminar ");
                Console.WriteLine(miCola.Obtenerdatos());

                
                Console.WriteLine("Presiona cualquier tecla para salir...");
                
            }
        }
    }