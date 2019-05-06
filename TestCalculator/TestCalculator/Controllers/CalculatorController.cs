using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestCalculator.Utils.DTO;


namespace TestCalculator.Controllers
{
    public class CalculatorController : ApiController
    {
        // GET: api/Alerts
        public IEnumerable<string> Get()
        {
            throw new HttpResponseException(
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(Resources.ErrorMessages.NotImplemented),
                        StatusCode = System.Net.HttpStatusCode.NotImplemented
                    }
                    );
        }

        /// <summary>
        /// Api para realizar la suma de 2 o 3 digitos
        /// </summary>
        /// <param name="digito1">primer digito</param>
        /// <param name="digito2">segundo digito</param>
        /// <param name="digito3">tercer digito</param>
        /// <returns>decimal con calculo de suma</returns>
        [HttpGet]
        [Route("api/Calculator/GetSum")]
        public string GetSum(string digito1, string digito2, string digito3)
        {
            ProcesoDto dto = new ProcesoDto();

            dto.Digito1 = digito1;
            dto.Digito2 = digito2;
            dto.Digito3 = digito3;
            dto.Operacion = "Suma";
            try
            {
                Double respuesta = (Convert.ToDouble(digito1) + Convert.ToDouble(digito2) + Convert.ToDouble(digito3));

                dto.Resultado = respuesta.ToString();

                this.TransactionLog(dto);

                return respuesta.ToString();
            }
            catch (Exception ex)
            {
                dto.Error = ex.ToString();
                this.TransactionLog(dto);

                throw new HttpResponseException(
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(Resources.ErrorMessages.InternalError),
                        StatusCode = System.Net.HttpStatusCode.InternalServerError
                    }
                    );
            }

        }

        /// <summary>
        /// Api para realizar la resta de 2 o 3 digitos
        /// </summary>
        /// <param name="digito1">primer digito</param>
        /// <param name="digito2">segundo digito</param>
        /// <param name="digito2">tercer digito</param>
        /// <returns>decimal con calculo de resta</returns>
        [HttpGet]
        [Route("api/Calculator/GetSustration")]
        public string GetSustration(string digito1, string digito2, string digito3)
        {
            ProcesoDto dto = new ProcesoDto();

            dto.Digito1 = digito1;
            dto.Digito2 = digito2;
            dto.Digito3 = digito3;
            dto.Operacion = "Resta";

            try
            {
                double respuesta = Convert.ToDouble(digito1) - Convert.ToDouble(digito2) - Convert.ToDouble(digito3);

                dto.Resultado = respuesta.ToString();

                this.TransactionLog(dto);

                return respuesta.ToString();
            }
            catch (Exception)
            {

                throw new HttpResponseException(
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(Resources.ErrorMessages.InternalError),
                        StatusCode = System.Net.HttpStatusCode.InternalServerError
                    }
                    );
            }
        }

        /// <summary>
        /// Api para realizar la multiplicación de 2 digitos
        /// </summary>
        /// <param name="digito1">primer digito</param>
        /// <param name="digito2">segundo digito</param>
        /// <returns>decimal con calculo de multiplicación</returns>
        [HttpGet]
        [Route("api/Calculator/GetMultiplication")]
        public string GetMultiplication(string digito1, string digito2, string digito3)
        {
            ProcesoDto dto = new ProcesoDto();

            dto.Digito1 = digito1;
            dto.Digito2 = digito2;
            dto.Digito3 = digito3;
            dto.Operacion = "Multiplicación";

            try
            {
                double respuesta = Convert.ToInt32(digito1) * Convert.ToInt32(digito2);

                respuesta = (Convert.ToDouble(digito3) == 0 ? respuesta : (respuesta * Convert.ToDouble(digito3)));

                dto.Resultado = respuesta.ToString();

                this.TransactionLog(dto);

                return respuesta.ToString();
            }
            catch (Exception)
            {

                throw new HttpResponseException(
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(Resources.ErrorMessages.InternalError),
                        StatusCode = System.Net.HttpStatusCode.InternalServerError
                    }
                    );
            }
        }

        /// <summary>
        /// Api para realizar una división
        /// </summary>
        /// <param name="digito1">Dividendo</param>
        /// <param name="digito2">Divisor</param>
        /// <returns>decimal con calculo de la división</returns>
        [HttpGet]
        [Route("api/Calculator/GetDivision")]
        public string GetDivision(string digito1, string digito2, string digito3)
        {
            ProcesoDto dto = new ProcesoDto();

            dto.Digito1 = digito1;
            dto.Digito2 = digito2;
            dto.Digito3 = digito3;
            dto.Operacion = "División";

            try
            {
                double respuesta = Convert.ToDouble(digito1) / Convert.ToDouble(digito2);
                respuesta = (Convert.ToDouble(digito3) == 0 ? respuesta : (respuesta / Convert.ToDouble(digito3)));

                dto.Resultado = respuesta.ToString();

                this.TransactionLog(dto);

                return respuesta.ToString();
            }
            catch (Exception)
            {

                throw new HttpResponseException(
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(Resources.ErrorMessages.InternalError),
                        StatusCode = System.Net.HttpStatusCode.InternalServerError
                    }
                    );
            }
        }

        /// <summary>
        /// Api para realizar el calculo de la raiz cuadrada
        /// </summary>
        /// <param name="digito1">Radicando</param>
        /// <returns>decimal con calculo de raiz cuadrada</returns>
        [HttpGet]
        [Route("api/Calculator/GetRaizCuadrada")]
        public string GetRaizCuadrada(string digito1, string digito2, string digito3)
        {
            ProcesoDto dto = new ProcesoDto();

            dto.Digito1 = digito1;
            dto.Digito2 = digito2;
            dto.Digito3 = digito3;
            dto.Operacion = "Raíz cuadrada";

            try
            {
                double respuesta = Math.Sqrt(Convert.ToDouble(digito1));
                respuesta = (Convert.ToDouble(digito2) == 0 ? respuesta : Math.Sqrt(respuesta));
                respuesta = (Convert.ToDouble(digito3) == 0 ? respuesta : Math.Sqrt(respuesta));

                dto.Resultado = respuesta.ToString();

                this.TransactionLog(dto);

                return respuesta.ToString();
            }
            catch (Exception)
            {

                throw new HttpResponseException(
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(Resources.ErrorMessages.InternalError),
                        StatusCode = System.Net.HttpStatusCode.InternalServerError
                    }
                    );
            }
        }

        /// <summary>
        /// Api para guardar la trazabilidad de los procesos ejecutados en la calculadora
        /// </summary>
        /// <param name="proceso">dto con los datos del calculo</param>
        [HttpPost]
        public void TransactionLog(ProcesoDto proceso)
        {
            string json = JsonConvert.SerializeObject(proceso);

            string fileName = @"D:\Calculadora.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        
                        Console.WriteLine(json);
                    }
                }
                else
                {
                    using (StreamWriter fs = new StreamWriter(fileName))
                    {
                        Console.WriteLine(json);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }
    }
}
