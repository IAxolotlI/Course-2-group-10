namespace PracticeABC;

using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;
using PracticeA.Classes;
using PracticeA.Repositories;
using System.Xml.Linq;

[ApiController]
public class StoreController : ControllerBase
{
    private List<Product>? Items = new List<Product>();
    ClassDB Data_Base { get; set; }
    ProductRepository _repos;
    public StoreController()
    {
        Data_Base.Read_Data_From_DB();
    }

    [HttpPost]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice(string name, double newPrice)
    {
        try
        {
            _repos.Update_Price(name, newPrice);
            return Ok($"{name} обновлен с новой ценой: {newPrice}");
        }
        catch (KeyNotFoundException error) {
            return NotFound("Такого товара нет");
        }
        catch (NullReferenceException)
        {
            return NotFound("Список продуктов пуст");
        }
    }

    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName(string currentName, string newName)
    {
        try
        {
            _repos.Update_Name(currentName, newName);
            return Ok($"{currentName} обновлен с новым именем: {newName}");
        }
        catch (KeyNotFoundException error)
        {
            return NotFound("Такого товара нет");
        }
        catch (NullReferenceException)
        {
            return NotFound("Список продуктов пуст");
        }
    }

    [HttpGet]
    [Route("/store/outofstock")]
    public IActionResult OutOfStock()
    {
        List <Product>? outOfStockItems = _repos.OutOfStock();
        if (outOfStockItems!=null)
        {
            return Ok(outOfStockItems);
        }
        else
        {
            return Ok("Все продукты в наличии");
        }
    }


    [HttpPost]
    [Route("/store/auth")]
    public IActionResult Auth([FromBody] UserCredentials user)
    { 
        if((user.User == "admin") && (user.Pass == "123"))
        {
            
            return Ok($"{user.User} авторизован");
        }
        else
        {
            return NotFound($"{user.User} не найден");
        }

    }


    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add([FromBody] Product newProduct)
    { 
        _repos.AddProduct(newProduct);
        return Ok(Items);
    }

    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete(string name)
    {
        try
        {
            _repos.DeleteProduct(name);
            return Ok($"{name} удален");
        }
        catch (KeyNotFoundException error)
        {
            return NotFound(error.Message);
        }
    }
    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        try
        {
            _repos.GetAllProducts();
            return Ok();
        }
        catch (KeyNotFoundException error)
        {
            return NotFound(error.Message);
        }
    }
}