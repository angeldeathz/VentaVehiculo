﻿using System.Collections.Generic;
using System.Net;
using VehiculosOnlineSite.Model.Clases;
using VehiculosOnlineSite.Services.Shared;

namespace VehiculosOnlineSite.Services.Servicios
{
    public class VentaService
    {
        private readonly RestClientHttp _restClientHttp;

        public VentaService()
        {
            _restClientHttp = new RestClientHttp();
        }

        public List<TipoPago> ObtenerTipoPago()
        {
            var url = $"http://localhost/VehiculosOnline/ventas/api/ventas/formasDePago";
            var respuesta = _restClientHttp.Get<List<TipoPago>>(url);
            if (respuesta.StatusName != HttpStatusCode.OK) return new List<TipoPago>();
            return respuesta.Response;
        }

        
    }
}