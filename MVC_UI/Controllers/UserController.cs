using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_UI.Models;
using Newtonsoft.Json;

namespace MVC_UI.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> GetUsers()
        {
            List<UserDetails> userDetails = new List<UserDetails>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:50443/api/v1/GetAllUsers"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    userDetails = JsonConvert.DeserializeObject<List<UserDetails>>(apiResponse);
                }
            }
            return View(userDetails);
        }
        public async Task<IActionResult> UserRegister()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserRegister(UserDetails user)
        {
            UserDetails user1 = new UserDetails();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:50443/api/v1/UserRegister/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //user1 = JsonConvert.DeserializeObject<UserDetails>(apiResponse);
                }
            }
            return RedirectToAction("GetUsers");
        }
        public ViewResult GetUserById() => View();
        [HttpGet]
        public async Task<IActionResult> GetUserById(int id)
        {
            UserDetails user = new UserDetails();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:50443/api/v1/GetUser/" + id))
                {
                   string apiResponse = await response.Content.ReadAsStringAsync();
                   user = JsonConvert.DeserializeObject<UserDetails>(apiResponse);
                }
            }
            return View(user);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateUser(int id)
        {
            UserDetails user = new UserDetails();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:50443/api/v1/GetUser/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<UserDetails>(apiResponse);
                }
            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserDetails user)
        {
            UserDetails user1 = new UserDetails();
            int id = user1.UserId;
            using (var httpClient = new HttpClient())
            {
                //var content = new MultipartFormDataContent();
                //content.Add(new StringContent(user.UserName), "UserName");
                //content.Add(new StringContent(user.FirstName), "FirstName");
                //content.Add(new StringContent(user.LastName), "LastName");
                //content.Add(new StringContent(user.UserPassword), "UserPassword");
                //content.Add(new StringContent(user.EmailAddr), "EmailAddr");
                //content.Add(new StringContent(user.PhoneNumber), "PhoneNumber");
                //content.Add(new StringContent(user.CreateDate.ToString()), "CreateDate");
                //content.Add(new StringContent(user.UpdatedDate.ToString()), "updatedDate");
                //content.Add(new StringContent(user.UserAddress), "UserAddress");
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");



                using (var response = await httpClient.PutAsync("http://localhost:50443/api/v1/UpdateUser/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    user1 = JsonConvert.DeserializeObject<UserDetails>(apiResponse);
                }
            }
            return RedirectToAction("GetUsers");
        }
    }
}