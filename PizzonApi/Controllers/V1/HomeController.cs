using AutoMapper;
using CloudinaryDotNet;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PizzonApi.Helpers;
using PizzonApi.Resources.HomePage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzonApi.Controllers.V1
{
    [Route("V1/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;
        private readonly Cloudinary _cloudinary;
        public HomeController(
            IUnitOfWork unitOfWork, 
            IMapper mapper, 
            IOptions<CloudinarySettings> cloudinaryConfig)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cloudinaryConfig = cloudinaryConfig;
            Account account = new Account(_cloudinaryConfig.Value.CloudName,
            _cloudinaryConfig.Value.ApiKey,
            _cloudinaryConfig.Value.ApiSecret);
            _cloudinary = new Cloudinary(account);
        }
        [Route("isBanner")]
        [HttpGet]
        public async Task<IActionResult> GetIsBannerAsync()
        {
            var isBanners = await _unitOfWork.Banner.GetIsBannerAsync();
            if (isBanners == null) return BadRequest("Could not find");
            var isBannerResources = _mapper.Map<IEnumerable<Banner>, IEnumerable<BannerResource>>(isBanners);
            return Ok(isBannerResources);
        }
        [Route("isService")]
        [HttpGet]
        public async Task<IActionResult> GetIsServiceAsync()
        {
            var isService = await _unitOfWork.Banner.GetIsServiceAsync();
            if (isService == null) return BadRequest("Could not find");
            var isServiceResources = _mapper.Map<IEnumerable<Banner>, IEnumerable<BannerResource>>(isService);
            return Ok(isServiceResources);
        }     
        [Route("isPromo")]
        [HttpGet]
        public async Task<IActionResult> GetIsPromoAsync()
        {
            var isPromo = await _unitOfWork.Product.GetIsPromoAsync();
            if (isPromo == null) return BadRequest("Could not find");
            var isPromoResources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductPromoResource>>(isPromo);
            return Ok(isPromoResources);
        }
        [Route("Catalogue")]
        [HttpGet]
        public async Task<IActionResult> GetCatalogueAsync([FromQuery] int categoryId)
        {
            var catalogue = await _unitOfWork.Product.GetCatalogueAsync(categoryId); 
            if (catalogue == null) return BadRequest("Could not find");
            var category = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductCategoryResource>>(catalogue);
            return Ok(category);
        }
    }
}
