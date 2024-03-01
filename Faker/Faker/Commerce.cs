//-----------------------------------------------------------------------
// <copyright file="Commerce.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Faker.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    /// <summary>
    /// Static Commerce class
    /// </summary>
    public static class Commerce
    {
        private static List<string> departments;
        private static readonly object departmentLock = new();
        private static List<string> products;
        private static readonly object productsLock = new();
        private static List<string> productAdjectives;
        private static readonly object productAdjectivesLock = new();
        private static List<string> productMaterials;
        private static readonly object productMaterialsLock = new();

        /// <summary>
        /// Gets a random department
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Department()
        {
            lock (departmentLock)
            {
                departments ??= XML.GetListString("Commerce", "Department");

                return departments[Number.RandomNumber(0, departments.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random departments
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Departments()
        {
            return Number.RandomNumber(1, 10).Times(_ => Department()).ToList();
        }

        /// <summary>
        /// Gets a list of random departments
        /// </summary>
        /// <param name="numberOfDepartments">Number of departments</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Departments(int numberOfDepartments)
        {
            return numberOfDepartments.Times(_ => Department()).ToList();
        }

        /// <summary>
        /// Gets a random product
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Product()
        {
            lock (productsLock)
            {
                products ??= XML.GetListString("Commerce", "Product");

                return products[Number.RandomNumber(0, products.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random products
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Products()
        {
            return Number.RandomNumber(1, 10).Times(_ => Product()).ToList();
        }

        /// <summary>
        /// Gets a list of random products
        /// </summary>
        /// <param name="numberOfProducts">Number of products</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Products(int numberOfProducts)
        {
            return numberOfProducts.Times(_ => Product()).ToList();
        }

        /// <summary>
        /// Gets a random product adjective
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string ProductAdjective()
        {
            lock (productAdjectivesLock)
            {
                productAdjectives ??= XML.GetListString("Commerce", "Adjective");

                return productAdjectives[Number.RandomNumber(0, productAdjectives.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random product adjectives
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductAdjectives()
        {
            return Number.RandomNumber(1, 10).Times(_ => ProductAdjective()).ToList();
        }

        /// <summary>
        /// Gets a list of random product adjectives
        /// </summary>
        /// <param name="numberOfAdjectives">Number of adjectives</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductAdjectives(int numberOfAdjectives)
        {
            return numberOfAdjectives.Times(_ => ProductAdjective()).ToList();
        }

        /// <summary>
        /// Gets a random product material
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string ProductMaterial()
        {
            lock (productMaterialsLock)
            {
                productMaterials ??= XML.GetListString("Commerce", "Material");

                return productMaterials[Number.RandomNumber(0, productMaterials.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random product materials
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductMaterials()
        {
            return Number.RandomNumber(1, 10).Times(_ => ProductMaterial()).ToList();
        }

        /// <summary>
        /// Gets a list of random product materials
        /// </summary>
        /// <param name="numberOfMaterials">Number of materials</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductMaterials(int numberOfMaterials)
        {
            return numberOfMaterials.Times(_ => ProductMaterial()).ToList();
        }

        /// <summary>
        /// Gets a random product name
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string ProductName()
        {
            return string.Join(" ", ProductAdjective(), ProductMaterial(), Product());
        }

        /// <summary>
        /// Gets a list of random product names
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductNames()
        {
            return Number.RandomNumber(1, 10).Times(_ => string.Join(" ", ProductAdjective(), ProductMaterial(), Product())).ToList();
        }

        /// <summary>
        /// Gets a list of random product names
        /// </summary>
        /// <param name="numberOfProductNames">Number of names</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductNames(int numberOfProductNames)
        {
            return numberOfProductNames.Times(_ => string.Join(" ", ProductAdjective(), ProductMaterial(), Product())).ToList();
        }

        /// <summary>
        /// Gets a random price
        /// </summary>
        /// <param name="min">Minimum amount</param>
        /// <param name="max">Maximum amount</param>
        /// <param name="decimals">Number of decimals</param>
        /// <param name="symbol">Symbol to append</param>
        /// <returns>A <see cref="string"/></returns>
        public static string Price(decimal min, decimal max, int decimals, string symbol = "")
        {
            var amount = max - min;
            var part = (decimal)Number.Double() * amount;
            return symbol + Math.Round(min + part, decimals);
        }

        /// <summary>
        /// Gets a random price
        /// </summary>
        /// <param name="symbol">Symbol to append</param>
        /// <returns>A <see cref="string"/></returns>
        public static string Price(string symbol = "")
        {
            return Price(0, 1000, 2, symbol);
        }

        /// <summary>
        /// Gets a list of random product prices
        /// </summary>
        /// <param name="symbol">Symbol to append</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Prices(string symbol = "")
        {
            // Potentially get a random symbol
            return Number.RandomNumber(1, 10).Times(_ => Price(symbol)).ToList();
        }

        /// <summary>
        /// Gets a list of random product prices
        /// </summary>
        /// <param name="symbol">Symbol to append</param>
        /// <param name="numberOfPrices">Number of prices</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Prices(string symbol, int numberOfPrices = 1)
        {
            return numberOfPrices.Times(_ => Price(symbol)).ToList();
        }
    }
}
