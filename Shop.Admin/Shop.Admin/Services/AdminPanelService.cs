using Microsoft.AspNetCore.Components;
using Shop.DataModels.CustomModels;
using System.Net.Http;

namespace Shop.Admin.Services
{
    public class AdminPanelService : IAdminPanelService
    {
        private readonly HttpClient httpClient;

        public AdminPanelService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<ResponseModel> AdminLogin(LoginModel loginModel)
        {
            // Make sure to specify the expected response type here (ResponseModel).
            return await httpClient.PostJsonAsync<ResponseModel>("api/admin/AdminLogin", loginModel);
        }
    }
}
