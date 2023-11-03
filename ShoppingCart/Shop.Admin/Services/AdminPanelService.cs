using Microsoft.AspNetCore.Components;
using Shop.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Shop.Admin.Services
{
    public class AdminPanelService : IAdminPanelService
    {
        private readonly HttpClient _httpClient;
        public AdminPanelService(HttpClient httpClient)
        {
            this._httpClient = httpClient; 
        }

        public async Task<ResponseModel> AdminLogin(LoginModel loginModel)
        {
            try
            {
                return await _httpClient.PostJsonAsync<ResponseModel>("api/admin/AdminLogin", loginModel);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return null;
            }
        }

        public async Task<CategoryModel> SaveCategory(CategoryModel newCategory)
        {
            try
            {
                return await _httpClient.PostJsonAsync<CategoryModel>("api/admin/SaveCategory", newCategory);
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Exception : {ex.Message}");
                return null;
            }
        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            try
            {
                return await _httpClient.GetJsonAsync<List<CategoryModel>>("api/admin/GetCategories");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UpdateCategory(CategoryModel categoryToUpdate)
        {
            try
            {
                return await _httpClient.PostJsonAsync<bool>("api/admin/UpdateCategory", categoryToUpdate);
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteCategory(CategoryModel categoryToDelete)
        {
            try
            {
                return await _httpClient.PostJsonAsync<bool>("api/admin/DeleteCategory", categoryToDelete);
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return false;
            }
        }
    }
}
