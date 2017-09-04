using System;
using System.ServiceProcess;

namespace GetInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            getInfo.IsServiceInstalled();

            Console.WriteLine("Teclea cualquier tecla para finalizar!!");
            Console.ReadKey();
        }
    }

    public static class getInfo
    {
        public static void IsServiceInstalled()
        {
            // get list of Windows services
            ServiceController[] services = ServiceController.GetServices();

            // try to find service name
            Console.WriteLine("Servicio Windows Instalados: NOMBRE|TIPO|ESTATUS");
            foreach (ServiceController service in services)                  
                    Console.WriteLine("{0}|{1}|{2}", service.ServiceName, service.ServiceType, service.Status);
        }
    }
}
