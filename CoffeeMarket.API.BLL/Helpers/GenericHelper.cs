using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Helpers
{
	public class GenericHelper
	{
		//public static async Task<string> UploadFileFromForm(IFormFile imageFile, I webHostEnvironment, string imagePath = "uploads")
		//{
		//	string imageName = null;

		//	if (imageFile != null)
		//	{
		//		string uploadFolder = Path.Combine(webHostEnvironment., imagePath);
		//		imageName = $"{Guid.NewGuid()}-{imageFile.FileName}";
		//		string filePath = Path.Combine(uploadFolder, imageName);

		//		if (!Directory.Exists(uploadFolder))
		//		{
		//			Directory.CreateDirectory(uploadFolder);
		//		}

		//		await using FileStream fs = new FileStream(filePath, FileMode.Create);
		//		await imageFile.CopyToAsync(fs);
		//		await fs.FlushAsync();

		//	}

		//	return Path.Combine(imagePath, imageName);
		//}

		public static async Task<UploadResponse> UploadFileFromBase64(string base64Image, string extension, string imagePath = "uploads")
		{
			string imageName = null;
			UploadResponse response = new UploadResponse();
			if (!string.IsNullOrEmpty(base64Image))
			{

				string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), imagePath);
				imageName = $"{Guid.NewGuid() + extension}";
				string filePath = Path.Combine(uploadFolder, imageName);

				if (!Directory.Exists(uploadFolder))
				{
					Directory.CreateDirectory(uploadFolder);
				}
				try
				{
					byte[] imageBytes = Convert.FromBase64String(base64Image);
					await File.WriteAllBytesAsync(filePath, imageBytes);
				}
				catch (Exception ex)
				{

					throw;
				}
			

				
			}
			response.url = Path.Combine(imagePath, imageName);
			response.fileName = imageName;
			return response;
		}
		public class UploadResponse
		{
			public string url { get; set; }
			public string fileName { get; set; }
		}
	}
}
