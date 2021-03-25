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
        //private readonly Cloudinary _cloudinary;
        public HomeController(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IOptions<CloudinarySettings> cloudinaryConfig)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cloudinaryConfig = cloudinaryConfig;
            //Account account = new Account(_cloudinaryConfig.Value.CloudName,
            //_cloudinaryConfig.Value.ApiKey,
            //_cloudinaryConfig.Value.ApiSecret);
            //_cloudinary = new Cloudinary(account);
        }

        // V1/home/isBanner
        [Route("isBanner")]
        [HttpGet]
        public async Task<IActionResult> GetIsBannerAsync()
        {
            var isBanners = await _unitOfWork.Banner.GetIsBannerAsync();
            if (isBanners == null) return NotFound("Could not find");
            var isBannerResources = _mapper.Map<IEnumerable<Banner>, IEnumerable<BannerResource>>(isBanners);
            return Ok(isBannerResources);
        }

        // V1/home/isService
        [Route("isService")]
        [HttpGet]
        public async Task<IActionResult> GetIsServiceAsync()
        {
            var isService = await _unitOfWork.Banner.GetIsServiceAsync();
            if (isService == null) return NotFound("Could not find");
            var isServiceResources = _mapper.Map<IEnumerable<Banner>, IEnumerable<BannerResource>>(isService);
            return Ok(isServiceResources);
        }

        // V1/home/isPromo
        [Route("isPromo")]
        [HttpGet]
        public async Task<IActionResult> GetIsPromoAsync()
        {
            var isPromo = await _unitOfWork.Product.GetIsPromoAsync();
            if (isPromo == null) return NotFound("Could not find");
            var isPromoResources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductPromoResource>>(isPromo);
            return Ok(isPromoResources);
        }
        // V1/home/Catalogue
        [Route("Catalogue")]
        [HttpGet]

        public async Task<IActionResult> GetCatalogueAsync([FromQuery] int categoryId)
        {
            var catalogue = await _unitOfWork.Product.GetCatalogueAsync(categoryId);
            if (catalogue == null) return NotFound("Could not find");
            var category = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductCategoryResource>>(catalogue);
            return Ok(category);
        }
        //  V1/home/Associate
        [Route("Associate")]
        [HttpGet]
        public async Task<IActionResult> GetAssociatesAsync()
        {
            var chef = await _unitOfWork.Associate.GetAllAsync();
            if (chef == null) return NotFound("Could not find");
            var chefs = _mapper.Map<IEnumerable<Associate>, IEnumerable<AssociateResouce>>(chef);
            return Ok(chefs);
        }

        //  V1/home/News
        [Route("News")]
        [HttpGet]
        public async Task<IActionResult> GetNewsAsync()
        {
            var news = await _unitOfWork.Blogs.GetIsNewAsync();
            if (news == null) return NotFound("Could not find");
            var isNews = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogResouce>>(news);
            return Ok(isNews);
        }

        //  V1/home/Customers
        [Route("Customers")]
        [HttpGet]
        public async Task<IActionResult> GetCustomersAsync()
        {
            var customer = await _unitOfWork.Testimonials.GetAllAsync();
            if (customer == null) return NotFound("Could not find");
            var customers = _mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialResouce>>(customer);
            return Ok(customers);
        }
        //  V1/home/About
        [Route("About")]
        [HttpGet]
        public async Task<IActionResult> GetAboutAsync()
        {
            var about = await _unitOfWork.Abouts.SingleOrDefaultAsync(c=>c.IsHome);
            if (about == null) return NotFound("Could not find");
            var abouts = _mapper.Map<AboutUs, AboutUsResouce>(about);
            return Ok(abouts);
        }
    }
}
