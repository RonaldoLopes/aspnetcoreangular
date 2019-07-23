using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        //GERAL
         void Add<T>(T enitity) where T : class;
         void Update<T>(T enitity) where T : class;
         void Delete<T>(T enitity) where T : class;
         Task<bool> SaveChangesAsync();

         //EVENTOS
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);
         Task<Evento> GetAllEventoAsyncById(int EventoId, bool includePalestrantes);

         //PALESTRANTE
         Task<Palestrante[]> GetAllEPalestrantesAsyncByName(string name, bool includeEventos);
         Task<Palestrante> GetPalestranteAsync(int PalestranteId ,bool includeEventos);
    }
}