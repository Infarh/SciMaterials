﻿using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SciMaterials.Contracts.API.DTO.Categories;
using SciMaterials.Contracts.Result;
using SciMaterials.Contracts.WebAPI.LinkSearch;
using SciMaterials.DAL.Models;

namespace SciMaterials.UI.MVC.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LinkSearchController : ApiBaseController<LinkSearchController>
    {
        private readonly ILinkShortCut<Link> _link;
        private readonly ILogger<LinkSearchController> _logger;

        public LinkSearchController(ILinkShortCut<Link> link, ILogger<LinkSearchController> logger)
        {
            _link = link;
            _logger = logger;
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetAllAsync()
        {
            var link = await _link.GetAllAsync();
            return Ok(link);
        }

        [HttpPost("link/{link}")]
        public async Task<IActionResult> Add([FromBody] Link link)
        {
            var result = await _link.AddAsync(link.SourceAddress);
            return Ok(result);
        }

        [HttpGet("hash/{hash}")]
        public async Task<IActionResult> HashInfo([MinLength(5)] string hash)
        {
            if (await _link.FindByHashAsync(hash) is { } info)
                return Ok(info);

            return NotFound(new { hash });
        }
    }
}
