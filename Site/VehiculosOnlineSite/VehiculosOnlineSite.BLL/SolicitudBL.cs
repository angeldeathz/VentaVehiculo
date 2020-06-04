﻿using VehiculosOnlineSite.Model.Clases;
using VehiculosOnlineSite.Services.Servicios;

namespace VehiculosOnlineSite.BLL
{
    public class SolicitudBL
    {
        private readonly SolicitudService _solicitudService;

        public SolicitudBL()
        {
            _solicitudService = new SolicitudService();
        }

        public int IngresarSolicitud(SolicitudDto solicitud)
        {
            return _solicitudService.IngresarSolicitud(solicitud);
        }
    }
}