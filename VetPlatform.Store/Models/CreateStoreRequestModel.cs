﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VetPlatform.Store.Models
{
    public class CreateStoreRequestModel
    {
        public TenantRequestModel Tenant { get; set; }
        public UserRequestModel User { get; set; }
    }
}
