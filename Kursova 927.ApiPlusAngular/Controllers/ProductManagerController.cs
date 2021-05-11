using Kursova_927.ApiPlusAngular.Helper;
using Kursova_927.DTO;
using Kursova_927.DataAccess.DTO;
using Kursova_927.DataAccess.DTO.Results;
using Kursova_927.DataAccess.EF;
using Kursova_927.DataAccess.Entitty;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursova_927.ApiPlusAngular.Controllers
{
    [Route("api/ProductManager")]
    [ApiController]
    public class ProductManagerController : ControllerBase
    {
        private readonly EFContext _context;

        public ProductManagerController(EFContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> getProducts()
        {
            List<ProductDTO> data = new List<ProductDTO>();

            var dataFromDB = _context.Products.ToList();

            foreach (var item in dataFromDB)
            {
                ProductDTO temp = new ProductDTO();
                var moreInfo = _context.Products.FirstOrDefault(t => t.Id == item.Id);

                temp.Id = item.Id;
                temp.Name = moreInfo.Name;
                temp.Price = moreInfo.Price;
                if (moreInfo != null)
                {
                    temp.ImagesURL = moreInfo.ImagesURL;
                    temp.IsAviable = item.IsAviable;
                    temp.Count = item.Count;
                }


                data.Add(temp);
            }

            return data;
        }


        //localhost:12312/api/UserManager/RemoveUser/89as7d89a7a8d09a8sd

        [HttpPost("RemoveProduct/{id}")]
        public ResultDTO RemoveProduct([FromRoute] string id)
        {
            try
            {
                var products = _context.Products.FirstOrDefault(t => t.Id == id);

                if (products != null)
                {
                    _context.Products.Remove(products);
                }
                _context.SaveChanges();

                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {
                List<string> temp = new List<string>();
                temp.Add(e.Message);

                return new ResultErrorDTO
                {
                    Code = 500,
                    Message = "ERROR",
                    Errors = temp
                };
            }
        }

        //localhost:12312/api/UserManager/98d789a789asd7a98sd
        [HttpGet("{id}")]
        public ProductDTO GetProduct([FromRoute] string id)
        {
            var product = _context.Products.FirstOrDefault(t => t.Id == id);


            ProductDTO model = new ProductDTO();

            if (product != null)
            {
                model.Id = product.Id;
                model.Name = product.Name;
                model.Price = product.Price;
                model.ImagesURL = product.ImagesURL;
                model.IsAviable = product.IsAviable;
                model.Count = product.Count;
            }

            return model;
        }


        [HttpPost("editProduct/{id}")]
        public ResultDTO EditProduct([FromRoute] string id, [FromBody] ProductDTO model)
        {
            var product = _context.Products.FirstOrDefault(t => t.Id == id);


            product.Name = model.Name;
            product.Price = model.Price;
            product.ImagesURL = model.ImagesURL;
            product.IsAviable = model.IsAviable;
            product.Count = model.Count;
            _context.SaveChanges();

            return new ResultDTO
            {
                Code = 200,
                Message = "OK"
            };

        }


        [HttpPost("addProduct")]
        public async Task<ResultDTO> AddProduct([FromBody] AddProductDTO model)
        {
            try
            {
                var product = new Product()
                {
                    Count = model.Count,
                    IsAviable = model.IsAviable,
                    Name = model.Name,
                    Price = model.Price,
                    ImagesURL = model.ImagesURL
                };

                _context.Products.Add(product);
                _context.SaveChanges();
                return new ResultDTO
                {
                    Code = 200
                };
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return new ResultErrorDTO
                {
                    Code = 400,
                    Message = "ERROR",
                    Errors = CustomValidator.getErrorsByModelState(ModelState)
                };
            }







        }
    }

    
}