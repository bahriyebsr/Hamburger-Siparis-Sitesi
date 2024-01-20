using HamburgerSitesi.Business.Dtos;
using HamburgerSitesi.Business.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSitesi.Business.Services
{
	public interface IUserService
	{
		ServiceMessage AddUser(AddUserDto addUserDto);
		UserInfoDto LoginUser(LoginDto loginDto);
	}
}
