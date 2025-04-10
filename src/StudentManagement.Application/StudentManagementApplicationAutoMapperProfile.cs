﻿using AutoMapper;
using StudentManagement.Students;

namespace StudentManagement;

public class StudentManagementApplicationAutoMapperProfile : Profile
{
    public StudentManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();

    }
}
