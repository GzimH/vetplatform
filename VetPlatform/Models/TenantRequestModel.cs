﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VetPlatform.Api.Models
{
    public class TenantRequestModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string HostName { get; set; }
        public IFormFile Logo { get; set; }
        [Required]
        public string Theme { get; set; }
    }
}
