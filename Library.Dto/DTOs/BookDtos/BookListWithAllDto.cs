﻿using OurProject.LibrarySystem.DTO.Interfaces;
using OurProject.LibrarySystem.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace OurProject.LibrarySystem.DTO.DTOs.BookDtos
{
    public class BookListWithAllDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageNumber { get; set; }
        public string LongDescription { get; set; }

        public DateTime PublishedTime { get; set; }
        public int Count { get; set; }
        public string Picture { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int BaseCategoryId { get; set; }
        public Category BaseCategory { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}