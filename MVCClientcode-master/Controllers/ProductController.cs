﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProductClient.Controllers
{
    public class ProductController : Controller
    {
        string Baseurl = "https://localhost:5000/";
        public async Task<IActionResult> GetAllProducts()
        {
            List<Product> ProductInfo = new List<Product>();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("https://localhost:5000/api/Product");
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    ProductInfo = JsonConvert.DeserializeObject<List<Product>>(ProductResponse);

                }
              return View(ProductInfo);
            }

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product p)
        {
            Product Pobj = new Product();
          //  HttpClient obj = new HttpClient();
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:5002/api/Cart/Products", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Pobj = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return RedirectToAction("GetAllProducts");
        }

        public async Task<IActionResult> Edit(int id)
        {
            Product p = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5002/api/Cart/Products/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(p);
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product p)
        {
            //Editing the product http post method
            Product p1 = new Product();
            Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                int id = p.pid;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:5002/api/Cart/Products/" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return RedirectToAction("GetAllProducts");
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            TempData["Prid"] = id;
            Product e = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5002/api/Cart/Products/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    e = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return View(e);

        }

        [HttpPost]
        public async Task<ActionResult> Delete(Product p)
        {
            //Deleting a product
            int prid = Convert.ToInt32(TempData["Prid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5002/api/Cart/Products/" + prid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("GetAllProducts");
        }
    }
}
