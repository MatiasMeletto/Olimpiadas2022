using MusseCore;

namespace MusseMovil.Services
{
    public interface IMapaService
    {
        MapaDTO Mapa { get; }
        Task<MapaDTO> RefreshDataAsync();
    }
}
