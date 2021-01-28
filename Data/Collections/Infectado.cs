using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace API.Data.Collections
{
    public class Infectado
    {
        public Infectado(DataTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = DataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public DataTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}