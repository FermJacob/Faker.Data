//-----------------------------------------------------------------------
// <copyright file="Commerce.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
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
        private static object departmentLock = new object();
        private static List<string> products;
        private static object productsLock = new object();
        private static List<string> productAdjectives;
        private static object productAdjectivesLock = new object();
        private static List<string> productMaterials;
        private static object productMaterialsLock = new object();

        /// <summary>
        /// Gets a random department
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Department()
        {
            lock (departmentLock)
            {
                if (departments == null)
                {
                    departments = XML.GetListString("Commerce", "Department");
                }

                return departments[Number.RandomNumber(0, departments.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random departments
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Departments()
        {
            return Number.RandomNumber(1, 10).Times(x => Department()).ToList();
        }

        /// <summary>
        /// Gets a list of random departments
        /// </summary>
        /// <param name="numberOfDepartments">Number of departments</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Departments(int numberOfDepartments)
        {
            return numberOfDepartments.Times(x => Department()).ToList();
        }

        /// <summary>
        /// Gets a random product
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Product()
        {
            lock (productsLock)
            {
                if (products == null)
                {
                    products = XML.GetListString("Commerce", "Product");
                }

                return products[Number.RandomNumber(0, products.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random products
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Products()
        {
            return Number.RandomNumber(1, 10).Times(x => Product()).ToList();
        }

        /// <summary>
        /// Gets a list of random products
        /// </summary>
        /// <param name="numberOfProducts">Number of products</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Products(int numberOfProducts)
        {
            return numberOfProducts.Times(x => Product()).ToList();
        }

        /// <summary>
        /// Gets a random product adjective
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string ProductAdjective()
        {
            lock (productAdjectivesLock)
            {
                if (productAdjectives == null)
                {
                    productAdjectives = XML.GetListString("Commerce", "Adjective");
                }

                return productAdjectives[Number.RandomNumber(0, productAdjectives.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random product adjectives
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductAdjectives()
        {
            return Number.RandomNumber(1, 10).Times(x => ProductAdjective()).ToList();
        }

        /// <summary>
        /// Gets a list of random product adjectives
        /// </summary>
        /// <param name="numberOfAdjectives">Number of adjectives</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductAdjectives(int numberOfAdjectives)
        {
            return numberOfAdjectives.Times(x => ProductAdjective()).ToList();
        }

        /// <summary>
        /// Gets a random product material
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string ProductMaterial()
        {
            lock (productMaterialsLock)
            {
                if (productMaterials == null)
                {
                    productMaterials = XML.GetListString("Commerce", "Material");
                }

                return productMaterials[Number.RandomNumber(0, productMaterials.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of random product materials
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductMaterials()
        {
            return Number.RandomNumber(1, 10).Times(x => ProductMaterial()).ToList();
        }

        /// <summary>
        /// Gets a list of random product materials
        /// </summary>
        /// <param name="numberOfMaterials">Number of materials</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductMaterials(int numberOfMaterials)
        {
            return numberOfMaterials.Times(x => ProductMaterial()).ToList();
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
            return Number.RandomNumber(1, 10).Times(x => string.Join(" ", ProductAdjective(), ProductMaterial(), Product())).ToList();
        }

        /// <summary>
        /// Gets a list of random product names
        /// </summary>
        /// <param name="numberOfProductNames">Number of names</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> ProductNames(int numberOfProductNames)
        {
            return numberOfProductNames.Times(x => string.Join(" ", ProductAdjective(), ProductMaterial(), Product())).ToList();
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
            return Number.RandomNumber(1, 10).Times(x => Price(symbol)).ToList();
        }

        /// <summary>
        /// Gets a list of random product prices
        /// </summary>
        /// <param name="symbol">Symbol to append</param>
        /// <param name="numberOfPrices">Number of prices</param>
        /// <returns>A <see cref="List{T}"/> of strings</returns>
        public static List<string> Prices(string symbol, int numberOfPrices = 1)
        {
            return numberOfPrices.Times(x => Price(symbol)).ToList();
        }
    }
}
