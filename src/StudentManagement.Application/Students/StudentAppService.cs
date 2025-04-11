using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;
using StudentManagement.Redis;
using System.Runtime.InteropServices;

namespace StudentManagement.Students
{
    public class StudentAppService
        : CrudAppService<Student, StudentDto, string, PagedAndSortedResultRequestDto, CreateUpdateStudentDto>,
          IStudentAppService
    {
        private readonly RedisHelper _redis;
        public StudentAppService(IRepository<Student, string> repository)
            : base(repository)
        {
            _redis = new RedisHelper();
        }
        
        public override async Task<StudentDto> CreateAsync(CreateUpdateStudentDto input)
        {
            var student = new Student(input.StudentCode, input.StudentName, input.GPA);
            await Repository.InsertAsync(student, autoSave: true);

            var dto = ObjectMapper.Map<Student, StudentDto>(student);

            await _redis.SetAsync($"student:{dto.StudentCode}", dto, TimeSpan.FromMinutes(10));

            return dto;
        }

        public override async Task<StudentDto> UpdateAsync(string id, CreateUpdateStudentDto input)
        {
            var student = await Repository.GetAsync(id);

            student.StudentName = input.StudentName;
            student.GPA = input.GPA;

            await Repository.UpdateAsync(student, autoSave: true);

            var dto = ObjectMapper.Map<Student, StudentDto>(student);

            await _redis.SetAsync($"student:{dto.StudentCode}", dto, TimeSpan.FromMinutes(10));

            return dto;
        }

        public override async Task<StudentDto> GetAsync(string id)
        {
            var cache = await _redis.GetAsync<StudentDto>($"student:{id}");
            if (cache != null)
                return cache;

            var dto = await base.GetAsync(id);

            await _redis.SetAsync($"student:{id}", dto, TimeSpan.FromMinutes(10));

            return dto;
        }

        public override async Task DeleteAsync(string id)
        {
            await base.DeleteAsync(id);
            await _redis.RemoveAsync($"student:{id}");
        }

        public async Task<double> GetAverageGpaAsync()
        {
            var students = await Repository.GetListAsync();
            if (!students.Any()) return 0;

            return students.Average(x => x.GPA);
        }
    }
}
