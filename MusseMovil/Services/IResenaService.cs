using MusseCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusseMovil.Services
{
    public interface IResenaService
    {
        Task<List<ResenaDTO>> RefreshDataAsync();
        Task EnviarComentario(ResenaDTO resena);
    }
}
