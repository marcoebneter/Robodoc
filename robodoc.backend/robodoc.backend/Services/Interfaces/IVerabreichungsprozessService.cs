using Robodoc.Data.Models;

namespace robodoc.backend.Services.Interfaces
{
    public interface IVerabreichungsprozessService
    {
        IEnumerable<Verabreichungsprozess> GetVerabreichungsprozesses();
        Verabreichungsprozess GetVerabreichungsprozessById(string id);
    }
}
