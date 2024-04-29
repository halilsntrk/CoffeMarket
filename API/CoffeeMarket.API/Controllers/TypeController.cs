using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	public class TypeController : ControllerBase
	{ private ITypeManager _typeManager;

		public TypeController(ITypeManager typeManager)
		{
			_typeManager = typeManager;
		}

		[HttpPost("list")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> List()
		{
			var res = await _typeManager.GetAll();
			return new ApiResponse("", new { status = true, data = res }, 200);
		}

		[HttpPost("getTypes")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> GetTypes(string id)
		{
			var res = await _typeManager.GetById(id);
			return new ApiResponse("", new { status = true, data = res }, 200);
		}
	}
}
