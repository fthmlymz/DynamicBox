﻿using DynamicBox.IdentityServer.Models;
using DynamicBox.IdentityServer.Security;
using DynamicBox.IdentityServer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;

namespace DynamicBox.IdentityServer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUserRepository _employeeRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger logger;
        private readonly IDataProtector protector;

        public HomeController(IUserRepository employeeRepository,
                              IHostingEnvironment hostingEnvironment,
                              ILogger<HomeController> logger,
                              IDataProtectionProvider dataProtectionProvider,
                              DataProtectionPurposeStrings dataProtectionPurposeStrings)
        {
            _employeeRepository = employeeRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;
            protector = dataProtectionProvider
                .CreateProtector(dataProtectionPurposeStrings.UserIdRouteValue);
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee()
                            .Select(e =>
                            {
                                e.EncryptedId = protector.Protect(e.Id.ToString());
                                return e;
                            });
            return View(model);
        }

        [AllowAnonymous]
        public ViewResult Details(string id)
        {
            //throw new Exception("Error in Details View");

            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");

            int employeeId = Convert.ToInt32(protector.Unprotect(id));

            User employee = _employeeRepository.GetEmployee(employeeId);

            if (employee == null)
            {
                Response.StatusCode = 404;
                return View("EmployeeNotFound", employeeId);
            }

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                User = employee,
                PageTitle = "Employee Details"
            };

            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            User employee = _employeeRepository.GetEmployee(id);
            UserEditViewModel employeeEditViewModel = new UserEditViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department,
                ExistingPhotoPath = employee.PhotoPath
            };
            return View(employeeEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                User employee = _employeeRepository.GetEmployee(model.Id);
                employee.Name = model.Name;
                employee.Email = model.Email;
                employee.Department = model.Department;
                if (model.Photo != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath,
                            "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    employee.PhotoPath = ProcessUploadedFile(model);

                }

                _employeeRepository.Update(employee);
                return RedirectToAction("index");
            }

            return View();
        }

        private string ProcessUploadedFile(UserCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        [HttpPost]
        public IActionResult Create(UserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);

                User newEmployee = new User
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    PhotoPath = uniqueFileName
                };

                _employeeRepository.Add(newEmployee);
                return RedirectToAction("details", new { id = newEmployee.Id });
            }

            return View();
        }
    }
}
