using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Infrastructure {
    public class DataContext:DbContext {

        public IDbSet<Movie> Movies { get; set; }
    }
}