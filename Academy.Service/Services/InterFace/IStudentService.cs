

using Academy.core.Enums;

namespace Academy.Service.Services.InterFace
{
    public interface IStudentService
    {
        public Task<string> CreateAsync(string fullName, string group, double average, Specialty specialty);
        public Task<string> UptadedAsync(string id, string fullName, string group, double average, Specialty specialty);
        public Task<string> RemoveAsync(string id);
        public Task<string> GetAsync(string id);
        public Task GetAllAsync();
    }
}
