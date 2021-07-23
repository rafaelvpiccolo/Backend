using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Paging
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int TotalItens { get; set; }

        public Paging(int totalPages, int page, int totalItens)
        {
            Page = page;
            TotalPages = totalPages;
            TotalItens = totalItens;
        }

        // Faltou a implementação da paginação, acabei ficando sem tempo restante para finalizar.
    }
}
