using applynowcrud.Models;
using applynowcrudmvc.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace applynowcrudmvc.Controllers
{
    public class applynowController : Controller
    {
        jdapplynowAPI _api = new jdapplynowAPI();
        public async Task<IActionResult> Index()
        {
            List<Jdapplynowmvc> studentDatas = new List<Jdapplynowmvc>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/jdapplynows");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                studentDatas = JsonConvert.DeserializeObject<List<Jdapplynowmvc>>(res);
            }


            return View(studentDatas);
        }
        public async Task<IActionResult> Details(int id)
        {
            var student = new Jdapplynowmvc();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync($"api/jdapplynows/{id}");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                student = JsonConvert.DeserializeObject<Jdapplynowmvc>(res);
            }
            return View(student);
        }
        public async Task<ActionResult> CreateAsync(int id)
        {
            var _jobid = new JobDetailmvc();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync($"api/JobDetails/{id}");
            if(result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                _jobid = JsonConvert.DeserializeObject<JobDetailmvc>(res);
                ViewData["id"] = _jobid.JobDetailsId;
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Jdapplynowmvc student)
        {
            HttpClient cli = _api.Initial();
            string authornew = JsonConvert.SerializeObject(student);
            StringContent content = new StringContent(authornew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = cli.PostAsync(cli.BaseAddress + "api/jdapplynows", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
    //public class AllowedExtensionsAttribute : ValidationAttribute
    //{
    //    private readonly string[] _extensions;
    //    public AllowedExtensionsAttribute(string[] extensions)
    //    {
    //        _extensions = extensions;
    //    }

    //    protected override ValidationResult IsValid(
    //    object value, ValidationContext validationContext)
    //    {
    //        var resume = value as IFormFile;
    //        if (resume != null)
    //        {
    //            var extension = Path.GetExtension(resume.FileName);
    //            if (!_extensions.Contains(extension.ToLower()))
    //            {
    //                return new ValidationResult(GetErrorMessage());
    //            }
    //        }

    //        return ValidationResult.Success;
    //    }

    //    public string GetErrorMessage()
    //    {
    //        return $"This photo extension is not allowed!";
    //    }
    

}
