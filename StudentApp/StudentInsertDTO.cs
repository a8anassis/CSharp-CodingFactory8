using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    // immutable, init-only, primary ctor με το ίδιο order, ToString(), ==
    internal record StudentInsertDTO(string? Firstname, string? Lastaname );
    
}
