using applynowcrud.Models;
using applynowcrudmvc.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace applynowcrudmvc.Controllers
{
    public class jobdetailController : Controller
    {
        jdapplynowAPI _api = new jdapplynowAPI();
        public async Task<IActionResult> Index()
        {
            List<JobDetailmvc> studentDatas = new List<JobDetailmvc>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/jobdetails");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                studentDatas = JsonConvert.DeserializeObject<List<JobDetailmvc>>(res);
            }


            return View(studentDatas);
        }
        public async Task<IActionResult> Details(int id)
        {
            var student = new JobDetailmvc();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync($"api/jobdetails/{id}");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                student = JsonConvert.DeserializeObject<JobDetailmvc>(res);
            }
            return View(student);
        }
        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(JobDetailmvc student)
        {
            HttpClient cli = _api.Initial();
            string authornew = JsonConvert.SerializeObject(student);
            StringContent content = new StringContent(authornew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = cli.PostAsync(cli.BaseAddress + "api/jobdetails", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        //public async Task<IActionResult> Edit(int id)
        //{
        //    HttpClient cli = _api.Initial();
        //    JobDetailmvc stud = new JobDetailmvc();
        //    HttpResponseMessage response = await cli.GetAsync($"api/jobdetails/{id}");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        string data = response.Content.ReadAsStringAsync().Result;
        //        stud = JsonConvert.DeserializeObject<JobDetailmvc>(data);
        //    }
        //    return View(stud);

        //}
        //[HttpPost]
        //public async Task<IActionResult> Edit(int id, [Bind("JobDetailsId,CompanyName,JobCategory")] JobDetailmvc model)
        //{
        //    if (id != model.JobDetailsId)
        //    {
        //        return NotFound();
        //    }
        //    HttpClient cli = _api.Initial();
        //    string stnew = JsonConvert.SerializeObject(model);
        //    StringContent content = new StringContent(stnew, Encoding.UTF8, "application/json");
        //    HttpResponseMessage response = await cli.PutAsync($"api/jobdetails/{id}", content);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        public async Task<IActionResult> Edit(int id)
        {
            HttpClient cli = _api.Initial();
            Jdapplynowmvc stud = new Jdapplynowmvc();
            HttpResponseMessage response = await cli.GetAsync($"api/jdapplynows/{id}");

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                stud = JsonConvert.DeserializeObject<Jdapplynowmvc>(data);
            }
            return View(stud);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ApplyId,Name,UserName,Link,Resume,Letter,JobId")] Jdapplynowmvc model)
        {
            if (id != model.JobId)
            {
                return NotFound();
            }
            HttpClient cli = _api.Initial();
            string stnew = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(stnew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await cli.PutAsync($"api/jdapplynows/{id}", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
