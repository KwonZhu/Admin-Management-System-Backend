﻿namespace Mooc.Application.Admin;

public class AdminProfile: Profile
{
    public AdminProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();
    }
}
