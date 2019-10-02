using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer.Data
{
    public class ProductRepository
    {
        private List<Product> _data = new List<Product> {
            new Product { Name = "Product 1", Color = "Blue" },
            new Product { Name = "Product 2", Color = "Yellow" },
            new Product { Name = "Product 3", Color = "Brown" },
            new Product { Name = "Product 4", Color = "Black" },
            new Product { Name = "Product 5", Color = "Blue" },
            new Product { Name = "Product 6", Color = "Yellow" },
            new Product { Name = "Product 7", Color = "Brown" },
            new Product { Name = "Product 8", Color = "Purple" },
            new Product { Name = "Product 9", Color = "Green" },
            new Product { Name = "Product 10", Color = "Blue" }
        };

        public ProductRepository()
        {
            for (int i = 0; i < _data.Count; i++)
            {
                _data[i].Id = i + 1;
            }
        }

        public Product[] Get()
        {
            return _data.ToArray();
        }

        public Product Get(int id)
        {
            return _data.FirstOrDefault(model => model.Id == id);
        }

        public int Add(Product model)
        {
            _data.Add(model);

            model.Id = _data.Count;

            return model.Id;
        }

        public void Update(int id, Product model)
        {
           var match = _data.FirstOrDefault(m => m.Id == id);

            if (match != null)
            {
                model.Id = id;
                _data[_data.IndexOf(match)] = model;
            }
        }

        public void Delete(int id)
        {
            var match = _data.FirstOrDefault(m => m.Id == id);

            if (match != null)
            {
                _data.Remove(match);
            }
        }
    }
}
