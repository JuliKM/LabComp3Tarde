using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TpJson.Model;
using System.IO;
using System.Net;
using static TpJson.ModeloPaises.ModeloPaises;

/*
Escribir JSON
Cree 2 tablas de base de datos:
Escritor: Campos-> id(PK),apellido, nombre, dni
Libro: Campos->nombre, año publicación, editorial, idEscritor(FK)
Cargue algunos campos de prueba en ambas tablas relacionando el escritor con
el libro mediante sus claves (PK/FK)
Mediante C# realice la conexión a la base de datos, obtenga los datos y ejecute
la escritura en un archivo con la siguiente estructura JSON. 
*/
namespace TpJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ryzen 7 3700X\Documents\Back Up Dell 01-2021\Documents\UTN\Semestre 3 (2021)\Prog3\JsonFile.json";//C:\Users\Ryzen 7 3700X\Documents\Back Up Dell 01-2021\Documents\UTN\Semestre 3 (2021)\Prog3

            //Write JSON
            List<Client> clients = GetClients();
            //WriteJsonFile(clients, path);

            //Read JSON 
            //string clientsRead = GetJsonFile(path);
            //ReadJson(clientsRead);

            //Read JSON without model (sin mapeo, no recomendado)
            //string clientsNoModel = GetJsonFile(path);
            //ReadJsonNoModel(clientsNoModel);

            //Read JSON from http
            ReadJsonFromUrl();
        }

        private static void ReadJsonFromUrl()
        {
            var url = "https://restcountries.com/v2/all";
            WebClient wc = new WebClient();
            string paisesJson = wc.DownloadString(url);

            var paises = JsonConvert.DeserializeObject<List<Country>>(paisesJson);

            foreach (Country pais in paises)
            {
                Console.WriteLine("Pais: " + pais.name);
                Console.WriteLine("Poblacion " + pais.population);
                Console.WriteLine("Capital " + pais.capital);
                foreach (Language idioma in pais.languages)
                {
                    Console.WriteLine("Idioma: " + idioma.name);
                }
                Console.WriteLine("-------------------");
            }

        }

        private static void ReadJsonNoModel(string clientsNoModel)
        {
             JsonTextReader readerJson = new JsonTextReader(new StringReader(clientsNoModel));

            while (readerJson.Read()) 
            {
                if (readerJson.Value!= null)
                {
                    Console.WriteLine("Token con valor " + readerJson.TokenType + ", Valor " + readerJson.Value);
                }
                else
                {
                    Console.WriteLine("Token sin valor " + readerJson.TokenType);
                }
            }
        }

        private static void ReadJson(string txtJson)
        {
            Console.WriteLine(txtJson);

            List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(txtJson);
            
            foreach (Client client in clients)
            {
                Console.WriteLine(client.RazonSocial);
                Console.WriteLine("Documento: " + client.Documento);
                Console.WriteLine(client.Domicilio.DomicilioCompleto());
                Console.WriteLine("----Facturas----");
                double totalcomp = 0;
                foreach (Comprobante comp in client.Comprobantes)
                {
                    Console.WriteLine(comp.NroComprobante);
                    Console.WriteLine(comp.Total);
                    totalcomp += comp.Total;
                }
                Console.WriteLine("Total Comprobantes: " + totalcomp);
                Console.WriteLine("-----------------");
            }
        }

        private static string GetJsonFile(string path)
        {
            string jsonClients;
            using (var reader= new StreamReader(path))
            {
                jsonClients = reader.ReadToEnd();
            }
            return jsonClients;
        }

        private static void WriteJsonFile(List<Client> clients, string path)
        {
            string jsonFile = JsonConvert.SerializeObject(clients.ToArray(), Formatting.Indented);
            File.WriteAllText(path, jsonFile);
        }

        private static List<Client> GetClients()
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    RazonSocial = "JP",
                    FechaAlta = new DateTime(1981, 10, 12),
                    Domicilio = new Domicilio
                    {
                        Calle = "Jujuy",
                        NroCalle = 658,
                        Ciudad = new Ciudad
                        {
                            Nombre = "Salta",
                            Pais = new Pais
                            {
                                Codigo = "1",
                                Nombre = "Argentina"
                            }
                        }
                    },
                    Comprobantes = new List<Comprobante>
                    {
                        new Comprobante { NroComprobante = "123456", Total = 124.25 },
                        new Comprobante { NroComprobante = "123457", Total = 12454.25 },
                        new Comprobante { NroComprobante = "123458", Total = 25124.25 },

                    }
                },
                new Client
                {
                    RazonSocial = "Fulano",
                    FechaAlta = new DateTime(1981, 10, 12),
                    Domicilio = new Domicilio
                    {
                        Calle = "25 de mayo",
                        NroCalle = 1224,
                        Ciudad = new Ciudad
                        {
                            Nombre = "Cordoba",
                            Pais = new Pais
                            {
                                Codigo = "1",
                                Nombre = "Argentina"
                            }
                        }
                    },
                    Comprobantes = new List<Comprobante>
                    {
                        new Comprobante { NroComprobante = "123456", Total = 124.25 },
                        new Comprobante { NroComprobante = "123457", Total = 12454.25 },
                        new Comprobante { NroComprobante = "123458", Total = 25124.25 },

                    }
                },
                new Client
                {
                    RazonSocial = "Sultano",
                    FechaAlta = new DateTime(1981, 10, 12),
                    Domicilio = new Domicilio
                    {
                        Calle = "Salta",
                        NroCalle = 124,
                        Ciudad = new Ciudad
                        {
                            Nombre = "Mendoza",
                            Pais = new Pais
                            {
                                Codigo = "1",
                                Nombre = "Argentina"
                            }
                        }
                    },
                    Comprobantes = new List<Comprobante>
                    {
                        new Comprobante { NroComprobante = "123456", Total = 124.25 },
                        new Comprobante { NroComprobante = "123457", Total = 12454.25 },
                        new Comprobante { NroComprobante = "123458", Total = 25124.25 },

                    }
                }
            };
            return clients;
        }
    }
}
