﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlayniteServices.Models.IGDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PlayniteServices.Controllers.IGDB
{
    [Route("igdb/collections")]
    public class CollectionController : IgdbItemController
    {
        private static readonly object CacheLock = new object();

        private const string endpointPath = "collections";

        [HttpGet("{collectionId}")]
        public async Task<ServicesResponse<Collection>> Get(ulong collectionId)
        {
            return new ServicesResponse<Collection>(await GetItem<Collection>(collectionId, endpointPath, CacheLock));
        }
    }
}
