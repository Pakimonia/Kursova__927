using Kursova_927.ApiPlusAngular.Helper;
using Kursova_927.DTO;
using Kursova_927.DTO.Models;
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
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly EFContext _context;

        public ProductController(EFContext context)
        {
            _context = context;
            //if (!_context.Products.Any())
            //{
                _context.Productss.Add(new Product {Id = 1, Name = "iPhone X", IsAviable = true, Price = 79900, Countt = 10, ImageURL = "https://ipartner.com.ua/image/cache/webp/catalog/imgmainru2_250/clearapple-iphone-x-64gb-silver-serebristij-680x630.webp"  });
                _context.Productss.Add(new Product {Id = 2, Name = "Galaxy S8", IsAviable = true, Price = 49900, Countt = 5, ImageURL = "https://i.citrus.ua/imgcache/size_500/uploads/shop/f/b/fb87ed6cea440efdc3d135e96daac698.jpg"  });
                _context.Productss.Add(new Product {Id = 3, Name = "Pixel 2", IsAviable = true, Price = 52900, Countt = 3, ImageURL = "https://content1.rozetka.com.ua/goods/images/big/171469417.jpg"  });
                _context.SaveChanges();

            //}
        }

        [HttpGet]
        public IEnumerable<ProductDTO> Get()
        {
            List<ProductDTO> data = new List<ProductDTO>();

            var dataFromDB = _context.Productss.ToList();

            foreach (var item in dataFromDB)
            {
                ProductDTO temp = new ProductDTO();

                temp.Id = item.Id;
                temp.Name = item.Name;
                temp.IsAviable = item.IsAviable;
                temp.Countt = item.Countt;
                temp.Price = item.Price;
                temp.ImageURL = item.ImageURL;



                data.Add(temp);
            }
            return data;
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product product = _context.Productss.FirstOrDefault(x => x.Id == id);
            return product;
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            if (product.Countt > 0)
            {
                product.IsAviable = true;
            }
            else
            {
                product.IsAviable = false;
            }
            if (ModelState.IsValid)
            {
                _context.Productss.Add(product);
                _context.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            if(product.Countt >0)
            {
                product.IsAviable = true;
            }
            else
            {
                product.IsAviable = false;
            }
            if (ModelState.IsValid)
            {
                _context.Update(product);
                _context.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product product = _context.Productss.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _context.Productss.Remove(product);
                _context.SaveChanges();
            }
            return Ok(product);
        }
    }

    
}