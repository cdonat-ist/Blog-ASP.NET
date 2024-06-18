﻿using ProductContext.Domain.Dtos.Product;
using ProductContext.Domain.Entities;
using ProductContext.Domain.Interfaces;
using ProductContext.Domain.Interfaces.Services;

namespace ProductContext.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(CreateProductDto dto)
        {
            var existingName = await _repository.VerifyDuplicateNameAsync(dto.Name);
            if (existingName) throw new ApplicationException("Já existe um produto cadastrado com esse nome!");

            var product = new Product(dto.Name, dto.Description, dto.Price, dto.Quantity);

            await _repository.RegisterAsync(product);
        }
    }
}
