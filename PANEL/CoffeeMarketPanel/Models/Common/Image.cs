namespace CoffeeMarketPanel.Models.Common
{
    public class Image
    {
        public string imageURL { get; set; }
        private readonly static string rootPath = "D:\\Git\\Local Projeler\\CoffeeMarket\\API\\CoffeeMarket.API" + "\\uploads";

        public Image(IFormFile image)
        {
           imageURL =  SaveImage(image,rootPath);
        }
        public string SaveImage(IFormFile imageUrl, string path)
        {
            if (imageUrl != null)
            {
                var uploadPath = Path.Combine(path); 
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var ext = Path.GetExtension(imageUrl.FileName);
                string imagePath = Guid.NewGuid().ToString() + ext;
                var imagePath2 = Path.Combine(uploadPath, imagePath);
                using (var fileStream = new FileStream(imagePath2, FileMode.Create))
                {
                        imageUrl.CopyTo(fileStream);
                    
                }
                return Path.Combine("uploads/", imagePath);
            }

            return "";
        }


        public IFormFile GetFormFile(string url)
        {
            using (var memoryStream = new MemoryStream())
            {
                var formFile = new FormFile(memoryStream, 0, 0, url, url)
                {
                    Headers = new HeaderDictionary(),
                    ContentType = "image/jpg"
                };

                return formFile;
            }




        }
      
    }
}
