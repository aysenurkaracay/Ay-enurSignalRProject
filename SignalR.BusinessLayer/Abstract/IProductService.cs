﻿using SignalR.EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        int TProductCount();

        int TProductCountByCategoryNameHamburger();
        int TProductCountByCategoryNameDrink();
        decimal TProductPriceAvg();
        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
        object? TTotalPriceByDrinkCategory();
        object? TProductPriceBySteakBurger();
        object? TProductAvgPriceByHamburger();
        object? TTotalPriceBySaladCategory();
        //decimal TProductPriceBySteakBurger();
        //decimal TTotalPriceByDrinkCategory();
        //decimal TTotalPriceBySaladCategory();
    }
}
