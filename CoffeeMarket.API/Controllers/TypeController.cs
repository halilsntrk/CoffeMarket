using AutoWrapper.Wrappers;
using CoffeeMarket.API.BLL.Interfaces.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarket.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TypeController : ControllerBase
	{ private ITypeManager _typeManager;

		public TypeController(ITypeManager typeManager)
		{
			_typeManager = typeManager;
		}

		[HttpPost("getTypes")]
		[ProducesResponseType(typeof(ApiResponse), 200)]
		public async Task<ApiResponse> GetCoffeeTypes(string id)
		{
			var res = await _typeManager.GetById(id);
			return new ApiResponse("", new { status = true, data = res }, 200);
		}
	}
}
