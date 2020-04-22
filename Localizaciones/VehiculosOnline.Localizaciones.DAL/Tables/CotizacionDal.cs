﻿using System.Collections.Generic;
using System.Threading.Tasks;
using VehiculosOnline.Modelo.Clases;
using VehiculosOnline.Transversal.Repositorios;

namespace VehiculosOnline.Localizaciones.DAL.Tables
{
    public class VentaDal
    {
        private readonly Repository _repository;
            
        public VentaDal()
        {
            _repository = new Repository(ConnectionStrings.VehiculosOnline);
        }

        public async Task<List<Venta>> ObtenerTodosAsync()
        {
            var sql = @"select 
                        id,
                        id_cotizacion AS IdCotizacion,
                        fec_venta,
                        total_venta
                        from venta";
            return await _repository.GetAllAsync<Venta>(sql);
        }
    }
}
