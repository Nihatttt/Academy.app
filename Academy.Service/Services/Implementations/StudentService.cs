using Academy.core.Enums;
using Academy.core.Models;
using Academy.core.Respository.cs;
using Academy.Data.Repostories;
using Academy.Service.Services.InterFace;

namespace Academy.Service.Services.Implementations
{
    public class StudentService : IStudentService
    {

        IStudentRespositories _studentRepository = new StudentRepositories();
        public async Task<string> CreateAsync(string fullName, string group, double average, Specialty specialty)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "fullname bos ola bilmez!";
            }
            if (string.IsNullOrWhiteSpace(group))
            {
                return "group bos ola bilmez!";
            }
            if (average < 0)
            {
                return "average 0dan kicik olmamalidir";
            }
            Student student = new Student(fullName, group, average, specialty);
            student.CreatAt = DateTime.UtcNow.AddHours(4);
            await _studentRepository.AddAsync(student);
            return "Success";
        }
         


        public async Task<string> GetAllAsync(string id)
        {
            Student student = await _studentRepository.GetAsync(x => x.Id == id);
            if (student == null)
                return "Student not found";

            Console.WriteLine($"Id:{student.Id},fullname:{student.FullName},average:{student.Average},studentEducation:{student.Specialty},create:{student.CreatAt},update:{student.UpdateAt}");
            return "successfull";
        }

        public Task<string> UpdateAsync(string FullNaame, string Group, string group, double average, Specialty specialty)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UptadedAsync(string id, string fullName, string group, double average, Specialty specialty)
        {
            Student student = await _studentRepository.GetAsync(x=>x.Id == id);
            if (string.IsNullOrEmpty(fullName))

                return "fullname bosdur";

            if (string.IsNullOrEmpty(group))

                return "group bosdur";
            if (average < 0)

                return "average 0dan kicikolmamalidir";
            if (student == null)

                return "Student not to found";
            student.id = id;
            student.FullName = fullName;
            student.Group = group;
            student.Average = average;  
            student.Specialty = specialty;  
            student.UpdateAt = DateTime.Now;
            return "Update successfuly";
            
        }

        Task IStudentService.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
