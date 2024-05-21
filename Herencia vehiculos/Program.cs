//Sebastian Borja
using System;  // Importa el espacio de nombres System que contiene las clases fundamentales de C#

namespace vehiculos  // Declaración del espacio de nombres vehiculos
{
    class Program  // Definición de la clase Program
    {
        class Vehiculo  // Definición de la clase base Vehiculo
        {
            // Declaración de campos privados para la marca, modelo y año del vehículo
            private string _Marca;
            public string Marca  // Propiedad pública para acceder a la marca del vehículo
            {
                get { return _Marca; }  // Método para obtener la marca
                set { _Marca = value; }  // Método para establecer la marca
            }
            private string _Modelo;  // Campo privado para el modelo del vehículo
            public string Modelo  // Propiedad pública para acceder al modelo del vehículo
            {
                get { return _Modelo; }  // Método para obtener el modelo
                set { _Modelo = value; }  // Método para establecer el modelo
            }
            private int _Año;  // Campo privado para el año del vehículo
            public int Año  // Propiedad pública para acceder al año del vehículo
            {
                get { return _Año; }  // Método para obtener el año
                set { _Año = value; }  // Método para establecer el año
            }

            // Constructor de la clase Vehiculo que inicializa los campos marca, modelo y año
            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;  // Establece la marca del vehículo
                Modelo = modelo;  // Establece el modelo del vehículo
                Año = año;  // Establece el año del vehículo
            }

            // Método virtual para mostrar la información del vehículo
            public virtual void MostrarInformacion()
            {
                // Imprime la marca, modelo y año del vehículo
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }

        // Definición de la clase bicicleta que hereda de Vehiculo
        class bicicleta : Vehiculo
        {
            private int _Numeromarchas;  // Campo privado para el número de marchas de la bicicleta
            public int Numeromarchas  // Propiedad pública para acceder al número de marchas
            {
                get { return _Numeromarchas; }  // Método para obtener el número de marchas
                set { _Numeromarchas = value; }  // Método para establecer el número de marchas
            }

            // Constructor de la clase bicicleta que inicializa los campos marca, modelo, año y número de marchas
            public bicicleta(string marca, string modelo, int año, int numeromarcha) : base(marca, modelo, año)
            {
                numeromarcha = numeromarcha;  // Asigna el número de marchas
            }

            // Método para mostrar la información de la bicicleta, sobreescribiendo el método de la clase base
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();  // Llama al método de la clase base para mostrar la información básica
                // Imprime el tipo de vehículo y el número de marchas de la bicicleta
                Console.WriteLine($"Tipo: Bicicleta \nmarchas: {Numeromarchas}");
            }
        }

        // Definición de la clase Avion que hereda de Vehiculo
        class Avion : Vehiculo
        {
            private string _TipoMotor;  // Campo privado para el tipo de motor del avión
            public string TipoMotor  // Propiedad pública para acceder al tipo de motor
            {
                get { return _TipoMotor; }  // Método para obtener el tipo de motor
                set { _TipoMotor = value; }  // Método para establecer el tipo de motor
            }

            // Constructor de la clase Avion que inicializa los campos marca, modelo, año y tipo de motor
            public Avion(string marca, string modelo, int año, string tipoMotor) : base(marca, modelo, año)
            {
                TipoMotor = tipoMotor;  // Establece el tipo de motor
            }

            // Método para mostrar la información del avión, sobreescribiendo el método de la clase base
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();  // Llama al método de la clase base para mostrar la información básica
                // Imprime el tipo de vehículo y el tipo de motor del avión
                Console.WriteLine($"Tipo: Avión \nTipo de motor: {TipoMotor}");
            }
        }

        // Definición de la clase Barco que hereda de Vehiculo
        class Barco : Vehiculo
        {
            private int _NumeroPasajeros;  // Campo privado para el número de pasajeros del barco
            public int NumeroPasajeros  // Propiedad pública para acceder al número de pasajeros
            {
                get { return _NumeroPasajeros; }  // Método para obtener el número de pasajeros
                set { _NumeroPasajeros = value; }  // Método para establecer el número de pasajeros
            }

            // Constructor de la clase Barco que inicializa los campos marca, modelo, año y número de pasajeros
            public Barco(string marca, string modelo, int año, int numeroPasajeros) : base(marca, modelo, año)
            {
                NumeroPasajeros = numeroPasajeros;  // Establece el número de pasajeros
            }

            // Método para mostrar la información del barco, sobreescribiendo el método de la clase base
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();  // Llama al método de la clase base para mostrar la información básica
                // Imprime el tipo de vehículo y el número de pasajeros del barco
                Console.WriteLine($"Tipo: Barco \nNúmero de pasajeros: {NumeroPasajeros}");
            }
        }

        // Definición de la clase Helicoptero que hereda de Vehiculo
        class Helicoptero : Vehiculo
        {
            private int _NumeroHelices;  // Campo privado para el número de hélices del helicóptero
            public int NumeroHelices  // Propiedad pública para acceder al número de hélices
            {
                get { return _NumeroHelices; }  // Método para obtener el número de hélices
                set { _NumeroHelices = value; }  // Método para establecer el número de hélices
            }

            // Constructor de la clase Helicoptero que inicializa los campos marca, modelo, año y número de hélices
            public Helicoptero(string marca, string modelo, int año, int numeroHelices) : base(marca, modelo, año)
            {
                NumeroHelices = numeroHelices;  // Establece el número de hélices
            }

            // Método para mostrar la información del helicóptero, sobreescribiendo el método de la clase base
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();  // Llama al método de la clase base para mostrar la información básica
                // Imprime el tipo de vehículo y el número de hélices del helicóptero
                Console.WriteLine($"Tipo: Helicóptero \nNúmero de hélices: {NumeroHelices}");
            }
        }

        // Método principal de la aplicación
        static void Main(string[] args)
        {
            // Imprime un título indicando que se van a mostrar vehículos
            Console.WriteLine("--------VEHICULOS--------");
            // Crea una instancia de Vehiculo con marca "Toyota", modelo "Corolla" y año 2020
            Vehiculo vehi = new Vehiculo("Toyota", "Corolla", 2020);
            // Crea otra instancia de Vehiculo con marca "Chevrolet", modelo "camaro" y año 2022
            Vehiculo vehi2 = new Vehiculo("Chevrolet", "camaro", 2022);
            // Muestra la información del primer vehículo
            vehi.MostrarInformacion();
            // Imprime una línea separadora
            Console.WriteLine("-----------------");
            // Muestra la información del segundo vehículo
            vehi2.MostrarInformacion();
            // Crea una instancia de bicicleta con marca "bmx", modelo "Gorila", año 2025 y 1 marcha
            bicicleta bic = new bicicleta("bmx", "Gorila", 2025, 1);
            // Imprime una línea separadora
            Console.WriteLine("-----------------");
            // Muestra la información de la bicicleta
            bic.MostrarInformacion();
            // Imprime una línea separadora
            Console.WriteLine("-----------------");
            // Imprime un título indicando que se van a mostrar aviones
            Console.WriteLine("--------AVION---------");
            // Crea una instancia de Avion con marca "Airbus SAS", modelo "Airbus A330", año 1980 y tipo de motor "Rolls-Royce Trent 700"
            Avion avi = new Avion("Airbus SAS", "Airbus A330", 1980, "Rolls-Royce Trent 700");
            // Muestra la información del avión
            avi.MostrarInformacion();
            // Imprime una línea separadora
            Console.WriteLine("-----------------");
            // Imprime un título indicando que se van a mostrar barcos
            Console.WriteLine("--------BARCO---------");
            // Crea una instancia de Barco con marca "Yamaha", modelo "WaveRunner", año 2024 y capacidad para 2 pasajeros
            Barco barco = new Barco("Yamaha", "WaveRunner", 2024, 2);
            // Muestra la información del barco
            barco.MostrarInformacion();
            // Imprime una línea separadora
            Console.WriteLine("-----------------");
            // Imprime un título indicando que se van a mostrar helicópteros
            Console.WriteLine("--------HELICOPTERO---------");
            // Crea una instancia de Helicoptero con marca "Airbus Helicopters", modelo "H145", año 2021 y 4 hélices
            Helicoptero helicoptero = new Helicoptero("Airbus Helicopters", "H145", 2021, 4);
            // Muestra la información del helicóptero
            helicoptero.MostrarInformacion();
        }
    }
}
