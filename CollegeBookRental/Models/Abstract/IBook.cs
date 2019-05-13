﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBookRental.Models.Abstract
{
    public interface IBook
    {
        IEnumerable<Book> Books { get; }
    }
}
