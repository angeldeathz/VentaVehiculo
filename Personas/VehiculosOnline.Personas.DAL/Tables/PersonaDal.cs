﻿using System.Collections.Generic;
using System.Threading.Tasks;
using VehiculosOnline.Model.Clases;
using VehiculosOnline.Transversal.Repositorios;

namespace VehiculosOnline.Personas.DAL.Tables
{
    public class PersonaDal
    {
        private readonly Repository _repository;
            
        public PersonaDal()
        {
            _repository = new Repository(ConnectionStrings.VehiculosOnline);
        }

        public async Task<List<Persona>> ObtenerTodosAsync()
        {
            const string sql = @"select 
                        id,
                        rut,
                        dv,
                        id_direccion AS IdDireccion,
                        nombres,
                        apellidos,
                        fec_nacimiento as FechaNacimiento,
                        email,
                        celular,
                        telefono
                        from persona";

            return await _repository.GetAllAsync<Persona>(sql);
        }

        public async Task<Persona> ObtenerPorIdAsync(int id)
        {
            const string sql = @"select 
                        id,
                        rut,
                        dv,
                        id_direccion AS IdDireccion,
                        nombres,
                        apellidos,
                        fec_nacimiento as FechaNacimiento,
                        email,
                        celular,
                        telefono
                        from persona
                        where id = @Id";

            return await _repository.GetAsync<Persona>(sql, new Dictionary<string, object>
            {
                {"@Id", id}
            });
        }

        public async Task<Persona> ObtenerPorRutAsync(int rut)
        {
            const string sql = @"select 
                        id,
                        rut,
                        dv,
                        id_direccion AS IdDireccion,
                        nombres,
                        apellidos,
                        fec_nacimiento as FechaNacimiento,
                        email,
                        celular,
                        telefono
                        from persona
                        where rut = @Rut";

            return await _repository.GetAsync<Persona>(sql, new Dictionary<string, object>
            {
                {"@Rut", rut}
            });
        }
    }
}
