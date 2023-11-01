using Microsoft.AspNetCore.Components;
using Shop.DataModels.CustomModels;
using System;
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
            return await _httpClient.PostJsonAsync<ResponseModel>("api/admin/AdminLogin", loginModel);
        }
    }
}
