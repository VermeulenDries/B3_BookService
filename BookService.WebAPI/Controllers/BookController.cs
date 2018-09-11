﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookService.WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookService.WebAPI.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookRepository repository;

        public BookController(BookRepository bookRepository)
        {
            repository = bookRepository;
        }

        // GET: api/Book
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(repository.List());
        }

        // GET: api/Book/Basic
        [HttpGet]
        [Route("Basic")]
        public IActionResult GetBookBasic()
        {
            return Ok(repository.ListBasic());
        }
    }
}